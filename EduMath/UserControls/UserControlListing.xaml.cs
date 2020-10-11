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

namespace EduMath.UserControls
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlTheoryListing.xaml
    /// </summary>
    public partial class UserControlListing : UserControl
    {
        public UserControlListing()
        {
            InitializeComponent();
        }

        private void ListBoxTheoryListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlDisplay();
            if ((Application.Current.MainWindow as MainWindow).ButtonTheory.IsEnabled == false)
            {
                if (ListBoxItemTheory1.IsSelected)
                {
                    XpsDocument xpsDocument = new XpsDocument(@"C:\Users\zuzzb\Documents\GitHub\praca-inzynierska\EduMath\Theory\Theory1.xps", System.IO.FileAccess.Read);
                    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).DocumentViewer.Document = xpsDocument.GetFixedDocumentSequence();
                    //((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = ClassDeserialization.Deserialize("../../Theory/PI_teoria.txt");

                    //Image image = new Image();
                    //BitmapImage bitmapImage = new BitmapImage();
                    //bitmapImage.BeginInit();
                    //bitmapImage.UriSource = new Uri(@"C:\Users\zuzzb\Documents\GitHub\praca-inzynierska\EduMath\UserControls\eqn.png");
                    //bitmapImage.EndInit();
                    //image.Source = bitmapImage;
                    //image.Width = 100;
                    //image.Height = 40;
                    //((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).Grid.Children.Add(image);               
                }
                //if (ListBoxItemTheory2.IsSelected)
                //    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = "Theory2";
                //if (ListBoxItemTheory3.IsSelected)
                //    ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = "Theory3";
            }
            //if ((Application.Current.MainWindow as MainWindow).ButtonExamples.IsEnabled == false)
            //{
            //    if (ListBoxItemTheory1.IsSelected)
            //        ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = "Example1";
            //    if (ListBoxItemTheory2.IsSelected)
            //        ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = "Example2";
            //    if (ListBoxItemTheory3.IsSelected)
            //        ((Application.Current.MainWindow as MainWindow).ContentControl.Content as UserControlDisplay).TextBox1.Text = "Example3";
            //}
        }
    }
}
