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
    public partial class Beri_Ulasan_Penyewa : Form
    {
        public Beri_Ulasan_Penyewa()
        {
            InitializeComponent();
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
