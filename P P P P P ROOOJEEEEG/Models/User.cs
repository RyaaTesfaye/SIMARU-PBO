using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaLengkap { get; set; }

        public User(string username, string password, string namaLengkap)
        {
            Username = username;
            Password = password;
            NamaLengkap = namaLengkap;
        }
    }
}