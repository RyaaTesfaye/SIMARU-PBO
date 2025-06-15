using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSUNAWAAA.View.Penyewa
{
    public partial class UC_PerpanjanganSewa1 : UserControl
    {
        private const decimal TARIF_SEWA_BULANAN = 100000;

        public int SelectedDurasiBulan { get; private set; }
        public decimal CalculatedNominal { get; private set; }
        public event EventHandler<int> DurasiChanged;
        public UC_PerpanjanganSewa1()
        {
            InitializeComponent();
        }
        private void cmbDurasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilihanTeks = cmbDurasi.SelectedItem?.ToString();
            int durasiBulan = 0; 
            if (!string.IsNullOrEmpty(pilihanTeks))
            {
                int.TryParse(pilihanTeks, out durasiBulan);
            }

            this.SelectedDurasiBulan = durasiBulan;
            this.CalculatedNominal = durasiBulan * TARIF_SEWA_BULANAN;

            txtBiaya.Text = "Rp. " + this.CalculatedNominal.ToString("N0");

            DurasiChanged?.Invoke(this, durasiBulan);

        }
    }
}
