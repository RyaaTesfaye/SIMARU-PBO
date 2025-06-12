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
using RUSUNAWAAA.Models;
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_DetailPengajuan : UserControl
    {
        public event EventHandler ActionCompleted;
        public event EventHandler BackRequested;

        private readonly PengajuanSewaService _pengajuanService;
        private readonly PerpanjanganService _perpanjanganService;

        private enum TipeData { BelumAda, Pengajuan, Perpanjangan };
        private TipeData _tipeDataSaatIni = TipeData.BelumAda;
        private int _currentId;
        public UC_DetailPengajuan()
        {
            InitializeComponent();
            _pengajuanService = new PengajuanSewaService();
            _perpanjanganService = new PerpanjanganService();

            // Hubungkan tombol-tombol
            btnTerima.Click += BtnTerima_Click;
            btnTolak.Click += BtnTolak_Click;
            btnKembali.Click += BtnKembali_Click;

            // Hubungkan semua link lihat file
            LinkLihatPasfoto.Click += LinkLihatFile_Click;
            LinkLihatSurat.Click += LinkLihatFile_Click;
            LinkLihatKTP.Click += LinkLihatFile_Click;
            LinkLihatBukti.Click += LinkLihatFile_Click;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void LoadDetail(Pengajuan data)
        {
            if (data == null) { HandleDataNotFound(); return; }

            _tipeDataSaatIni = TipeData.Pengajuan;
            _currentId = data.Id_Pengajuan;

            // Tampilkan semua data Pengajuan
            lblJudulDetail.Text = "Detail Pengajuan";
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

            // Atur visibilitas label dan link untuk Pengajuan
            SetVisibility(true);
            LinkLihatPasfoto.Visible = !string.IsNullOrEmpty(data.PathPasfoto);
            LinkLihatSurat.Visible = !string.IsNullOrEmpty(data.PathSuratPernyataan);
            LinkLihatKTP.Visible = !string.IsNullOrEmpty(data.PathKTP);
            LinkLihatBukti.Visible = !string.IsNullOrEmpty(data.PathPembayaran);
        }
        public void LoadDetail(PerpanjanganSewa data)
        {
            if (data == null) { HandleDataNotFound(); return; }

            _tipeDataSaatIni = TipeData.Perpanjangan;
            _currentId = data.Id_Perpanjangan;

            lblJudulDetail.Text = "Detail Perpanjangan";
            lblPengajuanIsi.Text = data.Id_Perpanjangan.ToString("D3");
            lblNamaIsi.Text = data.User?.NamaLengkap ?? "N/A";
            lblNomorHPIsi.Text = (data.User as PenyewaModel)?.NomorHP ?? "N/A";
            lblJenisKelaminIsi.Text = (data.User as PenyewaModel)?.JenisKelamin ?? "N/A";
            lblTanggalIsi.Text = data.TanggalPengajuan.ToLocalTime().ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
            lblNominalIsi.Text = data.Nominal.ToString("C", new CultureInfo("id-ID"));
            lblStatusIsi.Text = data.Status;
            lblDurasiIsi.Text = data.LamaBulan.ToString() + " Bulan";

            lblFakultasIsi.Text = "---";
            lblAlamatIsi.Text = "---";
            lblNIMIsi.Text = "---";
            lblProdiIsi.Text = "---";
            lblAsalKotaIsi.Text = "---";
            lblOrtuIsi.Text = "---";

            SetVisibility(false);
            LinkLihatBukti.Visible = !string.IsNullOrEmpty(data.PathBuktiPembayaran);
        }

        private void BtnTerima_Click(object sender, EventArgs e)
        {
            if (_tipeDataSaatIni == TipeData.Pengajuan)
            {
                if (MessageBox.Show("Anda yakin ingin menyetujui pengajuan ini? Akun penyewa baru akan dibuat.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_pengajuanService.ApprovePengajuan(_currentId))
                    {
                        MessageBox.Show("Pengajuan berhasil disetujui.", "Sukses");
                        ActionCompleted?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            else if (_tipeDataSaatIni == TipeData.Perpanjangan)
            {
                if (MessageBox.Show("Anda yakin ingin menyetujui perpanjangan sewa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_perpanjanganService.UpdateStatusPerpanjangan(_currentId, "Disetujui"))
                    {
                        MessageBox.Show("Perpanjangan sewa berhasil disetujui.", "Sukses");
                        ActionCompleted?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }

        private void BtnTolak_Click(object sender, EventArgs e)
        {
            if (_tipeDataSaatIni == TipeData.Pengajuan)
            {
                string alasan = "Tidak memenuhi syarat."; 
                if (MessageBox.Show($"Anda yakin ingin menolak pengajuan ini dengan alasan: {alasan}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (_pengajuanService.RejectPengajuan(_currentId, alasan))
                    {
                        MessageBox.Show("Pengajuan berhasil ditolak.", "Sukses");
                        ActionCompleted?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            else if (_tipeDataSaatIni == TipeData.Perpanjangan)
            {
                if (MessageBox.Show("Anda yakin ingin menolak perpanjangan sewa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (_perpanjanganService.UpdateStatusPerpanjangan(_currentId, "Ditolak"))
                    {
                        MessageBox.Show("Perpanjangan sewa berhasil ditolak.", "Sukses");
                        ActionCompleted?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }
        private void SetVisibility(bool isPengajuan)
        {
            // Atur visibilitas label dan link yang hanya ada di pengajuan
            lblNIMIsi.Visible = isPengajuan; lblNIMIsi.Visible = isPengajuan;
            lblProdiIsi.Visible = isPengajuan; lblProdiIsi.Visible = isPengajuan;
            lblFakultasIsi.Visible = isPengajuan;
            lblAsalKotaIsi.Visible = isPengajuan; lblAsalKotaIsi.Visible = isPengajuan;
            lblAlamatIsi.Visible = isPengajuan; lblAlamatIsi.Visible = isPengajuan;
            lblOrtuIsi.Visible = isPengajuan; lblOrtuIsi.Visible = isPengajuan;

            LinkLihatPasfoto.Visible = isPengajuan;
            LinkLihatSurat.Visible = isPengajuan;
            LinkLihatKTP.Visible = isPengajuan;
        }

        private void LinkLihatFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            var link = sender as Label; // Menggunakan Label, bukan LinkLabel

            if (link == null) return; // Pengaman jika sender bukan Label

            if (_tipeDataSaatIni == TipeData.Pengajuan)
            {
                var data = _pengajuanService.GetPengajuanById(_currentId);
                if (data == null) return;

                if (link == LinkLihatPasfoto) filePath = data.PathPasfoto;
                else if (link == LinkLihatSurat) filePath = data.PathSuratPernyataan;
                else if (link == LinkLihatKTP) filePath = data.PathKTP;
                else if (link == LinkLihatBukti) filePath = data.PathPembayaran;
            }
            else if (_tipeDataSaatIni == TipeData.Perpanjangan)
            {
                var data = _perpanjanganService.GetPerpanjanganById(_currentId);
                if (data == null) return;
                if (link == LinkLihatBukti) filePath = data.PathBuktiPembayaran;
            }

            OpenFile(filePath);
        }

        private void OpenFile(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true }); }
                catch (Exception ex) { MessageBox.Show("Gagal membuka file: " + ex.Message); }
            }
            else { MessageBox.Show("Path file tidak valid atau file tidak ditemukan.", "Error"); }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void HandleDataNotFound()
        {
            MessageBox.Show("Data tidak ditemukan.", "Error");
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
