using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Ulasan
    {
        [Key]
        public int Id_Ulasan { get; set; }
        public string NomorKTP { get; set; }
        [ForeignKey("NomorKTP")]
        public virtual User User { get; set; }
        public int Rating { get; set; }
        public string Komentar { get; set; }
        public DateTime Tanggal { get; set; }
        public string PathGambar { get; set; }
    }
}
