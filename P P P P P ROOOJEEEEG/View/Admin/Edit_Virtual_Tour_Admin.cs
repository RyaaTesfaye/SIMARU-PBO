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

namespace RUSUNAWAAA.View.Admin
{
    public partial class Edit_Virtual_Tour_Admin : Form
    {
        private readonly VirtualTourService _service = new VirtualTourService();
        public Edit_Virtual_Tour_Admin()
        {
            InitializeComponent();
        }
        private void Edit_Virtual_Tour_Admin_Load(object sender, EventArgs e)
        {
            // Saat form pertama kali dimuat, tampilkan daftar media
            ShowListView();
        }
        private void LoadAndDisplayMedia()
        {
            try
            {
                // Ambil semua data dari service
                var allMedia = _service.GetAllMedia();

                flowLayoutPanelMedia.Controls.Clear(); 

                if (allMedia.Any())
                {
                    foreach (var media in allMedia)
                    {
                        var itemUc = new UC_ItemVirtualTour();
                        itemUc.SetData(media);

                
                        // itemUc.EditButtonClicked += OnItemEditClicked; 

                        flowLayoutPanelMedia.Controls.Add(itemUc);
                    }
                }
                else
                {
                    // Tampilkan pesan jika tidak ada data virtual tour
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
            // Hapus form tambah/edit yang mungkin sedang tampil
            var formView = this.Controls.OfType<UC_TambahVirtual>().FirstOrDefault();
            if (formView != null)
            {
                this.Controls.Remove(formView);
                formView.Dispose();
            }

            // Tampilkan kembali container daftar dan muat ulang datanya
            panel11.Visible = true; // Asumsikan Anda punya panel induk ini
            LoadAndDisplayMedia();
        }
        private void ShowAddView()
        {
            // Sembunyikan container daftar
            panel11.Visible = false;

            var formView = new UC_TambahVirtual();
            formView.Dock = DockStyle.Fill;
            // Berlangganan sinyal dari form tambah
            formView.SaveCompleted += (s, ev) => ShowListView(); // Jika simpan sukses, kembali ke daftar
            formView.Cancelled += (s, ev) => ShowListView();     // Jika batal, kembali ke daftar


            this.Controls.Add(formView);
            formView.BringToFront();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            ShowAddView();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Kumpulkan semua item yang checkbox-nya tercentang
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
                // Ambil semua ID dari item yang dipilih
                var idsToDelete = itemsToDelete.Select(uc => uc.MediaId).ToList();

                // Panggil service untuk menghapus semuanya sekaligus
                bool sukses = _service.DeleteMultipleMedia(idsToDelete);

                if (sukses)
                {
                    MessageBox.Show("Data berhasil dihapus.", "Sukses");
                    LoadAndDisplayMedia(); // Muat ulang daftar untuk menampilkan perubahan
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error");
                }
            }
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

        private void ToManajemenSewa_AD(object sender, EventArgs e)
        {
            this.Hide();
            Manajemen_Sewa_Admin manajemensewaad = new Manajemen_Sewa_Admin();
            manajemensewaad.ShowDialog();
            this.Close();
        }

        private void ToSiaran_AD(object sender, EventArgs e)
        {
            this.Hide();
            Siaran_Admin siaranad = new Siaran_Admin();
            siaranad.ShowDialog();
            this.Close();
        }
    }
}
