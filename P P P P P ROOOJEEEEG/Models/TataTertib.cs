﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class TataTertib
    {
        [Key]
        public int Id_Tatatertib { get; set; }
        public string Judul { get; set; }
        public DateTime TanggalUpdate { get; set; }
        public string TargetJenisKelamin { get; set;}
    }
}
