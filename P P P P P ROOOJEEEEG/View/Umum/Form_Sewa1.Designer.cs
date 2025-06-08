namespace RUSUNAWAAA.View.Umum
{
    partial class Form_Sewa1
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
            panel13 = new Panel();
            button4 = new Button();
            radioPerempuan = new RadioButton();
            radioLakiLaki = new RadioButton();
            txtNomorHP = new TextBox();
            label14 = new Label();
            txtAsalKota = new TextBox();
            label11 = new Label();
            txtAlamat = new TextBox();
            label10 = new Label();
            txtNama = new TextBox();
            label9 = new Label();
            label8 = new Label();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(radioPerempuan);
            panel12.Controls.Add(radioLakiLaki);
            panel12.Controls.Add(txtNomorHP);
            panel12.Controls.Add(label14);
            panel12.Controls.Add(txtAsalKota);
            panel12.Controls.Add(label11);
            panel12.Controls.Add(txtAlamat);
            panel12.Controls.Add(label10);
            panel12.Controls.Add(txtNama);
            panel12.Controls.Add(label9);
            panel12.Controls.Add(label8);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(464, 597);
            panel12.TabIndex = 2;
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
            button4.Text = "Ajukan Sewa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnLanjut1_Click;
            // 
            // radioPerempuan
            // 
            radioPerempuan.AutoSize = true;
            radioPerempuan.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioPerempuan.ForeColor = Color.White;
            radioPerempuan.Location = new Point(170, 464);
            radioPerempuan.Name = "radioPerempuan";
            radioPerempuan.Size = new Size(113, 26);
            radioPerempuan.TabIndex = 25;
            radioPerempuan.TabStop = true;
            radioPerempuan.Text = "Perempuan";
            radioPerempuan.UseVisualStyleBackColor = true;
            // 
            // radioLakiLaki
            // 
            radioLakiLaki.AutoSize = true;
            radioLakiLaki.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioLakiLaki.ForeColor = Color.White;
            radioLakiLaki.Location = new Point(70, 463);
            radioLakiLaki.Name = "radioLakiLaki";
            radioLakiLaki.Size = new Size(90, 26);
            radioLakiLaki.TabIndex = 24;
            radioLakiLaki.TabStop = true;
            radioLakiLaki.Text = "Laki-laki";
            radioLakiLaki.UseVisualStyleBackColor = true;
            // 
            // txtNomorHP
            // 
            txtNomorHP.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomorHP.Location = new Point(70, 417);
            txtNomorHP.Name = "txtNomorHP";
            txtNomorHP.PlaceholderText = "Nomor HP";
            txtNomorHP.Size = new Size(316, 32);
            txtNomorHP.TabIndex = 23;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Inter", 8F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(70, 389);
            label14.Name = "label14";
            label14.Size = new Size(153, 24);
            label14.TabIndex = 22;
            label14.Text = "Masukkan Nomor HP";
            // 
            // txtAsalKota
            // 
            txtAsalKota.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsalKota.Location = new Point(70, 328);
            txtAsalKota.Name = "txtAsalKota";
            txtAsalKota.PlaceholderText = "Asal kota";
            txtAsalKota.Size = new Size(316, 32);
            txtAsalKota.TabIndex = 21;
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
            label11.Text = "Masukkan Asal Kota";
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAlamat.Location = new Point(70, 230);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = "Alamat";
            txtAlamat.Size = new Size(316, 32);
            txtAlamat.TabIndex = 19;
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
            label10.Text = "Masukkan Alamat";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(70, 125);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(316, 32);
            txtNama.TabIndex = 17;
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
            label9.Text = "Masukkan Nama";
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
            // Form_Sewa1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(panel12);
            Name = "Form_Sewa1";
            Size = new Size(464, 597);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel12;
        private Panel panel13;
        private Button button4;
        private RadioButton radioPerempuan;
        private RadioButton radioLakiLaki;
        private TextBox txtNomorHP;
        private Label label14;
        private TextBox txtAsalKota;
        private Label label11;
        private TextBox txtAlamat;
        private Label label10;
        private TextBox txtNama;
        private Label label9;
        private Label label8;
    }
}
