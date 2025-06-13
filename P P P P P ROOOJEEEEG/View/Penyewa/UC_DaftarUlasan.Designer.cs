namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_DaftarUlasan
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
            lblJumlahUlasan = new Label();
            linkLihatSemua = new Label();
            label9 = new Label();
            label8 = new Label();
            flowLayoutPanelUlasan = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblJumlahUlasan
            // 
            lblJumlahUlasan.BackColor = Color.Transparent;
            lblJumlahUlasan.Font = new Font("Inter", 9F);
            lblJumlahUlasan.ForeColor = Color.White;
            lblJumlahUlasan.Location = new Point(24, 182);
            lblJumlahUlasan.Name = "lblJumlahUlasan";
            lblJumlahUlasan.Size = new Size(231, 36);
            lblJumlahUlasan.TabIndex = 30;
            lblJumlahUlasan.Text = "2.000+ ulasan dari penghuni ";
            lblJumlahUlasan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLihatSemua
            // 
            linkLihatSemua.BackColor = Color.Transparent;
            linkLihatSemua.Font = new Font("Inter", 9F);
            linkLihatSemua.ForeColor = Color.White;
            linkLihatSemua.Location = new Point(340, 188);
            linkLihatSemua.Name = "linkLihatSemua";
            linkLihatSemua.Size = new Size(163, 25);
            linkLihatSemua.TabIndex = 29;
            linkLihatSemua.Text = "Lihat Semua Ulasan >";
            linkLihatSemua.TextAlign = ContentAlignment.MiddleCenter;
            linkLihatSemua.Click += LinkLihatSemua_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(39, 75);
            label9.Name = "label9";
            label9.Size = new Size(479, 77);
            label9.TabIndex = 28;
            label9.Text = "“Temukan pendapat asli para penghuni mengenai kenyamanan, fasilitas, dan layanan di Rusunawa Universitas Jember.”";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 19F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(154, 19);
            label8.Name = "label8";
            label8.Size = new Size(260, 45);
            label8.TabIndex = 27;
            label8.Text = "Ulasan Terbaru";
            // 
            // flowLayoutPanelUlasan
            // 
            flowLayoutPanelUlasan.Location = new Point(24, 245);
            flowLayoutPanelUlasan.Name = "flowLayoutPanelUlasan";
            flowLayoutPanelUlasan.Size = new Size(509, 359);
            flowLayoutPanelUlasan.TabIndex = 31;
            // 
            // UC_DaftarUlasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(flowLayoutPanelUlasan);
            Controls.Add(lblJumlahUlasan);
            Controls.Add(linkLihatSemua);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "UC_DaftarUlasan";
            Size = new Size(548, 607);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblJumlahUlasan;
        private Label linkLihatSemua;
        private Label label9;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanelUlasan;
    }
}
