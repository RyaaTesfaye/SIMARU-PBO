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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Form_Sewa2 : UserControl
    {
        public event EventHandler GoToNextStep;
        private Pengajuan dataSaatIni;
        public Form_Sewa2()
        {
            InitializeComponent();
        }
        public void MuatData(Pengajuan data)
        {
            txtNIM.Text = data.NIM;
            txtFakultas.Text = data.Fakultas;
            txtProdi.Text = data.Prodi;
            txtOrangTua.Text = data.NamaOrangTua;
            txtNomorKTP.Text = data.NomorKTP;
        }
        public void SimpanData(Pengajuan data)
        {
            data.NIM = txtNIM.Text;
            data.Fakultas = txtFakultas.Text;
            data.Prodi = txtProdi.Text;
            data.NamaOrangTua = txtOrangTua.Text;
            data.NomorKTP = txtNomorKTP.Text;
        }

        private void btnLanjut2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFakultas.Text) ||
                string.IsNullOrWhiteSpace(txtNIM.Text) ||
                string.IsNullOrEmpty(txtOrangTua.Text) ||
                string.IsNullOrEmpty(txtProdi.Text) ||
                string.IsNullOrWhiteSpace(txtNomorKTP.Text))
            {
                MessageBox.Show("Harap isi semua field yang wajib diisi!", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
