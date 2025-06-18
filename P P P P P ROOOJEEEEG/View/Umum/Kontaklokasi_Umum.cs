using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
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
using RUSUNAWAAA.Service;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Kontaklokasi_Umum : Form
    {
        private readonly KontakService _kontakService;
        public Kontaklokasi_Umum()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel12, 20);
            _kontakService = new KontakService();
        }
        private void Kontaklokasi_Umum_Load(object sender, EventArgs e)
        {
            LoadKontakPutra();
            LoadKontakPutri();
        }
        private void LoadKontakPutra()
        {
            Kontak dataPutra = _kontakService.GetKontakById(1);

            if (dataPutra != null)
            {
                lblNamaNaraPutra.Text = dataPutra.NamaKontak;
                lblNomorNaraPutra.Text = dataPutra.Telepon;

                linkLokasiPutra.Tag = dataPutra.Lokasi;

            }
        }
        private void LoadKontakPutri()
        {
            Kontak dataPutri = _kontakService.GetKontakById(2);

            if (dataPutri != null)
            {
                lblNamaNaraPutri.Text = dataPutri.NamaKontak;
                lblNomorNaraPutri.Text = dataPutri.Telepon;

                linkLokasiPutri.Tag = dataPutri.Lokasi;
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;

            try
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(processInfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Tidak dapat membuka link. Pastikan Anda terhubung ke internet. Error: " + ex.Message);
            }
        }

        private void label20_Click(object sender, EventArgs e)
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

        private void ToUlasan_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Ulasan_Umum>(this);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;

            try
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak dapat membuka link. Pastikan Anda terhubung ke internet. Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Loginss>(this);
            command.Execute();
        }
    }
}

