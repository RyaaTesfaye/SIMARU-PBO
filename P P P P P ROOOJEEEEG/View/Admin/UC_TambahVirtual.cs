using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Service;
using RUSUNAWAAA.Models;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_TambahVirtual : UserControl
    {
        public event EventHandler SaveCompleted; 
        public event EventHandler Cancelled;     
        
        private readonly VirtualTourService _service = new VirtualTourService();
      
        private MediaVirtual _currentMedia;
        public UC_TambahVirtual()
        {
            InitializeComponent();
        }
        public void LoadMediaToEdit(MediaVirtual media)
        {
            _currentMedia = media;
            txtNama.Text = media.NamaFile;
            txtpath.Text = media.PathMedia;
            txtKeterangan.Text = media.Keterangan;

         
            if (!string.IsNullOrEmpty(media.PathMedia) && File.Exists(media.PathMedia))
            {
                try
                {
                    pictureBoxPreview.Image = Image.FromFile(media.PathMedia);
                }
                catch { /* Abaikan jika file gambar rusak */ }
            }
        }

        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            ofdPilihFile.Title = "Pilih Gambar untuk Virtual Tour";
            ofdPilihFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
             
                txtNama.Text = Path.GetFileNameWithoutExtension(ofdPilihFile.FileName);
                txtpath.Text = ofdPilihFile.FileName;
                pictureBoxPreview.Image = Image.FromFile(ofdPilihFile.FileName);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtpath.Text))
            {
                MessageBox.Show("Nama File dan Gambar tidak boleh kosong.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (_currentMedia == null)
            {
                
                _currentMedia = new MediaVirtual();
            }

          
            _currentMedia.NamaFile = txtNama.Text;
            _currentMedia.PathMedia = txtpath.Text;
            _currentMedia.Keterangan = txtKeterangan.Text;
            

            bool sukses;
            
            if (_currentMedia.Id_Media > 0)
            {
                
                sukses = _service.UpdateMedia(_currentMedia);
            }
            else
            {
                
                sukses = _service.AddMedia(_currentMedia);
            }

           
            if (sukses)
            {
                MessageBox.Show("Data virtual tour berhasil disimpan.", "Sukses");
                SaveCompleted?.Invoke(this, EventArgs.Empty); 
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data ke database.", "Error");
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty); 
        }
    }
}
