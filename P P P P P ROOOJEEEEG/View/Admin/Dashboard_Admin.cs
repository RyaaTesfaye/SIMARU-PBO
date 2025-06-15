using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
using RUSUNAWAAA.View.Penyewa;
using RusunawaApp.Data;
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Dashboard_Admin : Form
    {
        private readonly PengajuanSewaService _pengajuanService;
        private readonly KeluhanService _keluhanService;
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
            UIhelper.MakePanelRound(panelLaporanTerbaru, 20);
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
            _pengajuanService = new PengajuanSewaService();
            _keluhanService = new KeluhanService();
        }
        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            // Panggil metode untuk memuat semua data ke kartu ringkasan
            LoadRingkasanData();
            LoadLaporanTerbaru();
        }
        private void LoadRingkasanData()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    int jumlahPenyewa = context.Users.OfType<PenyewaModel>().Count();

                    // Samakan nilainya sesuai permintaan
                    lblUserTerdaftar.Text = jumlahPenyewa.ToString();
                    lblPenyewaAktif.Text = jumlahPenyewa.ToString();
                }
                var daftarPengajuan = _pengajuanService.GetAllPendingApplications();
                lblMenungguKonfirmasi.Text = daftarPengajuan.Count.ToString();
            }
            catch (Exception ex)
            {
                // Jika gagal, tampilkan pesan error dan set angka ke "0"
                MessageBox.Show("Gagal memuat data ringkasan dashboard: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblUserTerdaftar.Text = "0";
                lblPenyewaAktif.Text = "0";
                lblMenungguKonfirmasi.Text = "0";
            }
        }
        private void LoadLaporanTerbaru()
        {
            try
            {
                // Ambil semua keluhan, yang sudah diurutkan dari terbaru oleh service
                var laporanTerbaru = _keluhanService.GetAllKeluhan().FirstOrDefault();

                // Pastikan nama panelnya benar, contoh: panelLaporanTerbaru
                if (laporanTerbaru != null)
                {
                    panelLaporanTerbaru.Visible = true;
                    // Isi kontrol yang sudah ada di desainer
                    // Pastikan nama kontrolnya cocok: lblNamaPelapor, lblTanggalLaporan, dll.
                    lblNamaPelapor.Text = laporanTerbaru.User?.NamaLengkap ?? "Nama tidak tersedia";
                    lblTanggalLaporan.Text = laporanTerbaru.Tanggal.ToLocalTime().ToString("dd MMMM yyyy");
                    lblIsiLaporan.Text = laporanTerbaru.Isi;

                }
                else
                {
                    // Jika tidak ada laporan sama sekali, sembunyikan panelnya
                    panelLaporanTerbaru.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan terbaru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelLaporanTerbaru.Visible = false;
            }
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
            var command = new NavigateToFormCommand<Pengelolaan_Akun_Admin>(this);
            command.Execute();
        }



        private void ToDaftarKeluhan_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Daftar_Keluhan_Admin>(this);
            command.Execute();
        }

        private void ToTinjauUlasan_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tinjau_Ulasan_Admin>(this);
            command.Execute();
        }

        private void ToKelolaAturan_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kelola_Aturan_Admin>(this);
            command.Execute();
        }

        private void ToManajemenSewa_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Manajemen_Sewa_Admin>(this);
            command.Execute();
        }

        private void ToEditVirtualTour_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Edit_Virtual_Tour_Admin>(this);
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
