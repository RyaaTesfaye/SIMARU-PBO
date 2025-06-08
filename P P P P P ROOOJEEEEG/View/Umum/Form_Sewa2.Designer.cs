namespace RUSUNAWAAA.View.Umum
{
    partial class Form_Sewa2
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
            txtProdi = new TextBox();
            label14 = new Label();
            txtFakultas = new TextBox();
            label11 = new Label();
            txtNIM = new TextBox();
            label10 = new Label();
            txtOrangTua = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtNomorKTP = new TextBox();
            label1 = new Label();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(23, 24, 29);
            panel12.Controls.Add(txtNomorKTP);
            panel12.Controls.Add(label1);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(txtProdi);
            panel12.Controls.Add(label14);
            panel12.Controls.Add(txtFakultas);
            panel12.Controls.Add(label11);
            panel12.Controls.Add(txtNIM);
            panel12.Controls.Add(label10);
            panel12.Controls.Add(txtOrangTua);
            panel12.Controls.Add(label9);
            panel12.Controls.Add(label8);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(464, 597);
            panel12.TabIndex = 2;
            panel12.Paint += panel12_Paint;
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
            button4.Click += btnLanjut2_Click;
            // 
            // txtProdi
            // 
            txtProdi.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProdi.Location = new Point(70, 358);
            txtProdi.Name = "txtProdi";
            txtProdi.PlaceholderText = "Prodi";
            txtProdi.Size = new Size(316, 32);
            txtProdi.TabIndex = 23;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Inter", 8F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(70, 330);
            label14.Name = "label14";
            label14.Size = new Size(153, 24);
            label14.TabIndex = 22;
            label14.Text = "Masukkan Prodi";
            // 
            // txtFakultas
            // 
            txtFakultas.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFakultas.Location = new Point(70, 282);
            txtFakultas.Name = "txtFakultas";
            txtFakultas.PlaceholderText = "Fakultas";
            txtFakultas.Size = new Size(316, 32);
            txtFakultas.TabIndex = 21;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Inter", 8F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(70, 255);
            label11.Name = "label11";
            label11.Size = new Size(153, 24);
            label11.TabIndex = 20;
            label11.Text = "Masukkan Fakultas";
            // 
            // txtNIM
            // 
            txtNIM.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIM.Location = new Point(70, 210);
            txtNIM.Name = "txtNIM";
            txtNIM.PlaceholderText = "NIM";
            txtNIM.Size = new Size(316, 32);
            txtNIM.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter", 8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(70, 182);
            label10.Name = "label10";
            label10.Size = new Size(113, 24);
            label10.TabIndex = 18;
            label10.Text = "Masukkan NIM";
            // 
            // txtOrangTua
            // 
            txtOrangTua.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrangTua.Location = new Point(70, 125);
            txtOrangTua.Name = "txtOrangTua";
            txtOrangTua.PlaceholderText = "Orang Tua";
            txtOrangTua.Size = new Size(316, 32);
            txtOrangTua.TabIndex = 17;
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
            label9.Text = "Masukkan Nama Orang Tua";
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
            // txtNomorKTP
            // 
            txtNomorKTP.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomorKTP.Location = new Point(70, 438);
            txtNomorKTP.Name = "txtNomorKTP";
            txtNomorKTP.PlaceholderText = "Nomor KTP";
            txtNomorKTP.Size = new Size(316, 32);
            txtNomorKTP.TabIndex = 28;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 410);
            label1.Name = "label1";
            label1.Size = new Size(171, 24);
            label1.TabIndex = 27;
            label1.Text = "Masukkan Nomor KTP";
            // 
            // Form_Sewa2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel12);
            Name = "Form_Sewa2";
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
        private TextBox txtProdi;
        private Label label14;
        private TextBox txtFakultas;
        private Label label11;
        private TextBox txtNIM;
        private Label label10;
        private TextBox txtOrangTua;
        private Label label9;
        private Label label8;
        private TextBox txtNomorKTP;
        private Label label1;
    }
}
