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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void enter_auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password = PasswordBoxPassword.Password.Trim();
           

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Incorrect value";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (password.Length < 5)
            {
                PasswordBoxPassword.ToolTip = "Incorrect value";
                PasswordBoxPassword.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                PasswordBoxPassword.ToolTip = "";
                PasswordBoxPassword.Background = Brushes.Transparent;

                User authUser = null;
                using (ApllicationContext db = new ApllicationContext())
                {
                    authUser = db.Users.Where(user => user.Login == login && user.Password == password).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Entering...");
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect input!");
                }

            }
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
