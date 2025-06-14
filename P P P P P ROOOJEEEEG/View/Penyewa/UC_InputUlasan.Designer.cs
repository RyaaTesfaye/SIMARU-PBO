namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_InputUlasan
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
            btnPilihFile = new Button();
            cmbRating = new ComboBox();
            txtPathGambar = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtKomentar = new TextBox();
            label1 = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            ofdPilihFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnPilihFile
            // 
            btnPilihFile.BackColor = Color.LightGray;
            btnPilihFile.Cursor = Cursors.Hand;
            btnPilihFile.FlatAppearance.BorderSize = 2;
            btnPilihFile.FlatStyle = FlatStyle.Flat;
            btnPilihFile.Font = new Font("Inter", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPilihFile.ForeColor = Color.Black;
            btnPilihFile.Location = new Point(102, 247);
            btnPilihFile.Name = "btnPilihFile";
            btnPilihFile.Size = new Size(61, 32);
            btnPilihFile.TabIndex = 33;
            btnPilihFile.Text = "Pilih File";
            btnPilihFile.UseVisualStyleBackColor = false;
            btnPilihFile.Click += BtnPilihFile_Click;
            // 
            // cmbRating
            // 
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.DropDownWidth = 200;
            cmbRating.Font = new Font("Inter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbRating.Location = new Point(101, 143);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(337, 32);
            cmbRating.TabIndex = 32;
            // 
            // txtPathGambar
            // 
            txtPathGambar.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPathGambar.Location = new Point(180, 247);
            txtPathGambar.Name = "txtPathGambar";
            txtPathGambar.ReadOnly = true;
            txtPathGambar.Size = new Size(257, 32);
            txtPathGambar.TabIndex = 31;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(101, 220);
            label10.Name = "label10";
            label10.Size = new Size(127, 24);
            label10.TabIndex = 30;
            label10.Text = "Masukkan Foto";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Inter", 8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(101, 115);
            label9.Name = "label9";
            label9.Size = new Size(199, 24);
            label9.TabIndex = 29;
            label9.Text = "Pilih Bintang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 19F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(101, 23);
            label8.Name = "label8";
            label8.Size = new Size(337, 45);
            label8.TabIndex = 34;
            label8.Text = "RATING RUSUNAWA";
            // 
            // txtKomentar
            // 
            txtKomentar.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKomentar.Location = new Point(103, 333);
            txtKomentar.Multiline = true;
            txtKomentar.Name = "txtKomentar";
            txtKomentar.PlaceholderText = "Klik Untuk Memberikan komentar";
            txtKomentar.Size = new Size(333, 132);
            txtKomentar.TabIndex = 44;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 305);
            label1.Name = "label1";
            label1.Size = new Size(242, 24);
            label1.TabIndex = 43;
            label1.Text = "Komentar";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(101, 524);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(142, 34);
            btnBatal.TabIndex = 46;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += BtnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(10, 100, 236);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(292, 524);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(144, 34);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += BtnSimpan_Click;
            // 
            // ofdPilihFile
            // 
            ofdPilihFile.FileName = "openFileDialog1";
            // 
            // UC_InputUlasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtKomentar);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(btnPilihFile);
            Controls.Add(cmbRating);
            Controls.Add(txtPathGambar);
            Controls.Add(label10);
            Controls.Add(label9);
            Name = "UC_InputUlasan";
            Size = new Size(548, 607);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPilihFile;
        private ComboBox cmbRating;
        private TextBox txtPathGambar;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtKomentar;
        private Label label1;
        private Button btnBatal;
        private Button btnSimpan;
        private OpenFileDialog ofdPilihFile;
    }
}
