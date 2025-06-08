using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_ItemPengajuan : UserControl
    {
        public int PengajuanId { get; private set; }
        public event EventHandler<int> DetailButtonClicked;
        public UC_ItemPengajuan()
        {
            InitializeComponent();
        }
        public void SetData(Pengajuan data)
        {
            this.PengajuanId = data.Id_Pengajuan;

            label_Id.Text = data.Id_Pengajuan.ToString("D3");
            label_Nama.Text = data.NamaLengkap;
            label_NoHp.Text = data.NomorHP;
            label_Fakultas.Text = data.Fakultas;
            label_DurasiSewa.Text = data.DurasiSewa.ToString() + " Bulan";
            label_TanggalPengajuan.Text = data.TanggalPengajuan.ToString("dd MMM yyyy");
        }

        private void btn_detailClick(object sender, EventArgs e)
        {
            DetailButtonClicked?.Invoke(this, this.PengajuanId);
        }
    }
}
