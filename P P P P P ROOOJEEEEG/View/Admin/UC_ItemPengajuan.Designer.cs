namespace RUSUNAWAAA.View.Admin
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
            label_TanggalPengajuan = new Label();
            label_Fakultas = new Label();
            label_DurasiSewa = new Label();
            label_NoHp = new Label();
            label_Nama = new Label();
            label_Id = new Label();
            btn_detail = new Button();
            SuspendLayout();
            // 
            // label_TanggalPengajuan
            // 
            label_TanggalPengajuan.AutoSize = true;
            label_TanggalPengajuan.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TanggalPengajuan.ForeColor = Color.FromArgb(139, 140, 142);
            label_TanggalPengajuan.Location = new Point(834, 11);
            label_TanggalPengajuan.Name = "label_TanggalPengajuan";
            label_TanggalPengajuan.Size = new Size(109, 24);
            label_TanggalPengajuan.TabIndex = 53;
            label_TanggalPengajuan.Text = "18 Mei 2025";
            // 
            // label_Fakultas
            // 
            label_Fakultas.AutoSize = true;
            label_Fakultas.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Fakultas.ForeColor = Color.FromArgb(139, 140, 142);
            label_Fakultas.Location = new Point(500, 11);
            label_Fakultas.Name = "label_Fakultas";
            label_Fakultas.Size = new Size(128, 24);
            label_Fakultas.TabIndex = 52;
            label_Fakultas.Text = "Ilmu Komputer";
            // 
            // label_DurasiSewa
            // 
            label_DurasiSewa.AutoSize = true;
            label_DurasiSewa.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DurasiSewa.ForeColor = Color.FromArgb(139, 140, 142);
            label_DurasiSewa.Location = new Point(669, 11);
            label_DurasiSewa.Name = "label_DurasiSewa";
            label_DurasiSewa.Size = new Size(70, 24);
            label_DurasiSewa.TabIndex = 51;
            label_DurasiSewa.Text = "3 Bulan";
            // 
            // label_NoHp
            // 
            label_NoHp.AutoSize = true;
            label_NoHp.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NoHp.ForeColor = Color.FromArgb(139, 140, 142);
            label_NoHp.Location = new Point(329, 11);
            label_NoHp.Name = "label_NoHp";
            label_NoHp.Size = new Size(134, 24);
            label_NoHp.TabIndex = 50;
            label_NoHp.Text = "082141404209";
            // 
            // label_Nama
            // 
            label_Nama.AutoSize = true;
            label_Nama.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Nama.ForeColor = Color.FromArgb(139, 140, 142);
            label_Nama.Location = new Point(111, 11);
            label_Nama.Name = "label_Nama";
            label_Nama.Size = new Size(198, 24);
            label_Nama.TabIndex = 49;
            label_Nama.Text = "Aditiya Rifki Arya Putra";
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Id.ForeColor = Color.FromArgb(139, 140, 142);
            label_Id.Location = new Point(26, 11);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(39, 24);
            label_Id.TabIndex = 48;
            label_Id.Text = "001";
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.FromArgb(10, 100, 236);
            btn_detail.Cursor = Cursors.Hand;
            btn_detail.FlatAppearance.BorderSize = 0;
            btn_detail.FlatStyle = FlatStyle.Flat;
            btn_detail.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detail.ForeColor = Color.White;
            btn_detail.Location = new Point(1024, 11);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(90, 28);
            btn_detail.TabIndex = 54;
            btn_detail.Text = "Detail";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detailClick;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TanggalPengajuan;
        private Label label_Fakultas;
        private Label label_DurasiSewa;
        private Label label_NoHp;
        private Label label_Nama;
        private Label label_Id;
        private Button btn_detail;
    }
}
