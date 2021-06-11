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
    /// Логика взаимодействия для Collections.xaml
    /// </summary>
    public partial class Collections : Window
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void autumn_click(object sender, RoutedEventArgs e)
        {
            AutumnCollect window = new AutumnCollect();
            window.Show();
            Close();
        }

        private void summer_click(object sender, RoutedEventArgs e)
        {
            SummerCollect window = new SummerCollect();
            window.Show();
            Close();
        }

        private void spring_click(object sender, RoutedEventArgs e)
        {
            SpringCollect window = new SpringCollect();
            window.Show();
            Close();
        }

        private void winter_click(object sender, RoutedEventArgs e)
        {
            WinterCollect window = new WinterCollect();
            window.Show();
            Close();
        }
    }
}
