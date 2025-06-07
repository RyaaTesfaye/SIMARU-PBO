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
    public partial class Form_Sewa2 : UserControl
    {
        public event EventHandler GoToNextStep;
        public Form_Sewa2()
        {
            InitializeComponent();
        }

        private void btnLanjut2_Click(object sender, EventArgs e)
        {
            GoToNextStep?.Invoke(this, EventArgs.Empty);
        }
    }
}
