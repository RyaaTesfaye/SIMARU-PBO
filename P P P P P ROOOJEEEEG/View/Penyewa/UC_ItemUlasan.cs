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
    public partial class UC_ItemUlasan: UserControl
    {
        public UC_ItemUlasan()
        {
            InitializeComponent();
        }
        public void SetData(Ulasan dataUlasan)
        {
            lblNama.Text = dataUlasan.User?.NamaLengkap ?? "Penghuni Anonim";
            lblTanggal.Text = dataUlasan.Tanggal.ToLocalTime().ToString("dd MMMM yyyy");
            lblKomentar.Text = dataUlasan.Komentar;

            TampilkanBintang(dataUlasan.Rating);
        }
        private void TampilkanBintang(int rating)
        {
            PictureBox[] stars = { star1, star2, star3, star4, star5 };

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = (i < rating) ? Properties.Resources.star_ratngsolo : Properties.Resources.star_kosong1;
            }
        }
    }
}
