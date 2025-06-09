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

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_TambahVirtual : UserControl
    {
        private VirtualTourService _virtualTourService;
        private string _selectedFilePathFromOFD = string.Empty;
        public UC_TambahVirtual()
        {
            InitializeComponent();
        }
        public VirtualTourService VirtualTourService
        {
            private set { _virtualTourService = value; }
            get { return _virtualTourService; }
        }

        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            if (ofdPilihFile.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePathFromOFD = ofdPilihFile.FileName; // Menyimpan path lengkap file yang dipilih.
                text_path.Text = _selectedFilePathFromOFD;        // Menampilkan path lengkap di TextBox Path Media.
                txtNama.Text = Path.GetFileNameWithoutExtension(_selectedFilePathFromOFD); // Mengisi TextBox Nama File dengan nama file saja (tanpa ekstensi).
            }
        }
    }
}
