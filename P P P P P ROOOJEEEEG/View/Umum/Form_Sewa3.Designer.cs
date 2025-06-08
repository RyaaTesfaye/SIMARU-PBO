namespace RUSUNAWAAA.View.Umum
{
    partial class Form_Sewa3
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
            btn_fotopas = new Button();
            text_pathpasfoto = new TextBox();
            label2 = new Label();
            btn_fotosp = new Button();
            text_pathsp = new TextBox();
            label1 = new Label();
            btn_fotoktp = new Button();
            cmbDurasi = new ComboBox();
            panel13 = new Panel();
            button4 = new Button();
            text_pathktp = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            ofdPilihFile = new OpenFileDialog();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(23, 24, 29);
            panel12.Controls.Add(btn_fotopas);
            panel12.Controls.Add(text_pathpasfoto);
            panel12.Controls.Add(label2);
            panel12.Controls.Add(btn_fotosp);
            panel12.Controls.Add(text_pathsp);
            panel12.Controls.Add(label1);
            panel12.Controls.Add(btn_fotoktp);
            panel12.Controls.Add(cmbDurasi);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(text_pathktp);
            panel12.Controls.Add(label10);
            panel12.Controls.Add(label9);
            panel12.Controls.Add(label8);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(464, 597);
            panel12.TabIndex = 3;
            // 
            // btn_fotopas
            // 
            btn_fotopas.BackColor = Color.LightGray;
            btn_fotopas.Cursor = Cursors.Hand;
            btn_fotopas.FlatAppearance.BorderSize = 2;
            btn_fotopas.FlatStyle = FlatStyle.Flat;
            btn_fotopas.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fotopas.ForeColor = Color.Black;
            btn_fotopas.Location = new Point(74, 410);
            btn_fotopas.Name = "btn_fotopas";
            btn_fotopas.Size = new Size(61, 32);
            btn_fotopas.TabIndex = 34;
            btn_fotopas.Text = "Pilih File";
            btn_fotopas.UseVisualStyleBackColor = false;
            btn_fotopas.Click += btn_fotopas_Click;
            // 
            // text_pathpasfoto
            // 
            text_pathpasfoto.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_pathpasfoto.Location = new Point(150, 410);
            text_pathpasfoto.Name = "text_pathpasfoto";
            text_pathpasfoto.ReadOnly = true;
            text_pathpasfoto.Size = new Size(239, 32);
            text_pathpasfoto.TabIndex = 33;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter", 8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 383);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 32;
            label2.Text = "Unggah Pas Foto";
            // 
            // btn_fotosp
            // 
            btn_fotosp.BackColor = Color.LightGray;
            btn_fotosp.Cursor = Cursors.Hand;
            btn_fotosp.FlatAppearance.BorderSize = 2;
            btn_fotosp.FlatStyle = FlatStyle.Flat;
            btn_fotosp.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fotosp.ForeColor = Color.Black;
            btn_fotosp.Location = new Point(74, 322);
            btn_fotosp.Name = "btn_fotosp";
            btn_fotosp.Size = new Size(61, 32);
            btn_fotosp.TabIndex = 31;
            btn_fotosp.Text = "Pilih File";
            btn_fotosp.UseVisualStyleBackColor = false;
            btn_fotosp.Click += btn_fotosp_Click;
            // 
            // text_pathsp
            // 
            text_pathsp.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_pathsp.Location = new Point(150, 322);
            text_pathsp.Name = "text_pathsp";
            text_pathsp.ReadOnly = true;
            text_pathsp.Size = new Size(239, 32);
            text_pathsp.TabIndex = 30;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 295);
            label1.Name = "label1";
            label1.Size = new Size(267, 24);
            label1.TabIndex = 29;
            label1.Text = "Unggah Surat Pernyataan (Wajib PDF)";
            // 
            // btn_fotoktp
            // 
            btn_fotoktp.BackColor = Color.LightGray;
            btn_fotoktp.Cursor = Cursors.Hand;
            btn_fotoktp.FlatAppearance.BorderSize = 2;
            btn_fotoktp.FlatStyle = FlatStyle.Flat;
            btn_fotoktp.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fotoktp.ForeColor = Color.Black;
            btn_fotoktp.Location = new Point(74, 229);
            btn_fotoktp.Name = "btn_fotoktp";
            btn_fotoktp.Size = new Size(61, 32);
            btn_fotoktp.TabIndex = 28;
            btn_fotoktp.Text = "Pilih File";
            btn_fotoktp.UseVisualStyleBackColor = false;
            btn_fotoktp.Click += btn_fotoktp_Click;
            // 
            // cmbDurasi
            // 
            cmbDurasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurasi.DropDownWidth = 200;
            cmbDurasi.Font = new Font("Inter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDurasi.FormattingEnabled = true;
            cmbDurasi.Items.AddRange(new object[] { "3", "6", "9", "12" });
            cmbDurasi.Location = new Point(70, 125);
            cmbDurasi.Name = "cmbDurasi";
            cmbDurasi.Size = new Size(316, 32);
            cmbDurasi.TabIndex = 27;
            // 
            // panel13
            // 
            panel13.Controls.Add(button4);
            panel13.Location = new Point(0, 515);
            panel13.Name = "panel13";
            panel13.Size = new Size(461, 57);
            panel13.TabIndex = 26;
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
            button4.Text = "Lanjut";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnLanjut3_Click;
            // 
            // text_pathktp
            // 
            text_pathktp.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_pathktp.Location = new Point(150, 229);
            text_pathktp.Name = "text_pathktp";
            text_pathktp.ReadOnly = true;
            text_pathktp.Size = new Size(239, 32);
            text_pathktp.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(70, 202);
            label10.Name = "label10";
            label10.Size = new Size(127, 24);
            label10.TabIndex = 18;
            label10.Text = "Unggah Foto Ktp";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(70, 97);
            label9.Name = "label9";
            label9.Size = new Size(199, 24);
            label9.TabIndex = 16;
            label9.Text = "Pilih Durasi Penyewaan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(100, 24);
            label8.Name = "label8";
            label8.Size = new Size(286, 36);
            label8.TabIndex = 6;
            label8.Text = "Form Pengajuan sewa";
            // 
            // ofdPilihFile
            // 
            ofdPilihFile.FileName = "openFileDialog1";
            // 
            // Form_Sewa3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel12);
            Name = "Form_Sewa3";
            Size = new Size(464, 597);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel12;
        private ComboBox cmbDurasi;
        private Panel panel13;
        private Button button4;
        private TextBox text_pathktp;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btn_fotoktp;
        private Button btn_fotopas;
        private TextBox text_pathpasfoto;
        private Label label2;
        private Button btn_fotosp;
        private TextBox text_pathsp;
        private Label label1;
        private OpenFileDialog ofdPilihFile;
    }
}
