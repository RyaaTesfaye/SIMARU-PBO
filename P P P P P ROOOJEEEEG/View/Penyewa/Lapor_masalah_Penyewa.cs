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
    public partial class Lapor_Masalah_Penyewa : Form
    {

        public Lapor_Masalah_Penyewa()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
        }
        private void LaporMasalah_Load(object sender, EventArgs e)
        {
           
            UC_Lapor ucLapor = new UC_Lapor();

            ucLapor.Dock = DockStyle.Fill;

            panel11.Controls.Clear();


            panel11.Controls.Add(ucLapor);
        }

        private void ToDashboard_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Penyewa>(this);
            command.Execute();
        }

        private void ToBeriUlasan_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Beri_Ulasan_Penyewa>(this);
            command.Execute();
        }

        private void ToTataTertib_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tata_Tertib_Penyewa>(this);
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
    }
}
