﻿namespace MeteoWF
{
    partial class generateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generateReport));
            this.Reportgeneration = new System.Windows.Forms.Label();
            this.Printbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reportgeneration
            // 
            this.Reportgeneration.AutoSize = true;
            this.Reportgeneration.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportgeneration.Location = new System.Drawing.Point(24, 26);
            this.Reportgeneration.Name = "Reportgeneration";
            this.Reportgeneration.Size = new System.Drawing.Size(586, 30);
            this.Reportgeneration.TabIndex = 2;
            this.Reportgeneration.Text = "Get those statistics with you and print the report!";
            this.Reportgeneration.Click += new System.EventHandler(this.label_Click);
            // 
            // Printbutton
            // 
            this.Printbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Printbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbutton.Location = new System.Drawing.Point(432, 351);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(190, 64);
            this.Printbutton.TabIndex = 3;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = false;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // generateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.Reportgeneration);
            this.Name = "generateReport";
            this.Size = new System.Drawing.Size(687, 439);
            this.Load += new System.EventHandler(this.generateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reportgeneration;
        private System.Windows.Forms.Button Printbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
