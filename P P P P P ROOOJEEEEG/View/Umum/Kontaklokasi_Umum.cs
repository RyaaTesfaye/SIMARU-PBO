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
    public partial class Kontaklokasi_Umum : Form
    {
        public Kontaklokasi_Umum()
        {
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            this.Hide();
            PengajuanSewa_Umum pengajuansewaum = new PengajuanSewa_Umum();
            pengajuansewaum.ShowDialog();
            this.Show();
        }

        private void ToUlasan_UM(object sender, EventArgs e)
        {
            this.Hide();
            Ulasan_Umum ulasanum = new Ulasan_Umum();
            ulasanum.ShowDialog();
            this.Show();
        }

        private void ToVirtualTour_UM(object sender, EventArgs e)
        {
            this.Hide();
            Virtual_Tour_Umum virtualtourum = new Virtual_Tour_Umum();
            virtualtourum.ShowDialog();
            this.Show();
        }

        private void ToTataTertib_UM(object sender, EventArgs e)
        {
            this.Hide();
            Tatatertib_Umum tatatertibum = new Tatatertib_Umum();
            tatatertibum.ShowDialog();
            this.Show();
        }
    }
}
