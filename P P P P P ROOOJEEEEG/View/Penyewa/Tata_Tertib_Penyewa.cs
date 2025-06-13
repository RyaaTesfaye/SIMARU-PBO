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
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Penyewa
{

    public partial class Tata_Tertib_Penyewa : Form
    {
        private AturanService _aturanService;
        private string _filterAktif = "Semua";
        public Tata_Tertib_Penyewa()
        {
            InitializeComponent();
            _aturanService = new AturanService(new Panel());
        }
        private void Tata_Tertib_Penyewa_Load(object sender, EventArgs e)
        {
            if (SesiLogin.IsLoggedIn() && SesiLogin.LoggedInUser is PenyewaModel penyewa)
            {
                _filterAktif = penyewa.JenisKelamin;
            }

            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            _aturanService.DisplayItemsOnDataGridView(dgvAturan, _filterAktif);
        }
        private void btnFilterPerempuan_Click(object sender, EventArgs e)
        {
            _filterAktif = "Perempuan";
            RefreshDataGridView();
        }

        private void btnFilterLakiLaki_Click(object sender, EventArgs e)
        {
            _filterAktif = "Laki-laki";
            RefreshDataGridView();
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
