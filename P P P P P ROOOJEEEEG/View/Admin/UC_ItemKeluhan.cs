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
    public partial class UC_ItemKeluhan : UserControl
    {
        public int Id_Keluhan { get; private set; }
        public event EventHandler<int> DetailButtonClicked;

        public UC_ItemKeluhan()
        {
            InitializeComponent();
        }
        public void SetData(Laporan data)
        {
            this.Id_Keluhan = data.Id_Laporan;

            
            lblID.Text = data.Id_Laporan.ToString();
            lblNama.Text = data.User?.NamaLengkap ?? "Nama Tidak Tersedia";
            lblJudul.Text = data.Judul;
            lblTanggal.Text = data.Tanggal.ToLocalTime().ToString("dd MMMM yyyy");
            lblStatus.Text = data.Status;
            if (data.Status == "Belum Ditangani")
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;
            }
            else if (data.Status == "Sedang Diproses")
            {
                lblStatus.BackColor = Color.Orange;
                lblStatus.ForeColor = Color.Black;
            }
            else 
            {
                lblStatus.BackColor = Color.Green;
                lblStatus.ForeColor = Color.White;
            }
        }

       
        private void btnDetail_Click(object sender, EventArgs e)
        {
          
            DetailButtonClicked?.Invoke(this, this.Id_Keluhan);
        }
    }
}
