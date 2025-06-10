using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
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
    public partial class Ulasan_Umum : Form
    {
        public Ulasan_Umum()
        {
            InitializeComponent();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<DaftarUnit_Umum>(this);
            command.Execute();
        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_umum>(this);
            command.Execute();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<PengajuanSewa_Umum>(this);
            command.Execute();
        }

        private void ToVirtualTour_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Virtual_Tour_Umum>(this);
            command.Execute();
        }

        private void ToTataTertib_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tatatertib_Umum>(this);
            command.Execute();
        }

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kontaklokasi_Umum>(this);
            command.Execute();
        }

        private void LoadFormSemuaUlasan_UM()
        {
            panel9.Controls.Clear(); // Hapus konten lama kalau ada
            Semua_Ulasan_Umum semuaUlasanum = new Semua_Ulasan_Umum();
            semuaUlasanum.Dock = DockStyle.Fill;
            semuaUlasanum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(semuaUlasanum);
        }

        private void ToSemuaUlasan_UM(object sender, EventArgs e)
        {
            LoadFormSemuaUlasan_UM();
        }
    }
}
