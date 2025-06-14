namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_PerpanjanganSewa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PerpanjanganSewa2));
            gambar_bp = new PictureBox();
            btn_fotobayar = new Button();
            panel13 = new Panel();
            button4 = new Button();
            txt_pathbp = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            ofdPilihFile = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)gambar_bp).BeginInit();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // gambar_bp
            // 
            gambar_bp.Image = (Image)resources.GetObject("gambar_bp.Image");
            gambar_bp.Location = new Point(130, 206);
            gambar_bp.Name = "gambar_bp";
            gambar_bp.Size = new Size(210, 280);
            gambar_bp.SizeMode = PictureBoxSizeMode.StretchImage;
            gambar_bp.TabIndex = 36;
            gambar_bp.TabStop = false;
            // 
            // btn_fotobayar
            // 
            btn_fotobayar.BackColor = Color.LightGray;
            btn_fotobayar.Cursor = Cursors.Hand;
            btn_fotobayar.FlatAppearance.BorderSize = 2;
            btn_fotobayar.FlatStyle = FlatStyle.Flat;
            btn_fotobayar.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fotobayar.ForeColor = Color.Black;
            btn_fotobayar.Location = new Point(72, 125);
            btn_fotobayar.Name = "btn_fotobayar";
            btn_fotobayar.Size = new Size(61, 32);
            btn_fotobayar.TabIndex = 35;
            btn_fotobayar.Text = "Pilih File";
            btn_fotobayar.UseVisualStyleBackColor = false;
            btn_fotobayar.Click += btnPilihFile_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(button4);
            panel13.Location = new Point(2, 515);
            panel13.Name = "panel13";
            panel13.Size = new Size(461, 57);
            panel13.TabIndex = 34;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 100, 236);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(48, 0);
            button4.Name = "button4";
            button4.Size = new Size(368, 57);
            button4.TabIndex = 1;
            button4.Text = "Konfirmasi Pembayaran";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnKonfirmasi_Click;
            // 
            // txt_pathbp
            // 
            txt_pathbp.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pathbp.Location = new Point(152, 125);
            txt_pathbp.Name = "txt_pathbp";
            txt_pathbp.ReadOnly = true;
            txt_pathbp.Size = new Size(239, 32);
            txt_pathbp.TabIndex = 33;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(72, 178);
            label10.Name = "label10";
            label10.Size = new Size(79, 24);
            label10.TabIndex = 32;
            label10.Text = "Pratinjau :";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(72, 97);
            label9.Name = "label9";
            label9.Size = new Size(199, 24);
            label9.TabIndex = 31;
            label9.Text = "Unggah Bukti Pembayaran";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(102, 24);
            label8.Name = "label8";
            label8.Size = new Size(286, 36);
            label8.TabIndex = 30;
            label8.Text = "Form Pengajuan sewa";
            // 
            // ofdPilihFile
            // 
            ofdPilihFile.FileName = "openFileDialog1";
            // 
            // UC_PerpanjanganSewa2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(gambar_bp);
            Controls.Add(btn_fotobayar);
            Controls.Add(panel13);
            Controls.Add(txt_pathbp);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "UC_PerpanjanganSewa2";
            Size = new Size(464, 597);
            ((System.ComponentModel.ISupportInitialize)gambar_bp).EndInit();
            panel13.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gambar_bp;
        private Button btn_fotobayar;
        private Panel panel13;
        private Button button4;
        private TextBox txt_pathbp;
        private Label label10;
        private Label label9;
        private Label label8;
        private OpenFileDialog ofdPilihFile;
    }
}
