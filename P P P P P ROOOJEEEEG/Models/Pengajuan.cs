using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Pengajuan
    {
        [Key]
        public int Id_Pengajuan { get; set; }
        public int Id_Unit { get; set; }
        public string NomorKTP { get; set; }
        public int DurasiSewa { get; set; }
        public decimal EstimasiBiaya { get; set; }
        public string Status { get; set; }
        public DateTime TanggalPengajuan { get; set; }
        public string PathKTP { get; set; }
        public string PathPasfoto { get; set; }
        public string PathPembayaran { get; set; }
        public string PathSuratPernyataan { get; set; }
    }
}
