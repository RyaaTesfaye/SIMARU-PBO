using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    class Kontak 
    {
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
