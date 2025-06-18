using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;

namespace RUSUNAWAAA.Service
{
    public class KontakService
    {
        public KontakService()
        {
        }
        public Kontak GetKontakById(int idKontak)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {

                    return context.Kontaks.Find(idKontak);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data kontak dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
