using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class Pembayaran
    {
        [Key]
        public int Id { get; set; }
        public int PenyewaId { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Nominal { get; set; }
        public string Status { get; set; }
    }
}
