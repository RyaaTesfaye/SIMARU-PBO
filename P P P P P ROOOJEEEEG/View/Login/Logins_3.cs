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
    public partial class Logins_3 : UserControl
    {
        // Pastikan event ini ada!
        public event EventHandler BackToLoginRequested;
        public event EventHandler ResetPasswordCompleted;

        private readonly AuthService _authService = new AuthService(); // Ini tetap dibutuhkan untuk update password
        private string _usernameOrEmailToReset;

        public Logins_3()
        {
            InitializeComponent();
        }

        public void SetDataFromPreviousStep(string usernameOrangYangMauDireseti)
        {
            _usernameOrEmailToReset = usernameOrangYangMauDireseti;
            // Anda bisa tampilkan _usernameOrEmailToReset di label jika perlu
            // Contoh: lblTargetUser.Text = $"Resetting password for: {_usernameOrEmailToReset}";
        }

        private void btnResetPasswordFinal_Click(object sender, EventArgs e)
        {
            string newPassword = textPassword.Text.Trim();
            string confirmPassword = textConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Kata sandi baru dan konfirmasi tidak boleh kosong.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Kata sandi baru dan konfirmasi tidak cocok.", "Reset Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Kata sandi minimal 6 karakter.", "Reset Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = _authService.UpdatePassword(_usernameOrEmailToReset, newPassword);

                if (success)
                {
                    // Jangan tampilkan MessageBox di sini lagi, biarkan Loginss yang tangani.
                    // MessageBox.Show("Kata sandi Anda berhasil direset! Silakan login dengan kata sandi baru Anda.", "Reset Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetPasswordCompleted?.Invoke(this, EventArgs.Empty); // Memanggil event yang akan ditangkap Loginss
                }
                else
                {
                    MessageBox.Show("Gagal mereset kata sandi. Silakan coba lagi atau hubungi administrator.", "Reset Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mereset kata sandi. \n\nError: " + ex.Message, "Error Reset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            BackToLoginRequested?.Invoke(this, EventArgs.Empty); // Memanggil event yang akan ditangkap Loginss
        }
    }
}