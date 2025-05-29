using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    class Admin : User
    {
        public Admin(string username, string password, string namaLengkap, string Role) : base(username, password, namaLengkap, Role)
        {
        }
    }
}
