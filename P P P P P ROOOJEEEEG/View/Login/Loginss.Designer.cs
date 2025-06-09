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
            txtUsername = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            panel15.Controls.Add(txtUsername);
            panel15.Controls.Add(label1);
            panel15.Controls.Add(textBox1);
            panel15.Controls.Add(label6);
            panel15.Controls.Add(label5);
            panel15.Controls.Add(label4);
            panel15.Controls.Add(label3);
            panel15.Controls.Add(linkLabel3);
            panel15.Controls.Add(panel1);
            panel15.Location = new Point(813, 107);
            panel15.Name = "panel15";
            panel15.Size = new Size(539, 615);
            panel15.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(53, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(445, 30);
            txtUsername.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 183);
            label1.Name = "label1";
            label1.Size = new Size(200, 22);
            label1.TabIndex = 19;
            label1.Text = "Masukkan Password Anda:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(53, 327);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(445, 30);
            textBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 282);
            label6.Name = "label6";
            label6.Size = new Size(203, 22);
            label6.TabIndex = 17;
            label6.Text = "Masukkan Username Anda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 53);
            label5.Name = "label5";
            label5.Size = new Size(185, 61);
            label5.TabIndex = 16;
            label5.Text = "MASUK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 26);
            label4.Name = "label4";
            label4.Size = new Size(87, 27);
            label4.TabIndex = 15;
            label4.Text = "SIMARU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 26);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 14;
            label3.Text = "Selamat datang di ";
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.DarkOrchid;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkArea = new LinkArea(0, 60);
            linkLabel3.LinkColor = Color.FromArgb(60, 138, 255);
            linkLabel3.Location = new Point(415, 387);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(82, 21);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Lupa Sandi?";
            linkLabel3.UseCompatibleTextRendering = true;
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
            button4.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(46, 0);
            button4.Name = "button4";
            button4.Size = new Size(451, 54);
            button4.TabIndex = 1;
            button4.Text = "Masuk";
            button4.UseVisualStyleBackColor = false;
            // 
            // Loginss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 7, 20);
            BackgroundImage = Properties.Resources.LOGIN2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 803);
            Controls.Add(panel15);
            DoubleBuffered = true;
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
        private Button button4;
        private LinkLabel linkLabel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtUsername;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
    }
}