namespace RUSUNAWAAA.View.Admin
{
    partial class UC_DetailKeluhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DetailKeluhan));
            panel15 = new Panel();
            pictureKeluhan = new PictureBox();
            txtIsiKeluhan = new Label();
            lblTanggal = new Label();
            lblNama = new Label();
            panel23 = new Panel();
            btnTangani = new Button();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeluhan).BeginInit();
            panel23.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(23, 24, 30);
            panel15.Controls.Add(pictureKeluhan);
            panel15.Controls.Add(txtIsiKeluhan);
            panel15.Controls.Add(lblTanggal);
            panel15.Controls.Add(lblNama);
            panel15.Controls.Add(panel23);
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(492, 556);
            panel15.TabIndex = 8;
            // 
            // pictureKeluhan
            // 
            pictureKeluhan.ErrorImage = null;
            pictureKeluhan.Image = (Image)resources.GetObject("pictureKeluhan.Image");
            pictureKeluhan.Location = new Point(23, 36);
            pictureKeluhan.Name = "pictureKeluhan";
            pictureKeluhan.Size = new Size(445, 215);
            pictureKeluhan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureKeluhan.TabIndex = 11;
            pictureKeluhan.TabStop = false;
            // 
            // txtIsiKeluhan
            // 
            txtIsiKeluhan.Font = new Font("Inter", 9F);
            txtIsiKeluhan.ForeColor = Color.White;
            txtIsiKeluhan.Location = new Point(23, 279);
            txtIsiKeluhan.Name = "txtIsiKeluhan";
            txtIsiKeluhan.Size = new Size(445, 190);
            txtIsiKeluhan.TabIndex = 10;
            txtIsiKeluhan.Text = resources.GetString("txtIsiKeluhan.Text");
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.FromArgb(139, 140, 142);
            lblTanggal.Location = new Point(23, 255);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(121, 24);
            lblTanggal.TabIndex = 9;
            lblTanggal.Text = "28 April 2025";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Inter", 10F, FontStyle.Bold);
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(154, 9);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(201, 24);
            lblNama.TabIndex = 8;
            lblNama.Text = "Ahmad Fajarudin Dzox";
            // 
            // panel23
            // 
            panel23.BackColor = Color.Transparent;
            panel23.Controls.Add(btnTangani);
            panel23.Location = new Point(119, 492);
            panel23.Name = "panel23";
            panel23.Size = new Size(220, 45);
            panel23.TabIndex = 5;
            // 
            // btnTangani
            // 
            btnTangani.BackColor = Color.FromArgb(10, 100, 236);
            btnTangani.Cursor = Cursors.Hand;
            btnTangani.FlatAppearance.BorderSize = 0;
            btnTangani.FlatStyle = FlatStyle.Flat;
            btnTangani.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTangani.ForeColor = Color.White;
            btnTangani.Location = new Point(25, 3);
            btnTangani.Name = "btnTangani";
            btnTangani.Size = new Size(171, 39);
            btnTangani.TabIndex = 0;
            btnTangani.Text = "Tangani";
            btnTangani.UseVisualStyleBackColor = false;
            btnTangani.Click += btnTangani_Click;
            // 
            // UC_DetailKeluhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 30);
            Controls.Add(panel15);
            Name = "UC_DetailKeluhan";
            Size = new Size(492, 556);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeluhan).EndInit();
            panel23.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private PictureBox pictureKeluhan;
        private Label txtIsiKeluhan;
        private Label lblTanggal;
        private Label lblNama;
        private Panel panel23;
        private Button btnTangani;
    }
}
