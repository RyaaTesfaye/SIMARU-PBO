using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Kelola_Aturan_Admin : Form
    {
        private readonly AturanService _aturanService; // Menggunakan AturanService

        // Anda tidak lagi membutuhkan variabel paginasi jika semua data ditampilkan
        // private List<TataTertib> _semuaAturan;
        // private List<TataTertib> _aturanYangTampil;
        // private int _halamanAturanSaatIni = 1;
        // private readonly int _itemAturanPerHalaman = 10;

        // Asumsikan Anda memiliki FlowLayoutPanel bernama 'flowLayoutPanelAturan' di designer
        // Tombol paginasi (btnPrevAturan, btnNextAturan) dan label halaman dihapus/tidak digunakan
        // Tombol Add (btnAddAturan) juga dihapus/tidak digunakan

        public Kelola_Aturan_Admin()
        {
            InitializeComponent();
            
            // Inisialisasi service dengan panel target
            // Pastikan flowLayoutPanelAturan sudah ada di designer dan diinisialisasi oleh InitializeComponent()
            _aturanService = new AturanService(flowLayoutPanelAturan); 
            
            // Muat dan tampilkan semua data saat form pertama kali dibuka
            LoadAndDisplayAllAturan();

            // Event handlers untuk tombol paginasi tidak ada lagi
            // btnPrevAturan.Click += btnPrevAturan_Click;
            // btnNextAturan.Click += btnNextAturan_Click;
        }

        private void LoadAndDisplayAllAturan()
        {
            if (flowLayoutPanelAturan == null)
            {
                MessageBox.Show("Error: flowLayoutPanelAturan tidak ditemukan. Pastikan sudah ditambahkan di designer.", "Error Konfigurasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Panggil service untuk mendapatkan semua data
            List<TataTertib> allAturan = _aturanService.GetAllAturan();

            // Panggil service untuk menampilkan semua data tersebut di panel
            _aturanService.DisplayAllItemsOnPanel(allAturan);
            
            // Tidak ada lagi UpdatePaginationControls() karena tidak ada paginasi
        }

        // Metode AturanItem_DeleteClicked (jika Anda punya tombol delete di UC dan ingin menanganinya)
        // Jika Anda ingin fungsi Delete aktif, Anda perlu mengaitkan event-nya di AturanService.DisplayAllItemsOnPanel
        // Atau, Anda bisa membuat tombol delete di Kelola_Aturan_Admin yang meminta ID dan memanggil service.DeleteAturan
        /*
        private void AturanItem_DeleteClicked(object sender, int idTataTertib)
        {
            // Logika konfirmasi dan pemanggilan service.DeleteAturan
            if (MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_aturanService.DeleteAturan(idTataTertib))
                {
                    MessageBox.Show("Berhasil dihapus!");
                    LoadAndDisplayAllAturan(); // Refresh tampilan
                }
                else
                {
                    MessageBox.Show("Gagal menghapus.");
                }
            }
        }
        */

        // --- Semua metode paginasi (btnPrevAturan_Click, btnNextAturan_Click, UpdatePaginationControls) dihapus ---

        // --- Event handlers navigasi ke form Admin lainnya (tetap ada) ---
        private void ToDashboard_AD(object sender, EventArgs e) { /* ... */ }
        private void ToPengelolaAkun_AD(object sender, EventArgs e) { /* ... */ }
        private void ToKelolaHunian_AD(object sender, EventArgs e) { /* ... */ }
        private void ToDaftarKeluhan_AD(object sender, EventArgs e) { /* ... */ }
        private void ToTinjauUlasan_AD(object sender, EventArgs e) { /* ... */ }
        private void ToManajemenSewa_AD(object sender, EventArgs e) { /* ... */ }
        private void ToEditVirtualTour_AD(object sender, EventArgs e) { /* ... */ }
        private void ToSiaran_AD(object sender, EventArgs e) { /* ... */ }
    }
}