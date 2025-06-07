using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Form_Sewa3 : UserControl
    {
        public event EventHandler GoToNextStep;
        public Form_Sewa3()
        {
            InitializeComponent();
        }

        private void btnLanjut3_Click(object sender, EventArgs e)
        {
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }

        private void btn_fotoktp_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            // 2. Tampilkan dialog
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {

                text_pathktp.Text = ofdPilihFile.FileName;
            }
        }

        private void btn_fotosp_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            // 2. Tampilkan dialog
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {

                text_pathsp.Text = ofdPilihFile.FileName;
            }
        }

        private void btn_fotopas_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto Profil";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            // 2. Tampilkan dialog
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {

                text_pathpasfoto.Text = ofdPilihFile.FileName;
            }
        }
    }
}
