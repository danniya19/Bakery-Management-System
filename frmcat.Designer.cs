namespace BMS
{
    partial class frmcat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcat));
            this.lblcat = new System.Windows.Forms.Label();
            this.cake = new System.Windows.Forms.PictureBox();
            this.cup = new System.Windows.Forms.PictureBox();
            this.sav = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sav)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblcat.Location = new System.Drawing.Point(359, 24);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(296, 75);
            this.lblcat.TabIndex = 29;
            this.lblcat.Text = "Categories";
            // 
            // cake
            // 
            this.cake.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cake.Image = ((System.Drawing.Image)(resources.GetObject("cake.Image")));
            this.cake.Location = new System.Drawing.Point(70, 123);
            this.cake.Name = "cake";
            this.cake.Size = new System.Drawing.Size(310, 230);
            this.cake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cake.TabIndex = 30;
            this.cake.TabStop = false;
            this.cake.Click += new System.EventHandler(this.logo_Click);
            // 
            // cup
            // 
            this.cup.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cup.Image = ((System.Drawing.Image)(resources.GetObject("cup.Image")));
            this.cup.Location = new System.Drawing.Point(618, 123);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(310, 230);
            this.cup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cup.TabIndex = 31;
            this.cup.TabStop = false;
            this.cup.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sav
            // 
            this.sav.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.sav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sav.Image = ((System.Drawing.Image)(resources.GetObject("sav.Image")));
            this.sav.Location = new System.Drawing.Point(345, 383);
            this.sav.Name = "sav";
            this.sav.Size = new System.Drawing.Size(310, 230);
            this.sav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sav.TabIndex = 32;
            this.sav.TabStop = false;
            this.sav.Click += new System.EventHandler(this.sav_Click);
            // 
            // frmcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1026, 650);
            this.Controls.Add(this.sav);
            this.Controls.Add(this.cup);
            this.Controls.Add(this.cake);
            this.Controls.Add(this.lblcat);
            this.Name = "frmcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcat";
            ((System.ComponentModel.ISupportInitialize)(this.cake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.PictureBox cake;
        private System.Windows.Forms.PictureBox cup;
        private System.Windows.Forms.PictureBox sav;
    }
}