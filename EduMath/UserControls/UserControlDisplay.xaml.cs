﻿using System;
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
    /// Kontrolka użytkownika służąca do wyświetlania plików .xps zawierających teorię
    /// </summary>
    public partial class UserControlDisplay : UserControl
    {
        public UserControlDisplay()
        {
            InitializeComponent();

            //Dostosuj szerokość kontrolki DocumentViewer do szerokości okna
            DocumentViewer.FitToWidth();
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlListing
            (Application.Current.MainWindow as MainWindow).ContentControl.Content = new UserControlListing();
        }

        private void ButtonScale_Click(object sender, RoutedEventArgs e)
        {
            //Otwórz poprzednią kontrolkę UserControlListing
            DocumentViewer.FitToWidth();
        }
    }
}
