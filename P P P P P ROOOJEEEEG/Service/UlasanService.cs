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
            if (ulasanBaru == null || ulasanBaru.Rating < 1 || ulasanBaru.Rating > 5 || string.IsNullOrEmpty(ulasanBaru.NomorKTP))
            {
                return false;
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    ulasanBaru.Tanggal = DateTime.UtcNow;
                    context.Ulasans.Add(ulasanBaru);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
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
            if (string.IsNullOrEmpty(nomorKtp)) return true; 

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
