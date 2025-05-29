using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    class Unit
    {
        [Key]
        public int Id { get; set; }
        public int Lantai { get; set; }
        public float Luas { get; set; }
        public decimal HargaSewa { get; set; }
        public string Status { get; set; }
    }
}
