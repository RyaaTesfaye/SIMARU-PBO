namespace RUSUNAWAAA.View.Admin
{
    partial class UC_ItemPerpanjangan
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
            btnDetail = new Button();
            label_TanggalPengajuan = new Label();
            label_Status = new Label();
            label_DurasiSewa = new Label();
            label_NoHp = new Label();
            label_Nama = new Label();
            label_Id = new Label();
            SuspendLayout();
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.FromArgb(10, 100, 236);
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.FlatAppearance.BorderSize = 0;
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = Color.White;
            btnDetail.Location = new Point(930, 0);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(72, 33);
            btnDetail.TabIndex = 68;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += BtnDetail_Click;
            // 
            // label_TanggalPengajuan
            // 
            label_TanggalPengajuan.AutoSize = true;
            label_TanggalPengajuan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TanggalPengajuan.ForeColor = Color.FromArgb(139, 140, 142);
            label_TanggalPengajuan.Location = new Point(774, 11);
            label_TanggalPengajuan.Margin = new Padding(2, 0, 2, 0);
            label_TanggalPengajuan.Name = "label_TanggalPengajuan";
            label_TanggalPengajuan.Size = new Size(111, 20);
            label_TanggalPengajuan.TabIndex = 74;
            label_TanggalPengajuan.Text = "18 Mei 2025";
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Status.ForeColor = Color.FromArgb(139, 140, 142);
            label_Status.Location = new Point(507, 11);
            label_Status.Margin = new Padding(2, 0, 2, 0);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(130, 20);
            label_Status.TabIndex = 73;
            label_Status.Text = "Ilmu Komputer";
            // 
            // label_DurasiSewa
            // 
            label_DurasiSewa.AutoSize = true;
            label_DurasiSewa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DurasiSewa.ForeColor = Color.FromArgb(139, 140, 142);
            label_DurasiSewa.Location = new Point(642, 11);
            label_DurasiSewa.Margin = new Padding(2, 0, 2, 0);
            label_DurasiSewa.Name = "label_DurasiSewa";
            label_DurasiSewa.Size = new Size(73, 20);
            label_DurasiSewa.TabIndex = 72;
            label_DurasiSewa.Text = "3 Bulan";
            // 
            // label_NoHp
            // 
            label_NoHp.AutoSize = true;
            label_NoHp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NoHp.ForeColor = Color.FromArgb(139, 140, 142);
            label_NoHp.Location = new Point(370, 11);
            label_NoHp.Margin = new Padding(2, 0, 2, 0);
            label_NoHp.Name = "label_NoHp";
            label_NoHp.Size = new Size(129, 20);
            label_NoHp.TabIndex = 71;
            label_NoHp.Text = "082141404209";
            // 
            // label_Nama
            // 
            label_Nama.AutoSize = true;
            label_Nama.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Nama.ForeColor = Color.FromArgb(139, 140, 142);
            label_Nama.Location = new Point(109, 11);
            label_Nama.Margin = new Padding(2, 0, 2, 0);
            label_Nama.Name = "label_Nama";
            label_Nama.Size = new Size(205, 20);
            label_Nama.TabIndex = 70;
            label_Nama.Text = "Aditiya Rifki Arya Putra";
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Id.ForeColor = Color.FromArgb(139, 140, 142);
            label_Id.Location = new Point(41, 11);
            label_Id.Margin = new Padding(2, 0, 2, 0);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(39, 20);
            label_Id.TabIndex = 69;
            label_Id.Text = "001";
            // 
            // UC_ItemPerpanjangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(btnDetail);
            Controls.Add(label_TanggalPengajuan);
            Controls.Add(label_Status);
            Controls.Add(label_DurasiSewa);
            Controls.Add(label_NoHp);
            Controls.Add(label_Nama);
            Controls.Add(label_Id);
            Name = "UC_ItemPerpanjangan";
            Size = new Size(1153, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetail;
        private Label label_TanggalPengajuan;
        private Label label_Status;
        private Label label_DurasiSewa;
        private Label label_NoHp;
        private Label label_Nama;
        private Label label_Id;
    }
}
