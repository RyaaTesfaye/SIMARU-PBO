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

namespace RUSUNAWAAA.View.Umum
{
    public partial class PengajuanSewa_Umum : Form
    {
        private PengajuanSewaService _service;
        public PengajuanSewa_Umum()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
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

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kontaklokasi_Umum>(this);
            command.Execute();
        }

        private void PengajuanSewa_Umum_Load(object sender, EventArgs e)
        {
            _service = new PengajuanSewaService(this.panel10, this.btnBack);
            _service.Start();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            _service.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Loginss>(this);
            command.Execute();
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
    }
}
