﻿using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Service
{
    public class AkunService
    {
        public List<User> GetAllUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Users.ToList();
            }
        }
        public List<Penyewa> GetPenyewa(string genderFilter = "Semua")
        {
            using (var context = new ApplicationDbContext())
            {
                
                var query = context.Users.OfType<Penyewa>();

               
                if (genderFilter != "Semua")
                {
                    query = query.Where(p => p.JenisKelamin == genderFilter);
                }

                
                return query.ToList();
            }
        }
        public bool DeleteMultipleUsers(List<string> nomorKtps)
        {
            if (nomorKtps == null || !nomorKtps.Any())
            {
                return false; 
            }
            using (var context = new ApplicationDbContext())
            {
                var usersToDelete = context.Users.Where(u => nomorKtps.Contains(u.NomorKTP)).ToList();

                if (usersToDelete.Any())
                {
                    context.Users.RemoveRange(usersToDelete);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public Penyewa GetPenyewaByKtp(string nomorKtp)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Users.OfType<Penyewa>().FirstOrDefault(p => p.NomorKTP == nomorKtp);
            }
        }
        public Pengajuan GetApprovedPengajuanForUser(string nomorKtp)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Pengajuans
                              .Where(p => p.NomorKTP == nomorKtp && p.Status == "Disetujui")
                              .OrderByDescending(p => p.TanggalPengajuan)
                              .FirstOrDefault();
            }
        }
    }
}
