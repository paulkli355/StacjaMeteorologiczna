namespace MeteoWF
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.appname = new System.Windows.Forms.Label();
            this.iconpic = new System.Windows.Forms.PictureBox();
            this.openNowlabel = new System.Windows.Forms.Label();
            this.minimisePic = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.dashbutton = new System.Windows.Forms.Button();
            this.todaybutton = new System.Windows.Forms.Button();
            this.weekbutton = new System.Windows.Forms.Button();
            this.reportbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimisePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.reportbutton);
            this.panel1.Controls.Add(this.weekbutton);
            this.panel1.Controls.Add(this.todaybutton);
            this.panel1.Controls.Add(this.dashbutton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 511);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.closePic);
            this.panel2.Controls.Add(this.minimisePic);
            this.panel2.Controls.Add(this.openNowlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 69);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.iconpic);
            this.panel3.Controls.Add(this.appname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 69);
            this.panel3.TabIndex = 0;
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appname.Location = new System.Drawing.Point(52, 24);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(137, 30);
            this.appname.TabIndex = 1;
            this.appname.Text = "AirControll";
            // 
            // iconpic
            // 
            this.iconpic.Image = ((System.Drawing.Image)(resources.GetObject("iconpic.Image")));
            this.iconpic.Location = new System.Drawing.Point(14, 24);
            this.iconpic.Name = "iconpic";
            this.iconpic.Size = new System.Drawing.Size(32, 32);
            this.iconpic.TabIndex = 2;
            this.iconpic.TabStop = false;
            // 
            // openNowlabel
            // 
            this.openNowlabel.AutoSize = true;
            this.openNowlabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNowlabel.Location = new System.Drawing.Point(39, 26);
            this.openNowlabel.Name = "openNowlabel";
            this.openNowlabel.Size = new System.Drawing.Size(127, 30);
            this.openNowlabel.TabIndex = 1;
            this.openNowlabel.Text = "Dashbord";
            this.openNowlabel.Click += new System.EventHandler(this.openNowlabel_Click);
            // 
            // minimisePic
            // 
            this.minimisePic.Image = ((System.Drawing.Image)(resources.GetObject("minimisePic.Image")));
            this.minimisePic.Location = new System.Drawing.Point(605, 26);
            this.minimisePic.Name = "minimisePic";
            this.minimisePic.Size = new System.Drawing.Size(32, 32);
            this.minimisePic.TabIndex = 3;
            this.minimisePic.TabStop = false;
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(643, 26);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(32, 32);
            this.closePic.TabIndex = 4;
            this.closePic.TabStop = false;
            // 
            // dashbutton
            // 
            this.dashbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashbutton.FlatAppearance.BorderSize = 0;
            this.dashbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.dashbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.dashbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbutton.Location = new System.Drawing.Point(0, 69);
            this.dashbutton.Name = "dashbutton";
            this.dashbutton.Size = new System.Drawing.Size(195, 51);
            this.dashbutton.TabIndex = 3;
            this.dashbutton.Text = "Dashboard";
            this.dashbutton.UseVisualStyleBackColor = true;
            // 
            // todaybutton
            // 
            this.todaybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.todaybutton.FlatAppearance.BorderSize = 0;
            this.todaybutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.todaybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.todaybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todaybutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaybutton.Location = new System.Drawing.Point(0, 120);
            this.todaybutton.Name = "todaybutton";
            this.todaybutton.Size = new System.Drawing.Size(195, 51);
            this.todaybutton.TabIndex = 4;
            this.todaybutton.Text = "Today          ";
            this.todaybutton.UseVisualStyleBackColor = true;
            // 
            // weekbutton
            // 
            this.weekbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekbutton.FlatAppearance.BorderSize = 0;
            this.weekbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.weekbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.weekbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekbutton.Location = new System.Drawing.Point(0, 171);
            this.weekbutton.Name = "weekbutton";
            this.weekbutton.Size = new System.Drawing.Size(195, 51);
            this.weekbutton.TabIndex = 5;
            this.weekbutton.Text = "Last week  ";
            this.weekbutton.UseVisualStyleBackColor = true;
            // 
            // reportbutton
            // 
            this.reportbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.reportbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.Location = new System.Drawing.Point(0, 222);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(195, 51);
            this.reportbutton.TabIndex = 6;
            this.reportbutton.Text = "Report        ";
            this.reportbutton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimisePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label appname;
        private System.Windows.Forms.PictureBox iconpic;
        private System.Windows.Forms.Label openNowlabel;
        private System.Windows.Forms.PictureBox minimisePic;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Button dashbutton;
        private System.Windows.Forms.Button todaybutton;
        private System.Windows.Forms.Button weekbutton;
        private System.Windows.Forms.Button reportbutton;
    }
}