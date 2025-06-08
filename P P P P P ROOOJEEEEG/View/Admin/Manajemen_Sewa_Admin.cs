using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
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

namespace RUSUNAWAAA.View.Admin
{
    public partial class Manajemen_Sewa_Admin : Form
    {
        private readonly PengajuanSewaService _service = new PengajuanSewaService();

        // --- Variabel untuk menyimpan data Master ---
        private List<Pengajuan> _semuaPengajuan;
        private List<PerpanjanganSewa> _semuaPerpanjangan;

        // --- Variabel untuk menyimpan State Tampilan Saat Ini ---
        private List<object> _dataYangTampil; // Daftar yang sudah difilter
        private int _halamanSaatIni = 1;
        private readonly int _itemPerHalaman = 7; // Atur berapa item per halaman
        private string _filterJenisKelamin = "Perempuan"; // Default: tampilkan semua
        private string _tipeTampilan = "Pengajuan"; // Default: tampilkan Pengajuan
        public Manajemen_Sewa_Admin()
        {
            InitializeComponent();
        }

        private void ToDashboard_AD(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Admin dashboardad = new Dashboard_Admin();
            dashboardad.ShowDialog();
            this.Close();
        }

        private void ToPengelolaAkun_AD(object sender, EventArgs e)
        {
            this.Hide();
            Pengelolaan_Akun_Admin kelolaakunad = new Pengelolaan_Akun_Admin();
            kelolaakunad.ShowDialog();
            this.Close();
        }

        private void ToKelolaHunian_AD(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Hunian_Admin kelolahunianad = new Kelola_Hunian_Admin();
            kelolahunianad.ShowDialog();
            this.Close();
        }

        private void ToDaftarKeluhan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Daftar_Keluhan_Admin daftarkeluhanad = new Daftar_Keluhan_Admin();
            daftarkeluhanad.ShowDialog();
            this.Close();
        }

        private void ToTinjauUlasan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Tinjau_Ulasan_Admin tinjauulasanad = new Tinjau_Ulasan_Admin();
            tinjauulasanad.ShowDialog();
            this.Close();
        }

        private void ToKelolaAturan_AD(object sender, EventArgs e)
        {
            this.Hide();
            Kelola_Aturan_Admin kelolaaturanad = new Kelola_Aturan_Admin();
            kelolaaturanad.ShowDialog();
            this.Close();
        }

        private void ToEditVirtualTour_AD(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Virtual_Tour_Admin editvirtualtourad = new Edit_Virtual_Tour_Admin();
            editvirtualtourad.ShowDialog();
            this.Close();
        }

        private void ToSiaran_AD(object sender, EventArgs e)
        {
            this.Hide();
            Siaran_Admin siaranad = new Siaran_Admin();
            siaranad.ShowDialog();
            this.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manajemen_Sewa_Admin_Load(object sender, EventArgs e)
        {
            _semuaPengajuan = _service.GetAllPendingApplications();
            _semuaPerpanjangan = _service.GetAllPerpanjangan();

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
                // Filter data perpanjangan (logika sama, tapi pada _semuaPerpanjangan)
                // Karena masih kosong, hasilnya akan kosong
                var filteredList = _semuaPerpanjangan.AsQueryable();
                // if (_filterJenisKelamin != "Semua") { ... filter di sini ... }
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
                // Tampilkan label "Tidak ada data" jika perlu
            }
            else
            {
                foreach (var itemData in itemsUntukHalamanIni)
                {
                    if (itemData is Pengajuan pengajuan)
                    {
                        var itemUc = new UC_ItemPengajuan();
                        itemUc.SetData(pengajuan);
                        itemUc.DetailButtonClicked += (s, id) => { /* Logika saat tombol detail diklik */ };
                        flowLayoutPanelPengajuan.Controls.Add(itemUc);
                    }
                    else if (itemData is PerpanjanganSewa perpanjangan)
                    {
                        // Nanti Anda akan buat ucItemPerpanjangan di sini
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
            // Panggil metode baru untuk menampilkan detail
            ShowDetailView(pengajuanId);
        }
        private void ShowDetailView(int pengajuanId)
        {
            // 1. Sembunyikan semua kontrol yang berhubungan dengan tampilan daftar
            panel11.Visible = false;


            // 2. Buat instance dari UC Detail
            var detailView = new UC_DetailPengajuan();
            detailView.Dock = DockStyle.Fill; // Penuhi seluruh area

            // 3. Berlangganan sinyal dari UC Detail
            detailView.ActionCompleted += (s, ev) => ShowListView(); // Jika ACC/Tolak, kembali ke list
            detailView.BackRequested += (s, ev) => ShowListView(); // Jika Kembali, kembali ke list

            // 4. Tambahkan ke panel induk dan muat datanya
            this.Controls.Add(detailView);
            detailView.BringToFront();
            detailView.LoadDetail(pengajuanId);
        }
        private void ShowListView()
        {
            // Hapus UC Detail yang sedang tampil
            var detailView = this.Controls.OfType<UC_DetailPengajuan>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }

            // Tampilkan kembali semua kontrol untuk daftar
            panel11.Visible = true;

            // Muat ulang data daftar agar update (misalnya, pengajuan yang di-ACC hilang)
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
    }
}
