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
    public partial class UC_StatistikUlasan: UserControl
    {
        public event EventHandler BeriUlasanClicked;

        public UC_StatistikUlasan()
        {
            InitializeComponent();
            linkBeriUlasan.Click += LinkBeriUlasan_Click;
        }
        private void LinkBeriUlasan_Click(object sender, EventArgs e)
        {
            // Memicu event untuk memberitahu form utama.
            BeriUlasanClicked?.Invoke(this, EventArgs.Empty);
        }
        public void TampilkanStatistik(List<Ulasan> semuaUlasan, TampilanUlasanMode mode)
        {
            TampilkanStatistikInternal(semuaUlasan);
            linkBeriUlasan.Visible = (mode == TampilanUlasanMode.Penyewa);
        }
        public void TampilkanStatistikInternal(List<Ulasan> semuaUlasan)
        {
            if (semuaUlasan == null || !semuaUlasan.Any())
            {
                lblTotalSkor.Text = "N/A";
                lblJumlahPenyewa.Text = "Belum ada ulasan";
                // Atur semua lebar panel bar ke 0
                panelBarBintang5.Width = 0;
                panelBarBintang4.Width = 0;
                panelBarBintang3.Width = 0;
                panelBarBintang2.Width = 0;
                panelBarBintang1.Width = 0;

                lblJmlBintang5.Text = "0";
                lblJmlBintang4.Text = "0";
                lblJmlBintang3.Text = "0";
                lblJmlBintang2.Text = "0";
                lblJmlBintang1.Text = "0";
                return;
            }

            int totalUlasan = semuaUlasan.Count;
            double rataRata = semuaUlasan.Average(u => u.Rating);
            int count5 = semuaUlasan.Count(u => u.Rating == 5);
            int count4 = semuaUlasan.Count(u => u.Rating == 4);
            int count3 = semuaUlasan.Count(u => u.Rating == 3);
            int count2 = semuaUlasan.Count(u => u.Rating == 2);
            int count1 = semuaUlasan.Count(u => u.Rating == 1);

            lblTotalSkor.Text = rataRata.ToString("F1") + "/5";
            lblJumlahPenyewa.Text = "Dari " + totalUlasan + " Penyewa";

            lblJmlBintang5.Text = count5.ToString();
            lblJmlBintang4.Text = count4.ToString();
            lblJmlBintang3.Text = count3.ToString();
            lblJmlBintang2.Text = count2.ToString();
            lblJmlBintang1.Text = count1.ToString();

            UpdateBarWidth(panelBgBintang5, panelBarBintang5, count5, totalUlasan);
            UpdateBarWidth(panelBgBintang4, panelBarBintang4, count4, totalUlasan);
            UpdateBarWidth(panelBgBintang3, panelBarBintang3, count3, totalUlasan);
            UpdateBarWidth(panelBgBintang2, panelBarBintang2, count2, totalUlasan);
            UpdateBarWidth(panelBgBintang1, panelBarBintang1, count1, totalUlasan);
        }
        private void UpdateBarWidth(Panel backgroundPanel, Panel barPanel, int count, int total)
        {
            if (total == 0)
            {
                barPanel.Width = 0;
                return;
            }
            double percentage = (double)count / total;
            int newWidth = (int)Math.Round(percentage * backgroundPanel.Width);

            barPanel.Width = newWidth;
        }
    }
}
