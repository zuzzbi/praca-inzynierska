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

namespace EduMath.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlDisplayTasks.xaml
    /// </summary>
    public partial class UserControlTasksDisplay : UserControl
    {
        public UserControlTasksDisplay()
        {
            InitializeComponent();

            //Dostosuj szerokość kontrolki DocumentViewer do szerokości okna
            DocumentViewer.FitToWidth();
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlTaskListing
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTasksListing();
        }

        private void ButtonScale_Click(object sender, RoutedEventArgs e)
        {
            DocumentViewer.FitToWidth();
        }
    }
}
