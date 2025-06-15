using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
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
            UIhelper.MakePanelRound(panel9, 20);
        }
        private void PerpanjanganSewaView_Load(object sender, EventArgs e)
        {
            LoadUserControls();
        }

        private void LoadUserControls()
        {
            ucFormKiri = new UC_PerpanjanganSewa1();
            ucFormKanan = new UC_PerpanjanganSewa2();

            ucFormKiri.Dock = DockStyle.Fill;
            ucFormKanan.Dock = DockStyle.Fill;

            panel10.Controls.Clear();
            panel10.Controls.Add(ucFormKiri);

            panel11.Controls.Clear();
            panel11.Controls.Add(ucFormKanan);

            ucFormKiri.DurasiChanged += UcFormKiri_DurasiChanged;
            ucFormKanan.KonfirmasiButtonClicked += UcFormKanan_KonfirmasiButtonClicked;
        }
        private void UcFormKiri_DurasiChanged(object sender, int durasiBulan)
        {
            _durasiSewaTerpilih = durasiBulan;
        }

        private void UcFormKanan_KonfirmasiButtonClicked(object sender, EventArgs e)
        {
            try
            {
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

                var perpanjanganBaru = new PerpanjanganSewa
                {
                    NomorKTP = SesiLogin.LoggedInUser.NomorKTP,
                    LamaBulan = _durasiSewaTerpilih,
                    Nominal = ucFormKiri.CalculatedNominal,
                    PathBuktiPembayaran = ucFormKanan.PathBuktiPembayaran
                };

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



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
            "Anda yakin ingin keluar dari aplikasi?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (konfirmasi == DialogResult.Yes)
            {
                SesiLogin.Logout();

                var command = new NavigateToFormCommand<Loginss>(this);
                command.Execute();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
