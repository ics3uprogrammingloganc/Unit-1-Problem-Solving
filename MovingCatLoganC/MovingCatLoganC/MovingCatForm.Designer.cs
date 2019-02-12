namespace MovingCatLoganC
{
    partial class frmMovingCat
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
            this.mnuCat = new System.Windows.Forms.MenuStrip();
            this.mniCats = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxCat = new System.Windows.Forms.PictureBox();
            this.mnuCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCat
            // 
            this.mnuCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCats});
            this.mnuCat.Location = new System.Drawing.Point(0, 0);
            this.mnuCat.Name = "mnuCat";
            this.mnuCat.Size = new System.Drawing.Size(268, 24);
            this.mnuCat.TabIndex = 0;
            this.mnuCat.Text = "menuStrip1";
            // 
            // mniCats
            // 
            this.mniCats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCats.Name = "mniCats";
            this.mniCats.Size = new System.Drawing.Size(37, 20);
            this.mniCats.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // pbxCat
            // 
            this.pbxCat.Image = global::MovingCatLoganC.Properties.Resources.cat1;
            this.pbxCat.Location = new System.Drawing.Point(75, 59);
            this.pbxCat.Name = "pbxCat";
            this.pbxCat.Size = new System.Drawing.Size(110, 125);
            this.pbxCat.TabIndex = 1;
            this.pbxCat.TabStop = false;
            this.pbxCat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 248);
            this.Controls.Add(this.pbxCat);
            this.Controls.Add(this.mnuCat);
            this.MainMenuStrip = this.mnuCat;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Logan C";
            this.mnuCat.ResumeLayout(false);
            this.mnuCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCat;
        private System.Windows.Forms.ToolStripMenuItem mniCats;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox pbxCat;
    }
}

