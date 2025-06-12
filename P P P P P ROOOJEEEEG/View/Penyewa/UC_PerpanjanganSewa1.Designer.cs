namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_PerpanjanganSewa1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbDurasi = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtBiaya = new TextBox();
            estimasibulan = new Label();
            label2 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            NominalIsi = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDurasi
            // 
            cmbDurasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurasi.DropDownWidth = 200;
            cmbDurasi.Font = new Font("Inter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDurasi.FormattingEnabled = true;
            cmbDurasi.Items.AddRange(new object[] { "3", "6", "9", "12" });
            cmbDurasi.Location = new Point(65, 136);
            cmbDurasi.Name = "cmbDurasi";
            cmbDurasi.Size = new Size(316, 32);
            cmbDurasi.TabIndex = 29;
            cmbDurasi.SelectedIndexChanged += cmbDurasi_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(65, 108);
            label9.Name = "label9";
            label9.Size = new Size(199, 24);
            label9.TabIndex = 28;
            label9.Text = "Pilih Durasi Penyewaan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(88, 26);
            label8.Name = "label8";
            label8.Size = new Size(286, 36);
            label8.TabIndex = 30;
            label8.Text = "Form Pengajuan sewa";
            // 
            // txtBiaya
            // 
            txtBiaya.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBiaya.Location = new Point(65, 248);
            txtBiaya.Name = "txtBiaya";
            txtBiaya.ReadOnly = true;
            txtBiaya.Size = new Size(316, 32);
            txtBiaya.TabIndex = 58;
            // 
            // estimasibulan
            // 
            estimasibulan.BackColor = Color.Transparent;
            estimasibulan.Font = new Font("Inter", 8F);
            estimasibulan.ForeColor = Color.White;
            estimasibulan.Location = new Point(65, 221);
            estimasibulan.Name = "estimasibulan";
            estimasibulan.Size = new Size(316, 24);
            estimasibulan.TabIndex = 57;
            estimasibulan.Text = "Estimasi Biaya untuk X Bulan Sewa";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter", 8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 309);
            label2.Name = "label2";
            label2.Size = new Size(359, 24);
            label2.TabIndex = 69;
            label2.Text = "Silahkan Transfer ke Rekening Berikut:";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Inter", 8F);
            label17.ForeColor = Color.White;
            label17.Location = new Point(234, 343);
            label17.Name = "label17";
            label17.Size = new Size(239, 24);
            label17.TabIndex = 68;
            label17.Text = "BRI";
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Inter", 8F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(234, 393);
            label16.Name = "label16";
            label16.Size = new Size(239, 24);
            label16.TabIndex = 67;
            label16.Text = "351xxxxxxxxxxxx";
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Inter", 8F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(234, 443);
            label15.Name = "label15";
            label15.Size = new Size(239, 24);
            label15.TabIndex = 66;
            label15.Text = "Ahmad Fajarudin DZOX";
            // 
            // NominalIsi
            // 
            NominalIsi.BackColor = Color.Transparent;
            NominalIsi.Font = new Font("Inter", 8F);
            NominalIsi.ForeColor = Color.White;
            NominalIsi.Location = new Point(234, 493);
            NominalIsi.Name = "NominalIsi";
            NominalIsi.Size = new Size(239, 24);
            NominalIsi.TabIndex = 65;
            NominalIsi.Text = "otomatis tergantung pilihan";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Inter", 9F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(65, 393);
            label13.Name = "label13";
            label13.Size = new Size(169, 22);
            label13.TabIndex = 64;
            label13.Text = "No. Rekening               :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Inter", 9F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(65, 493);
            label12.Name = "label12";
            label12.Size = new Size(172, 22);
            label12.TabIndex = 63;
            label12.Text = "Jumlah Nominal           :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Inter", 9F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(65, 443);
            label11.Name = "label11";
            label11.Size = new Size(169, 22);
            label11.TabIndex = 62;
            label11.Text = "Atas Nama                    :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(65, 543);
            label7.Name = "label7";
            label7.Size = new Size(172, 22);
            label7.TabIndex = 61;
            label7.Text = "Keterangan Transfer   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 343);
            label3.Name = "label3";
            label3.Size = new Size(169, 22);
            label3.TabIndex = 60;
            label3.Text = "Bank                              :";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 543);
            label1.Name = "label1";
            label1.Size = new Size(239, 24);
            label1.TabIndex = 59;
            label1.Text = "Sertakan nama dan nomor HP ";
            // 
            // UC_PerpanjanganSewa1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(label2);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(NominalIsi);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtBiaya);
            Controls.Add(estimasibulan);
            Controls.Add(label8);
            Controls.Add(cmbDurasi);
            Controls.Add(label9);
            Name = "UC_PerpanjanganSewa1";
            Size = new Size(464, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDurasi;
        private Label label9;
        private Label label8;
        private TextBox txtBiaya;
        private Label estimasibulan;
        private Label label2;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label NominalIsi;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label3;
        private Label label1;
    }
}
