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
        private Stack<UserControl> history = new Stack<UserControl>();
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
            this.Close();
        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_umum dashboardum = new Dashboard_umum();
            dashboardum.ShowDialog();
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

        private void PengajuanSewa_Umum_Load(object sender, EventArgs e)
        {
            var ucStep1 = new Form_Sewa1();
            ucStep1.GoToNextStep += OnGoToNextStep;
            ucStep1.Location = new Point(21, 18);
            panel10.Controls.Add(ucStep1);

            btnBack.Visible = false;
        }
        private void OnGoToNextStep(object sender, EventArgs e)
        {
            UserControl nextUc = null;
            if (sender is Form_Sewa1) { nextUc = new Form_Sewa2(); }
            else if (sender is Form_Sewa2) { nextUc = new Form_Sewa3(); }
            else if (sender is Form_Sewa3) { nextUc = new Form_Sewa4(); }
            else if (sender is Form_Sewa4) { nextUc = new Form_Sewa5(); }
            else if (sender is Form_Sewa5) { nextUc = new Form_Sewa6(); }

            if (nextUc != null)
            {
                NavigateTo(nextUc);
            }
        }

        private void NavigateTo(UserControl newUc)
        {
            var currentUc = panel10.Controls.OfType<UserControl>().FirstOrDefault();
            if (currentUc != null)
            {
                history.Push(currentUc);
                // Putuskan sambungan event dari UC lama
                if (currentUc is Form_Sewa1 old1) old1.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa2 old2) old2.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa3 old3) old3.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa4 old4) old4.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa5 old5) old5.GoToNextStep -= OnGoToNextStep;
                //if (currentUc is Form_Sewa6 old6) old6.GoToNextStep -= OnGoToNextStep;
            }

            // Sambungkan event ke UC baru
            if (newUc is Form_Sewa1 new1) new1.GoToNextStep += OnGoToNextStep;
            if (newUc is Form_Sewa2 new2) new2.GoToNextStep += OnGoToNextStep;
            if (newUc is Form_Sewa3 new3) new3.GoToNextStep += OnGoToNextStep;
            if (newUc is Form_Sewa4 new4) new4.GoToNextStep += OnGoToNextStep;
            if (newUc is Form_Sewa5 new5) new5.GoToNextStep += OnGoToNextStep;
            //if (newUc is Form_Sewa6 new6) new6.GoToNextStep += OnGoToNextStep;

            // Tampilkan UC yang baru
            panel10.Controls.Clear();
            newUc.Location = new Point(21, 18);
            panel10.Controls.Add(newUc);
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                var previousUc = history.Pop();
                var currentUc = panel10.Controls.OfType<UserControl>().FirstOrDefault();

                // Putuskan sambungan dari UC yang akan hilang
                if (currentUc is Form_Sewa1 old1) old1.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa2 old2) old2.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa3 old3) old3.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa4 old4) old4.GoToNextStep -= OnGoToNextStep;
                if (currentUc is Form_Sewa5 old5) old5.GoToNextStep -= OnGoToNextStep;
                //if (currentUc is Form_Sewa6 old6) old6.GoToNextStep -= OnGoToNextStep;

                // Sambungkan kembali event ke UC yang ditampilkan lagi
                if (previousUc is Form_Sewa1 prev1) prev1.GoToNextStep += OnGoToNextStep;
                if (previousUc is Form_Sewa2 prev2) prev2.GoToNextStep += OnGoToNextStep;
                if (previousUc is Form_Sewa3 prev3) prev3.GoToNextStep += OnGoToNextStep;
                if (previousUc is Form_Sewa4 prev4) prev4.GoToNextStep += OnGoToNextStep;
                if (previousUc is Form_Sewa5 prev5) prev5.GoToNextStep += OnGoToNextStep;
                //if (previousUc is Form_Sewa6 prev6) prev6.GoToNextStep += OnGoToNextStep;

                // Tampilkan kembali UC sebelumnya
                panel10.Controls.Clear();
                previousUc.Location = new Point(21, 18);
                panel10.Controls.Add(previousUc);

                btnBack.Visible = history.Count > 0;
            }
        }
    }
}
