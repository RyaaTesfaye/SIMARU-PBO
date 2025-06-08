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
    public partial class Form_Sewa3 : UserControl
    {
        public event EventHandler GoToNextStep;
        private Pengajuan dataSaatIni;
        public Form_Sewa3()
        {
            InitializeComponent();
        }
        public void MuatData(Pengajuan data)
        {
            cmbDurasi.SelectedItem = data.DurasiSewa > 0 ? data.DurasiSewa.ToString() : null;
            text_pathktp.Text = data.PathKTP;
            text_pathsp.Text = data.PathSuratPernyataan;
            text_pathpasfoto.Text = data.PathPasfoto;
        }
        public void SimpanData(Pengajuan data)
        {
            int.TryParse(cmbDurasi.SelectedItem?.ToString(), out int durasi);
            data.DurasiSewa = durasi;

            data.PathKTP = text_pathktp.Text;
            data.PathSuratPernyataan = text_pathsp.Text;
            data.PathPasfoto = text_pathpasfoto.Text;
        }

        private void btnLanjut3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_pathktp.Text) ||
                string.IsNullOrWhiteSpace(text_pathpasfoto.Text) ||
                string.IsNullOrWhiteSpace(text_pathsp.Text) ||
                cmbDurasi.SelectedItem == null)
            {
                MessageBox.Show("Harap isi semua field yang wajib diisi!", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }

        private void btn_fotoktp_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {

                text_pathktp.Text = ofdPilihFile.FileName;
            }
        }

        private void btn_fotosp_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {   
                text_pathsp.Text = ofdPilihFile.FileName;
            }
        }

        private void btn_fotopas_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                text_pathpasfoto.Text = ofdPilihFile.FileName;
            }
        }
    }
}
