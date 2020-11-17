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
using System.Windows.Xps.Packaging;
using System.IO;

namespace EduMath.UserControls
{
    /// <summary>
    /// Kontrolka użytkownika do wyświetlania listy działów matematycznych
    /// </summary>
    public partial class UserControlListing : UserControl
    {
        public UserControlListing()
        {
            InitializeComponent();
        }

        private void ListBoxTheoryListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            //Jeśli wyciśnięty jest przycisk ButtonTheory z MainWindow
            if ((Application.Current.MainWindow as MainWindow).ButtonTheory.IsEnabled == false)
            {
                try
                {
                    string number;

                    //Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItemTheory
                    number = Convert.ToString((ListBoxTheoryListing.SelectedItem as ListBoxItem).Name).Replace("ListBoxItemTheory", "");
                    string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
                    path = path + @"\Theory\Theory" + number + ".xps";

                    //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
                    XpsDocument xpsDocument = new XpsDocument(path, FileAccess.Read);

                    //Otwórz kontrolkę UserControlDisplay
                    (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlDisplay();

                    //Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlDisplay uzyskany dokument xpsDocument
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).DocumentViewer.Document = xpsDocument.GetFixedDocumentSequence();
                    xpsDocument.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można wyświetlić tego pliku", "Plik uszkodzony", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            //Jeśli wyciśnięty jest przycisk ButtonTasks z MainWindow
            if ((Application.Current.MainWindow as MainWindow).ButtonTasks.IsEnabled == false)
            {
                //Nadpisz zmienną sectionNumber z MainWindow wartością numeru z nazwy wybranego obiektu ListBoxItemTheory
                (Application.Current.MainWindow as MainWindow).sectionNumber = Convert.ToInt32(Convert.ToString((ListBoxTheoryListing.SelectedItem as ListBoxItem).Name).Replace("ListBoxItemTheory", ""));               
                
                //Otwórz kontrolkę UserControlTasksListing
                (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTasksListing();
            }
        }
    }
}
