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
    /// Логика взаимодействия для WinterCollect.xaml
    /// </summary>
    public partial class WinterCollect : Window
    {
        public WinterCollect()
        {
            InitializeComponent();
        }

        private void BackCollections_Click(object sender, RoutedEventArgs e)
        {
            Collections window = new Collections();
            window.Show();
            Close();
        }
    }
}
