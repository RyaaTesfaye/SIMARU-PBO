using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.View.Umum;
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
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Daftar_Keluhan_Admin : Form
    {
        private readonly KeluhanService _service = new KeluhanService();
        private List<Laporan> _semuaKeluhan;
        private List<Laporan> _dataYangTampil;
        private int _halamanSaatIni = 1;
        private readonly int _itemPerHalaman = 9;
        private string _filterStatus = "Semua";
        private string _filterJenisKelamin = "Semua";
        public Daftar_Keluhan_Admin()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
        }
        private void Daftar_Keluhan_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                _semuaKeluhan = _service.GetAllKeluhan();
                ApplyFiltersAndDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data keluhan: " + ex.Message);
            }
        }
        private void ApplyFiltersAndDisplay()
        {
            IEnumerable<Laporan> filteredList = _semuaKeluhan;

            if (_filterStatus != "Semua")
            {
                filteredList = filteredList.Where(k => k.Status == _filterStatus);
            }

            if (_filterJenisKelamin != "Semua")
            {
                filteredList = filteredList.Where(k => (k.User as Models.Penyewa)?.JenisKelamin == _filterJenisKelamin);
            }

            _dataYangTampil = filteredList.OrderByDescending(k => k.Tanggal).ToList();

            _halamanSaatIni = 1;
            DisplayCurrentPage();
        }
        private void DisplayCurrentPage()
        {
            flowLayoutPanelKeluhan.Controls.Clear();

            var itemsUntukHalamanIni = _dataYangTampil
                .Skip((_halamanSaatIni - 1) * _itemPerHalaman)
                .Take(_itemPerHalaman)
                .ToList();

            if (itemsUntukHalamanIni.Any())
            {
                foreach (var keluhan in itemsUntukHalamanIni)
                {
                    var itemUc = new UC_ItemKeluhan();
                    itemUc.SetData(keluhan);
                    itemUc.DetailButtonClicked += OnItemDetailClicked;
                    flowLayoutPanelKeluhan.Controls.Add(itemUc);
                }
            }
            else
            {
                var lblKosong = new Label { Text = "Tidak ada keluhan dengan filter ini.", AutoSize = true };
                flowLayoutPanelKeluhan.Controls.Add(lblKosong);
            }

        }
        private void OnItemDetailClicked(object sender, int keluhanId)
        {
            ShowDetailView(keluhanId);
        }
        private void ShowDetailView(int keluhanId)
        {
            panel12.Visible = false;


            var detailView = new UC_DetailKeluhan();
            detailView.Dock = DockStyle.Fill;


            detailView.ActionCompleted += (s, ev) => ShowListView();
            detailView.BackRequested += (s, ev) => ShowListView();


            this.Controls.Add(detailView);
            detailView.BringToFront();
            detailView.LoadDetail(keluhanId);
        }


        private void ShowListView()
        {

            var detailView = this.Controls.OfType<UC_DetailKeluhan>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }


            panel12.Visible = true;


            Daftar_Keluhan_Admin_Load(this, EventArgs.Empty);
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


        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStatusFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbStatusFilter.SelectedItem != null)
            {
                _filterStatus = cmbStatusFilter.SelectedItem.ToString();
                ApplyFiltersAndDisplay();
            }
        }
        private void btnKeluar_Click(object sender, EventArgs e)
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

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
