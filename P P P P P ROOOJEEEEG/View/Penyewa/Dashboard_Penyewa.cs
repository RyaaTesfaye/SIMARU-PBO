using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
using RusunawaApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenyewaModel = RUSUNAWAAA.Models.Penyewa; 

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class Dashboard_Penyewa : Form
    {
        private readonly UlasanService _ulasanService;
        private readonly VirtualTourService _virtualTourService;
        public Dashboard_Penyewa()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel6, 20);
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakePanelRound(panel14, 20);
            UIhelper.MakePanelRound(panelVirtualTour, 20);
            UIhelper.MakePanelRound(panelSkorUlasan, 20);
            UIhelper.MakePanelRound(panel25, 20);
            UIhelper.MakeRoundedButton(button1, 10);
            UIhelper.MakeRoundedButton(button2, 10);
            UIhelper.MakeRoundedButton(button3, 10);
            UIhelper.MakeRoundedButton(button4, 10);
            _ulasanService = new UlasanService();
            _virtualTourService = new VirtualTourService();
        }
        private void Beranda_Penyewa_Load(object sender, EventArgs e)
        {
            LoadRingkasanData();
            LoadUlasanTerbaru();
            LoadVirtualTourTerbaru();
        }
        private void LoadRingkasanData()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    int jumlahPenyewa = context.Users.OfType<PenyewaModel>().Count();

                    lblUserTerdaftar.Text = jumlahPenyewa.ToString();
                    lblPenyewaAktif.Text = jumlahPenyewa.ToString();
                }
                var semuaUlasan = _ulasanService.GetAllUlasan();
                if (semuaUlasan.Any())
                {
                    double rataRata = semuaUlasan.Average(u => u.Rating);
                    lblRating.Text = rataRata.ToString("F1"); 
                }
                else
                {
                    lblRating.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                lblRating.Text = "Error";
                Console.WriteLine("Error memuat rating: " + ex.Message);
            }
        }
        private void LoadUlasanTerbaru()
        {
            try
            {
                var ulasanTerbaru = _ulasanService.GetAllUlasan().FirstOrDefault();

                if (ulasanTerbaru != null)
                {
                    lblJudulTour.Text = ulasanTerbaru.User?.NamaLengkap ?? "Penghuni Anonim";
                    lblTanggalUlasan.Text = ulasanTerbaru.Tanggal.ToLocalTime().ToString("dd MMMM yyyy");
                    lblKomentarUlasan.Text = ulasanTerbaru.Komentar;
                }
                else
                {
                    panelSkorUlasan.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error memuat ulasan terbaru: " + ex.Message);
                panelSkorUlasan.Visible = false;
            }
        }
        private void LoadVirtualTourTerbaru()
        {
            try
            {
                var tourTerbaru = _virtualTourService.GetTourTerbaru();

                if (tourTerbaru != null)
                {
                    lblJudulTour.Text = tourTerbaru.Keterangan;


                    if (!string.IsNullOrEmpty(tourTerbaru.PathMedia) && File.Exists(tourTerbaru.PathMedia))
                    {
                        picThumbnailTour.Image = new Bitmap(tourTerbaru.PathMedia);
                    }
                }
                else
                {
                    panelVirtualTour.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error memuat virtual tour: " + ex.Message);
                panelVirtualTour.Visible = false;
            }
        }

        private void ToBeriUlasan_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Beri_Ulasan_Penyewa>(this);
            command.Execute();
        }

        private void ToTataTertib_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tata_Tertib_Penyewa>(this);
            command.Execute();
        }

        private void ToLaporMasalah_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Lapor_Masalah_Penyewa>(this);
            command.Execute();
        }

        private void ToRiwayatLaporan_PE(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Riwayat_laporan_Penyewa>(this);
            command.Execute();
        }


        private void ToPerpanjanganSewa_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Perpanjangan_Sewa_Penyewa>(this);
            command.Execute();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
              "Anda yakin ingin keluar dari aplikasi?",
              "Konfirmasi Keluar",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (konfirmasi == DialogResult.Yes)
            {
                SesiLogin.Logout();

                var command = new NavigateToFormCommand<Loginss>(this);
                command.Execute();
            }
        }
    }
}
