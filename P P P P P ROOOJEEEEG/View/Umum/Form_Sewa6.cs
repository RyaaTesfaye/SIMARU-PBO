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
    public partial class Form_Sewa6 : UserControl
    {
        public event EventHandler FinishClicked;
        private Pengajuan dataSaatIni;
        public Form_Sewa6()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakeRoundedButton(button4, 10);
        }
        public void MuatData(Pengajuan data)
        {
            this.dataSaatIni = data;
            txt_pathbp.Text = this.dataSaatIni.PathPembayaran;
            if (!string.IsNullOrEmpty(this.dataSaatIni.PathPembayaran) && File.Exists(this.dataSaatIni.PathPembayaran))
            {
                try
                {
                    gambar_bp.Image = Image.FromFile(this.dataSaatIni.PathPembayaran);
                }
                catch (Exception)
                {
                    gambar_bp.Image = null;
                }
            }
        }


        public void SimpanData(Pengajuan data)
        {
            if (data != null)
            {
                data.PathPembayaran = txt_pathbp.Text;
            }
        }

        private void btn_fotobayar_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                txt_pathbp.Text = ofdPilihFile.FileName;
                gambar_bp.Image = Image.FromFile(ofdPilihFile.FileName);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_pathbp.Text))
            {
                MessageBox.Show("Harap unggah bukti pembayaran terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FinishClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
