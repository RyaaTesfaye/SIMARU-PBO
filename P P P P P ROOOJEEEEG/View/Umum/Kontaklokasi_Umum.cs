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
            string url = (sender as LinkLabel).Text;

            try
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ini adalah kunci utamanya
                };
                System.Diagnostics.Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                // Tampilkan pesan jika terjadi error
                MessageBox.Show("Tidak dapat membuka link. Pastikan Anda terhubung ke internet. Error: " + ex.Message);
            }
        }

        private void label20_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;

            try
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ini adalah kunci utamanya
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

