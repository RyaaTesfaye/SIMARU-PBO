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
    public partial class UC_ItemKelolaAturan : UserControl
    {
       
        public int AturanId { get; private set; }

        
        public event EventHandler<int> DeleteClicked;

       
        public event EventHandler<int> UpdateClicked; 

        public UC_ItemKelolaAturan()
        {
            InitializeComponent();
        }

      
public void SetData(TataTertib data, int nomorUrut)
        {
            this.AturanId = data.Id_Tatatertib; 
            
           
            label_ID.Text = nomorUrut.ToString(); 
            
            label_TataTertib.Text = data.Judul; 
        }


        
        private void btn_deleteClick(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus aturan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, this.AturanId); 
            }
        }

    }
}