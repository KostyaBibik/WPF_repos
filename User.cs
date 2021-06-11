using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class User
    {
        public int id { get; set; }

        private string login, password, mail;


        public string Password { get { return password; } set { password = value; } }
        public string Login {
            get { return login;  } 
            set { login = value; }
        }
        public string Mail { get { return mail; } set { mail = value; } } 

        public User()
        {

        }
        public User(string login, string password, string mail)
        {
            this.login = login;
            this.password = password;
            this.mail = mail;
        }


    }
}
