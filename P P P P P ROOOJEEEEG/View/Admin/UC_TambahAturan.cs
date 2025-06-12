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

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_TambahAturan: UserControl
    {
        public event EventHandler<TataTertib> SimpanClicked;
        public event EventHandler BatalClicked;
        public UC_TambahAturan()
        {
            InitializeComponent();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAturan.Text))
            {
                MessageBox.Show("Teks aturan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string jenisKelaminTarget = "";
            if (radioLakiLaki.Checked)
            {
                jenisKelaminTarget = "Laki-laki";
            }
            else if (radioPerempuan.Checked)
            {
                jenisKelaminTarget = "Perempuan";
            }


            if (string.IsNullOrEmpty(jenisKelaminTarget))
            {
                MessageBox.Show("Harap pilih target jenis kelamin untuk aturan ini.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var aturanBaru = new TataTertib
            {
                Judul = txtAturan.Text,
                TargetJenisKelamin = jenisKelaminTarget
            };

            SimpanClicked?.Invoke(this, aturanBaru);
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            BatalClicked?.Invoke(this, EventArgs.Empty);
        }


        public void ClearForm()
        {
            txtAturan.Clear();

            radioLakiLaki.Checked = false;
            radioPerempuan.Checked = false;
        }
    }
}
