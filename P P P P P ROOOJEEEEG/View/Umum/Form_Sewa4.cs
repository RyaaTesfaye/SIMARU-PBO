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
using RUSUNAWAAA.Utils;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Form_Sewa4 : UserControl
    {
        public event EventHandler GoToNextStep;
        public Form_Sewa4()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakeRoundedButton(button4, 10);
        }

        public void MuatData(Pengajuan data)
        {

            NamaIsi.Text =  data.NamaLengkap;
            JenisKelaminIsi.Text =  data.JenisKelamin;
            AlamatIsi.Text = data.AlamatAsal;
            AsalKotaIsi.Text = data.AsalKota;
            NomorHpIsi.Text = data.NomorHP;
            NamaOrangTuaIsi.Text = data.NamaOrangTua;
            NimIsi.Text = data.NIM; 
            FakultasIsi.Text = data.Fakultas;
            ProdiIsi.Text = data.Prodi;
        }

        private void btnLanjut4_Click(object sender, EventArgs e)
        {
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }
    }
}
