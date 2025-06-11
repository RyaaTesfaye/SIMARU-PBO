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

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_TambahVirtual : UserControl
    {
        public event EventHandler SaveCompleted; // Sinyal jika simpan berhasil
        public event EventHandler Cancelled;     // Sinyal jika dibatalkan

        // Service untuk berinteraksi dengan database
        private readonly VirtualTourService _service = new VirtualTourService();
        // Variabel untuk menyimpan data yang sedang diedit
        private MediaVirtual _currentMedia;
        public UC_TambahVirtual()
        {
            InitializeComponent();
        }
        public void LoadMediaToEdit(MediaVirtual media)
        {
            _currentMedia = media;
            txtNama.Text = media.NamaFile;
            txtpath.Text = media.PathMedia;
            txtKeterangan.Text = media.Keterangan;

            // Tampilkan preview gambar jika path-nya ada dan filenya ditemukan
            if (!string.IsNullOrEmpty(media.PathMedia) && File.Exists(media.PathMedia))
            {
                try
                {
                    pictureBoxPreview.Image = Image.FromFile(media.PathMedia);
                }
                catch { /* Abaikan jika file gambar rusak */ }
            }
        }

        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Gambar untuk Virtual Tour";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                // Tampilkan path di textbox dan preview di PictureBox
                txtNama.Text = Path.GetFileNameWithoutExtension(ofdPilihFile.FileName);
                txtpath.Text = ofdPilihFile.FileName;
                pictureBoxPreview.Image = Image.FromFile(ofdPilihFile.FileName);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi input
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtpath.Text))
            {
                MessageBox.Show("Nama File dan Gambar tidak boleh kosong.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Cek apakah ini mode Tambah atau Edit
            if (_currentMedia == null)
            {
                // Jika _currentMedia masih null, berarti kita membuat objek baru (Mode Tambah)
                _currentMedia = new MediaVirtual();
            }

            // 3. Isi objek dengan data dari form
            _currentMedia.NamaFile = txtNama.Text;
            _currentMedia.PathMedia = txtpath.Text;
            _currentMedia.Keterangan = txtKeterangan.Text;
            // Anda bisa tambahkan input untuk UrutanTampil jika perlu

            bool sukses;
            // 4. Panggil service yang sesuai
            if (_currentMedia.Id_Media > 0)
            {
                // Jika sudah punya ID, berarti ini mode Edit
                sukses = _service.UpdateMedia(_currentMedia);
            }
            else
            {
                // Jika belum punya ID, berarti ini mode Tambah Baru
                sukses = _service.AddMedia(_currentMedia);
            }

            // 5. Beri feedback dan kirim sinyal
            if (sukses)
            {
                MessageBox.Show("Data virtual tour berhasil disimpan.", "Sukses");
                SaveCompleted?.Invoke(this, EventArgs.Empty); // Kirim sinyal bahwa simpan selesai
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data ke database.", "Error");
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty); // Kirim sinyal batal
        }
    }
}
