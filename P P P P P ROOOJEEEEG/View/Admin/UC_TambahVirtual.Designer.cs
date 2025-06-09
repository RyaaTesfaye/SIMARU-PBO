namespace RUSUNAWAAA.View.Admin
{
    partial class UC_TambahVirtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TambahVirtual));
            btn_fotoktp = new Button();
            text_path = new TextBox();
            label10 = new Label();
            txtNama = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ofdPilihFile = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_fotoktp
            // 
            btn_fotoktp.BackColor = Color.LightGray;
            btn_fotoktp.Cursor = Cursors.Hand;
            btn_fotoktp.FlatAppearance.BorderSize = 2;
            btn_fotoktp.FlatStyle = FlatStyle.Flat;
            btn_fotoktp.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fotoktp.ForeColor = Color.Black;
            btn_fotoktp.Location = new Point(85, 310);
            btn_fotoktp.Name = "btn_fotoktp";
            btn_fotoktp.Size = new Size(61, 32);
            btn_fotoktp.TabIndex = 31;
            btn_fotoktp.Text = "Pilih File";
            btn_fotoktp.UseVisualStyleBackColor = false;
            btn_fotoktp.Click += btnPilihFile_Click;
            // 
            // text_path
            // 
            text_path.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_path.Location = new Point(161, 310);
            text_path.Name = "text_path";
            text_path.ReadOnly = true;
            text_path.Size = new Size(239, 32);
            text_path.TabIndex = 30;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(81, 283);
            label10.Name = "label10";
            label10.Size = new Size(127, 24);
            label10.TabIndex = 29;
            label10.Text = "Unggah Media";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(88, 378);
            txtNama.Name = "txtNama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(316, 32);
            txtNama.TabIndex = 33;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(88, 350);
            label9.Name = "label9";
            label9.Size = new Size(135, 24);
            label9.TabIndex = 32;
            label9.Text = "Nama File";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(88, 456);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Keterangan";
            textBox1.Size = new Size(316, 32);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 428);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 34;
            label1.Text = "Keterangan";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 100, 236);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(161, 540);
            button4.Name = "button4";
            button4.Size = new Size(156, 34);
            button4.TabIndex = 36;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(85, 60);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(331, 220);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 15F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(117, 21);
            label7.Name = "label7";
            label7.Size = new Size(266, 36);
            label7.TabIndex = 39;
            label7.Text = "Tambah Virtual Tour";
            // 
            // ofdPilihFile
            // 
            ofdPilihFile.FileName = "openFileDialog1";
            // 
            // UC_TambahVirtual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtNama);
            Controls.Add(label9);
            Controls.Add(btn_fotoktp);
            Controls.Add(text_path);
            Controls.Add(label10);
            Name = "UC_TambahVirtual";
            Size = new Size(492, 594);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fotoktp;
        private TextBox text_path;
        private Label label10;
        private TextBox txtNama;
        private Label label9;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label label7;
        private OpenFileDialog ofdPilihFile;
    }
}
