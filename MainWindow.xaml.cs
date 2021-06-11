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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApllicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApllicationContext();
        }

        private void sign_up_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password = PasswordBoxPassword.Password.Trim();
            string RePassword = RePasswordBoxLogin.Password.Trim();
            string mail = textBoxMail.Text.Trim();

            if(login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Incorrect value";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if(password.Length < 5){
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                PasswordBoxPassword.ToolTip = "Incorrect value";
                PasswordBoxPassword.Background = Brushes.DarkRed;
            }
            else if (RePassword != password)
            {
                PasswordBoxPassword.ToolTip = "";
                PasswordBoxPassword.Background = Brushes.Transparent;
                RePasswordBoxLogin.ToolTip = "don't match the password";
                RePasswordBoxLogin.Background = Brushes.DarkRed;
            }
            else if (mail.Length < 5 || !mail.Contains("@") || !mail.Contains("."))
            {
                RePasswordBoxLogin.ToolTip = "";
                RePasswordBoxLogin.Background = Brushes.Transparent;
                textBoxMail.ToolTip = "Incorrect value";
                textBoxMail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxMail.ToolTip = "";
                textBoxMail.Background = Brushes.Transparent;

                MessageBox.Show("successful registration");

                User user = new User(login, password, mail);
                

                db.Users.Add(user);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Close();
            }

        }

        private void enter_click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }
    }
}
