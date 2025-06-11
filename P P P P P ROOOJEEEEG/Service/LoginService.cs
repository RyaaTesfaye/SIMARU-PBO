// File: RUSUNAWAAA.Service/LoginService.cs
using RUSUNAWAAA.View.Login;
using System;
using System.Windows.Forms;

namespace RUSUNAWAAA.Service
{
    public class LoginService
    {
        private Form _parentForm;
        private Panel _targetPanel;
        private UserControl _currentActiveUserControl = null;

        public event EventHandler BackToLoginRequested;
        public event EventHandler ResetPasswordCompleted;

        public LoginService(Form parentForm, Panel targetPanel)
        {
            _parentForm = parentForm;
            _targetPanel = targetPanel;
        }

        public void ShowLupaPasswordStep1()
        {
            RemoveCurrentActiveUserControl();

            var ucLupaPasswordStep1 = new Logins_2();
            ucLupaPasswordStep1.BackToLoginRequested += OnBackToLoginRequested;
            ucLupaPasswordStep1.ProceedToNextStepRequested += OnProceedToNextStepRequested;

            _currentActiveUserControl = ucLupaPasswordStep1;
            AddUserControlToPanel(_currentActiveUserControl);
        }

        private void OnProceedToNextStepRequested(object sender, string[] verificationData)
        {
            RemoveCurrentActiveUserControl();

            var ucLupaPasswordStep2 = new Logins_3();
            ucLupaPasswordStep2.BackToLoginRequested += OnBackToLoginRequested;
            ucLupaPasswordStep2.ResetPasswordCompleted += OnResetPasswordCompleted;

            if (verificationData != null && verificationData.Length > 0)
            {
                ucLupaPasswordStep2.SetDataFromPreviousStep(verificationData[0]);
            }
            else
            {
                MessageBox.Show("Data verifikasi tidak lengkap. Kembali ke login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnBackToLoginRequested(this, EventArgs.Empty);
                return;
            }

            _currentActiveUserControl = ucLupaPasswordStep2;
            AddUserControlToPanel(_currentActiveUserControl);
        }

        private void OnResetPasswordCompleted(object sender, EventArgs e)
        {
            RemoveCurrentActiveUserControl();
            ResetPasswordCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void OnBackToLoginRequested(object sender, EventArgs e)
        {
            RemoveCurrentActiveUserControl();
            BackToLoginRequested?.Invoke(this, EventArgs.Empty);
        }

        private void AddUserControlToPanel(UserControl userControl)
        {
            _parentForm.Controls.Add(userControl);
            userControl.Location = _targetPanel.Location;
            userControl.Size = _targetPanel.Size;
            userControl.BringToFront();
        }

        private void RemoveCurrentActiveUserControl()
        {
            if (_currentActiveUserControl != null)
            {
                _currentActiveUserControl.Dispose();
                _parentForm.Controls.Remove(_currentActiveUserControl);
                _currentActiveUserControl = null;
            }
        }

        public void ClearActiveUserControl()
        {
            RemoveCurrentActiveUserControl();
        }
    }
}