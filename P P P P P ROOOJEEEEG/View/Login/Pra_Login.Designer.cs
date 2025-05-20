namespace RUSUNAWAAA.View.Login
{
    partial class Pra_Login
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
            label3 = new Label();
            linkLabel3 = new LinkLabel();
            panel1 = new Panel();
            button4 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 69);
            label3.Name = "label3";
            label3.Size = new Size(375, 73);
            label3.TabIndex = 26;
            label3.Text = "Silakan masuk ke akun Anda sebagai penyewa untuk mengakses fitur dan layanan yang tersedia bagi penyewa properti";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.DarkOrchid;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Inter", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkArea = new LinkArea(0, 60);
            linkLabel3.LinkColor = Color.FromArgb(60, 138, 255);
            linkLabel3.Location = new Point(148, 282);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(149, 22);
            linkLabel3.TabIndex = 25;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Masuk sebagai umum";
            linkLabel3.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Location = new Point(2, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 54);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 100, 236);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(96, 0);
            button4.Name = "button4";
            button4.Size = new Size(271, 54);
            button4.TabIndex = 1;
            button4.Text = "Masuk";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 17);
            label5.Name = "label5";
            label5.Size = new Size(298, 31);
            label5.TabIndex = 27;
            label5.Text = "Selamat datang di SIMARU";
            // 
            // Pra_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(linkLabel3);
            Controls.Add(panel1);
            Name = "Pra_Login";
            Size = new Size(472, 339);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private LinkLabel linkLabel3;
        private Panel panel1;
        private Button button4;
        private Label label5;
    }
}
