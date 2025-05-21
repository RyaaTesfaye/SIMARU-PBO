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

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_umum dashboardum = new Dashboard_umum();
            dashboardum.ShowDialog();
            this.Close();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            this.Hide();
            PengajuanSewa_Umum pengajuansewaum = new PengajuanSewa_Umum();
            pengajuansewaum.ShowDialog();
            this.Close();
        }

        private void ToUlasan_UM(object sender, EventArgs e)
        {
            this.Hide();
            Ulasan_Umum ulasanum = new Ulasan_Umum();
            ulasanum.ShowDialog();
            this.Close();
        }

        private void ToVirtualTour_UM(object sender, EventArgs e)
        {
            this.Hide();
            Virtual_Tour_Umum virtualtourum = new Virtual_Tour_Umum();
            virtualtourum.ShowDialog();
            this.Close();
        }

        private void ToTataTertib_UM(object sender, EventArgs e)
        {
            this.Hide();
            Tatatertib_Umum tatatertibum = new Tatatertib_Umum();
            tatatertibum.ShowDialog();
            this.Close();
        }

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            this.Hide();
            Kontaklokasi_Umum kontaklokasium = new Kontaklokasi_Umum();
            kontaklokasium.ShowDialog();
            this.Close();
        }
    }
}
