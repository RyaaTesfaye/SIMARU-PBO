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
        private readonly ApplicationDbContext _context;
        public List<Laporan> GetAllKeluhan()
        {
            try
            {
                return _context.Laporans
                               .Include(l => l.User)
                               .OrderByDescending(l => l.Tanggal)
                               .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat semua keluhan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Laporan>();
            }
        }
        public Laporan GetKeluhanById(int keluhanId)
        {
            try
            {
                return _context.Laporans
                               .Include(l => l.User)
                               .FirstOrDefault(l => l.Id_Laporan == keluhanId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil detail keluhan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

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
            if (laporanBaru == null || string.IsNullOrWhiteSpace(laporanBaru.NomorKTP) || string.IsNullOrWhiteSpace(laporanBaru.Judul))
            {
                MessageBox.Show("Data keluhan tidak lengkap.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                laporanBaru.Tanggal = DateTime.UtcNow;
                _context.Laporans.Add(laporanBaru);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string errorMessage = "Gagal membuat keluhan baru: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n--> Detail: " + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<Laporan> GetLaporanByPenyewa(string nomorKtp)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Laporans
                .Where(l => l.NomorKTP == nomorKtp)
                .OrderByDescending(l => l.Tanggal)
                .ToList();
            }

        }
    }
}
