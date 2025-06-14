namespace RUSUNAWAAA.View.Admin
{
    partial class UC_ItemKeluhan
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
            lblTanggal = new Label();
            lblJudul = new Label();
            lblNama = new Label();
            lblID = new Label();
            Detail = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.FromArgb(139, 140, 142);
            lblTanggal.Location = new Point(668, 11);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(109, 24);
            lblTanggal.TabIndex = 55;
            lblTanggal.Text = "18 Mei 2025";
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(139, 140, 142);
            lblJudul.Location = new Point(387, 11);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(275, 24);
            lblJudul.TabIndex = 54;
            lblJudul.Text = "082141404209";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.FromArgb(139, 140, 142);
            lblNama.Location = new Point(142, 11);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(198, 24);
            lblNama.TabIndex = 53;
            lblNama.Text = "Aditiya Rifki Arya Putra";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.FromArgb(139, 140, 142);
            lblID.Location = new Point(54, 11);
            lblID.Name = "lblID";
            lblID.Size = new Size(39, 24);
            lblID.TabIndex = 52;
            lblID.Text = "001";
            // 
            // Detail
            // 
            Detail.BackColor = Color.FromArgb(10, 100, 236);
            Detail.Cursor = Cursors.Hand;
            Detail.FlatAppearance.BorderSize = 0;
            Detail.FlatStyle = FlatStyle.Flat;
            Detail.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Detail.ForeColor = Color.White;
            Detail.Location = new Point(1024, 11);
            Detail.Name = "Detail";
            Detail.Size = new Size(90, 28);
            Detail.TabIndex = 57;
            Detail.Text = "Detail";
            Detail.UseVisualStyleBackColor = false;
            Detail.Click += btnDetail_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(139, 140, 142);
            lblStatus.Location = new Point(850, 11);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(109, 24);
            lblStatus.TabIndex = 58;
            lblStatus.Text = "18 Mei 2025";
            // 
            // UC_ItemKeluhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(lblStatus);
            Controls.Add(Detail);
            Controls.Add(lblTanggal);
            Controls.Add(lblJudul);
            Controls.Add(lblNama);
            Controls.Add(lblID);
            Name = "UC_ItemKeluhan";
            Size = new Size(1153, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox13;
        private Label lblTanggal;
        private Label lblJudul;
        private Label lblNama;
        private Label lblID;
        private Button Detail;
        private Label lblStatus;
    }
}
