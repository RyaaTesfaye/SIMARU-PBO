using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Pembayaran
    {
        [Key]
        public int Id_Pembayaran { get; set; }
        public string NomorKTP { get; set; }
        [ForeignKey("NomorKTP")]
        public virtual User User { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Nominal { get; set; }
        public string Status { get; set; }
    }
}
