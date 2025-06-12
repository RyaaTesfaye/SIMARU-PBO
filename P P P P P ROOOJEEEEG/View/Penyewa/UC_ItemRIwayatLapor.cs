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

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class UC_ItemRIwayatLapor: UserControl
    {
        public UC_ItemRIwayatLapor()
        {
            InitializeComponent();
        }
        public void SetData(Laporan dataLaporan, int nomorUrut)
        {
            lblID.Text = nomorUrut.ToString();
            lblJudul.Text = dataLaporan.Judul;
            lblTanggal.Text = dataLaporan.Tanggal.ToLocalTime().ToString("dd MMMM yyyy"); 
            lblStatus.Text = dataLaporan.Status;

            
            switch (dataLaporan.Status)
            {
                case "Selesai":
                    lblStatus.BackColor = Color.SeaGreen;
                    lblStatus.ForeColor = Color.White;
                    break;
                case "Sedang Diproses":
                    lblStatus.BackColor = Color.Orange;
                    lblStatus.ForeColor = Color.Black;
                    break;
                case "Belum Ditangani":
                default:
                    lblStatus.BackColor = Color.Firebrick;
                    lblStatus.ForeColor = Color.White;
                    break;
            }
        }
    }
}
