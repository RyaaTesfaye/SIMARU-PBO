using RUSUNAWAAA.Service;
using RUSUNAWAAA.Utils;
using RUSUNAWAAA.View.Login;
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

namespace RUSUNAWAAA.View.Umum
{
    public partial class Tatatertib_Umum : Form
    {
        private string _filterAktif = "Semua";
        private AturanService _aturanService;
        public Tatatertib_Umum()
        {
            InitializeComponent();
            _aturanService = new AturanService(new Panel());
        }
        private void Tata_Tertib_Umum_Load(object sender, EventArgs e)
        {
            if (SesiLogin.IsLoggedIn() && SesiLogin.LoggedInUser is PenyewaModel penyewa)
            {
                _filterAktif = penyewa.JenisKelamin;
            }

            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            _aturanService.DisplayItemsOnDataGridView(dgvAturan, _filterAktif);
        }
        private void btnFilterPerempuan_Click(object sender, EventArgs e)
        {
            _filterAktif = "Perempuan";
            RefreshDataGridView();
        }

        private void btnFilterLakiLaki_Click(object sender, EventArgs e)
        {
            _filterAktif = "Laki-laki";
            RefreshDataGridView();
        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<DaftarUnit_Umum>(this);
            command.Execute();
        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_umum>(this);
            command.Execute();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<PengajuanSewa_Umum>(this);
            command.Execute();
        }

        private void ToUlasan_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Ulasan_Umum>(this);
            command.Execute();
        }

        private void ToVirtualTour_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Virtual_Tour_Umum>(this);
            command.Execute();
        }

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kontaklokasi_Umum>(this);
            command.Execute();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Loginss>(this);
            command.Execute();
        }
    }
}
