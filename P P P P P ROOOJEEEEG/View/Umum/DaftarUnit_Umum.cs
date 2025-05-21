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
    public partial class DaftarUnit_Umum : Form
    {
        public DaftarUnit_Umum()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_umum dashboardum = new Dashboard_umum();
            dashboardum.ShowDialog();
            this.Show();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            this.Hide();
            PengajuanSewa_Umum pengajuansewaum = new PengajuanSewa_Umum();
            pengajuansewaum.ShowDialog();
            this.Show();
        }
    }
}
