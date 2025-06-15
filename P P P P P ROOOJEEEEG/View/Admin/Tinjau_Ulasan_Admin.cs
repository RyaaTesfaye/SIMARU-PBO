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


namespace RUSUNAWAAA.View.Admin
{
        public partial class Tinjau_Ulasan_Admin : Form
        {
            private readonly UlasanService _ulasanService;
            private List<Ulasan> _semuaUlasan;

            private UC_SemuaUlasan _ucSemuaUlasan;

            private readonly TampilanUlasanMode _currentMode;
            public Tinjau_Ulasan_Admin()
            {
                InitializeComponent();
                UIhelper.MakePanelRound(panelSemua, 20);
                UIhelper.MakePanelRound(panelKanan, 20);
                UIhelper.MakePanelRound(panelKiri, 20);
                _ulasanService = new UlasanService();
                _currentMode = TampilanUlasanMode.AdminOrUmum;
            }
            private void Lihat_Ulasan_Admin_Load(object sender, EventArgs e)
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
        private void ToDashboard_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Admin>(this);
            command.Execute();
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
