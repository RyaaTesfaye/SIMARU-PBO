using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Pengelolaan_Akun_Admin : Form
    {
        private readonly AkunService _userService = new AkunService();

        private List<PenyewaModel> _semuaPenyewa;
        public Pengelolaan_Akun_Admin()
        {
            InitializeComponent();
        }
        private void Pengelolaan_Akun_Admin_Load(object sender, EventArgs e)
        {
            LoadAndDisplayPenyewa("Semua");
        }
        private void LoadAndDisplayPenyewa(string genderFilter)
        {
            try
            {
                _semuaPenyewa = _userService.GetPenyewa(genderFilter);
                flowLayoutAkun.Controls.Clear();

                if (_semuaPenyewa.Any())
                {
                    foreach (var penyewa in _semuaPenyewa)
                    {
                        var itemUc = new UC_ItemAkun();
                        itemUc.SetData(penyewa);
                        itemUc.DetailButtonClicked += OnItemClicked;
                        flowLayoutAkun.Controls.Add(itemUc);
                    }
                }
                else
                {
                    // Tampilkan pesan jika tidak ada data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data akun: " + ex.Message);
            }
        }
        private void btnHapusMaster_Click(object sender, EventArgs e)
        {
            // 1. Kumpulkan semua item yang checkbox-nya tercentang
            var itemsToDelete = flowLayoutAkun.Controls
                .OfType<UC_ItemAkun>()
                .Where(uc => uc.IsChecked)
                .ToList();

            // 2. Cek apakah ada yang dipilih
            if (!itemsToDelete.Any())
            {
                MessageBox.Show("Harap pilih setidaknya satu akun untuk dihapus.", "Tidak Ada yang Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Anda yakin ingin menghapus {itemsToDelete.Count} akun yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var ktpToDelete = itemsToDelete.Select(uc => uc.NomorKTP).ToList();

                // 5. Panggil service untuk menghapus semuanya sekaligus
                bool sukses = _userService.DeleteMultipleUsers(ktpToDelete);

                if (sukses)
                {
                    MessageBox.Show($"{itemsToDelete.Count} akun berhasil dihapus.", "Sukses");
                    LoadAndDisplayPenyewa("Semua"); 
                }
                else
                {
                    MessageBox.Show("Gagal menghapus akun.", "Error");
                }
            }
        }
        private void btnFilterSemua_Click(object sender, EventArgs e)
        {
            LoadAndDisplayPenyewa("Semua");
        }

        private void btnFilterLaki_Click(object sender, EventArgs e)
        {
            LoadAndDisplayPenyewa("Laki-laki");
        }

        private void btnFilterPerempuan_Click(object sender, EventArgs e)
        {
            LoadAndDisplayPenyewa("Perempuan");
        }
        private void OnItemClicked(object sender, string nomorKtp)
        {
            ShowDetailView(nomorKtp);
        }
        private void ShowDetailView(string nomorKtp)
        {
            // Sembunyikan container yang berisi daftar akun
            panel10.Visible = false; // Asumsikan Anda punya panel induk ini

            var detailView = new UC_DetailAkun(); // Buat instance UC Detail
            detailView.Dock = DockStyle.Fill;
            // Berlangganan event 'BackRequested' dari UC Detail
            detailView.BackRequested += (s, ev) => ShowListView();

            // Tambahkan UC Detail ke form utama
            this.Controls.Add(detailView);
            detailView.BringToFront();
            // Muat data spesifik ke dalam UC Detail
            detailView.LoadData(nomorKtp);
        }
        private void ShowListView()
        {
            // Hapus UC Detail yang mungkin sedang tampil
            var detailView = this.Controls.OfType<UC_DetailAkun>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }

            // Tampilkan kembali container daftar akun
            panel10.Visible = true;

            // Muat ulang data dari database untuk memastikan datanya paling baru
            LoadAndDisplayPenyewa("Semua");
        }
        private void ToDashboard_AD(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_Admin dashboardad = new Dashboard_Admin();
            dashboardad.ShowDialog();
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

        private void ToTInjauUlasan_AD(object sender, EventArgs e)
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

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToHapusAkun_AD(object sender, EventArgs e)
        {
        }
    }
}
