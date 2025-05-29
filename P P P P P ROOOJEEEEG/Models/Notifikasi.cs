using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Notifikasi
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Isi { get; set; }
        public DateTime Tanggal { get; set; }
        public bool SudahDibaca { get; set; }
    }
}
