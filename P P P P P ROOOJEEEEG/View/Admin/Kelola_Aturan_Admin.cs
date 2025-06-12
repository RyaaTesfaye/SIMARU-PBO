using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Penyewa;
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
        private readonly AturanService _aturanService; 

        public Kelola_Aturan_Admin()
        {
            InitializeComponent();
            
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


            List<TataTertib> allAturan = _aturanService.GetAllAturan();

 
            _aturanService.DisplayAllItemsOnPanel(allAturan);
           
        }
        private void ToDashboard_AD(object sender, EventArgs e) { /* ... */ }
        private void ToPengelolaAkun_AD(object sender, EventArgs e) { /* ... */ }
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

        private void ToSiaran_AD(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Siaran_Admin>(this);
            command.Execute();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}