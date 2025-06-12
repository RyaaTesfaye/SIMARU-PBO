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
    public partial class UC_ItemVirtualTour: UserControl
    {
        public MediaVirtual MediaData { get; private set; }

        
        public bool IsChecked => chkPilih.Checked;

     
        public int MediaId => MediaData.Id_Media;
        public UC_ItemVirtualTour()
        {
            InitializeComponent();
        }
        public void SetData(MediaVirtual data)
        {
            this.MediaData = data;
            lblIDIsi.Text = data.Id_Media.ToString("D3");
            lblNamaMedia.Text = data.NamaFile;
            lblPath.Text = Path.GetFileName(data.PathMedia); 
            lblKeterangan.Text = data.Keterangan;
        }
    }
}
