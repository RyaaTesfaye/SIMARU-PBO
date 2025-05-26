namespace RUSUNAWAAA
{
    partial class Preview
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
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label3 = new Label();
            linkLabel3 = new LinkLabel();
            panel3 = new Panel();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(108, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 652);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(317, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 339);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 24);
            label5.Name = "label5";
            label5.Size = new Size(266, 31);
            label5.TabIndex = 31;
            label5.Text = "APAKAH ANDA YAKIN ?";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 77);
            label3.Name = "label3";
            label3.Size = new Size(375, 73);
            label3.TabIndex = 30;
            label3.Text = "Jika anda menghapus akun yang telah dipilih, maka akun yang dipilih akan dihapus secara permanen dan tidak dapat dipulihkan lagi!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.DarkOrchid;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Inter", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkArea = new LinkArea(0, 60);
            linkLabel3.LinkColor = Color.FromArgb(60, 138, 255);
            linkLabel3.Location = new Point(207, 287);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(57, 22);
            linkLabel3.TabIndex = 29;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Kembali";
            linkLabel3.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Location = new Point(1, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 54);
            panel3.TabIndex = 28;
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
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = false;
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 803);
            Controls.Add(panel1);
            Name = "Preview";
            Text = "Preview";
            Load += Preview_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label3;
        private LinkLabel linkLabel3;
        private Panel panel3;
        private Button button4;
    }
}