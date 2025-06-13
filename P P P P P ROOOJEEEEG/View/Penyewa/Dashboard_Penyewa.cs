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
    public partial class Dashboard_Penyewa : Form
    {
        public Dashboard_Penyewa()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel6, 20);
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakePanelRound(panel13, 20);
            UIhelper.MakePanelRound(panel14, 20);
            UIhelper.MakePanelRound(panel15, 20);
            UIhelper.MakePanelRound(panel16, 20);
            UIhelper.MakePanelRound(panel25, 20);
            UIhelper.MakeRoundedButton(button1, 10);
            UIhelper.MakeRoundedButton(button2, 10);
            UIhelper.MakeRoundedButton(button3, 10);
            UIhelper.MakeRoundedButton(button4, 10);
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

        private void ToPerpanjanganSewa_UM(object sender, EventArgs e)
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
