using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Penyewa
    {
        [Key]
        public string NomorKTP { get; set; }
        public string AlamatAsal { get; set; }
        public string NomorHP { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Fakultas { get; set; }
        public string Prodi { get; set; }
        public string AsalKota { get; set; }
        public string JenisKelamin { get; set; }
        public string NamaOrangTua { get; set; }

        public Penyewa(string username, string password, string namaLengkap)
            : base(username, password, namaLengkap)
        {

        }
    }


}


    

