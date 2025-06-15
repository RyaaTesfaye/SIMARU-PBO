using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
using RUSUNAWAAA.View.Penyewa;
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
        private readonly UlasanService _ulasanService;
        private List<Ulasan> _semuaUlasan;

        private UC_SemuaUlasan _ucSemuaUlasan;

        private readonly TampilanUlasanMode _currentMode;
        public Ulasan_Umum()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panelKanan, 20);
            UIhelper.MakePanelRound(panelSemua, 20);
            UIhelper.MakePanelRound(panelKiri, 20);
            _ulasanService = new UlasanService();
            _currentMode = TampilanUlasanMode.AdminOrUmum;
        }
        private void Lihat_Ulasan_Umum_Load(object sender, EventArgs e)
        {
            RefreshHalaman();
        }
        private void RefreshHalaman()
        {
            try
            {
                _semuaUlasan = _ulasanService.GetAllUlasan();
                LoadTampilanAwal(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Kritis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTampilanAwal()
        {
            var ucStatistik = new UC_StatistikUlasan();
            ucStatistik.Dock = DockStyle.Fill;
            ucStatistik.TampilkanStatistik(_semuaUlasan, _currentMode);
            panelKiri.Controls.Clear();
            panelKiri.Controls.Add(ucStatistik);

            var ucDaftar = new UC_DaftarUlasan();
            ucDaftar.Dock = DockStyle.Fill;
            ucDaftar.TampilkanUlasan(_semuaUlasan);
            ucDaftar.LihatSemuaClicked += UcDaftar_LihatSemuaClicked;

            panelKanan.Controls.Clear();
            panelKanan.Controls.Add(ucDaftar);
        }

        private void UcDaftar_LihatSemuaClicked(object sender, EventArgs e)
        {
            if (_ucSemuaUlasan == null)
            {
                _ucSemuaUlasan = new UC_SemuaUlasan();
                _ucSemuaUlasan.Dock = DockStyle.Fill;
                _ucSemuaUlasan._BackRequested += UcSemuaUlasan_BackRequested;
            }

            _ucSemuaUlasan.MuatDanTampilkan(_semuaUlasan);

            panelSemua.Controls.Clear();
            panelSemua.Controls.Add(_ucSemuaUlasan);

            panelKiri.Controls.Clear();
            Label lblPlaceholder = new Label() { Text = "Daftar Semua Ulasan", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold) };
            panelKiri.Controls.Add(lblPlaceholder);
        }

        private void UcSemuaUlasan_BackRequested(object sender, EventArgs e)
        {
            LoadTampilanAwal();
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

        }

        private void ToSemuaUlasan_UM(object sender, EventArgs e)
        {
            LoadFormSemuaUlasan_UM();
        }

        private void ToMasuk_Click(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Loginss>(this);
            command.Execute();
        }
    }
}
