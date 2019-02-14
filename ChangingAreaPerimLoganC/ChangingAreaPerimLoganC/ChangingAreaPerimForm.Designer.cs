namespace ChangingAreaPerimLoganC
{
    partial class frmChangingAreaPerim
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
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblUnits1 = new System.Windows.Forms.Label();
            this.lblUnits2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(116, 39);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(100, 20);
            this.tbxLength.TabIndex = 0;
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(116, 75);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(100, 20);
            this.tbxWidth.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(312, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 56);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(33, 154);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 24);
            this.lblArea.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(18, 30);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(92, 29);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(30, 66);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(80, 29);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(33, 191);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 24);
            this.lblPerimeter.TabIndex = 7;
            // 
            // lblUnits1
            // 
            this.lblUnits1.AutoSize = true;
            this.lblUnits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits1.Location = new System.Drawing.Point(222, 34);
            this.lblUnits1.Name = "lblUnits1";
            this.lblUnits1.Size = new System.Drawing.Size(38, 25);
            this.lblUnits1.TabIndex = 8;
            this.lblUnits1.Text = "cm";
            // 
            // lblUnits2
            // 
            this.lblUnits2.AutoSize = true;
            this.lblUnits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits2.Location = new System.Drawing.Point(222, 70);
            this.lblUnits2.Name = "lblUnits2";
            this.lblUnits2.Size = new System.Drawing.Size(38, 25);
            this.lblUnits2.TabIndex = 9;
            this.lblUnits2.Text = "cm";
            // 
            // frmChangingAreaPerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 264);
            this.Controls.Add(this.lblUnits2);
            this.Controls.Add(this.lblUnits1);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxLength);
            this.Name = "frmChangingAreaPerim";
            this.Text = "Changing Area and Perimeter by Logan C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblUnits1;
        private System.Windows.Forms.Label lblUnits2;
    }
}

