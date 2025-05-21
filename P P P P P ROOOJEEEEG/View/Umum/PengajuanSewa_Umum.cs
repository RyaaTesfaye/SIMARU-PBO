using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSUNAWAAA.View.Umum
{
    public partial class PengajuanSewa_Umum : Form
    {
        public PengajuanSewa_Umum()
        {
            InitializeComponent();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            this.Hide();
            DaftarUnit_Umum daftarunit = new DaftarUnit_Umum();
            daftarunit.ShowDialog();
            this.Show();
        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_umum dashboardum = new Dashboard_umum();
            dashboardum.ShowDialog();
            this.Show();
        }
    }
}
