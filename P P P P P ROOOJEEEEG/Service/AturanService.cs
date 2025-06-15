using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;
using Microsoft.EntityFrameworkCore;
using RUSUNAWAAA.View.Admin;

namespace RUSUNAWAAA.Service
{
    public class AturanService
    {
        private readonly Panel _targetPanel;
        private List<TataTertib> _semuaTatatertibs; 

        public AturanService(Panel targetPanel)
        {
            _targetPanel = targetPanel;
            LoadAllTatatertibs(); 
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
            LoadAllTatatertibs(); 
            return _semuaTatatertibs;
        }
        private void OnDeleteClicked(object sender, int id)
        {
            HandleDeleteRequestFromUI(id);
        }

        public void DisplayAllItemsOnPanel(List<TataTertib> itemsToDisplay)
        {
            if (_targetPanel == null)
            {
                MessageBox.Show("Panel target belum diinisialisasi di AturanService. Tidak dapat menampilkan item.", "Error Konfigurasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _targetPanel.Controls.Clear(); 

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

                    
                    item.DeleteClicked += OnDeleteClicked;
                  

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

        
        private void HandleDeleteRequestFromUI(int idTataTertib)
        {
          
            DialogResult confirmResult = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus aturan ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                bool success = DeleteAturan(idTataTertib); 

                if (success)
                {
                    MessageBox.Show("Aturan berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Gagal menghapus aturan. Aturan tidak ditemukan atau ada masalah.", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

      
        public bool AddAturan(TataTertib newTataTertib)
        {
           
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.TataTertibs.Add(newTataTertib);
                    newTataTertib.TanggalUpdate = DateTime.UtcNow;
                    context.SaveChanges();
                    LoadAllTatatertibs();
                    DisplayAllItemsOnPanel(_semuaTatatertibs); 
                    return true;
                }
                catch (Exception ex) { MessageBox.Show($"Error adding rule: {ex.Message}", "Error"); return false; }
            }
        }

        public TataTertib GetAturanById(int idAturan)
        {
          
            using (var context = new ApplicationDbContext())
            {
                try { return context.TataTertibs.Find(idAturan); }
                catch (Exception ex) { MessageBox.Show($"Error getting rule by ID: {ex.Message}", "Error"); return null; }
            }
        }

        public bool DeleteAturan(int idTataTertib)
        {
           
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var tataTertibToDelete = context.TataTertibs.Find(idTataTertib);
                    if (tataTertibToDelete == null) return false;
                    context.TataTertibs.Remove(tataTertibToDelete);
                    context.SaveChanges();
                    LoadAllTatatertibs(); 
                    DisplayAllItemsOnPanel(_semuaTatatertibs); 
                    return true;
                }
                catch (Exception ex) { MessageBox.Show($"Error deleting rule: {ex.Message}", "Error"); return false; }
            }
        }

        public void DisplayItemsOnDataGridView(DataGridView targetDgv, string filterJenisKelamin)
        {
            try
            {
                List<TataTertib> semuaAturan = this.GetAllAturan();

                var filteredList = semuaAturan
                    .Where(a => a.TargetJenisKelamin == "Semua" || a.TargetJenisKelamin == filterJenisKelamin)
                    .ToList();


                targetDgv.Rows.Clear(); 

                if (targetDgv.Columns.Count == 0)
                {
                    targetDgv.AutoGenerateColumns = false;
                    targetDgv.Columns.Add("Nomor", "No.");
                    targetDgv.Columns.Add("Aturan", "Aturan");
                    targetDgv.Columns["Nomor"].Width = 50;
                    targetDgv.Columns["Aturan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    targetDgv.RowHeadersVisible = false;
                    targetDgv.AllowUserToAddRows = false;
                }

                int nomorUrut = 1;
                foreach (var aturan in filteredList)
                {
                    targetDgv.Rows.Add(nomorUrut, aturan.Judul);
                    nomorUrut++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan aturan di tabel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}