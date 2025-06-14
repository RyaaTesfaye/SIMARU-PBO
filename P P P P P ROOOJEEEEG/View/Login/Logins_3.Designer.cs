namespace RUSUNAWAAA.View.Login
{
    partial class Logins_3
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
            panel15 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            textPassword = new TextBox();
            label1 = new Label();
            textConfirmPassword = new TextBox();
            label6 = new Label();
            linkLabel3 = new LinkLabel();
            panel1 = new Panel();
            button4 = new Button();
            panel15.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Controls.Add(label3);
            panel15.Controls.Add(label2);
            panel15.Controls.Add(label5);
            panel15.Controls.Add(textPassword);
            panel15.Controls.Add(label1);
            panel15.Controls.Add(textConfirmPassword);
            panel15.Controls.Add(label6);
            panel15.Controls.Add(linkLabel3);
            panel15.Controls.Add(panel1);
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(539, 615);
            panel15.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 570);
            label3.Name = "label3";
            label3.Size = new Size(129, 16);
            label3.TabIndex = 23;
            label3.Text = "Kembali ke halaman";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(383, 49);
            label2.TabIndex = 22;
            label2.Text = "Pastikan kata sandi mengandung huruf besar, huruf kecil, angka, dan karakter khusus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(180, 24);
            label5.Name = "label5";
            label5.Size = new Size(168, 24);
            label5.TabIndex = 21;
            label5.Text = "Reset Kata Sandi";
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Font = new Font("Segoe UI", 10F);
            textPassword.Location = new Point(53, 221);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Kata Sandi";
            textPassword.Size = new Size(445, 30);
            textPassword.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 183);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 19;
            label1.Text = "Masukkan sandi Anda";
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            textConfirmPassword.Font = new Font("Segoe UI", 10F);
            textConfirmPassword.Location = new Point(53, 327);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PlaceholderText = "Kata Sandi";
            textConfirmPassword.Size = new Size(445, 30);
            textConfirmPassword.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 290);
            label6.Name = "label6";
            label6.Size = new Size(192, 18);
            label6.TabIndex = 17;
            label6.Text = "Masukkan ulang sandi Anda";
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.DarkOrchid;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkArea = new LinkArea(0, 60);
            linkLabel3.LinkColor = Color.FromArgb(60, 138, 255);
            linkLabel3.Location = new Point(130, 571);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(38, 20);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Login";
            linkLabel3.UseCompatibleTextRendering = true;
            linkLabel3.Click += btnKembali_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 54);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 100, 236);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(46, 0);
            button4.Name = "button4";
            button4.Size = new Size(451, 54);
            button4.TabIndex = 1;
            button4.Text = "Konfirmasi";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnResetPasswordFinal_Click;
            // 
            // Logins_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel15);
            Name = "Logins_3";
            Size = new Size(539, 615);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private TextBox textPassword;
        private Label label1;
        private TextBox textConfirmPassword;
        private Label label6;
        private LinkLabel linkLabel3;
        private Panel panel1;
        private Button button4;
        private Label label2;
        private Label label5;
        private Label label3;
    }
}
