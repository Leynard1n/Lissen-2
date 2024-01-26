using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lissen_2
{
    internal class User
    {

        public int id { get; set; }
        public string login, email, pass;


        public User() { }


        public User(string login , string email , string pass)
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }
       

    }
}
