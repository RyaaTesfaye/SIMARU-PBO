// File: RUSUNAWAAA.View.Login/Loginss.cs
using RUSUNAWAAA.Service;
using RUSUNAWAAA.View.Admin;
using RUSUNAWAAA.View.Penyewa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Models;
using RUSUNAWAAA.Utils;


namespace RUSUNAWAAA.View.Login
{
    public partial class Loginss : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly LoginService _loginService;

        public Loginss()
        {
            InitializeComponent();
            _loginService = new LoginService(this, panel15);
            _loginService.BackToLoginRequested += HandleBackToLoginRequest;
            _loginService.ResetPasswordCompleted += Logins_3_ResetPasswordCompleted;

            UIhelper.MakePanelRound(panel15, 20);
            UIhelper.MakeRoundedButton(btnLogin, 10);

            ShowAllLoginControls();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = _authService.Login(username, password);

                if (user != null)
                {
                    SesiLogin.SetLoggedInUser(user);
                    MessageBox.Show($"Selamat datang, {user.NamaLengkap}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    if (user.Role == "Admin")
                    {
                        var dashboardAdmin = new Dashboard_Admin();
                        dashboardAdmin.ShowDialog();
                    }
                    else if (user.Role == "Penyewa")
                    {
                        var dashboardPenyewa = new Dashboard_Penyewa();
                        dashboardPenyewa.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Role pengguna tidak dikenal. Aplikasi akan ditutup.", "Error");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mencoba login. \n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLupaPassword_Click(object sender, EventArgs e)
        {
            HideAllLoginControls();
            _loginService.ShowLupaPasswordStep1();
        }

        private void Logins_3_ResetPasswordCompleted(object sender, EventArgs e)
        {
            RestoreOriginalLoginView();
            MessageBox.Show("Password Anda telah berhasil diatur ulang. Silakan login dengan kata sandi baru Anda.", "Reset Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleBackToLoginRequest(object sender, EventArgs e)
        {
            RestoreOriginalLoginView();
        }

        private void HideAllLoginControls()
        {
            if (textUsername != null) textUsername.Visible = false;
            if (textPassword != null) textPassword.Visible = false;
            if (btnLogin != null) btnLogin.Visible = false;
            if (btnLupaPassword != null) btnLupaPassword.Visible = false;
        }

        private void ShowAllLoginControls()
        {
            if (textUsername != null) textUsername.Visible = true;
            if (textPassword != null) textPassword.Visible = true;
            if (btnLogin != null) btnLogin.Visible = true;
            if (btnLupaPassword != null) btnLupaPassword.Visible = true;
        }

        private void RestoreOriginalLoginView()
        {
            _loginService.ClearActiveUserControl();
            ShowAllLoginControls();
            textUsername.Text = "";
            textPassword.Text = "";
        }
    }
}