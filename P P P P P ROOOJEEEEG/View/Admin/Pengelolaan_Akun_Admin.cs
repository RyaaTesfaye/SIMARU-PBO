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
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
using RUSUNAWAAA.View.Penyewa;
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
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
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
            var itemsToDelete = flowLayoutAkun.Controls
                .OfType<UC_ItemAkun>()
                .Where(uc => uc.IsChecked)
                .ToList();


            if (!itemsToDelete.Any())
            {
                MessageBox.Show("Harap pilih setidaknya satu akun untuk dihapus.", "Tidak Ada yang Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Anda yakin ingin menghapus {itemsToDelete.Count} akun yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var ktpToDelete = itemsToDelete.Select(uc => uc.NomorKTP).ToList();

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

            panel10.Visible = false;

            var detailView = new UC_DetailAkun();
            detailView.Dock = DockStyle.Fill;
            detailView.BackRequested += (s, ev) => ShowListView();


            this.Controls.Add(detailView);
            detailView.BringToFront();

            detailView.LoadData(nomorKtp);
        }
        private void ShowListView()
        {

            var detailView = this.Controls.OfType<UC_DetailAkun>().FirstOrDefault();
            if (detailView != null)
            {
                this.Controls.Remove(detailView);
                detailView.Dispose();
            }


            panel10.Visible = true;

            LoadAndDisplayPenyewa("Semua");
        }
        private void ToDashboard_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_Admin>(this);
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



        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToHapusAkun_AD(object sender, EventArgs e)
        {
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
