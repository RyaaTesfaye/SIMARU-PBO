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
    
    public partial class UC_PerpanjanganSewa2 : UserControl
    {
        public string PathBuktiPembayaran { get; private set; }

        public event EventHandler KonfirmasiButtonClicked;
        public UC_PerpanjanganSewa2()
        {
            InitializeComponent();
        }
        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            
                ofdPilihFile.Title = "Pilih Gambar Bukti Pembayaran";.
                ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofdPilihFile.ShowDialog() == DialogResult.OK)
                {
                    this.PathBuktiPembayaran = ofdPilihFile.FileName;

                    txt_pathbp.Text = System.IO.Path.GetFileName(ofdPilihFile.FileName);

                    gambar_bp.Image = new Bitmap(ofdPilihFile.FileName);
                }
            
        }
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            KonfirmasiButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
    
    
}
