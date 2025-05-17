using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.View.Umum;

namespace RUSUNAWAAA
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }
        private void LoadFormPengajuanSewa()
        {
            panel1.Controls.Clear(); // Hapus konten lama kalau ada
            Form_Sewa3 formSewa = new Form_Sewa3();
            formSewa.Dock = DockStyle.Fill;
            panel1.Controls.Add(formSewa);
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            LoadFormPengajuanSewa();
        }
    }
}
