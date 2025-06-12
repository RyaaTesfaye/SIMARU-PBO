using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models;

namespace RUSUNAWAAA.View.Penyewa
{
    
    public partial class UC_PerpanjanganSewa2 : UserControl
    {
        public string PathBuktiPembayaran { get; private set; }

        // Event untuk "berkomunikasi" dengan Form utama saat tombol konfirmasi diklik.
        public event EventHandler KonfirmasiButtonClicked;
        public UC_PerpanjanganSewa2()
        {
            InitializeComponent();
        }
        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            
                ofdPilihFile.Title = "Pilih Gambar Bukti Pembayaran";
                // Filter file agar hanya menampilkan format gambar yang umum.
                ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofdPilihFile.ShowDialog() == DialogResult.OK)
                {
                    // Simpan path file yang dipilih ke properti.
                    this.PathBuktiPembayaran = ofdPilihFile.FileName;

                    // Tampilkan path di label (opsional, untuk UX).
                    txt_pathbp.Text = System.IO.Path.GetFileName(ofdPilihFile.FileName);

                    // Tampilkan pratinjau gambar di PictureBox.
                    gambar_bp.Image = new Bitmap(ofdPilihFile.FileName);
                }
            
        }
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            // Memicu event KonfirmasiButtonClicked.
            // Tanda tanya (?) adalah cek singkat untuk memastikan ada yang "mendengarkan" event ini.
            KonfirmasiButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
    
    
}
