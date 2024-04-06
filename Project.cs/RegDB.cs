using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.cs
{
    class RegDB
    {
        string username, password, email;
        string contact;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
    }
}
