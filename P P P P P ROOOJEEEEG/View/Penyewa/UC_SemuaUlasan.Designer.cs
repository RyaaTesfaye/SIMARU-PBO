namespace RUSUNAWAAA.View.Penyewa
{
    partial class UC_SemuaUlasan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SemuaUlasan));
            panel9 = new Panel();
            flowLayoutPanelSemuaUlasan = new FlowLayoutPanel();
            btnKembali = new PictureBox();
            pictureBox45 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            pictureBox28 = new PictureBox();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(23, 24, 29);
            panel9.Controls.Add(flowLayoutPanelSemuaUlasan);
            panel9.Controls.Add(btnKembali);
            panel9.Controls.Add(pictureBox45);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(pictureBox28);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(50);
            panel9.Size = new Size(1165, 662);
            panel9.TabIndex = 7;
            // 
            // flowLayoutPanelSemuaUlasan
            // 
            flowLayoutPanelSemuaUlasan.Location = new Point(29, 64);
            flowLayoutPanelSemuaUlasan.Name = "flowLayoutPanelSemuaUlasan";
            flowLayoutPanelSemuaUlasan.Size = new Size(1113, 560);
            flowLayoutPanelSemuaUlasan.TabIndex = 30;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.Cursor = Cursors.Hand;
            btnKembali.Image = (Image)resources.GetObject("btnKembali.Image");
            btnKembali.Location = new Point(14, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(52, 22);
            btnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKembali.TabIndex = 29;
            btnKembali.TabStop = false;
            btnKembali.Click += BtnKembali_Click;
            // 
            // pictureBox45
            // 
            pictureBox45.BackColor = Color.Transparent;
            pictureBox45.Cursor = Cursors.Hand;
            pictureBox45.Image = (Image)resources.GetObject("pictureBox45.Image");
            pictureBox45.Location = new Point(649, 630);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(52, 22);
            pictureBox45.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox45.TabIndex = 28;
            pictureBox45.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Inter", 8.3F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(522, 630);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 24;
            label4.Text = "Halaman 1 dari 1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(456, 11);
            label6.Name = "label6";
            label6.Size = new Size(244, 45);
            label6.TabIndex = 12;
            label6.Text = "Semua Ulasan";
            // 
            // pictureBox28
            // 
            pictureBox28.BackColor = Color.Transparent;
            pictureBox28.Cursor = Cursors.Hand;
            pictureBox28.Image = (Image)resources.GetObject("pictureBox28.Image");
            pictureBox28.Location = new Point(466, 630);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(52, 22);
            pictureBox28.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox28.TabIndex = 21;
            pictureBox28.TabStop = false;
            // 
            // UC_SemuaUlasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Name = "UC_SemuaUlasan";
            Size = new Size(1165, 662);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private PictureBox btnKembali;
        private PictureBox pictureBox45;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox28;
        private FlowLayoutPanel flowLayoutPanelSemuaUlasan;
    }
}
