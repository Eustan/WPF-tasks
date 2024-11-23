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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int bals = 0;
            if(radioBtn16.IsChecked ==true)
            {
                bals++;
            }
            if (radioBtn6.IsChecked == true)
            {
                bals++;
            }
            if (radioBtn14.IsChecked == true)
            {
                bals++;
            }
            if (radioBtn13.IsChecked == true)
            {
                bals++;
            }
            MessageBox.Show($" у тебя:{bals}");
        }
    }
}
