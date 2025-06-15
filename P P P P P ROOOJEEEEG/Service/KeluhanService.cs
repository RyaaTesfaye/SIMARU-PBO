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
        public KeluhanService()
        {
            // --- PERBAIKAN DI SINI: Menambahkan try-catch di constructor ---
            try
            {
                _context = new ApplicationDbContext();
            }
            catch (Exception ex)
            {
                // Ini akan menangkap error yang sebenarnya saat koneksi database gagal dibuat.
                MessageBox.Show("Gagal menginisialisasi koneksi database. Pastikan connection string Anda benar dan database server berjalan.\n\nError Detail: " + ex.Message, "Error Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set _context menjadi null secara eksplisit jika gagal.
                _context = null;
            }
        }
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
            using (var context = new ApplicationDbContext())
            {
                if (laporanBaru == null || string.IsNullOrWhiteSpace(laporanBaru.NomorKTP) || string.IsNullOrWhiteSpace(laporanBaru.Judul))
                {
                    MessageBox.Show("Data keluhan tidak lengkap.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                try
                {
                    laporanBaru.Tanggal = DateTime.UtcNow;
                    if (_context == null)
                    {
                        MessageBox.Show("Konteks database (DbContext) belum diinisialisasi.", "Error Kritis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // --- PENAMBAHAN KODE PENGAMAN BARU ---
                    // Cek apakah DbSet 'Laporans' null. Ini terjadi jika lupa didefinisikan di ApplicationDbContext.cs
                    if (_context.Laporans == null)
                    {
                        MessageBox.Show("Error Konfigurasi: Properti 'Laporans' di DbContext bernilai null.\n\nPastikan Anda sudah menambahkan baris berikut di file ApplicationDbContext.cs Anda:\n\npublic DbSet<Laporan> Laporans { get; set; }", "Error Konfigurasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    _context.Laporans.Add(laporanBaru);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    string errorMessage = "Gagal membuat keluhan baru: " + ex.Message;

                    if (ex.InnerException != null)
                    {
                        errorMessage += "\n--> Detail DB: " + ex.InnerException.Message;
                    }
                    errorMessage += "\n\nStack Trace:\n" + ex.StackTrace;

                    MessageBox.Show(errorMessage, "Error Database Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
