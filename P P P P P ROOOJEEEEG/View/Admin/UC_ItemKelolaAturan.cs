using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models; // Memastikan model TataTertib dapat diakses

namespace RUSUNAWAAA.View.Admin
{
    public partial class UC_ItemKelolaAturan : UserControl
    {
        // AturanId sekarang merujuk ke Id_Tatatertib
        public int AturanId { get; private set; }

        // Event yang akan dipicu ketika tombol HAPUS diklik
        public event EventHandler<int> DeleteClicked;

        // Event BARU yang akan dipicu ketika tombol DETAIL/EDIT diklik (jika ada)
        public event EventHandler<int> UpdateClicked; // Pastikan ini juga ada jika Anda menggunakannya

        public UC_ItemKelolaAturan()
        {
            InitializeComponent();
        }

        // Menerima objek TataTertib, bukan Aturan
public void SetData(TataTertib data, int nomorUrut)
        {
            this.AturanId = data.Id_Tatatertib; // Menyimpan Id_Tatatertib ke properti AturanId
            
            // Ini yang Anda inginkan: label_ID menampilkan nomor urut, bukan ID asli
            label_ID.Text = nomorUrut.ToString(); 
            
            label_TataTertib.Text = data.Judul; // Menampilkan Judul
            
            // Jika ada label lain, gunakan data dari objek TataTertib
            // if (label_TanggalUpdate != null) label_TanggalUpdate.Text = data.TanggalUpdate.ToShortDateString();
            // if (label_JenisK != null) label_JenisK.Text = data.TargetJenisKelamin;
        }


        // Event handler untuk tombol HAPUS (btn_Delete di gambar)
        private void btn_deleteClick(object sender, EventArgs e) // Sesuaikan dengan nama event handler di designer untuk tombol "Hapus"
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus aturan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, this.AturanId); // Memicu event DeleteClicked dengan Id_Tatatertib
            }
        }

        // Jika Anda memiliki tombol Update/Edit terpisah (misalnya btn_detail di designer Anda)
        // private void btn_updateClick(object sender, EventArgs e) // Sesuaikan dengan nama event handler di designer
        // {
        //     UpdateClicked?.Invoke(this, this.AturanId); // Memicu event UpdateClicked dengan Id_Tatatertib
        // }
    }
}