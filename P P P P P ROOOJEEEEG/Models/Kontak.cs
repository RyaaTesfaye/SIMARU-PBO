using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Kontak 
    {
        [Key]
        public int Id { get; set; }
        public string NamaKontak { get; set; }
        public string Telepon { get; set; }
        public string Lokasi { get; set; }
        public Kontak(string NamaKontak, string Telepon, string Lokasi)
        {
            this.NamaKontak = NamaKontak;
            this.Telepon = Telepon;
            this.Lokasi = Lokasi;

        }
    }
}
