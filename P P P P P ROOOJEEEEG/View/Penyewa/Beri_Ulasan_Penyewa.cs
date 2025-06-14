using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RUSUNAWAAA.View.Penyewa;
using RUSUNAWAAA.Utils;// Pastikan namespace ini benar

namespace RUSUNAWAAA.View.Penyewa
{
    // Definisikan mode tampilan di luar kelas agar bisa diakses dari tempat lain
    public enum TampilanUlasanMode { Penyewa, AdminOrUmum }

    public partial class Beri_Ulasan_Penyewa : Form
    {
        private readonly UlasanService _ulasanService;
        private List<Ulasan> _semuaUlasan;
        private UC_InputUlasan _ucInputUlasan;
        private UC_SemuaUlasan _ucSemuaUlasan;

        // --- PERUBAHAN 1: Tambahkan variabel untuk menyimpan mode saat ini ---
        private readonly TampilanUlasanMode _currentMode;

        // Constructor lama tetap ada untuk Penyewa
        public Beri_Ulasan_Penyewa() : this(TampilanUlasanMode.Penyewa)
        {
            // Konstruktor ini akan otomatis memanggil constructor utama dengan mode Penyewa
        }

        // --- PERUBAHAN 2: Constructor baru yang lebih fleksibel ---
        public Beri_Ulasan_Penyewa(TampilanUlasanMode mode)
        {
            InitializeComponent();
            _ulasanService = new UlasanService();
            _currentMode = mode; // Simpan mode yang dipilih
        }

        private void Beri_Ulasan_Penyewa_Load(object sender, EventArgs e)
        {
            RefreshHalaman();
        }

        private void RefreshHalaman()
        {
            try
            {
                _semuaUlasan = _ulasanService.GetAllUlasan();
                LoadTampilanAwal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Kritis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTampilanAwal()
        {
            var ucStatistik = new UC_StatistikUlasan();
            ucStatistik.Dock = DockStyle.Fill;
            ucStatistik.TampilkanStatistik(_semuaUlasan, _currentMode);
            ucStatistik.BeriUlasanClicked += UcStatistik_BeriUlasanClicked;

            panelKiri.Controls.Clear();
            panelKiri.Controls.Add(ucStatistik);

            var ucDaftar = new UC_DaftarUlasan();
            ucDaftar.Dock = DockStyle.Fill;
            ucDaftar.TampilkanUlasan(_semuaUlasan);
            ucDaftar.LihatSemuaClicked += UcDaftar_LihatSemuaClicked;

            panelKanan.Controls.Clear();
            panelKanan.Controls.Add(ucDaftar);
        }

        private void UcStatistik_BeriUlasanClicked(object sender, EventArgs e)
        {

            if (_ulasanService.SudahMemberiUlasan(SesiLogin.LoggedInUser.NomorKTP))
            {
                MessageBox.Show("Anda sudah pernah memberikan ulasan.", "Informasi");
                return;
            }

            if (_ucInputUlasan == null)
            {
                _ucInputUlasan = new UC_InputUlasan();
                _ucInputUlasan.Dock = DockStyle.Fill;
                _ucInputUlasan.KirimUlasanClicked += UcInput_KirimUlasanClicked;
                _ucInputUlasan.BatalClicked += UcInput_BatalClicked;
            }

            panelSemua.Controls.Clear();
            panelSemua.Controls.Add(_ucInputUlasan);
        }

        private void UcDaftar_LihatSemuaClicked(object sender, EventArgs e)
        {
            if (_ucSemuaUlasan == null)
            {
                _ucSemuaUlasan = new UC_SemuaUlasan();
                _ucSemuaUlasan.Dock = DockStyle.Fill;
                _ucSemuaUlasan._BackRequested += UcSemuaUlasan_BackRequested;
            }

            _ucSemuaUlasan.MuatDanTampilkan(_semuaUlasan);

            panelSemua.Controls.Clear();
            panelSemua.Controls.Add(_ucSemuaUlasan);
        }


        private void UcInput_KirimUlasanClicked(object sender, Ulasan ulasanBaru)
        {
            if (_ulasanService.AddUlasan(ulasanBaru))
            {
                MessageBox.Show("Terima kasih, ulasan Anda berhasil dikirim!", "Sukses");
                RefreshHalaman();
            }
            else
            {
                MessageBox.Show("Gagal mengirim ulasan, silakan coba lagi.", "Error");
            }
        }

        private void UcInput_BatalClicked(object sender, EventArgs e)
        {
            LoadTampilanAwal();
        }

        private void UcSemuaUlasan_BackRequested(object sender, EventArgs e)
        {
            LoadTampilanAwal();
        }
        private void ToDashboard_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Penyewa>(this);
            command.Execute();
        }

        private void ToTataTertib_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tata_Tertib_Penyewa>(this);
            command.Execute();
        }

        private void ToLaporMasalah_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Lapor_Masalah_Penyewa>(this);
            command.Execute();
        }

        private void ToRiwayatLaporan_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Riwayat_laporan_Penyewa>(this);
            command.Execute();
        }

        private void ToPerpanjanganSewa_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Perpanjangan_Sewa_Penyewa>(this);
            command.Execute();
        }
    }
}

    

        