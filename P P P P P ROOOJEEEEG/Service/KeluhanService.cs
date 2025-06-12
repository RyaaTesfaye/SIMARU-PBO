using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Service
{
    public class KeluhanService
    {
        public List<Laporan> GetAllKeluhan()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Laporans.Include(l => l.User).ToList();
            }
        }
        public Laporan GetKeluhanById(int keluhanId)
        {
            using (var context = new ApplicationDbContext())
            {
                // Gunakan .Include() agar data User pelapor juga ikut terambil
                return context.Laporans
                              .Include(l => l.User)
                              .FirstOrDefault(l => l.Id_Laporan == keluhanId);
            }
        }

        /// <summary>
        /// Mengubah status sebuah keluhan (misalnya dari "Belum Ditangani" menjadi "Selesai").
        /// </summary>
        public bool UpdateStatusKeluhan(int keluhanId, string newStatus)
        {
            using (var context = new ApplicationDbContext())
            {
                var keluhan = context.Laporans.Find(keluhanId);
                if (keluhan != null)
                {
                    keluhan.Status = newStatus;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool BuatKeluhanBaru(Laporan laporanBaru)
        {
            // Validasi dasar
            if (laporanBaru == null || string.IsNullOrWhiteSpace(laporanBaru.NomorKTP) || string.IsNullOrWhiteSpace(laporanBaru.Judul))
            {
                return false;
            }

            using (var context = new ApplicationDbContext())
            {
                context.Laporans.Add(laporanBaru);
                context.SaveChanges();
                return true;
            }
        }
    }
}
