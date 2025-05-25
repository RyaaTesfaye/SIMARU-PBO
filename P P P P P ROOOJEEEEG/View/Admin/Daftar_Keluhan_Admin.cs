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

namespace RUSUNAWAAA.View.Admin
{
    public partial class Daftar_Keluhan_Admin : Form
    {
        public Daftar_Keluhan_Admin()
        {
            InitializeComponent();
        }

        private void ToDashboard_AD(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Admin dashboardad = new Dashboard_Admin();
            dashboardad.ShowDialog();
            this.Close();
        }

        private void ToPengelolaAkun_AD(object sender, EventArgs e)
        {
            this.Hide();
            Pengelolaan_Akun_Admin kelolaakunad = new Pengelolaan_Akun_Admin();
            kelolaakunad.ShowDialog();
            this.Close();
        }

        private void ToKelolaHunian_AD(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Hunian_Admin kelolahunianad = new Kelola_Hunian_Admin();
            kelolahunianad.ShowDialog();
            this.Close();
        }

        private void ToTinjauUlasan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Tinjau_Ulasan_Admin tinjauulasanad = new Tinjau_Ulasan_Admin();
            tinjauulasanad.ShowDialog();
            this.Close();
        }

        private void ToKelolaAturan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Aturan_Admin kelolaaturanad = new Kelola_Aturan_Admin();
            kelolaaturanad.ShowDialog();
            this.Close();
        }

        private void ToManajemenSewa_AD(object sender, EventArgs e)
        {
            this.Hide();
            Manajemen_Sewa_Admin manajemensewaad = new Manajemen_Sewa_Admin();
            manajemensewaad.ShowDialog();
            this.Close();
        }

        private void ToEditVirtualTour_AD(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Virtual_Tour_Admin editvirtualtourad = new Edit_Virtual_Tour_Admin();
            editvirtualtourad.ShowDialog();
            this.Close();
        }

        private void ToSiaran_AD(object sender, EventArgs e)
        {
            this.Hide();
            Siaran_Admin siaranad = new Siaran_Admin();
            siaranad.ShowDialog();
            this.Close();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
