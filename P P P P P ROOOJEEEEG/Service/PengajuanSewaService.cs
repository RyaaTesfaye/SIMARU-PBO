using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RUSUNAWAAA.Models;
using RUSUNAWAAA.View.Umum;
using RusunawaApp.Data;
using RUSUNAWAAA.View.Admin;

namespace RUSUNAWAAA.Service
{
    class PengajuanSewaService
    {
        private readonly Panel _contentPanel;
        private readonly PictureBox _backButton;
        private readonly Stack<UserControl> _navigationHistory = new Stack<UserControl>();
        private readonly Pengajuan _dataPengajuan = new Pengajuan();

        public PengajuanSewaService()
        {
        }
        public PengajuanSewaService(Panel contentPanel, PictureBox backButton)
        {
            _contentPanel = contentPanel;
            _backButton = backButton;
        }
        private void HitungEstimasiBiaya()
        {
            decimal hargaPerBulan = 100000;
            _dataPengajuan.EstimasiBiaya = _dataPengajuan.DurasiSewa * hargaPerBulan;
        }
        public void Start()
        {
            NavigateTo(new Form_Sewa1(), true);
        }
        public void GoBack()
        {
            if (_navigationHistory.Count > 0)
            {
                var currentUc = _contentPanel.Controls.OfType<UserControl>().FirstOrDefault();
                UnsubscribeFromEvents(currentUc);

                var previousUc = _navigationHistory.Pop();
                SubscribeToEvents(previousUc);

                LoadDataForUc(previousUc);

                _contentPanel.Controls.Clear();
                previousUc.Location = new Point(21, 18);
                _contentPanel.Controls.Add(previousUc);
                _backButton.Visible = _navigationHistory.Count > 0;
            }
        }
        private void HandleNextStep(object sender, EventArgs e)
        {
            var currentUc = sender as UserControl;
            // Panggil SimpanData untuk UC yang sekarang
            if (currentUc is Form_Sewa1 s1) s1.SimpanData(_dataPengajuan);
            if (currentUc is Form_Sewa2 s2) s2.SimpanData(_dataPengajuan);
            if (currentUc is Form_Sewa3 s3)
            {
                s3.SimpanData(_dataPengajuan);
                HitungEstimasiBiaya();
            }

            // Tentukan UC berikutnya
            UserControl nextUc = null;
            if (sender is Form_Sewa1) nextUc = new Form_Sewa2();
            else if (sender is Form_Sewa2) nextUc = new Form_Sewa3();
            else if (sender is Form_Sewa3) nextUc = new Form_Sewa4();
            else if (sender is Form_Sewa4) nextUc = new Form_Sewa5();
            else if (sender is Form_Sewa5) nextUc = new Form_Sewa6();

            if (nextUc != null) NavigateTo(nextUc);
        }
        private void HandleFinish(object sender, EventArgs e)
        {
            if (sender is Form_Sewa6 s6) s6.SimpanData(_dataPengajuan);

            _dataPengajuan.TanggalPengajuan = DateTime.UtcNow;
            _dataPengajuan.Status = "Menunggu Verifikasi";

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Pengajuans.Add(_dataPengajuan);
                    context.SaveChanges();
                }
                MessageBox.Show("Pengajuan berhasil dikirim!", "Sukses");
                Form formWizard = _contentPanel.FindForm();
                if (formWizard != null)
                {
                    Dashboard_umum formDashboard = new Dashboard_umum();
                    formDashboard.FormClosed += (s, args) => formWizard.Close();
                    formWizard.Hide();
                }
            }
            catch (Exception ex)
            {
                // Variabel untuk menyimpan pesan error yang paling detail
                string errorMessage = ex.Message;

                // Cek apakah ada "inner exception"
                if (ex.InnerException != null)
                {
                    // Ambil pesan error dari level yang lebih dalam, ini yang paling penting!
                    errorMessage += "\n\nInner Exception:\n" + ex.InnerException.Message;
                }

                // Tampilkan pesan error yang sudah lengkap
                MessageBox.Show("Gagal menyimpan data ke database.\n\n" + errorMessage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NavigateTo(UserControl newUc, bool isFirstPage = false)
        {
            if (!isFirstPage)
            {
                var currentUc = _contentPanel.Controls.OfType<UserControl>().FirstOrDefault();
                if (currentUc != null)
                {
                    _navigationHistory.Push(currentUc);
                    UnsubscribeFromEvents(currentUc);
                }
            }

            SubscribeToEvents(newUc);
            LoadDataForUc(newUc);

            _contentPanel.Controls.Clear();
            newUc.Location = new Point(21, 18);
            _contentPanel.Controls.Add(newUc);
            _backButton.Visible = _navigationHistory.Count > 0;
        }
        private void LoadDataForUc(UserControl uc)
        {
            if (uc is Form_Sewa1 s1) s1.MuatData(_dataPengajuan);
            if (uc is Form_Sewa2 s2) s2.MuatData(_dataPengajuan);
            if (uc is Form_Sewa3 s3) s3.MuatData(_dataPengajuan);
            if (uc is Form_Sewa4 s4) s4.MuatData(_dataPengajuan);
            if (uc is Form_Sewa5 s5) s5.MuatData(_dataPengajuan);
            if (uc is Form_Sewa6 s6) s6.MuatData(_dataPengajuan);
        }
        private void SubscribeToEvents(UserControl uc)
        {
            if (uc is Form_Sewa1 s1) s1.GoToNextStep += HandleNextStep;
            else if (uc is Form_Sewa2 s2) s2.GoToNextStep += HandleNextStep;
            else if (uc is Form_Sewa3 s3) s3.GoToNextStep += HandleNextStep;
            else if (uc is Form_Sewa4 s4) s4.GoToNextStep += HandleNextStep;
            else if (uc is Form_Sewa5 s5) s5.GoToNextStep += HandleNextStep;
            else if (uc is Form_Sewa6 s6) s6.FinishClicked += HandleFinish;
        }

        private void UnsubscribeFromEvents(UserControl uc)
        {
            if (uc is Form_Sewa1 s1) s1.GoToNextStep -= HandleNextStep;
            else if (uc is Form_Sewa2 s2) s2.GoToNextStep -= HandleNextStep;
            else if (uc is Form_Sewa3 s3) s3.GoToNextStep -= HandleNextStep;
            else if (uc is Form_Sewa4 s4) s4.GoToNextStep -= HandleNextStep;
            else if (uc is Form_Sewa5 s5) s5.GoToNextStep -= HandleNextStep;
            else if (uc is Form_Sewa6 s6) s6.FinishClicked -= HandleFinish;
        }

        //===========================Admin==============================
        public List<Pengajuan> GetAllPendingApplications()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Pengajuans
                              .Where(p => p.Status == "Menunggu Verifikasi")
                              .ToList();
            }
        }
        public List<PerpanjanganSewa> GetAllPerpanjangan()
        {
            // Untuk saat ini, kita kembalikan daftar kosong.
            // Nanti, Anda akan isi ini dengan logika dari database.
            return new List<PerpanjanganSewa>();
        }
        public Pengajuan GetPengajuanById(int pengajuanId)
        {
            using (var context = new ApplicationDbContext())
            {
                // FindAsync adalah cara paling efisien untuk mencari berdasarkan Primary Key
                return context.Pengajuans.Find(pengajuanId);
            }
        }
        public bool ApprovePengajuan(int pengajuanId)
        {
            using (var context = new ApplicationDbContext())
            {
                var pengajuan = context.Pengajuans.Find(pengajuanId);
                if (pengajuan == null) return false;

                var newPenyewa = new Penyewa
                {
                    NomorKTP = pengajuan.NomorKTP,
                    NamaLengkap = pengajuan.NamaLengkap,
                    Username = pengajuan.NIM,
                    Password = GenerateRandomPassword(),
                    Role = "Penyewa",

                    // Pindahkan data spesifik lainnya
                    AlamatAsal = pengajuan.AlamatAsal,
                    NomorHP = pengajuan.NomorHP,
                    Fakultas = pengajuan.Fakultas,
                    Prodi = pengajuan.Prodi,
                    JenisKelamin = pengajuan.JenisKelamin,
                    AsalKota = pengajuan.AsalKota,
                    NamaOrangTua = pengajuan.NamaOrangTua,
                    NIM = pengajuan.NIM
                 
                    
                };
                context.Users.Add(newPenyewa);

                pengajuan.Status = "Disetujui";

                context.SaveChanges();
                return true;
            }
        }
        private string GenerateRandomPassword(int length = 8)
        {
            return System.IO.Path.GetRandomFileName().Replace(".", "").Substring(0, length);
        }

        public bool RejectPengajuan(int pengajuanId, string alasan)
        {
            using (var context = new ApplicationDbContext())
            {
                var pengajuan = context.Pengajuans.Find(pengajuanId);
                if (pengajuan == null) return false;

                pengajuan.Status = $"Ditolak - {alasan}";
                context.SaveChanges();
                return true;
            }
        }
    }
}
