using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Xps.Packaging;

namespace EduMath.UserControls
{
    /// <summary>
    /// Kontrolka użytkownika do wyświetlania listy zadań
    /// </summary>
    public partial class UserControlTasksListing : UserControl
    {
        public UserControlTasksListing()
        {
            InitializeComponent();

            //Utwórz ścieżkę path do folderu na podstawie zmiennej sectionNumber zapisanej w MainWindow 
            string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
            DirectoryInfo directoryInfo = new DirectoryInfo(path + @"\Tasks\" + (Application.Current.MainWindow as MainWindow).sectionNumber);
           
            //Odczytaj plik progres.txt i utwórz tablicę lines typu string złożoną z jego linijek
            StreamReader streamReader = new StreamReader("progres.txt");
            string all = streamReader.ReadToEnd();
            streamReader.Close();
            string[] lines = all.Split('\n');

            //Dla każdego pliku .xps z uzyskanego folderu dodaj obiekty do dwóch list: ChceckBox oraz ListBoxItem o odpowiednim numerze odpowiadającym jego nazwie
            foreach(var item in directoryInfo.GetFiles("*.xps"))
            {
                //Pobierz numer n zadania z nazwy pliku
                int n = Convert.ToInt32(item.Name.Replace("Task", "").Replace(".xps", ""));

                //Utwórz obiekt ListBoxItem z odpowiednim numerem i dodaj do pierwszej listy
                ListBoxItem listBoxItemTask = new ListBoxItem();
                listBoxItemTask.Content = item.Name.Replace("Task", "Zadanie ").Replace(".xps", "");
                listBoxItemTask.Name = "ListBoxItemTask" + n;
                ListBoxTaskListing.Items.Add(listBoxItemTask);

                //Utwórz obiekt CheckBox z odpowiednim numerem i dodaj do drugiej listy
                CheckBox checkBox = new CheckBox();
                checkBox.Name = "CheckBoxTask" + n;
                ListBoxTaskListing2.Items.Add(checkBox);

                //Wybierz odpowiednią linijkę pliku progres.txt z tablicy lines i zapisz do zmiennej task
                string task = lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1].Trim('\n').Trim('\r');
                
                //Każdy kolejny znak zmiennej task odpowiada deklaracji ukończenia bądź nieukończenia zadania (0-niukończone, 1-ukończone)
                //Jeśli znak odpowiadający numerem reprezentacji aktualnego zadania jest równy 1, zaznacz aktualny CheckBox
                if (task[n - 1] == '1')
                {
                    checkBox.IsChecked = true;
                }
            }
        }

        private void ListBoxTaskListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Otwórz kontrolkę UserControlTasksDisplay
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTasksDisplay();

            //Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItem z ListBoxTaskListing
            string number = Convert.ToString((ListBoxTaskListing.SelectedItem as ListBoxItem).Name).Replace("ListBoxItemTask", "");
            string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
            path = path + @"\Tasks\" + (Application.Current.MainWindow as MainWindow).sectionNumber + @"\Task" + number + ".xps";

            //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
            XpsDocument xpsDocument = new XpsDocument(path, FileAccess.Read);

            //Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlTasksDisplay uzyskany dokument xpsDocument
            ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTasksDisplay).DocumentViewer.Document = xpsDocument.GetFixedDocumentSequence();
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlListing
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlListing();
        }
    }
}
