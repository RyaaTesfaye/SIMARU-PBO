using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Laporan
    {
        [Key]
        public int Id { get; set; }
        public int PenyewaId { get; set; }
        public string Judul { get; set; }
        public string Isi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public string PathGambar { get; set; }
    }
}
