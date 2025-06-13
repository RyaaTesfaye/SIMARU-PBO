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
using RUSUNAWAAA.Utils;

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class UC_InputUlasan: UserControl
    {
        public event EventHandler<Ulasan> KirimUlasanClicked;
        public event EventHandler BatalClicked;
        public UC_InputUlasan()
        {
            InitializeComponent();
            btnSimpan.Click += BtnSimpan_Click;
            btnBatal.Click += BtnBatal_Click;
            btnPilihFile.Click += BtnPilihFile_Click;
        }
        private void BtnPilihFile_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            ofdPilihFile.Title = "Pilih Gambar Bukti";
                if (ofdPilihFile.ShowDialog() == DialogResult.OK)
                {
                    // Tampilkan nama file di textbox
                    txtPathGambar.Text = Path.GetFileName(ofdPilihFile.FileName);
                    // Simpan path lengkap di dalam Properti Tag untuk digunakan nanti
                    txtPathGambar.Tag = ofdPilihFile.FileName;
                }
            
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi Rating
            if (cmbRating.SelectedItem == null || string.IsNullOrEmpty(cmbRating.SelectedItem.ToString()))
            {
                MessageBox.Show("Harap berikan rating bintang terlebih dahulu.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Komentar
            if (string.IsNullOrWhiteSpace(txtKomentar.Text))
            {
                MessageBox.Show("Komentar tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- PERUBAHAN DI SINI: Validasi Gambar Wajib ---
            string pathGambar = txtPathGambar.Tag as string;
            if (string.IsNullOrWhiteSpace(pathGambar))
            {
                MessageBox.Show("Gambar wajib diunggah.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbRating.SelectedItem.ToString(), out int ratingValue))
            {
                MessageBox.Show("Pilihan rating tidak valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat objek Ulasan baru dari semua input
            var ulasanBaru = new Ulasan
            {
                Rating = ratingValue,
                Komentar = txtKomentar.Text,
                PathGambar = pathGambar,
                NomorKTP = SesiLogin.LoggedInUser.NomorKTP
            };

            // Kirim sinyal ke form utama
            KirimUlasanClicked?.Invoke(this, ulasanBaru);
        }
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            BatalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
