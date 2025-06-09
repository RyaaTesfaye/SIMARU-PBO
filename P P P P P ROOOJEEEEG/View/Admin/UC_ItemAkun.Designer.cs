namespace RUSUNAWAAA.View.Admin
{
    partial class UC_ItemAkun
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
            label23 = new Label();
            chkPilih = new CheckBox();
            lblFakultas = new Label();
            lblNIM = new Label();
            lblNomorHP = new Label();
            lblNamaLengkap = new Label();
            lblNomorKTPIsi = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(139, 140, 142);
            label23.Location = new Point(865, 11);
            label23.Name = "label23";
            label23.Size = new Size(70, 24);
            label23.TabIndex = 55;
            label23.Text = "99 Hari";
            // 
            // chkPilih
            // 
            chkPilih.BackColor = Color.Transparent;
            chkPilih.ForeColor = SystemColors.ButtonHighlight;
            chkPilih.Location = new Point(28, 11);
            chkPilih.Name = "chkPilih";
            chkPilih.Size = new Size(23, 24);
            chkPilih.TabIndex = 54;
            chkPilih.Text = "checkBox22";
            chkPilih.UseVisualStyleBackColor = false;
            // 
            // lblFakultas
            // 
            lblFakultas.AutoSize = true;
            lblFakultas.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFakultas.ForeColor = Color.FromArgb(139, 140, 142);
            lblFakultas.Location = new Point(531, 11);
            lblFakultas.Name = "lblFakultas";
            lblFakultas.Size = new Size(128, 24);
            lblFakultas.TabIndex = 53;
            lblFakultas.Text = "Ilmu Komputer";
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIM.ForeColor = Color.FromArgb(139, 140, 142);
            lblNIM.Location = new Point(700, 11);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(134, 24);
            lblNIM.TabIndex = 52;
            lblNIM.Text = "242410103082";
            // 
            // lblNomorHP
            // 
            lblNomorHP.AutoSize = true;
            lblNomorHP.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorHP.ForeColor = Color.FromArgb(139, 140, 142);
            lblNomorHP.Location = new Point(360, 11);
            lblNomorHP.Name = "lblNomorHP";
            lblNomorHP.Size = new Size(134, 24);
            lblNomorHP.TabIndex = 51;
            lblNomorHP.Text = "082141404209";
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaLengkap.ForeColor = Color.FromArgb(139, 140, 142);
            lblNamaLengkap.Location = new Point(142, 11);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(198, 24);
            lblNamaLengkap.TabIndex = 50;
            lblNamaLengkap.Text = "Aditiya Rifki Arya Putra";
            // 
            // lblNomorKTPIsi
            // 
            lblNomorKTPIsi.AutoSize = true;
            lblNomorKTPIsi.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorKTPIsi.ForeColor = Color.FromArgb(139, 140, 142);
            lblNomorKTPIsi.Location = new Point(57, 11);
            lblNomorKTPIsi.Name = "lblNomorKTPIsi";
            lblNomorKTPIsi.Size = new Size(39, 24);
            lblNomorKTPIsi.TabIndex = 49;
            lblNomorKTPIsi.Text = "001";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 100, 236);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(994, 7);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 56;
            button1.Text = "Detail";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDetail_Click;
            // 
            // UC_ItemAkun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(button1);
            Controls.Add(label23);
            Controls.Add(chkPilih);
            Controls.Add(lblFakultas);
            Controls.Add(lblNIM);
            Controls.Add(lblNomorHP);
            Controls.Add(lblNamaLengkap);
            Controls.Add(lblNomorKTPIsi);
            Name = "UC_ItemAkun";
            Size = new Size(1153, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label23;
        private CheckBox chkPilih;
        private Label lblFakultas;
        private Label lblNIM;
        private Label lblNomorHP;
        private Label lblNamaLengkap;
        private Label lblNomorKTPIsi;
        private Button button1;
    }
}
