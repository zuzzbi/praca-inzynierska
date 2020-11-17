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
    /// Logika interakcji dla klasy UserControlProgresDisplay.xaml
    /// </summary>
    public partial class UserControlProgresDisplay : UserControl
    {
        public UserControlProgresDisplay()
        {
            InitializeComponent();

            StreamReader streamReader = new StreamReader("progres.txt");
            string all = streamReader.ReadToEnd();
            string[] lines = all.Split('\n');
            streamReader.Close();

            foreach (TextBox item in ItemsControl2.Items)
            {              
                int number = Convert.ToInt32(item.Name.Replace("TextBoxProgres", ""));
                int completedTasks = 0;
                string line = lines[number - 1];
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '1')
                    {
                        completedTasks++;
                    }
                }
                int percentage = (completedTasks * 100) / line.Trim('\n').Trim('\r').Length;

                item.Text = percentage + "%";
            }
        }
    }
}
