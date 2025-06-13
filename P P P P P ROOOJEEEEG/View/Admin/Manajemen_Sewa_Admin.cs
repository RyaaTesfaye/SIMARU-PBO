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
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Manajemen_Sewa_Admin : Form
    {
        private readonly PengajuanSewaService _pengajuanService = new PengajuanSewaService();
        private readonly PerpanjanganService _perpanjanganService = new PerpanjanganService();

        private List<Pengajuan> _semuaPengajuan;
        private List<PerpanjanganSewa> _semuaPerpanjangan;

        private List<object> _dataYangTampil;
        private int _halamanSaatIni = 1;
        private readonly int _itemPerHalaman = 7;
        private string _filterJenisKelamin = "Perempuan";
        private string _tipeTampilan = "Pengajuan";
        public Manajemen_Sewa_Admin()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
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

        private void ToKelolaHunian_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kelola_Hunian_Admin>(this);
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

        private void ToEditVirtualTour_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Edit_Virtual_Tour_Admin>(this);
            command.Execute();
        }



        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manajemen_Sewa_Admin_Load(object sender, EventArgs e)
        {
            _semuaPengajuan = _pengajuanService.GetAllPendingApplications();
            _semuaPerpanjangan = _perpanjanganService.GetAllPerpanjangan();
            ApplyFiltersAndDisplay();
        }
        private void ApplyFiltersAndDisplay()
        {
            if (_tipeTampilan == "Pengajuan")
            {
                var filteredList = _semuaPengajuan.AsQueryable();
                if (_filterJenisKelamin != "Perempuan")
                {
                    filteredList = filteredList.Where(p => p.JenisKelamin == _filterJenisKelamin);
                }
                _dataYangTampil = filteredList.Cast<object>().ToList();
            }
            else if (_tipeTampilan == "Perpanjangan")
            {
                var filteredList = _semuaPerpanjangan
                                    .Where(p => p.User is PenyewaModel && (p.User as PenyewaModel).JenisKelamin == _filterJenisKelamin);
                _dataYangTampil = filteredList.Cast<object>().ToList();
            }
            _halamanSaatIni = 1;
            DisplayCurrentPage();
        }
        private void DisplayCurrentPage()
        {
            flowLayoutPanelPengajuan.Controls.Clear();

            var itemsUntukHalamanIni = _dataYangTampil
                .Skip((_halamanSaatIni - 1) * _itemPerHalaman)
                .Take(_itemPerHalaman)
                .ToList();

            if (itemsUntukHalamanIni.Count == 0)
            {

            }
            else
            {
                foreach (var itemData in itemsUntukHalamanIni)
                {
                    if (itemData is Pengajuan pengajuan)
                    {
                        var itemUc = new UC_ItemPengajuan();
                        itemUc.SetData(pengajuan);
                        itemUc.DetailButtonClicked += OnItemDetailClicked;
                        flowLayoutPanelPengajuan.Controls.Add(itemUc);
                    }
                    else if (itemData is PerpanjanganSewa perpanjangan)
                    {
                        var itemUc = new UC_ItemPerpanjangan();
                        itemUc.SetData(perpanjangan);
                        itemUc.DetailButtonClicked += OnPerpanjanganDetailClicked;
                        flowLayoutPanelPengajuan.Controls.Add(itemUc);
                    }
                }
            }

            UpdatePagingButtons();
        }
        private void UpdatePagingButtons()
        {
            int totalHalaman = (int)Math.Ceiling((double)_dataYangTampil.Count / _itemPerHalaman);
            btnNextPage.Enabled = (_halamanSaatIni < totalHalaman);
            btnPrevPage.Enabled = (_halamanSaatIni > 1);
            lblInfoHalaman.Text = $"Halaman {_halamanSaatIni} dari {totalHalaman}";
        }
        private void OnItemDetailClicked(object sender, int pengajuanId)
        {
            var dataPengajuan = _semuaPengajuan.FirstOrDefault(p => p.Id_Pengajuan == pengajuanId);
            if (dataPengajuan != null)
            {
                ShowDetailView(dataPengajuan);
            }
        }
        private void OnPerpanjanganDetailClicked(object sender, int perpanjanganId)
        {
            var dataPerpanjangan = _semuaPerpanjangan.FirstOrDefault(p => p.Id_Perpanjangan == perpanjanganId);
            if (dataPerpanjangan != null)
            {
                ShowDetailView(dataPerpanjangan);
            }
        }
        private void ShowDetailView(Pengajuan data)
        {
            panel11.Visible = false;
            var detailView = new UC_DetailPengajuan();
            detailView.Dock = DockStyle.Fill;
            detailView.ActionCompleted += (s, ev) => ShowListView();
            detailView.BackRequested += (s, ev) => ShowListView();
            this.Controls.Add(detailView);
            detailView.BringToFront();
            detailView.LoadDetail(data);
        }
        private void ShowDetailView(PerpanjanganSewa data)
        {
            panel11.Visible = false;
            var detailView = new UC_DetailPengajuan();
            detailView.Dock = DockStyle.Fill;
            detailView.ActionCompleted += (s, ev) => ShowListView();
            detailView.BackRequested += (s, ev) => ShowListView();
            this.Controls.Add(detailView);
            detailView.BringToFront();
            detailView.LoadDetail(data);
        }
        private void ShowListView()
        {

            var detailView = this.Controls.OfType<UC_DetailPengajuan>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }


            panel11.Visible = true;


            Manajemen_Sewa_Admin_Load(this, EventArgs.Empty);
        }
        private void btnTipePengajuan_Click(object sender, EventArgs e)
        {
            _tipeTampilan = "Pengajuan";
            ApplyFiltersAndDisplay();
        }

        private void btnTipePerpanjangan_Click(object sender, EventArgs e)
        {
            _tipeTampilan = "Perpanjangan";
            ApplyFiltersAndDisplay();
        }


        private void btnFilterLaki_Click(object sender, EventArgs e)
        {
            _filterJenisKelamin = "Laki-laki";
            ApplyFiltersAndDisplay();
        }

        private void btnFilterPerempuan_Click(object sender, EventArgs e)
        {
            _filterJenisKelamin = "Perempuan";
            ApplyFiltersAndDisplay();
        }

        // Tombol Paginasi
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _halamanSaatIni++;
            DisplayCurrentPage();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _halamanSaatIni--;
            DisplayCurrentPage();
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
