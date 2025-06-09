using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RUSUNAWAAA.Utils;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Dashboard_Admin : Form
    {
        public Dashboard_Admin()
        {
            InitializeComponent();
            UIhelper.MakePictureBoxRound(pictureBox6);
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakePanelRound(panel13, 20);
            UIhelper.MakePanelRound(panel14, 20);
            UIhelper.MakePanelRound(panel15, 20);
            UIhelper.MakePanelRound(panel16, 20);
            UIhelper.MakePanelRound(panel17, 20);
            UIhelper.MakePanelRound(panel18, 20);
            UIhelper.MakePanelRound(panel19, 20);
            UIhelper.MakePanelRound(panel20, 20);
            UIhelper.MakePanelRound(panel24, 20);
            UIhelper.MakePanelRound(panel25, 3);
            UIhelper.MakePanelRound(panel26, 3);
            UIhelper.MakePanelRound(panel27, 3);
            UIhelper.MakeRoundedButton(button1, 3);
            UIhelper.MakeRoundedButton(button2, 3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

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

        private void ToDaftarKeluhan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Daftar_Keluhan_Admin daftarkeluhanad = new Daftar_Keluhan_Admin();
            daftarkeluhanad.ShowDialog();
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
            var command = new NavigateToFormCommand<Kelola_Aturan_Admin>(this);
            command.Execute();
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
    }
}
