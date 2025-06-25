using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Penyewa : User
    {
        
        public string AlamatAsal { get; set; }
        public string NomorHP { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Fakultas { get; set; }
        public string Prodi { get; set; }
        public string AsalKota { get; set; }
        public string JenisKelamin { get; set; }
        public string NamaOrangTua { get; set; }
        public string NIM { get; set; }
        public Penyewa() { }
        public Penyewa(string nomorktp,string username, string password, string namaLengkap,string role)
            : base(nomorktp,username, password, namaLengkap,"Penyewa")
        {

        }
        public override string GetRoleName()
        {
            return "Penyewa";
        }
    }


}


    

