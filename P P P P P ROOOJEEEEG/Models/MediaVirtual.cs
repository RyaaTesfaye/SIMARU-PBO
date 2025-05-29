using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Models
{
    public class MediaVirtual
    {
        [Key]
        public int Id { get; set; }
        public string NamaFile { get; set; }
        public string PathMedia { get; set; }
        public string Keterangan { get; set; }
    }
}
