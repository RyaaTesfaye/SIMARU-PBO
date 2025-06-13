using Microsoft.EntityFrameworkCore;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Service
{
    public class UlasanService
    {
        public bool AddUlasan(Ulasan ulasanBaru)
        {
            // Validasi dasar di service
            if (ulasanBaru == null || ulasanBaru.Rating < 1 || ulasanBaru.Rating > 5 || string.IsNullOrEmpty(ulasanBaru.NomorKTP))
            {
                return false;
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Selalu gunakan UTC untuk tanggal di database
                    ulasanBaru.Tanggal = DateTime.UtcNow;
                    context.Ulasans.Add(ulasanBaru);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Di aplikasi nyata, ini seharusnya dicatat ke file log.
                // Kita return false untuk menandakan ada error.
                Console.WriteLine("Error saat menambah ulasan: " + ex.Message);
                return false;
            }
        }
        public List<Ulasan> GetAllUlasan()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // .Include(u => u.User) penting untuk mengambil data pengguna (nama, dll) yang berelasi.
                    return context.Ulasans
                                  .Include(u => u.User)
                                  .OrderByDescending(u => u.Tanggal)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data ulasan dari database.", ex);
            }
        }
        public bool SudahMemberiUlasan(string nomorKtp)
        {
            if (string.IsNullOrEmpty(nomorKtp)) return true; // Anggap sudah jika KTP tidak valid

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return context.Ulasans.Any(u => u.NomorKTP == nomorKtp);
                }
            }
            catch
            {
                return true;
            }
        }
    }
}
