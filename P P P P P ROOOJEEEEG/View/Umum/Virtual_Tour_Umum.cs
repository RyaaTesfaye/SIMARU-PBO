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
    public partial class Virtual_Tour_Umum : Form
    {
        public Virtual_Tour_Umum()
        {
            InitializeComponent();
        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            this.Hide();
            DaftarUnit_Umum daftarunit = new DaftarUnit_Umum();
            daftarunit.ShowDialog();
            this.Close();
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
