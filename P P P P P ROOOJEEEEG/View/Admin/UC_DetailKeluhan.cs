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

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_DetailKeluhan : UserControl
    {
        public event EventHandler ActionCompleted;
        public event EventHandler BackRequested;

        private readonly KeluhanService _service = new KeluhanService();
        private int _currentKeluhanId;
        public UC_DetailKeluhan()
        {
            InitializeComponent();
            btnTangani.Click += btnTangani_Click;
        }
        public void LoadDetail(int keluhanId)
        {
            _currentKeluhanId = keluhanId;
            var data = _service.GetKeluhanById(keluhanId);
            if (data == null)
            {
                MessageBox.Show("Data keluhan tidak ditemukan.");
                BackRequested?.Invoke(this, EventArgs.Empty);
                return;
            }

            
            lblNama.Text = data.User?.NamaLengkap ?? "N/A";
            lblTanggal.Text = data.Tanggal.ToLocalTime().ToString("dd MMMM yyyy");
            txtIsiKeluhan.Text = data.Isi;
            
            if (!string.IsNullOrEmpty(data.PathGambar) && File.Exists(data.PathGambar))
            {
                try
                {
                    pictureKeluhan.Image = Image.FromFile(data.PathGambar);
                }
                catch { /* Abaikan jika file rusak */ }
            }
            btnTangani.Visible = (data.Status == "Belum Ditangani");
        }
        private void btnTangani_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
               "Anda yakin ingin menangani keluhan ini? Status akan diubah menjadi 'Selesai'.",
               "Konfirmasi Tindakan",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (konfirmasi == DialogResult.Yes)
            {
                // Panggil service untuk mengubah status di database
                bool sukses = _service.UpdateStatusKeluhan(_currentKeluhanId, "Selesai");

                if (sukses)
                {
                    MessageBox.Show("Status keluhan berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActionCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
