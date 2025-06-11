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
using PenyewaModel = RUSUNAWAAA.Models.Penyewa;

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_ItemAkun: UserControl
    {
        public event EventHandler<string> DetailButtonClicked;
        public bool IsChecked => chkPilih.Checked;
        public PenyewaModel PenyewaData { get; private set; }
        public string NomorKTP => PenyewaData?.NomorKTP;
        public UC_ItemAkun()
        {
            InitializeComponent();
        }
        public void SetData(PenyewaModel data)
        {
            this.PenyewaData = data;

            lblNomorHP.Text = data.NomorHP;
            lblNamaLengkap.Text = data.NamaLengkap;
            lblNIM.Text = data.Username;
            lblFakultas.Text = data.Fakultas;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            // Kirim sinyal "DetailButtonClicked" keluar, beserta NomorKTP dari penyewa ini
            if (PenyewaData != null)
            {
                DetailButtonClicked?.Invoke(this, this.PenyewaData.NomorKTP);
            }
        }

    }
}
