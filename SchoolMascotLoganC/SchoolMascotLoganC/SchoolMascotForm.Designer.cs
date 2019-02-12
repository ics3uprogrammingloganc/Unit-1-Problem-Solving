namespace SchoolMascotLoganC
{
    partial class frmSchoolMascot
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
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSacred = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.mnuSchools.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(487, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStMarks,
            this.mniSacred,
            this.mniTeresa});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(157, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniStMarks
            // 
            this.mniStMarks.Name = "mniStMarks";
            this.mniStMarks.Size = new System.Drawing.Size(157, 22);
            this.mniStMarks.Text = "St Marks";
            this.mniStMarks.Click += new System.EventHandler(this.mniStMarks_Click);
            // 
            // mniSacred
            // 
            this.mniSacred.Name = "mniSacred";
            this.mniSacred.Size = new System.Drawing.Size(157, 22);
            this.mniSacred.Text = "Sacred Heart";
            this.mniSacred.Click += new System.EventHandler(this.mniSacred_Click);
            // 
            // mniTeresa
            // 
            this.mniTeresa.Name = "mniTeresa";
            this.mniTeresa.Size = new System.Drawing.Size(157, 22);
            this.mniTeresa.Text = "Mother Theresa";
            this.mniTeresa.Click += new System.EventHandler(this.mniTeresa_Click);
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascot);
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Location = new System.Drawing.Point(41, 50);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(390, 155);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Racer", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(54, 81);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(132, 30);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Text = "Saints";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Impact", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(51, 30);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(257, 59);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Immaculata";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 267);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Logan C";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStMarks;
        private System.Windows.Forms.ToolStripMenuItem mniSacred;
        private System.Windows.Forms.ToolStripMenuItem mniTeresa;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchoolName;
    }
}

