using Microsoft.Win32;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Admin;
using RUSUNAWAAA.View.Login;
using RUSUNAWAAA.View.Penyewa;
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

namespace RUSUNAWAAA.View.Umum
{
    public partial class Dashboard_umum : Form
    {
        private readonly UlasanService _ulasanService;
        private readonly VirtualTourService _virtualTourService;
        public Dashboard_umum()
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
            UIhelper.MakePanelRound(panel17, 20);
            UIhelper.MakePanelRound(panel18, 20);
            UIhelper.MakePanelRound(panel19, 20);
            UIhelper.MakePanelRound(panel24, 20);
            UIhelper.MakePanelRound(panel25, 20);
            UIhelper.MakePanelRound(panel26, 3);
            UIhelper.MakeRoundedButton(button1, 10);
            UIhelper.MakeRoundedButton(button5, 10);
            UIhelper.MakeRoundedButton(button4, 10);
            UIhelper.MakeRoundedButton(button3, 10);
            _ulasanService = new UlasanService();
            _virtualTourService = new VirtualTourService();
        }
        private void Beranda_Umum_Load(object sender, EventArgs e)
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
                    lblNamaUlasan.Text = ulasanTerbaru.User?.NamaLengkap ?? "Penghuni Anonim";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<DaftarUnit_Umum>(this);
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

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kontaklokasi_Umum>(this);
            command.Execute();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Loginss>(this);
            command.Execute();
        }
    }
}
