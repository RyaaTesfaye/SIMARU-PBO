using RUSUNAWAAA.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Edit_Virtual_Tour_Admin : Form
    {
        private readonly VirtualTourService _service = new VirtualTourService();
        public Edit_Virtual_Tour_Admin()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel11, 20);
        }
        private void Edit_Virtual_Tour_Admin_Load(object sender, EventArgs e)
        {

            ShowListView();
        }
        private void LoadAndDisplayMedia()
        {
            try
            {

                var allMedia = _service.GetAllMedia();

                flowLayoutPanelMedia.Controls.Clear();

                if (allMedia.Any())
                {
                    foreach (var media in allMedia)
                    {
                        var itemUc = new UC_ItemVirtualTour();
                        itemUc.SetData(media);

                        flowLayoutPanelMedia.Controls.Add(itemUc);
                    }
                }
                else
                {

                    var lblKosong = new Label { Text = "Belum ada data virtual tour.", AutoSize = true };
                    flowLayoutPanelMedia.Controls.Add(lblKosong);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error");
            }
        }

        private void ShowListView()
        {

            var formView = this.Controls.OfType<UC_TambahVirtual>().FirstOrDefault();
            if (formView != null)
            {
                this.Controls.Remove(formView);
                formView.Dispose();
            }


            panel11.Visible = true;
            LoadAndDisplayMedia();
        }
        private void ShowAddView()
        {

            panel11.Visible = false;

            var formView = new UC_TambahVirtual();
            formView.Dock = DockStyle.Fill;

            formView.SaveCompleted += (s, ev) => ShowListView();
            formView.Cancelled += (s, ev) => ShowListView();


            this.Controls.Add(formView);
            formView.BringToFront();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            ShowAddView();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {

            var itemsToDelete = flowLayoutPanelMedia.Controls
                .OfType<UC_ItemVirtualTour>()
                .Where(uc => uc.IsChecked)
                .ToList();

            if (!itemsToDelete.Any())
            {
                MessageBox.Show("Harap pilih setidaknya satu item untuk dihapus.", "Tidak Ada yang Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Anda yakin ingin menghapus {itemsToDelete.Count} item yang dipilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var idsToDelete = itemsToDelete.Select(uc => uc.MediaId).ToList();


                bool sukses = _service.DeleteMultipleMedia(idsToDelete);

                if (sukses)
                {
                    MessageBox.Show("Data berhasil dihapus.", "Sukses");
                    LoadAndDisplayMedia();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error");
                }
            }
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
