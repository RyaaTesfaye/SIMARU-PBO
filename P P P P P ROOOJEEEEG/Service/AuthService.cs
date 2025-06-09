using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;


namespace RUSUNAWAAA.Service
{
    public class AuthService
    {
        public User Login(string username, string password)
        {
            // Validasi input dasar
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            using (var context = new ApplicationDbContext())
            {
                // Cari user di database yang username DAN password-nya cocok.
                // NOTE: Di aplikasi dunia nyata, password harus di-hash.
                // Untuk proyek ini, perbandingan teks biasa sudah cukup.
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                // Kembalikan objek user jika ditemukan, jika tidak maka akan mengembalikan null.
                return user;
            }
        }
    }
}
