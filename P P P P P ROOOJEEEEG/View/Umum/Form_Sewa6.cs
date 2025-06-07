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
    public partial class Form_Sewa6 : UserControl
    {
        public Form_Sewa6()
        {
            InitializeComponent();
        }

        private void btn_fotobayar_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Foto";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if(ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                gambar_bp.Image = Image.FromFile(ofdPilihFile.FileName);
            }
        }
    }
}
