using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using Microsoft.EntityFrameworkCore;
using RUSUNAWAAA.View.Admin; // Diperlukan untuk UC_ItemKelolaAturan

namespace RUSUNAWAAA.Service
{
    public class AturanService
    {
        private readonly Panel _targetPanel; // Panel di form utama tempat UC akan ditambahkan
        private List<TataTertib> _semuaTatatertibs; // Semua data dari DB (internal service)

        public AturanService(Panel targetPanel)
        {
            _targetPanel = targetPanel;
            LoadAllTatatertibs(); // Muat data awal saat service diinisialisasi
        }

        private void LoadAllTatatertibs()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    _semuaTatatertibs = context.TataTertibs.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat tata tertib. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _semuaTatatertibs = new List<TataTertib>();
            }
        }

        public List<TataTertib> GetAllAturan()
        {
            LoadAllTatatertibs(); // Pastikan data terbaru dimuat
            return _semuaTatatertibs;
        }

        public void DisplayAllItemsOnPanel(List<TataTertib> itemsToDisplay)
        {
            if (_targetPanel == null)
            {
                MessageBox.Show("Panel target belum diinisialisasi di AturanService. Tidak dapat menampilkan item.", "Error Konfigurasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _targetPanel.Controls.Clear(); // Bersihkan panel

            if (itemsToDisplay != null && itemsToDisplay.Any())
            {
                int yPos = 10;
                for (int i = 0; i < itemsToDisplay.Count; i++)
                {
                    var tataTertib = itemsToDisplay[i];
                    int nomorUrut = i + 1;

                    UC_ItemKelolaAturan item = new UC_ItemKelolaAturan();
                    item.SetData(tataTertib, nomorUrut);
                    item.Location = new System.Drawing.Point(10, yPos);
                    item.Width = _targetPanel.ClientSize.Width - 20;
                    item.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    // FIX: Subscribe to the DeleteClicked event of each UC_ItemKelolaAturan
                    item.DeleteClicked += (s, id) => HandleDeleteRequestFromUI(id);
                    // If you also have an EditClicked event, subscribe it here too:
                    // item.EditClicked += (s, id) => HandleEditRequestFromUI(id);

                    _targetPanel.Controls.Add(item);
                    yPos += item.Height + 5;
                }
            }
            else
            {
                Label noDataLabel = new Label();
                noDataLabel.Text = "Tidak ada tata tertib yang tersedia.";
                noDataLabel.AutoSize = true;
                noDataLabel.Location = new System.Drawing.Point(10, 10);
                _targetPanel.Controls.Add(noDataLabel);
            }
        }

        // --- New method to handle delete requests coming from the UI (UC_ItemKelolaAturan) ---
        private void HandleDeleteRequestFromUI(int idTataTertib)
        {
            // Add a confirmation dialog before deleting
            DialogResult confirmResult = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus aturan ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                bool success = DeleteAturan(idTataTertib); // Call the actual delete method

                if (success)
                {
                    MessageBox.Show("Aturan berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // The LoadAllTatatertibs() and DisplayAllItemsOnPanel() calls inside DeleteAturan
                    // will automatically refresh the display.
                }
                else
                {
                    MessageBox.Show("Gagal menghapus aturan. Aturan tidak ditemukan atau ada masalah.", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // --- CRUD Methods ---
        public bool AddAturan(TataTertib newTataTertib)
        {
            // ... (existing AddAturan logic) ...
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.TataTertibs.Add(newTataTertib);
                    newTataTertib.TanggalUpdate = DateTime.Now;
                    context.SaveChanges();
                    LoadAllTatatertibs();
                    DisplayAllItemsOnPanel(_semuaTatatertibs); // Refresh display
                    return true;
                }
                catch (Exception ex) { MessageBox.Show($"Error adding rule: {ex.Message}", "Error"); return false; }
            }
        }

        public TataTertib GetAturanById(int idAturan)
        {
            // ... (existing GetAturanById logic) ...
            using (var context = new ApplicationDbContext())
            {
                try { return context.TataTertibs.Find(idAturan); }
                catch (Exception ex) { MessageBox.Show($"Error getting rule by ID: {ex.Message}", "Error"); return null; }
            }
        }

        public bool DeleteAturan(int idTataTertib)
        {
            // This method now includes the refresh logic.
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var tataTertibToDelete = context.TataTertibs.Find(idTataTertib);
                    if (tataTertibToDelete == null) return false;
                    context.TataTertibs.Remove(tataTertibToDelete);
                    context.SaveChanges();
                    LoadAllTatatertibs(); // Reload internal data after delete
                    DisplayAllItemsOnPanel(_semuaTatatertibs); // Refresh the UI
                    return true;
                }
                catch (Exception ex) { MessageBox.Show($"Error deleting rule: {ex.Message}", "Error"); return false; }
            }
        }
    }
}