using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EduMath
{
    /// <summary>
    /// Główne okno wyświetlane cały czas, z zawartością reprezentowaną przez kontrolki użytkownika
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //Jeśli przycisk ButtonTheory został wciśnięty, zmień wartość jego właściwości isEnabled na false oraz wartość właściwości isEnabled pozostałych przycisków na true
        //Otwórz kontrolkę UserControlListing
        private void ButtonTheory_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button item in Grid.Children.OfType<Button>())
            {
                if (item.GetType() == typeof(Button))
                {
                    Button button = (Button)item;
                    button.IsEnabled = true;
                }
            }
            ButtonTheory.IsEnabled = false;
            ContentControl.Content = new UserControls.UserControlListing();
        }

        //Jeśli przycisk ButtonExamples został wciśnięty, zmień wartość jego właściwości isEnabled na false oraz wartość właściwości isEnabled pozostałych przycisków na true
        //Otwórz kontrolkę UserControlListing
        private void ButtonExamples_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button item in Grid.Children.OfType<Button>())
            {
                if (item.GetType() == typeof(Button))
                {
                    Button button = (Button)item;
                    button.IsEnabled = true;
                }
            }
            ButtonExamples.IsEnabled = false;
            ContentControl.Content = new UserControls.UserControlListing();
        }

        //Jeśli przycisk ButtonTasks został wciśnięty, zmień wartość jego właściwości isEnabled na false oraz wartość właściwości isEnabled pozostałych przycisków na true
        //Otwórz kontrolkę UserControlListing
        private void ButtonTasks_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button item in Grid.Children.OfType<Button>())
            {
                if (item.GetType() == typeof(Button))
                {
                    Button button = (Button)item;
                    button.IsEnabled = true;
                }
            }
            ButtonTasks.IsEnabled = false;
            ContentControl.Content = new UserControls.UserControlListing();
        }

        //Jeśli przycisk ButtonTests został wciśnięty, zmień wartość jego właściwości isEnabled na false oraz wartość właściwości isEnabled pozostałych przycisków na true
        //Otwórz kontrolkę UserControlListing
        private void ButtonTests_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button item in Grid.Children.OfType<Button>())
            {
                if (item.GetType() == typeof(Button))
                {
                    Button button = (Button)item;
                    button.IsEnabled = true;
                }
            }
            ButtonTests.IsEnabled = false;
            ContentControl.Content = new UserControls.UserControlListing();
        }

        //Jeśli przycisk ButtonProgres został wciśnięty, zmień wartość jego właściwości isEnabled na false oraz wartość właściwości isEnabled pozostałych przycisków na true
        //Otwórz kontrolkę UserControlProgresDisplay
        private void ButtonProgres_Click(object sender, RoutedEventArgs e)
        {

            foreach (Button item in Grid.Children.OfType<Button>())
            {
                if (item.GetType() == typeof(Button))
                {
                    Button button = (Button)item;
                    button.IsEnabled = true;
                }
            }
            ButtonProgres.IsEnabled = false;
            ContentControl.Content = new UserControls.UserControlProgresDisplay();
        }

        //Zmienna, która przechowuje numer obecnie wybranego działu, nadpisywana jest w kontrolce UserControlListing, gdy przycisk ButtonTasks jest wciśnięty
        public int sectionNumber;
    }
}
