namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_ItemRIwayatLapor
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
            lblStatus = new Label();
            lblTanggal = new Label();
            lblJudul = new Label();
            lblID = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(139, 140, 142);
            lblStatus.Location = new Point(835, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(109, 24);
            lblStatus.TabIndex = 64;
            lblStatus.Text = "18 Mei 2025";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.FromArgb(139, 140, 142);
            lblTanggal.Location = new Point(665, 8);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(109, 24);
            lblTanggal.TabIndex = 62;
            lblTanggal.Text = "18 Mei 2025";
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(139, 140, 142);
            lblJudul.Location = new Point(181, 8);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(465, 24);
            lblJudul.TabIndex = 61;
            lblJudul.Text = "082141404209";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.FromArgb(139, 140, 142);
            lblID.Location = new Point(42, 8);
            lblID.Name = "lblID";
            lblID.Size = new Size(39, 24);
            lblID.TabIndex = 59;
            lblID.Text = "001";
            // 
            // UC_ItemRIwayatLapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(lblStatus);
            Controls.Add(lblTanggal);
            Controls.Add(lblJudul);
            Controls.Add(lblID);
            Name = "UC_ItemRIwayatLapor";
            Size = new Size(1153, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblTanggal;
        private Label lblJudul;
        private Label lblID;
    }
}
