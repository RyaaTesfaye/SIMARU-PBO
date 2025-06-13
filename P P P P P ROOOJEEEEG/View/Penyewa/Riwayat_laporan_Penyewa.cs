using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
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
    public partial class Riwayat_laporan_Penyewa : Form
    {
        private readonly KeluhanService _keluhanService;
        public Riwayat_laporan_Penyewa()
        {
            InitializeComponent();
            _keluhanService = new KeluhanService();
        }
        private void RiwayatLaporanView_Load(object sender, EventArgs e)
        {
            LoadRiwayatLaporan();
        }
        private void LoadRiwayatLaporan()
        {
            try
            {
                string nomorKtpPenyewa = SesiLogin.LoggedInUser.NomorKTP;
                flowLayoutPanelRiwayat.Controls.Clear();

                List<Laporan> daftarLaporan = _keluhanService.GetLaporanByPenyewa(nomorKtpPenyewa);
                if (daftarLaporan != null && daftarLaporan.Count > 0)
                {
                    int nomorUrut = 1;
                    foreach (Laporan laporan in daftarLaporan)
                    {
                        UC_ItemRIwayatLapor item = new UC_ItemRIwayatLapor();

                        // b. Kirim data laporan dan nomor urut ke UserControl item
                        item.SetData(laporan, nomorUrut);

                        // c. Tambahkan item yang sudah jadi ke dalam FlowLayoutPanel
                        flowLayoutPanelRiwayat.Controls.Add(item);

                        nomorUrut++;
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat. Error: " + ex.Message,
                                "Error Kritis",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            UIhelper.MakePanelRound(panel9, 20);
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

        private void ToRiwayatPembayaran_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Riwayat_Pembayarn_Penyewa>(this);
            command.Execute();
        }

        private void ToPerpanjanganSewa_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Perpanjangan_Sewa_Penyewa>(this);
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
    }
}
