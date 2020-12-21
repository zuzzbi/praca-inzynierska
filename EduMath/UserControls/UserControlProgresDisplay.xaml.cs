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

            try
            {
                StreamReader streamReader = new StreamReader("progres.dat");
                string all = streamReader.ReadToEnd();
                all = Encoding.UTF8.GetString(Convert.FromBase64String(all));
                string[] lines = all.Split('\n');
                streamReader.Close();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (i == lines.Length - 1)
                    {
                        string[] results = line.Split(' ');
                        for (int j = 0; j < results.Length; j++)
                        {
                            int result = Convert.ToInt32(results[j]);
                            TextBlock textBlock = new TextBlock();
                            Color color;
                            if (result < 50)
                            {
                                color = (Color)ColorConverter.ConvertFromString("#DC143C");
                            }
                            else if (result >= 50 && result < 100)
                            {
                                color = (Color)ColorConverter.ConvertFromString("#FDE456");
                            }
                            else
                            {
                                color = (Color)ColorConverter.ConvertFromString("#BCE27F");
                            }
                            SolidColorBrush brush = new SolidColorBrush(color);
                            textBlock.Text = results[j] + "%";
                            textBlock.Foreground = brush;
                            ItemsControl3.Items.Add(textBlock);
                        }
                    }
                    else
                    {
                        int completedTasks = 0;
                        for (int j = 0; j < line.Length; j++)
                        {
                            if (line[j] == '1')
                            {
                                completedTasks++;
                            }
                        }
                        int percentage = (completedTasks * 100) / line.Trim('\n').Trim('\r').Length;

                        TextBlock textBlock = new TextBlock();
                        Color color;
                        if (percentage < 50)
                        {
                            color = (Color)ColorConverter.ConvertFromString("#DC143C");
                        }
                        else if (percentage >= 50 && percentage < 100)
                        {
                            color = (Color)ColorConverter.ConvertFromString("#FDE456");
                        }
                        else
                        {
                            color = (Color)ColorConverter.ConvertFromString("#BCE27F");
                        }
                        SolidColorBrush brush = new SolidColorBrush(color);
                        textBlock.Text = percentage + "%";
                        textBlock.Foreground = brush;
                        ItemsControl2.Items.Add(textBlock);
                    }
                }
            }
            catch (Exception)
            {
                ItemsControl1.Visibility = Visibility.Hidden;
                ItemsControl2.Visibility = Visibility.Hidden;
                ItemsControl3.Visibility = Visibility.Hidden;
                TextBlock1.Visibility = Visibility.Hidden;
                TextBlock2.Visibility = Visibility.Hidden;
                TextBlock3.Visibility = Visibility.Hidden;
                TextBlockError.Visibility = Visibility.Visible;

            }
        }
    }
}
