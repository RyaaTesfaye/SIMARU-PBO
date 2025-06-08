using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using RUSUNAWAAA.Models;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Form_Sewa5 : UserControl
    {
        public event EventHandler GoToNextStep;
        private Pengajuan dataSaatIni;
        public Form_Sewa5()
        {
            InitializeComponent();
        }
        public void MuatData(Pengajuan data)
        {

            estimasibulan.Text = $"Estimasi Biaya untuk {data.DurasiSewa} Bulan";
            txtBiaya.Text = data.EstimasiBiaya.ToString("C", new CultureInfo("id-ID"));
            NominalIsi.Text = $"{data.DurasiSewa} Bulan";

        }

        private void btnLanjut5_Click(object sender, EventArgs e)
        {
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }
    }
}
