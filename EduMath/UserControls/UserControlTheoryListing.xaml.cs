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

namespace EduMath.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlTheoryListing.xaml
    /// </summary>
    public partial class UserControlTheoryListing : UserControl
    {
        public UserControlTheoryListing()
        {
            InitializeComponent();
        }

        private void ListBoxTheoryListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlTheoryDisplay();
            if ((Application.Current.MainWindow as MainWindow).ButtonTheory.IsEnabled == false)
            {
                if (ListBoxItemTheory1.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Theory1";
                if (ListBoxItemTheory2.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Theory2";
                if (ListBoxItemTheory3.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Theory3";
            }
            if ((Application.Current.MainWindow as MainWindow).ButtonExamples.IsEnabled == false)
            {
                if (ListBoxItemTheory1.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Example1";
                if (ListBoxItemTheory2.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Example2";
                if (ListBoxItemTheory3.IsSelected)
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlTheoryDisplay).TextBox1.Text = "Example3";
            }
        }
    }
}
