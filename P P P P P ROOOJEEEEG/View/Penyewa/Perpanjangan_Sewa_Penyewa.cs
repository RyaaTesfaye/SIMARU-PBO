using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Umum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class Perpanjangan_Sewa_Penyewa : Form
    {

        private readonly PerpanjanganService _perpanjanganService;
        private UC_PerpanjanganSewa1 ucFormKiri;
        private UC_PerpanjanganSewa2 ucFormKanan;
        private int _durasiSewaTerpilih = 0;
        public Perpanjangan_Sewa_Penyewa()
        {
            _perpanjanganService = new PerpanjanganService();
            InitializeComponent();
        }
        private void PerpanjanganSewaView_Load(object sender, EventArgs e)
        {
            LoadUserControls();
        }

        /// <summary>
        /// Metode untuk membuat, mengkonfigurasi, dan menampilkan UserControl secara dinamis.
        /// </summary>
        private void LoadUserControls()
        {
            // Buat instance baru dari UserControl
            ucFormKiri = new UC_PerpanjanganSewa1();
            ucFormKanan = new UC_PerpanjanganSewa2();

            // Atur agar UC mengisi seluruh area panel
            ucFormKiri.Dock = DockStyle.Fill;
            ucFormKanan.Dock = DockStyle.Fill;

            // Tambahkan UC ke panel yang sesuai.
            // PASTIKAN nama panel Anda adalah 'panelKiri' dan 'panelKanan' di desainer.
            panel10.Controls.Clear();
            panel10.Controls.Add(ucFormKiri);

            panel11.Controls.Clear();
            panel11.Controls.Add(ucFormKanan);

            ucFormKiri.DurasiChanged += UcFormKiri_DurasiChanged;
            ucFormKanan.KonfirmasiButtonClicked += UcFormKanan_KonfirmasiButtonClicked;
        }
        private void UcFormKiri_DurasiChanged(object sender, int durasiBulan)
        {
            // Manajer mencatat durasi yang dilaporkan ke buku catatannya.
            _durasiSewaTerpilih = durasiBulan;
        }

        private void UcFormKanan_KonfirmasiButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // 1. Validasi Input
                if (_durasiSewaTerpilih <= 0)
                {
                    MessageBox.Show("Harap pilih durasi penyewaan terlebih dahulu.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(ucFormKanan.PathBuktiPembayaran))
                {
                    MessageBox.Show("Harap unggah bukti pembayaran Anda.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (SesiLogin.LoggedInUser == null)
                {
                    MessageBox.Show("Sesi login tidak ditemukan. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Kumpulkan Data
                var perpanjanganBaru = new PerpanjanganSewa
                {
                    NomorKTP = SesiLogin.LoggedInUser.NomorKTP,
                    LamaBulan = _durasiSewaTerpilih,
                    Nominal = ucFormKiri.CalculatedNominal,
                    PathBuktiPembayaran = ucFormKanan.PathBuktiPembayaran
                };

                // 3. Panggil Service
                bool sukses = _perpanjanganService.AjukanPerpanjangan(perpanjanganBaru);

                if (sukses)
                {
                    MessageBox.Show("Pengajuan perpanjangan sewa Anda telah berhasil dikirim dan akan segera diproses.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan tak terduga: " + ex.Message, "Error Kritis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToDashboard_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Penyewa>(this);
            command.Execute();
        }

        private void ToBeriUlasan_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Beri_Ulasan_Penyewa>(this);
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

        private void ToRiwayatPembayaran_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Riwayat_Pembayarn_Penyewa>(this);
            command.Execute();
        }
    }
}
