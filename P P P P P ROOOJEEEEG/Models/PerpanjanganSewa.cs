using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class PerpanjanganSewa
    {
        public int Id { get; set; }
        public int PenyewaId { get; set; }
        public DateTime TanggalPengajuan { get; set; }
        public int LamaBulan { get; set; }
        public string Status { get; set; }
        public decimal Nominal { get; set; }
        public string PathBuktiPembayaran { get; set; }
    }
}
