namespace RUSUNAWAAA.View.Admin
{
    partial class UC_TambahAturan
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
            label7 = new Label();
            txtAturan = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            radioPerempuan = new RadioButton();
            radioLakiLaki = new RadioButton();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 15F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(122, 33);
            label7.Name = "label7";
            label7.Size = new Size(206, 36);
            label7.TabIndex = 40;
            label7.Text = "Tambah Aturan";
            // 
            // txtAturan
            // 
            txtAturan.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAturan.Location = new Point(52, 146);
            txtAturan.Multiline = true;
            txtAturan.Name = "txtAturan";
            txtAturan.PlaceholderText = "Masukkan pesan";
            txtAturan.Size = new Size(382, 281);
            txtAturan.TabIndex = 42;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 118);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 41;
            label1.Text = "Aturan:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 527);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 44;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBatal_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 100, 236);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(256, 527);
            button4.Name = "button4";
            button4.Size = new Size(144, 34);
            button4.TabIndex = 43;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnSimpan_Click;
            // 
            // radioPerempuan
            // 
            radioPerempuan.AutoSize = true;
            radioPerempuan.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioPerempuan.ForeColor = Color.White;
            radioPerempuan.Location = new Point(149, 434);
            radioPerempuan.Name = "radioPerempuan";
            radioPerempuan.Size = new Size(113, 26);
            radioPerempuan.TabIndex = 46;
            radioPerempuan.TabStop = true;
            radioPerempuan.Text = "Perempuan";
            radioPerempuan.UseVisualStyleBackColor = true;
            // 
            // radioLakiLaki
            // 
            radioLakiLaki.AutoSize = true;
            radioLakiLaki.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioLakiLaki.ForeColor = Color.White;
            radioLakiLaki.Location = new Point(49, 433);
            radioLakiLaki.Name = "radioLakiLaki";
            radioLakiLaki.Size = new Size(90, 26);
            radioLakiLaki.TabIndex = 45;
            radioLakiLaki.TabStop = true;
            radioLakiLaki.Text = "Laki-laki";
            radioLakiLaki.UseVisualStyleBackColor = true;
            // 
            // UC_TambahAturan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(radioPerempuan);
            Controls.Add(radioLakiLaki);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(txtAturan);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "UC_TambahAturan";
            Size = new Size(492, 594);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtAturan;
        private Label label1;
        private Button button1;
        private Button button4;
        private RadioButton radioPerempuan;
        private RadioButton radioLakiLaki;
    }
}
