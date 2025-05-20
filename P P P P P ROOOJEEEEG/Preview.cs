using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.View.Login;

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
            Logins_2 formSewa = new Logins_2();
            formSewa.Dock = DockStyle.Fill;
            panel1.Controls.Add(formSewa);
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            LoadFormPengajuanSewa();
        }
    }
}
