using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        public string name = "";
        public string surname = "";
        public string email = "";
        public string password = "";
        public string phone;

        public bool isLoggedIn = false;


        public User(string name, string surname, string email, string password, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.phone = phone;

            this.isLoggedIn = true;
        }
    }
}
