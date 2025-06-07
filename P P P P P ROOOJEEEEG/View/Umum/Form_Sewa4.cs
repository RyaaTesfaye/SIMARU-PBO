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
    public partial class Form_Sewa4 : UserControl
    {
        public event EventHandler GoToNextStep;
        public Form_Sewa4()
        {
            InitializeComponent();
        }

        private void btnLanjut4_Click(object sender, EventArgs e)
        {
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }
    }
}
