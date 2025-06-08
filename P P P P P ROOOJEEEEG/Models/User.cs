using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public abstract class User
    {
        [Key]
        public string NomorKTP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Ulasan> Ulasans { get; set; }
        public virtual ICollection<PerpanjanganSewa> Perpanjangans { get; set; }
        public virtual ICollection<Pembayaran> Pembayarans { get; set; }
        public virtual ICollection<Laporan> Laporans { get; set; }
        public User() { }
        public User(string nomorktp,string username, string password, string namaLengkap, string role)
        {
            NomorKTP = nomorktp;
            Username = username;
            Password = password;
            NamaLengkap = namaLengkap;
            Role = role;
        }
    }
}