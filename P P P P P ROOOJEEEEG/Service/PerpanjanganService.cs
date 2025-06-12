using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RUSUNAWAAA.Service
{
    public class PerpanjanganService
    {
        private readonly ApplicationDbContext _context;
        public PerpanjanganService()
        {
            _context = new ApplicationDbContext();
        }
        public bool AjukanPerpanjangan(PerpanjanganSewa perpanjanganBaru)
        {
            if (perpanjanganBaru == null || perpanjanganBaru.LamaBulan <= 0 || string.IsNullOrWhiteSpace(perpanjanganBaru.PathBuktiPembayaran))
            {
                MessageBox.Show("Data tidak lengkap. Durasi sewa dan bukti pembayaran wajib diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                perpanjanganBaru.TanggalPengajuan = DateTime.UtcNow;
                perpanjanganBaru.Status = "Menunggu Konfirmasi";

                _context.Perpanjangans.Add(perpanjanganBaru);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Kita gali InnerException untuk menemukan pesan error yang sebenarnya.
                string errorMessage = "Gagal menyimpan data perpanjangan: " + ex.Message;
                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    errorMessage += "\n--> " + innerException.Message;
                    innerException = innerException.InnerException;
                }
                MessageBox.Show(errorMessage, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<PerpanjanganSewa> GetPerpanjanganByPenyewa(string nomorKtp)
        {
            try
            {
                return _context.Perpanjangans
                              .Where(p => p.NomorKTP == nomorKtp)
                              .OrderByDescending(p => p.TanggalPengajuan)
                              .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil riwayat perpanjangan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PerpanjanganSewa>(); 
            }
        }
        public List<PerpanjanganSewa> GetAllPerpanjangan()
        {
            try
            {
                return _context.Perpanjangans
                               .Include(p => p.User)
                               .OrderByDescending(p => p.TanggalPengajuan)
                               .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil semua data perpanjangan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PerpanjanganSewa>();
            }
        }
        public bool UpdateStatusPerpanjangan(int idPerpanjangan, string status)
        {
            try
            {
                var perpanjangan = _context.Perpanjangans.Find(idPerpanjangan);
                if (perpanjangan == null)
                {
                    MessageBox.Show("Data perpanjangan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                perpanjangan.Status = status;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui status: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public PerpanjanganSewa GetPerpanjanganById(int idPerpanjangan)
        {
            try
            {
                return _context.Perpanjangans
                               .Include(p => p.User)
                               .FirstOrDefault(p => p.Id_Perpanjangan == idPerpanjangan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil detail perpanjangan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
