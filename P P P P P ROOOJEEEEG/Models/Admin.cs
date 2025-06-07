using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Admin : User
    {
        public Admin() { }
        public Admin(string nomorktp, string username, string password, string namaLengkap, string Role) : base(nomorktp, username, password, namaLengkap, "Admin")
        {

        }
    }
}
