namespace BMS
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblcreate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(233, 97);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(541, 396);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblwelcome.Location = new System.Drawing.Point(361, 19);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(322, 75);
            this.lblwelcome.TabIndex = 28;
            this.lblwelcome.Text = "Welcome to";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnnext.Location = new System.Drawing.Point(425, 499);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(184, 73);
            this.btnnext.TabIndex = 29;
            this.btnnext.Text = "Login";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblcreate
            // 
            this.lblcreate.AutoSize = true;
            this.lblcreate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblcreate.Location = new System.Drawing.Point(408, 588);
            this.lblcreate.Name = "lblcreate";
            this.lblcreate.Size = new System.Drawing.Size(224, 32);
            this.lblcreate.TabIndex = 30;
            this.lblcreate.Text = "Create new account";
            this.lblcreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcreate.Click += new System.EventHandler(this.lblcreate_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1026, 650);
            this.Controls.Add(this.lblcreate);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.logo);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblcreate;
    }
}