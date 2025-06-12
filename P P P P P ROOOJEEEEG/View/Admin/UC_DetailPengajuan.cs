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
using System.Globalization;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_DetailPengajuan : UserControl
    {
        public event EventHandler ActionCompleted;
        public event EventHandler BackRequested;

        private readonly PengajuanSewaService _service = new PengajuanSewaService();
        private int _currentPengajuanId;
        public UC_DetailPengajuan()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void LoadDetail(int pengajuanId)
        {
            _currentPengajuanId = pengajuanId;
            var data = _service.GetPengajuanById(pengajuanId);

            if (data == null)
            {
                MessageBox.Show("Data pengajuan tidak ditemukan.");
                BackRequested?.Invoke(this, EventArgs.Empty);
                return;
            }

            
            lblPengajuanIsi.Text = data.Id_Pengajuan.ToString("D3");
            lblNamaIsi.Text = data.NamaLengkap;
            lblFakultasIsi.Text = data.Fakultas;
            lblAlamatIsi.Text = data.AlamatAsal;
            lblJenisKelaminIsi.Text = data.JenisKelamin;

            lblNIMIsi.Text = data.NIM;
            lblProdiIsi.Text = data.Prodi;
            lblAsalKotaIsi.Text = data.AsalKota;
            lblNomorHPIsi.Text = data.NomorHP;
            lblOrtuIsi.Text = data.NamaOrangTua;

            lblTanggalIsi.Text = data.TanggalPengajuan.ToLocalTime().ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
            lblNominalIsi.Text = data.EstimasiBiaya.ToString("C", new CultureInfo("id-ID"));
            lblStatusIsi.Text = data.Status;
            lblDurasiIsi.Text = data.DurasiSewa.ToString() + " Bulan";

            
            LinkLihatPasfoto.Visible = !string.IsNullOrEmpty(data.PathPasfoto);
            LinkLihatSurat.Visible = !string.IsNullOrEmpty(data.PathSuratPernyataan);
            LinkLihatKTP.Visible = !string.IsNullOrEmpty(data.PathKTP);
            LinkLihatBukti.Visible = !string.IsNullOrEmpty(data.PathPembayaran);
        }

        private void btnTerima_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menyetujui pengajuan ini? Akun penyewa baru akan dibuat.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool sukses = _service.ApprovePengajuan(_currentPengajuanId);
                if (sukses)
                {
                    MessageBox.Show("Pengajuan berhasil disetujui.", "Sukses");
                   
                    ActionCompleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Gagal menyetujui pengajuan.", "Error");
                }
            }
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
           
            string alasan = "Tidak memenuhi syarat."; 
            if (MessageBox.Show($"Anda yakin ingin menolak pengajuan ini dengan alasan: {alasan}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool sukses = _service.RejectPengajuan(_currentPengajuanId, alasan);
                if (sukses)
                {
                    MessageBox.Show("Pengajuan berhasil ditolak.", "Sukses");
                    ActionCompleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Gagal menolak pengajuan.", "Error");
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void linkLihatKTP_LinkClicked(object sender, EventArgs e)
        {
            var data = _service.GetPengajuanById(_currentPengajuanId);
            if (data != null && !string.IsNullOrEmpty(data.PathKTP))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(data.PathKTP) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuka file: " + ex.Message);
                }
            }
        }
    }
}
