using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using Microsoft.EntityFrameworkCore;


namespace RUSUNAWAAA.Service
{
    public class AuthService
    {
        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                return user;
            }
        }
        public bool CheckUserAccountDetails(string noHp, string username, string nik, string namaOrangTua)
        {
            if (string.IsNullOrWhiteSpace(noHp) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(nik) ||
                string.IsNullOrWhiteSpace(namaOrangTua))
            {
                return false;
            }

            using (var context = new ApplicationDbContext())
            {
                var penyewa = context.Penyewas.FirstOrDefault(p =>
                    p.NomorHP == noHp &&
                    p.Username == username &&
                    p.NomorKTP == nik &&
                    p.NamaOrangTua == namaOrangTua);

                return penyewa != null;
            }
        }
        // In AuthService.cs
        public bool UpdatePassword(string identifierNIK, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(identifierNIK) || string.IsNullOrWhiteSpace(newPassword))
            {
                return false;
            }

            using (var context = new ApplicationDbContext())
            {
                
                var penyewa = context.Penyewas.FirstOrDefault(p => p.NomorKTP == identifierNIK); 

                if (penyewa != null)
                {
                    penyewa.Password = newPassword;
                    try 
                    {
                        context.SaveChanges();
                        return true;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        Console.WriteLine($"Database update error in UpdatePassword: {dbEx.Message}");
                        if (dbEx.InnerException != null)
                            Console.WriteLine($"Inner Exception: {dbEx.InnerException.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General error in UpdatePassword: {ex.Message}");
                        return false;
                    }
                }
                Console.WriteLine($"User with NIK '{identifierNIK}' not found for password update."); // Added console message
                return false;
            }
        }

    }
}
