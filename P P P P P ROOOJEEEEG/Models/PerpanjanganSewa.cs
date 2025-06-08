using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class PerpanjanganSewa
    {
        [Key]
        public int Id_Perpanjangan { get; set; }
        public string NomorKTP { get; set; }
        [ForeignKey("NomorKTP")]
        public virtual User User { get; set; }
        public DateTime TanggalPengajuan { get; set; }
        public int LamaBulan { get; set; }
        public string Status { get; set; }
        public decimal Nominal { get; set; }
        public string PathBuktiPembayaran { get; set; }
    }
}
