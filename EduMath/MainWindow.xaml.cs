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

namespace EduMath
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SolidColorBrush buttonNotClicked = new SolidColorBrush(Color.FromRgb(255, 199, 46));
        SolidColorBrush buttonClicked = new SolidColorBrush(Color.FromRgb(255, 160, 0));

        private void ButtonTheory_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new UserControls.UserControlTheoryListing();
            ButtonTheory.Background = buttonClicked;
            ButtonExamples.Background = buttonNotClicked;
            ButtonTasks.Background = buttonNotClicked;
            ButtonTests.Background = buttonNotClicked;
            ButtonProgres.Background = buttonNotClicked;
        }

        private void ButtonExamples_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new UserControls.UserControlExamplesListing();
            ButtonTheory.Background = buttonNotClicked;
            ButtonExamples.Background = buttonClicked;
            ButtonTasks.Background = buttonNotClicked;
            ButtonTests.Background = buttonNotClicked;
            ButtonProgres.Background = buttonNotClicked;
        }

        private void ButtonTasks_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new UserControls.UserControlTasksListing();
            ButtonTheory.Background = buttonNotClicked;
            ButtonExamples.Background = buttonNotClicked;
            ButtonTasks.Background = buttonClicked;
            ButtonTests.Background = buttonNotClicked;
            ButtonProgres.Background = buttonNotClicked;
        }

        private void ButtonTests_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new UserControls.UserControlTestsListing();
            ButtonTheory.Background = buttonNotClicked;
            ButtonExamples.Background = buttonNotClicked;
            ButtonTasks.Background = buttonNotClicked;
            ButtonTests.Background = buttonClicked;
            ButtonProgres.Background = buttonNotClicked;
        }

        private void ButtonProgres_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new UserControls.UserControlProgresDisplay();
            ButtonTheory.Background = buttonNotClicked;
            ButtonExamples.Background = buttonNotClicked;
            ButtonTasks.Background = buttonNotClicked;
            ButtonTests.Background = buttonNotClicked;
            ButtonProgres.Background = buttonClicked;
        }
    }
}
