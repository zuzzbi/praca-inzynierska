using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps;
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
            DirectoryInfo directoryInfo = new DirectoryInfo(path + @"\Tasks\Tasks" + (Application.Current.MainWindow as MainWindow).sectionNumber + ".xps");

            //Dla każdego pliku .xps z uzyskanego folderu dodaj obiekty do dwóch list: ChceckBox oraz ListBoxItem o odpowiednim numerze odpowiadającym jego nazwie
            //foreach (var item in directoryInfo.GetFiles("*.xps"))
            //{
            //    ////Pobierz numer n zadania z nazwy pliku
            //    //int n = Convert.ToInt32(item.Name.Replace("Task", "").Replace(".xps", ""));

            //    ////Utwórz obiekt CheckBox z odpowiednim numerem i dodaj do drugiej listy
            //    //CheckBox checkBox = new CheckBox();
            //    //checkBox.Name = "CheckBoxTask" + n;
            //    //checkBox.Checked += new RoutedEventHandler(CheckBoxTask_CheckedChange);
            //    //checkBox.Unchecked += new RoutedEventHandler(CheckBoxTask_CheckedChange);
            //    //Viewbox checkBoxItem = new Viewbox();
            //    //checkBoxItem.Child = checkBox;
            //    //ListBoxTaskListing2.Items.Add(checkBoxItem);
            //    ////StackPanel.Children.Add(checkBox);

            //    ////Utwórz obiekt ListBoxItem z odpowiednim numerem i dodaj do pierwszej listy
            //    //ListBoxItem listBoxItemTask = new ListBoxItem();
            //    //listBoxItemTask.Content = item.Name.Replace("Task", "Zadanie ").Replace(".xps", "");
            //    //listBoxItemTask.Name = "ListBoxItemTask" + n;
            //    //ListBoxTaskListing.Items.Add(listBoxItemTask);

            //    //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
            //}
            try
            {
                XpsDocument xpsDocument = new XpsDocument(directoryInfo.FullName, FileAccess.Read);
                int numberOfTasks = xpsDocument.GetFixedDocumentSequence().DocumentPaginator.PageCount / 2;
                for (int i = 0; i < numberOfTasks; i++)
                {
                    int n = i + 1;
                    //Utwórz obiekt CheckBox z odpowiednim numerem i dodaj do drugiej listy
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "CheckBoxTask" + n;
                    checkBox.Checked += new RoutedEventHandler(CheckBoxTask_CheckedChange);
                    checkBox.Unchecked += new RoutedEventHandler(CheckBoxTask_CheckedChange);
                    Viewbox checkBoxItem = new Viewbox();
                    checkBoxItem.Child = checkBox;
                    ListBoxTaskListing2.Items.Add(checkBoxItem);
                    //StackPanel.Children.Add(checkBox);

                    //Utwórz obiekt ListBoxItem z odpowiednim numerem i dodaj do pierwszej listy
                    ListBoxItem listBoxItemTask = new ListBoxItem();
                    listBoxItemTask.Content = "Zadanie " + n;
                    listBoxItemTask.Name = "ListBoxItemTask" + n;
                    ListBoxTaskListing.Items.Add(listBoxItemTask);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można wyświetlić zawartości", "Brak plików", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            try
            {
                //Odczytaj plik progres.txt i utwórz tablicę lines typu string złożoną z jego linijek
                StreamReader streamReader = new StreamReader("progres.txt");
                string all = streamReader.ReadToEnd();
                streamReader.Close();
                string[] lines = all.Split('\n');

                foreach (Viewbox viewbox in ListBoxTaskListing2.Items)
                {
                    //Pobierz numer n zadania z nazwy pliku
                    int n = Convert.ToInt32((viewbox.Child as CheckBox).Name.Replace("CheckBoxTask", ""));

                    try
                    {
                        //Wybierz odpowiednią linijkę pliku progres.txt z tablicy lines i zapisz do zmiennej task
                        string task = lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1].Trim('\n').Trim('\r');

                        //Każdy kolejny znak zmiennej task odpowiada deklaracji ukończenia bądź nieukończenia zadania (0-niukończone, 1-ukończone)
                        //Jeśli znak odpowiadający numerem reprezentacji aktualnego zadania jest równy 1, zaznacz aktualny CheckBox
                        if (task[n - 1] == '1')
                        {
                            (viewbox.Child as CheckBox).IsChecked = true;
                        }
                    }
                    catch (Exception)
                    {
                        (viewbox.Child as CheckBox).IsChecked = false;
                    }
                }
            }
            catch (Exception)
            {
                foreach (Viewbox viewbox in ListBoxTaskListing2.Items)
                {
                    (viewbox.Child as CheckBox).IsChecked = false;
                }
            }
        }

        private void ListBoxTaskListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //Usuń pliki pomocnicze
                File.Delete("x.xps");
                File.Delete("y.xps");

                ////Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItem z ListBoxTaskListing
                //string number = Convert.ToString((ListBoxTaskListing.SelectedItem as ListBoxItem).Name).Replace("ListBoxItemTask", "");
                //string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
                //path = path + @"\Tasks\" + (Application.Current.MainWindow as MainWindow).sectionNumber + @"\Task" + number + ".xps";             

                ////Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
                //XpsDocument xpsDocument = new XpsDocument(path, FileAccess.Read);
                //FixedPage fixedPageTask = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[0].GetPageRoot(false);
                //FixedPage fixedPageAns = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[1].GetPageRoot(false);
                //XpsDocument xpsDocumentTask = new XpsDocument("x.xps", FileAccess.ReadWrite);
                //XpsDocumentWriter xpsDocumentWriterTask = XpsDocument.CreateXpsDocumentWriter(xpsDocumentTask);
                //xpsDocumentWriterTask.Write(fixedPageTask);
                //XpsDocument xpsDocumentAns = new XpsDocument("y.xps", FileAccess.ReadWrite);
                //XpsDocumentWriter xpsDocumentWriterAns = XpsDocument.CreateXpsDocumentWriter(xpsDocumentAns);
                //xpsDocumentWriterAns.Write(fixedPageAns);

                ////Otwórz kontrolkę UserControlTasksDisplay
                //(Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTasksDisplay();

                ////Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlTasksDisplay uzyskany dokument xpsDocument
                //((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTasksDisplay).DocumentViewer.Document = xpsDocumentTask.GetFixedDocumentSequence();
                //((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTasksDisplay).DocumentViewerExpander.Document = xpsDocumentAns.GetFixedDocumentSequence();

                //xpsDocument.Close();
                //xpsDocumentTask.Close();
                //xpsDocumentAns.Close();

                //Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItem z ListBoxTaskListing
                string number = Convert.ToString((ListBoxTaskListing.SelectedItem as ListBoxItem).Name).Replace("ListBoxItemTask", "");
                int taskNumber = Convert.ToInt32(number) - 1;
                string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
                path = path + @"\Tasks\Tasks" + (Application.Current.MainWindow as MainWindow).sectionNumber + ".xps";

                //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
                XpsDocument xpsDocument = new XpsDocument(path, FileAccess.Read);
                FixedPage fixedPageTask = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[taskNumber * 2].GetPageRoot(false);
                FixedPage fixedPageAns = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[taskNumber * 2 + 1].GetPageRoot(false);
                XpsDocument xpsDocumentTask = new XpsDocument("x.xps", FileAccess.ReadWrite);
                XpsDocumentWriter xpsDocumentWriterTask = XpsDocument.CreateXpsDocumentWriter(xpsDocumentTask);
                xpsDocumentWriterTask.Write(fixedPageTask);
                XpsDocument xpsDocumentAns = new XpsDocument("y.xps", FileAccess.ReadWrite);
                XpsDocumentWriter xpsDocumentWriterAns = XpsDocument.CreateXpsDocumentWriter(xpsDocumentAns);
                xpsDocumentWriterAns.Write(fixedPageAns);

                //Otwórz kontrolkę UserControlTasksDisplay
                (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTasksDisplay();

                //Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlTasksDisplay uzyskany dokument xpsDocument
                ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTasksDisplay).DocumentViewer.Document = xpsDocumentTask.GetFixedDocumentSequence();
                ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTasksDisplay).DocumentViewerExpander.Document = xpsDocumentAns.GetFixedDocumentSequence();

                xpsDocument.Close();
                xpsDocumentTask.Close();
                xpsDocumentAns.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można wyświetlić tego pliku","Plik uszkodzony",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlListing
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlListing();
        }

        private void CheckBoxTask_CheckedChange(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckBox checkBox = sender as CheckBox;
                int taskNumber = Convert.ToInt32(checkBox.Name.Replace("CheckBoxTask", ""));
                if (checkBox.IsChecked == true)
                {
                    StreamReader streamReader = new StreamReader("progres.txt");
                    string all = streamReader.ReadToEnd();
                    string[] lines = all.Split('\n');
                    streamReader.Close();
                    StringBuilder line = new StringBuilder(lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1]);
                    line[taskNumber - 1] = '1';
                    lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1] = line.ToString();
                    string newAll = "";
                    for (int i = 0; i < lines.Length; i++)
                    {
                        newAll += lines[i] + '\n';
                    }
                    File.WriteAllText("progres.txt", newAll.Trim('\n'));
                }
                if (checkBox.IsChecked == false)
                {
                    StreamReader streamReader = new StreamReader("progres.txt");
                    string all = streamReader.ReadToEnd();
                    string[] lines = all.Split('\n');
                    streamReader.Close();
                    StringBuilder line = new StringBuilder(lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1]);
                    line[taskNumber - 1] = '0';
                    lines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1] = line.ToString();
                    string newAll = "";
                    for (int i = 0; i < lines.Length; i++)
                    {
                        newAll += lines[i] + '\n';
                    }
                    File.WriteAllText("progres.txt", newAll.Trim('\n'));
                }
            }
            catch (Exception) { }
        }
    }
}
