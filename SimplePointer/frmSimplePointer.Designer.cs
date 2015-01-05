namespace SimplePointer
{
    partial class frmSimplePointer
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
            this.lblCoords = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.lblPointer = new System.Windows.Forms.Label();
            this.pnlPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(31, 9);
            this.lblCoords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(35, 17);
            this.lblCoords.TabIndex = 2;
            this.lblCoords.Text = "(x,y)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(88, 416);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(157, 295);
            this.btnEast.Margin = new System.Windows.Forms.Padding(4);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(44, 28);
            this.btnEast.TabIndex = 22;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(78, 295);
            this.btnWest.Margin = new System.Windows.Forms.Padding(4);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(44, 28);
            this.btnWest.TabIndex = 21;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(117, 331);
            this.btnSouth.Margin = new System.Windows.Forms.Padding(4);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(44, 28);
            this.btnSouth.TabIndex = 20;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(117, 259);
            this.btnNorth.Margin = new System.Windows.Forms.Padding(4);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(44, 28);
            this.btnNorth.TabIndex = 19;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(172, 370);
            this.btnGoTen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(69, 28);
            this.btnGoTen.TabIndex = 18;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(41, 370);
            this.btnGoOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(69, 28);
            this.btnGoOne.TabIndex = 17;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
            // 
            // pnlPosition
            // 
            this.pnlPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPosition.Controls.Add(this.lblPointer);
            this.pnlPosition.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlPosition.Location = new System.Drawing.Point(34, 29);
            this.pnlPosition.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(215, 215);
            this.pnlPosition.TabIndex = 16;
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(2)));
            this.lblPointer.Location = new System.Drawing.Point(84, 88);
            this.lblPointer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(15, 12);
            this.lblPointer.TabIndex = 1;
            this.lblPointer.Text = " ";
            this.lblPointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSimplePointer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.pnlPosition);
            this.Controls.Add(this.lblCoords);
            this.Name = "frmSimplePointer";
            this.Text = "Simple Pointer";
            this.Load += new System.EventHandler(this.frmSimplePointer_Load);
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label lblPointer;
    }
}

