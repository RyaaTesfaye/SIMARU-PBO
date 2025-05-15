namespace RUSUNAWAAA.View.Notif
{
    partial class Notifikasi
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
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.Information;
            pictureBox3.Location = new Point(20, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 4;
            label2.Text = "Ringkasan";
            // 
            // label1
            // 
            label1.Font = new Font("Inter", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(388, 76);
            label1.TabIndex = 5;
            label1.Text = "Alert with title and longer description, lorem ipsum dolor sit amet constrectum adipisicng lorem ipsum dolor sit amet consrectumis adipisingus.";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.close_alert_icon;
            pictureBox1.Location = new Point(471, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Notifikasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 129);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notifikasi";
            Text = "Informasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}