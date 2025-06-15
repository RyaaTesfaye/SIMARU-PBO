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
    public partial class UC_DaftarUlasan: UserControl
    {
        public event EventHandler LihatSemuaClicked;
        public UC_DaftarUlasan()
        {
            InitializeComponent();
            linkLihatSemua.Click += LinkLihatSemua_Click;
        }
        public void TampilkanUlasan(List<Ulasan> semuaUlasan)
        {
            flowLayoutPanelUlasan.Controls.Clear();

            lblJumlahUlasan.Text = (semuaUlasan?.Count ?? 0).ToString("N0") + "+ ulasan dari penghuni";

            if (semuaUlasan == null || !semuaUlasan.Any())
            {
                Label lblPesanKosong = new Label
                {
                    Text = "Jadilah yang pertama memberikan ulasan!",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 12F)
                };
                flowLayoutPanelUlasan.Controls.Add(lblPesanKosong);
                return;
            }

            foreach (var ulasan in semuaUlasan.Take(2))
            {
                var itemUlasan = new UC_ItemUlasan();
                itemUlasan.SetData(ulasan);
                itemUlasan.Width = flowLayoutPanelUlasan.ClientSize.Width - 25;
                flowLayoutPanelUlasan.Controls.Add(itemUlasan);
            }
        }
        private void LinkLihatSemua_Click(object sender, EventArgs e)
        {
            LihatSemuaClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
