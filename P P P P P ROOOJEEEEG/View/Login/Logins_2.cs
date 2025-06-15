using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Service;

namespace RUSUNAWAAA.View.Login
{
    public partial class Logins_2 : UserControl
    {
        public event EventHandler BackToLoginRequested;
        public event EventHandler<string[]> ProceedToNextStepRequested;

        private readonly AuthService _authService = new AuthService(); 

        public Logins_2()
        {
            InitializeComponent();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            string noHp = textNoHP.Text.Trim();
            string username = textUsername.Text.Trim();
            string nik = textNIK.Text.Trim();
            string namaOrangTua = textOrangTua.Text.Trim();

            if (string.IsNullOrWhiteSpace(noHp) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(nik) ||
                string.IsNullOrWhiteSpace(namaOrangTua))
            {
                MessageBox.Show("Semua data (No. HP, Username, NIK, Nama Orang Tua) harus diisi.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool dataExists = _authService.CheckUserAccountDetails(noHp, username, nik, namaOrangTua);

                if (dataExists)
                {
                    MessageBox.Show("Data ditemukan. Silakan lanjutkan untuk mengatur ulang kata sandi Anda.", "Verifikasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProceedToNextStepRequested?.Invoke(this, new string[] { nik });
                }
                else
                {
                    MessageBox.Show("Data yang Anda masukkan tidak cocok dengan catatan kami. Mohon periksa kembali.", "Verifikasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memverifikasi data. \n\nError: " + ex.Message, "Error Verifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            BackToLoginRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}