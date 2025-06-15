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
                    txtPathGambar.Text = Path.GetFileName(ofdPilihFile.FileName);
                    txtPathGambar.Tag = ofdPilihFile.FileName;
                }
            
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbRating.SelectedItem == null || string.IsNullOrEmpty(cmbRating.SelectedItem.ToString()))
            {
                MessageBox.Show("Harap berikan rating bintang terlebih dahulu.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKomentar.Text))
            {
                MessageBox.Show("Komentar tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            var ulasanBaru = new Ulasan
            {
                Rating = ratingValue,
                Komentar = txtKomentar.Text,
                PathGambar = pathGambar,
                NomorKTP = SesiLogin.LoggedInUser.NomorKTP
            };
            KirimUlasanClicked?.Invoke(this, ulasanBaru);
        }
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            BatalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
