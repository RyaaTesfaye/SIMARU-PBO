using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Models;
using RUSUNAWAAA.Utils;

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class UC_Lapor : UserControl
    {
        public event EventHandler LaporanBerhasilDibuat;

        private readonly KeluhanService _service = new KeluhanService();
        public UC_Lapor()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtJudul.Clear();
            txtIsiKeluhan.Clear();
            txtPathGambar.Clear();
        }
        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                txtPathGambar.Text = ofdPilihFile.FileName;
            }
        }
        private void btnKirim_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtJudul.Text) || string.IsNullOrWhiteSpace(txtIsiKeluhan.Text))
            {
                MessageBox.Show("Judul dan Isi Keluhan tidak boleh kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!SesiLogin.IsLoggedIn())
            {
                MessageBox.Show("Sesi tidak ditemukan. Harap login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var laporanBaru = new Laporan
            {
                Judul = txtJudul.Text,
                Isi = txtIsiKeluhan.Text,
                PathGambar = txtPathGambar.Text,

                
                NomorKTP = SesiLogin.LoggedInUser.NomorKTP,

              
                Tanggal = DateTime.UtcNow,
                Status = "Belum Ditangani"
            };

            
            try
            {
                bool sukses = _service.BuatKeluhanBaru(laporanBaru);
                if (sukses)
                {
                    MessageBox.Show("Laporan keluhan Anda berhasil dikirim.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LaporanBerhasilDibuat?.Invoke(this, EventArgs.Empty);
                    
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Gagal mengirim laporan. Coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;

                
                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    
                    errorMessage += "\n --> " + innerException.Message;

                 
                    innerException = innerException.InnerException;
                }

               
                MessageBox.Show("Terjadi kesalahan database:\n\n" + errorMessage, "Error Kritis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
    }
}
  