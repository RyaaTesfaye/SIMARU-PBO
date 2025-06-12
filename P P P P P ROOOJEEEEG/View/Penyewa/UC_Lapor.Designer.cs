namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_Lapor
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
            panel12 = new Panel();
            btnPilihGambar = new Button();
            panel13 = new Panel();
            btnKirim = new Button();
            txtIsiKeluhan = new TextBox();
            label11 = new Label();
            txtPathGambar = new TextBox();
            label10 = new Label();
            txtJudul = new TextBox();
            label9 = new Label();
            label8 = new Label();
            ofdPilihFile = new OpenFileDialog();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Controls.Add(btnPilihGambar);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(txtIsiKeluhan);
            panel12.Controls.Add(label11);
            panel12.Controls.Add(txtPathGambar);
            panel12.Controls.Add(label10);
            panel12.Controls.Add(txtJudul);
            panel12.Controls.Add(label9);
            panel12.Controls.Add(label8);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(464, 597);
            panel12.TabIndex = 3;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.BackColor = Color.LightGray;
            btnPilihGambar.Cursor = Cursors.Hand;
            btnPilihGambar.FlatAppearance.BorderSize = 2;
            btnPilihGambar.FlatStyle = FlatStyle.Flat;
            btnPilihGambar.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPilihGambar.ForeColor = Color.Black;
            btnPilihGambar.Location = new Point(70, 230);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(61, 32);
            btnPilihGambar.TabIndex = 29;
            btnPilihGambar.Text = "Pilih File";
            btnPilihGambar.UseVisualStyleBackColor = false;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnKirim);
            panel13.Location = new Point(0, 515);
            panel13.Name = "panel13";
            panel13.Size = new Size(461, 52);
            panel13.TabIndex = 26;
            // 
            // btnKirim
            // 
            btnKirim.BackColor = Color.FromArgb(10, 100, 236);
            btnKirim.Cursor = Cursors.Hand;
            btnKirim.FlatAppearance.BorderSize = 0;
            btnKirim.FlatStyle = FlatStyle.Flat;
            btnKirim.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKirim.ForeColor = Color.White;
            btnKirim.Location = new Point(135, 0);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(192, 49);
            btnKirim.TabIndex = 1;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = false;
            btnKirim.Click += btnKirim_Click;
            // 
            // txtIsiKeluhan
            // 
            txtIsiKeluhan.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIsiKeluhan.Location = new Point(70, 328);
            txtIsiKeluhan.Multiline = true;
            txtIsiKeluhan.Name = "txtIsiKeluhan";
            txtIsiKeluhan.PlaceholderText = "Ketik Pesan";
            txtIsiKeluhan.Size = new Size(316, 164);
            txtIsiKeluhan.TabIndex = 21;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Inter", 8F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(70, 301);
            label11.Name = "label11";
            label11.Size = new Size(153, 24);
            label11.TabIndex = 20;
            label11.Text = "Pesan";
            // 
            // txtPathGambar
            // 
            txtPathGambar.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPathGambar.Location = new Point(146, 230);
            txtPathGambar.Name = "txtPathGambar";
            txtPathGambar.Size = new Size(240, 32);
            txtPathGambar.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(70, 202);
            label10.Name = "label10";
            label10.Size = new Size(135, 24);
            label10.TabIndex = 18;
            label10.Text = "Unggah Foto";
            // 
            // txtJudul
            // 
            txtJudul.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJudul.Location = new Point(70, 125);
            txtJudul.Name = "txtJudul";
            txtJudul.PlaceholderText = "Judul";
            txtJudul.Size = new Size(316, 32);
            txtJudul.TabIndex = 17;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(70, 97);
            label9.Name = "label9";
            label9.Size = new Size(135, 24);
            label9.TabIndex = 16;
            label9.Text = "Judul Masalah";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(135, 25);
            label8.Name = "label8";
            label8.Size = new Size(196, 36);
            label8.TabIndex = 6;
            label8.Text = "Lapor Masalah";
            // 
            // ofdPilihFile
            // 
            ofdPilihFile.FileName = "openFileDialog1";
            // 
            // UC_Lapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 39, 48);
            Controls.Add(panel12);
            Name = "UC_Lapor";
            Size = new Size(464, 597);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel12;
        private Panel panel13;
        private Button btnKirim;
        private TextBox txtIsiKeluhan;
        private Label label11;
        private TextBox txtPathGambar;
        private Label label10;
        private TextBox txtJudul;
        private Label label9;
        private Label label8;
        private Button btnPilihGambar;
        private OpenFileDialog ofdPilihFile;
    }
}
