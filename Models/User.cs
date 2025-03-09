using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class User
    {
        public string? Userame;
        public string? Email;
        public string? Password;


        public User(string username, string email, string passowrd) 
        {
            Userame = username;
            Email = email;
            Password = passowrd;
        }
    }
}
