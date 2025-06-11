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
using RUSUNAWAAA.Service;

namespace RUSUNAWAAA.View.Admin
{

    public partial class UC_DetailAkun : UserControl
    {
        public event EventHandler BackRequested;
        private readonly AkunService _userService = new AkunService();
        public UC_DetailAkun()
        {
            InitializeComponent();
        }
        public void LoadData(string nomorKtp)
        {
            // Ambil data Penyewa dari database
            var penyewa = _userService.GetPenyewaByKtp(nomorKtp);

            // Ambil data Pengajuan yang terkait dengan penyewa ini
            var pengajuan = _userService.GetApprovedPengajuanForUser(nomorKtp);

            if (penyewa == null)
            {
                MessageBox.Show("Data penyewa tidak ditemukan.");
                return;
            }

            // --- Isi Label dengan Data dari Objek Penyewa ---
            lblNomorKTPIsi.Text = penyewa.NomorKTP; // atau Username/NIM
            lblNamaIsi.Text = penyewa.NamaLengkap;
            lblFakultasIsi.Text = penyewa.Fakultas;
            lblAlamatIsi.Text = penyewa.AlamatAsal;
            lblJenisKelaminIsi.Text = penyewa.JenisKelamin;
            lblNIMIsi.Text = penyewa.NIM;
            lblProdiIsi.Text = penyewa.Prodi;
            lblAsalKotaIsi.Text = penyewa.AsalKota;
            lblNomorHPIsi.Text = penyewa.NomorHP;
            lblOrtuIsi.Text = penyewa.NamaOrangTua;

            // --- Isi Label dengan Data dari Objek Pengajuan (jika ada) ---
            if (pengajuan != null)
            {
                lblDurasiIsi.Text = pengajuan.DurasiSewa.ToString() + " Bulan";
                // Anda bisa tambahkan label lain jika perlu, misal nominal pembayaran

                // Atur link untuk melihat berkas
                LinkLihatPasfoto.Tag = pengajuan.PathPasfoto;
                LinkLihatKTP.Tag = pengajuan.PathKTP;
                // ... atur Tag untuk link lain
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void Berkas_LinkClicked(object sender, EventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            string filePath = linkLabel?.Tag?.ToString();

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    // Buka file dengan program default
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuka file. Pastikan file ada di lokasi yang benar.\n\nError: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Path file tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
