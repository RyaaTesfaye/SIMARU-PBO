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
        }
        private void Daftar_Keluhan_Admin_Load(object sender, EventArgs e)
        {
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

            //UpdatePagingButtons();
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

            // 4. Tambahkan ke form utama dan muat datanya
            this.Controls.Add(detailView);
            detailView.BringToFront();
            detailView.LoadDetail(keluhanId);
        }

        // Metode baru untuk kembali menampilkan halaman daftar
        private void ShowListView()
        {
            // Hapus UC Detail yang sedang tampil
            var detailView = this.Controls.OfType<UC_DetailKeluhan>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }

            // Tampilkan kembali container daftar
            panel12.Visible = true;

            // Muat ulang data daftar agar statusnya update
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

        private void ToManajemenSewa_AD(object sender, EventArgs e)
        {
            this.Hide();
            Manajemen_Sewa_Admin manajemensewaad = new Manajemen_Sewa_Admin();
            manajemensewaad.ShowDialog();
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
    }
}
