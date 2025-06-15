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
    public partial class UC_SemuaUlasan: UserControl
    {
        public event EventHandler _BackRequested;
        private List<Ulasan> _semuaUlasan;
        //private int _halamanSaatIni = 1;
        private readonly int _itemPerHalaman = 4;
        public UC_SemuaUlasan()
        {
            InitializeComponent();
            btnKembali.Click += BtnKembali_Click;
        }
        public void MuatDanTampilkan(List<Ulasan> daftarUlasan)
        {
            _semuaUlasan = daftarUlasan ?? new List<Ulasan>();
            DisplayAllItems();
        }
        private void DisplayAllItems()
        {
            flowLayoutPanelSemuaUlasan.Controls.Clear();

            if (_semuaUlasan.Any())
            {
                foreach (var ulasan in _semuaUlasan)
                {
                    var itemUlasan = new UC_ItemUlasan();
                    itemUlasan.SetData(ulasan);
                    itemUlasan.Width = flowLayoutPanelSemuaUlasan.ClientSize.Width - 25;
                    flowLayoutPanelSemuaUlasan.Controls.Add(itemUlasan);
                }
            }
            else
            {
                Label lblPesanKosong = new Label { Text = "Tidak ada ulasan untuk ditampilkan.", AutoSize = true };
                flowLayoutPanelSemuaUlasan.Controls.Add(lblPesanKosong);
            }

        }
        private void BtnKembali_Click(object sender, EventArgs e)
        {
           _BackRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}
