namespace RUSUNAWAAA.View.Admin
{
    partial class UC_ItemKelolaAturan
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
            btn_Delete = new Button();
            label_TataTertib = new Label();
            label_ID = new Label();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Red;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(1262, 11);
            btn_Delete.Margin = new Padding(4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 35);
            btn_Delete.TabIndex = 45;
            btn_Delete.Text = "Hapus";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_deleteClick;
            // 
            // label_TataTertib
            // 
            label_TataTertib.AutoSize = true;
            label_TataTertib.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TataTertib.ForeColor = Color.FromArgb(139, 140, 142);
            label_TataTertib.Location = new Point(171, 14);
            label_TataTertib.Margin = new Padding(4, 0, 4, 0);
            label_TataTertib.Name = "label_TataTertib";
            label_TataTertib.Size = new Size(444, 25);
            label_TataTertib.TabIndex = 44;
            label_TataTertib.Text = "Penjual galon dilarang masuk Rusunawi Putri";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ID.ForeColor = Color.FromArgb(139, 140, 142);
            label_ID.Location = new Point(73, 16);
            label_ID.Margin = new Padding(4, 0, 4, 0);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(48, 25);
            label_ID.TabIndex = 43;
            label_ID.Text = "001";
            // 
            // UC_ItemKelolaAturan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            Controls.Add(btn_Delete);
            Controls.Add(label_TataTertib);
            Controls.Add(label_ID);
            Name = "UC_ItemKelolaAturan";
            Size = new Size(1388, 56);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Id;
        private Button btn_Delete;
        private Label label_TataTertib;
        private Label label_ID;
    }
}
