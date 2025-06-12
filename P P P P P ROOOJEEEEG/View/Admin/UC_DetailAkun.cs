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
          
            var penyewa = _userService.GetPenyewaByKtp(nomorKtp);

            
            var pengajuan = _userService.GetApprovedPengajuanForUser(nomorKtp);

            if (penyewa == null)
            {
                MessageBox.Show("Data penyewa tidak ditemukan.");
                return;
            }

           
            lblNomorKTPIsi.Text = penyewa.NomorKTP; 
            lblNamaIsi.Text = penyewa.NamaLengkap;
            lblFakultasIsi.Text = penyewa.Fakultas;
            lblAlamatIsi.Text = penyewa.AlamatAsal;
            lblJenisKelaminIsi.Text = penyewa.JenisKelamin;
            lblNIMIsi.Text = penyewa.NIM;
            lblProdiIsi.Text = penyewa.Prodi;
            lblAsalKotaIsi.Text = penyewa.AsalKota;
            lblNomorHPIsi.Text = penyewa.NomorHP;
            lblOrtuIsi.Text = penyewa.NamaOrangTua;

       
            if (pengajuan != null)
            {
                lblDurasiIsi.Text = pengajuan.DurasiSewa.ToString() + " Bulan";
                
                LinkLihatPasfoto.Tag = pengajuan.PathPasfoto;
                LinkLihatKTP.Tag = pengajuan.PathKTP;
                
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
