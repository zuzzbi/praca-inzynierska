using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace EduMath.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlTestsDisplay.xaml
    /// </summary>
    public partial class UserControlTestsDisplay : UserControl
    {
        int questionNumber = 0;
        int positiveAnswersNumber = 0;
        string[] answerLines;
        char currentAnswer;

        public UserControlTestsDisplay()
        {
            InitializeComponent();
            DocumentViewer.FitToWidth();          
            try
            {
                //Usuń pliki pomocnicze
                File.Delete("z.xps");

                //Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItem z ListBoxTaskListing
                string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
                string pathXPS = path + @"\Tests\Test" + (Application.Current.MainWindow as MainWindow).sectionNumber + ".xps";
                string pathTXT = path + @"\Tests\TestsAns.txt";

                //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
                XpsDocument xpsDocument = new XpsDocument(pathXPS, FileAccess.Read);
                FixedPage fixedPageQuestion = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[questionNumber].GetPageRoot(false);
                XpsDocument xpsDocumentQuestion = new XpsDocument("z.xps", FileAccess.ReadWrite);
                XpsDocumentWriter xpsDocumentWriterTask = XpsDocument.CreateXpsDocumentWriter(xpsDocumentQuestion);
                xpsDocumentWriterTask.Write(fixedPageQuestion);

                //Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlTasksDisplay uzyskany dokument xpsDocument
                DocumentViewer.Document = xpsDocumentQuestion.GetFixedDocumentSequence();

                xpsDocument.Close();
                xpsDocumentQuestion.Close();

                StreamReader streamReader = new StreamReader(pathTXT);
                string answers = streamReader.ReadToEnd();
                streamReader.Close();

                answerLines = answers.Split('\n');
                questionNumber++;
            }
            catch (Exception)
            {
                DocumentViewer.Visibility = Visibility.Hidden;
                foreach (Viewbox item in Grid.Children.OfType<Viewbox>())
                {
                    item.Visibility = Visibility.Hidden;
                }
                ButtonSubmit.Visibility = Visibility.Hidden;
                MessageBox.Show("Nie można wyświetlić tego pliku", "Plik uszkodzony", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            ButtonSubmit.IsEnabled = false;
            A.IsChecked = false;
            B.IsChecked = false;
            C.IsChecked = false;
            D.IsChecked = false;
            try
            {
                //Usuń pliki pomocnicze
                if (answerLines[(Application.Current.MainWindow as MainWindow).sectionNumber - 1][questionNumber] == currentAnswer)
                {
                    positiveAnswersNumber++;
                }
                File.Delete("z.xps");

                //Utwórz ścieżkę path do pliku .xps na podstawie numeru w nazwie wybranego obiektu ListBoxItem z ListBoxTaskListing
                string path = (new FileInfo(AppDomain.CurrentDomain.BaseDirectory)).Directory.Parent.Parent.FullName;
                path = path + @"\Tests\Test" + (Application.Current.MainWindow as MainWindow).sectionNumber + ".xps";

                //Wczytaj dokument xpsDocument na podstawie uzyskanej ściezki path
                XpsDocument xpsDocument = new XpsDocument(path, FileAccess.Read);
                FixedPage fixedPageQuestion = xpsDocument.GetFixedDocumentSequence().References.First().GetDocument(false).Pages[questionNumber].GetPageRoot(false);
                XpsDocument xpsDocumentQuestion = new XpsDocument("z.xps", FileAccess.ReadWrite);
                XpsDocumentWriter xpsDocumentWriterTask = XpsDocument.CreateXpsDocumentWriter(xpsDocumentQuestion);
                xpsDocumentWriterTask.Write(fixedPageQuestion);

                //Wyświetl w kontrolce DocumentViewer z kontrolki użytkownika UserControlTasksDisplay uzyskany dokument xpsDocument
                DocumentViewer.Document = xpsDocumentQuestion.GetFixedDocumentSequence();

                xpsDocument.Close();
                xpsDocumentQuestion.Close();
                questionNumber++;
            }
            catch (Exception)
            {
                DocumentViewer.Visibility = Visibility.Hidden;
                foreach (Viewbox item in Grid.Children.OfType<Viewbox>())
                {
                    item.Visibility = Visibility.Hidden;
                }
                ButtonSubmit.Visibility = Visibility.Hidden;
                TextBlockTest.Visibility = Visibility.Visible;
                int positiveAnswersPercentage = (positiveAnswersNumber * 100) / questionNumber;

                StreamReader streamReader = new StreamReader("progres.txt");
                string progres = streamReader.ReadToEnd();
                streamReader.Close();
                string[] progresLines = progres.Split('\n');
                string[] results = progresLines[progresLines.Length - 1].Split(' ');
                if(Convert.ToInt32(results[(Application.Current.MainWindow as MainWindow).sectionNumber - 1].Replace(" ","")) < positiveAnswersPercentage)
                {
                    results[(Application.Current.MainWindow as MainWindow).sectionNumber - 1] = positiveAnswersPercentage.ToString();
                }
                progresLines[progresLines.Length - 1] = String.Join(" ",results);
                string newProgres = "";
                for (int i = 0; i < progresLines.Length; i++)
                {
                    newProgres += progresLines[i] + '\n';
                }
                File.WriteAllText("progres.txt", newProgres.Trim('\n'));
                TextBlockTest.Text = "Twój wynik to " + positiveAnswersPercentage + "%";
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (A.IsChecked == true)
            {
                currentAnswer = 'A';
            }
            else if (B.IsChecked == true)
            {
                currentAnswer = 'B';
            }
            else if (C.IsChecked == true)
            {
                currentAnswer = 'C';
            }
            else if(D.IsChecked == true)
            {
                currentAnswer = 'D';
            }
            ButtonSubmit.IsEnabled = true;           
        }


        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlTaskListing
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlListing();
        }

        private void ButtonScale_Click(object sender, RoutedEventArgs e)
        {
            DocumentViewer.FitToWidth();
        }
    }
}
