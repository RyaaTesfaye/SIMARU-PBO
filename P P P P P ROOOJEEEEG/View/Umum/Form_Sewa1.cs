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
    public partial class Form_Sewa1 : UserControl
    {
        public event EventHandler GoToNextStep;
        private Pengajuan dataSaatIni;
        public Form_Sewa1()
        {
            InitializeComponent();
        }
        public void MuatData(Pengajuan data)
        {
            txtNama.Text = data.NamaLengkap;
            txtAlamat.Text = data.AlamatAsal;
            txtAsalKota.Text = data.AsalKota;
            txtNomorHP.Text = data.NomorHP;

            if (data.JenisKelamin == "Laki-laki")
            {
                radioLakiLaki.Checked = true;
            }
            else if (data.JenisKelamin == "Perempuan")
            {
                radioPerempuan.Checked = true;
            }
        }
        public void SimpanData(Pengajuan data)
        {
            data.NamaLengkap = txtNama.Text;
            data.AlamatAsal = txtAlamat.Text;
            data.AsalKota = txtAsalKota.Text;
            data.NomorHP = txtNomorHP.Text;

            if (radioLakiLaki.Checked)
            {
                data.JenisKelamin = "Laki-laki";
            }
            else if (radioPerempuan.Checked)
            {
                data.JenisKelamin = "Perempuan";
            }
        }

        private void btnLanjut1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                 string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                 string.IsNullOrWhiteSpace(txtAsalKota.Text) ||
                 string.IsNullOrWhiteSpace(txtNomorHP.Text))
            {
                MessageBox.Show("Harap isi semua field yang wajib diisi!", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioLakiLaki.Checked && !radioPerempuan.Checked)
            {
                MessageBox.Show("Harap pilih Jenis Kelamin!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GoToNextStep?.Invoke(this, EventArgs.Empty);

        }
    }
}
