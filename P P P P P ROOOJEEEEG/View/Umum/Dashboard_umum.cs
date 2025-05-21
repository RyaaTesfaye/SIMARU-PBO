using Microsoft.Win32;
using RUSUNAWAAA.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Dashboard_umum : Form
    {
        public Dashboard_umum()
        {
            InitializeComponent();
            UIhelper.MakePanelRound(panel9, 20);
            UIhelper.MakePanelRound(panel10, 20);
            UIhelper.MakePanelRound(panel11, 20);
            UIhelper.MakePanelRound(panel12, 20);
            UIhelper.MakePanelRound(panel13, 20);
            UIhelper.MakePanelRound(panel14, 20);
            UIhelper.MakePanelRound(panel15, 20);
            UIhelper.MakePanelRound(panel16, 20);
            UIhelper.MakePanelRound(panel17, 20);
            UIhelper.MakePanelRound(panel18, 20);
            UIhelper.MakePanelRound(panel19, 20);
            UIhelper.MakePanelRound(panel20, 20);
            UIhelper.MakePanelRound(panel24, 20);
            UIhelper.MakePanelRound(panel25, 3);
            UIhelper.MakePanelRound(panel26, 3);
            UIhelper.MakeRoundedButton(button1, 3);
            UIhelper.MakeRoundedButton(button5, 3);
            UIhelper.MakeRoundedButton(button4, 3);
            UIhelper.MakeRoundedButton(button3, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToDaftarUnit(object sender, EventArgs e)
        {

        }

        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            this.Hide();
            DaftarUnit_Umum daftarunit = new DaftarUnit_Umum();
            daftarunit.ShowDialog();
            this.Show();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            this.Hide();
            PengajuanSewa_Umum pengajuansewaum = new PengajuanSewa_Umum();
            pengajuansewaum.ShowDialog();
            this.Show();
        }
    }
}
