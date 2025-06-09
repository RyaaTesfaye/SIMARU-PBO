using RUSUNAWAAA.Utils;
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
    public partial class _2_Penyewa : Form
    {
        public _2_Penyewa()
        {
            InitializeComponent();
        }

        private void ToDashboard_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Penyewa>(this);
            command.Execute();
        }

        private void ToBeriUlasan_PE(object sender, EventArgs e)
        {

        }

        private void ToLaporMasalah_PE(object sender, EventArgs e)
        {

        }

        private void ToRiwayatLaporan_PE(object sender, EventArgs e)
        {

        }

        private void ToRiwayatPembayaran_PE(object sender, EventArgs e)
        {

        }

        private void ToPerpanjanganSewa_PE(object sender, EventArgs e)
        {

        }
    }
}
