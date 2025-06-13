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
using RUSUNAWAAA.View.Login;

namespace RUSUNAWAAA.View.Admin
{
    public partial class Kelola_Aturan_Admin : Form
    {
        private readonly AturanService _aturanService;
        private UC_TambahAturan _ucTambahAturan;

        private string _filterJenisKelamin = "Perempuan";
        public Kelola_Aturan_Admin()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel14, 20);
            UIhelper.MakePanelRound(flowLayoutPanelAturan, 20);

            _aturanService = new AturanService(flowLayoutPanelAturan);
        }

        // Muat dan tampilkan semua data saat form pertama kali dibuka

        private void Kelola_Aturan_Admin_Load(object sender, EventArgs e)
        {
            ApplyFilterAndDisplay();
        }
        private void ApplyFilterAndDisplay()
        {
            try
            {
                List<TataTertib> semuaAturan = _aturanService.GetAllAturan();


                var filteredList = semuaAturan
                    .Where(a => a.TargetJenisKelamin == _filterJenisKelamin || a.TargetJenisKelamin == "Semua")
                    .ToList();

                _aturanService.DisplayAllItemsOnPanel(filteredList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menerapkan filter dan menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFilterPerempuan_Click(object sender, EventArgs e)
        {
            _filterJenisKelamin = "Perempuan";
            ApplyFilterAndDisplay();
        }

        private void btnFilterLakiLaki_Click(object sender, EventArgs e)
        {
            _filterJenisKelamin = "Laki-laki";
            ApplyFilterAndDisplay();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (_ucTambahAturan == null)
            {
                _ucTambahAturan = new UC_TambahAturan();
                _ucTambahAturan.Dock = DockStyle.Fill;

                // "Dengarkan" sinyal dari UC Tambah Aturan
                _ucTambahAturan.SimpanClicked += UcTambahAturan_SimpanClicked;
                _ucTambahAturan.BatalClicked += UcTambahAturan_BatalClicked;

                // Tambahkan UC ke form (di atas kontrol lain)
                this.Controls.Add(_ucTambahAturan);
            }

            _ucTambahAturan.BringToFront();
            _ucTambahAturan.Visible = true;
        }
        private void UcTambahAturan_BatalClicked(object sender, EventArgs e)
        {
            // Cukup sembunyikan form tambah jika dibatalkan
            if (_ucTambahAturan != null)
            {
                _ucTambahAturan.Visible = false;
            }
        }
        private void UcTambahAturan_SimpanClicked(object sender, TataTertib aturanBaru)
        {
            bool sukses = _aturanService.AddAturan(aturanBaru);
            if (sukses)
            {
                MessageBox.Show("Aturan baru berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ucTambahAturan.Visible = false;
                _ucTambahAturan.ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan aturan baru.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint_1(object sender, PaintEventArgs e)
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