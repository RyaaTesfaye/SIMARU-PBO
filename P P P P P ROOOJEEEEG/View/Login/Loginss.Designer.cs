namespace RUSUNAWAAA.View.Login
{
    partial class Loginss
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel15 = new Panel();
            textUsername = new TextBox();
            label1 = new Label();
            textPassword = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLupaPassword = new LinkLabel();
            panel1 = new Panel();
            btnLogin = new Button();
            panel15.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Controls.Add(textUsername);
            panel15.Controls.Add(label1);
            panel15.Controls.Add(textPassword);
            panel15.Controls.Add(label6);
            panel15.Controls.Add(label5);
            panel15.Controls.Add(label4);
            panel15.Controls.Add(label3);
            panel15.Controls.Add(btnLupaPassword);
            panel15.Controls.Add(panel1);
            panel15.Location = new Point(1016, 134);
            panel15.Margin = new Padding(4);
            panel15.Name = "panel15";
            panel15.Size = new Size(674, 769);
            panel15.TabIndex = 13;
            // 
            // textUsername
            // 
            textUsername.BorderStyle = BorderStyle.FixedSingle;
            textUsername.Font = new Font("Segoe UI", 10F);
            textUsername.Location = new Point(66, 276);
            textUsername.Margin = new Padding(4);
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(556, 34);
            textUsername.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 229);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 22);
            label1.TabIndex = 19;
            label1.Text = "Masukkan Password Anda:";
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Font = new Font("Segoe UI", 10F);
            textPassword.Location = new Point(66, 409);
            textPassword.Margin = new Padding(4);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(556, 34);
            textPassword.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 352);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(230, 22);
            label6.TabIndex = 17;
            label6.Text = "Masukkan Username Anda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 66);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(207, 58);
            label5.TabIndex = 16;
            label5.Text = "MASUK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 15;
            label4.Text = "SIMARU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 26);
            label3.TabIndex = 14;
            label3.Text = "Selamat datang di ";
            // 
            // btnLupaPassword
            // 
            btnLupaPassword.ActiveLinkColor = Color.DarkOrchid;
            btnLupaPassword.AutoSize = true;
            btnLupaPassword.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLupaPassword.LinkArea = new LinkArea(0, 60);
            btnLupaPassword.LinkColor = Color.FromArgb(60, 138, 255);
            btnLupaPassword.Location = new Point(519, 484);
            btnLupaPassword.Margin = new Padding(4, 0, 4, 0);
            btnLupaPassword.Name = "btnLupaPassword";
            btnLupaPassword.Size = new Size(96, 23);
            btnLupaPassword.TabIndex = 13;
            btnLupaPassword.TabStop = true;
            btnLupaPassword.Text = "Lupa Sandi?";
            btnLupaPassword.UseCompatibleTextRendering = true;
            btnLupaPassword.Click += btnLupaPassword_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(0, 622);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 68);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(10, 100, 236);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(58, 0);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(564, 68);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Loginss
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 7, 20);
            BackgroundImage = Properties.Resources.LOGIN2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1778, 1004);
            Controls.Add(panel15);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "Loginss";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loginss";
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private Panel panel1;
        private Button btnLogin;
        private LinkLabel btnLupaPassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textUsername;
        private Label label1;
        private TextBox textPassword;
        private Label label6;
    }
}