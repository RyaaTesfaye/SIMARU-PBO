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
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_ItemPerpanjangan: UserControl
    {
        public event EventHandler<int> DetailButtonClicked;
        public int Id_Perpanjangan { get; private set; }
        public UC_ItemPerpanjangan()
        {
            InitializeComponent();
            btnDetail.Click += BtnDetail_Click;
        }
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            DetailButtonClicked?.Invoke(this, this.Id_Perpanjangan);
        }
        public void SetData(PerpanjanganSewa data)
        {
            this.Id_Perpanjangan = data.Id_Perpanjangan;

            label_Id.Text = data.Id_Perpanjangan.ToString();

            label_Nama.Text = data.User?.NamaLengkap ?? "Data Tidak Lengkap";
            label_NoHp.Text = (data.User as PenyewaModel)?.NomorHP ?? "N/A";

            label_Status.Text = data.Status;

            label_DurasiSewa.Text = data.LamaBulan.ToString() + " Bulan";
            label_TanggalPengajuan.Text = data.TanggalPengajuan.ToLocalTime().ToString("dd MMM yyyy");
        }
    }
}
