using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Laporan
    {
        [Key]
        public int Id_Laporan { get; set; }
        public string NomorKTP { get; set; }
        [ForeignKey("NomorKTP")]
        public virtual User User { get; set; }
        public string Judul { get; set; }
        public string Isi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public string PathGambar { get; set; }
    }
}
