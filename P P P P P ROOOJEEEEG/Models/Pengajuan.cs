using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Pengajuan
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int PenyewaId { get; set; }
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
