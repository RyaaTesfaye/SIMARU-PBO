﻿namespace RUSUNAWAAA.View.Admin
{
    partial class UC_ItemPengajuan
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
            btn_detail = new Button();
            label_TanggalPengajuan = new Label();
            label_Fakultas = new Label();
            label_DurasiSewa = new Label();
            label_NoHp = new Label();
            label_Nama = new Label();
            label_Id = new Label();
            SuspendLayout();
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.FromArgb(10, 100, 236);
            btn_detail.Cursor = Cursors.Hand;
            btn_detail.FlatAppearance.BorderSize = 0;
            btn_detail.FlatStyle = FlatStyle.Flat;
            btn_detail.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detail.ForeColor = Color.White;
            btn_detail.Location = new Point(940, 5);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(72, 33);
            btn_detail.TabIndex = 54;
            btn_detail.Text = "Detail";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detailClick;
            // 
            // label_TanggalPengajuan
            // 
            label_TanggalPengajuan.AutoSize = true;
            label_TanggalPengajuan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TanggalPengajuan.ForeColor = Color.FromArgb(139, 140, 142);
            label_TanggalPengajuan.Location = new Point(755, 9);
            label_TanggalPengajuan.Margin = new Padding(2, 0, 2, 0);
            label_TanggalPengajuan.Name = "label_TanggalPengajuan";
            label_TanggalPengajuan.Size = new Size(111, 20);
            label_TanggalPengajuan.TabIndex = 67;
            label_TanggalPengajuan.Text = "18 Mei 2025";
            // 
            // label_Fakultas
            // 
            label_Fakultas.AutoSize = true;
            label_Fakultas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Fakultas.ForeColor = Color.FromArgb(139, 140, 142);
            label_Fakultas.Location = new Point(488, 9);
            label_Fakultas.Margin = new Padding(2, 0, 2, 0);
            label_Fakultas.Name = "label_Fakultas";
            label_Fakultas.Size = new Size(130, 20);
            label_Fakultas.TabIndex = 66;
            label_Fakultas.Text = "Ilmu Komputer";
            // 
            // label_DurasiSewa
            // 
            label_DurasiSewa.AutoSize = true;
            label_DurasiSewa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DurasiSewa.ForeColor = Color.FromArgb(139, 140, 142);
            label_DurasiSewa.Location = new Point(623, 9);
            label_DurasiSewa.Margin = new Padding(2, 0, 2, 0);
            label_DurasiSewa.Name = "label_DurasiSewa";
            label_DurasiSewa.Size = new Size(73, 20);
            label_DurasiSewa.TabIndex = 65;
            label_DurasiSewa.Text = "3 Bulan";
            // 
            // label_NoHp
            // 
            label_NoHp.AutoSize = true;
            label_NoHp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NoHp.ForeColor = Color.FromArgb(139, 140, 142);
            label_NoHp.Location = new Point(351, 9);
            label_NoHp.Margin = new Padding(2, 0, 2, 0);
            label_NoHp.Name = "label_NoHp";
            label_NoHp.Size = new Size(129, 20);
            label_NoHp.TabIndex = 64;
            label_NoHp.Text = "082141404209";
            // 
            // label_Nama
            // 
            label_Nama.AutoSize = true;
            label_Nama.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Nama.ForeColor = Color.FromArgb(139, 140, 142);
            label_Nama.Location = new Point(85, 9);
            label_Nama.Margin = new Padding(2, 0, 2, 0);
            label_Nama.Name = "label_Nama";
            label_Nama.Size = new Size(205, 20);
            label_Nama.TabIndex = 63;
            label_Nama.Text = "Aditiya Rifki Arya Putra";
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Id.ForeColor = Color.FromArgb(139, 140, 142);
            label_Id.Location = new Point(17, 9);
            label_Id.Margin = new Padding(2, 0, 2, 0);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(39, 20);
            label_Id.TabIndex = 62;
            label_Id.Text = "001";
            // 
            // UC_ItemPengajuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(btn_detail);
            Controls.Add(label_TanggalPengajuan);
            Controls.Add(label_Fakultas);
            Controls.Add(label_DurasiSewa);
            Controls.Add(label_NoHp);
            Controls.Add(label_Nama);
            Controls.Add(label_Id);
            Name = "UC_ItemPengajuan";
            Size = new Size(1153, 45);
            Load += UC_ItemPengajuan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_detail;
        private Label label_TanggalPengajuan;
        private Label label_Fakultas;
        private Label label_DurasiSewa;
        private Label label_NoHp;
        private Label label_Nama;
        private Label label_Id;
    }
}
