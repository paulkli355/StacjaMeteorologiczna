namespace MeteoWF
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
            this.Reportgeneration = new System.Windows.Forms.Label();
            this.Printbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reportgeneration
            // 
            this.Reportgeneration.AutoSize = true;
            this.Reportgeneration.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportgeneration.Location = new System.Drawing.Point(24, 26);
            this.Reportgeneration.Name = "Reportgeneration";
            this.Reportgeneration.Size = new System.Drawing.Size(598, 30);
            this.Reportgeneration.TabIndex = 2;
            this.Reportgeneration.Text = "Get those statistics with you and generate report!";
            this.Reportgeneration.Click += new System.EventHandler(this.label_Click);
            // 
            // Printbutton
            // 
            this.Printbutton.Location = new System.Drawing.Point(432, 351);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(190, 47);
            this.Printbutton.TabIndex = 3;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // generateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.Reportgeneration);
            this.Name = "generateReport";
            this.Size = new System.Drawing.Size(687, 439);
            this.Load += new System.EventHandler(this.generateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reportgeneration;
        private System.Windows.Forms.Button Printbutton;
    }
}
