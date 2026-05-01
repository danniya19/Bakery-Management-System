namespace BMS
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbllogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnlogin.Location = new System.Drawing.Point(545, 418);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(184, 73);
            this.btnlogin.TabIndex = 23;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lbluser.Location = new System.Drawing.Point(343, 194);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(206, 45);
            this.lbluser.TabIndex = 28;
            this.lbluser.Text = "Username:";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblpw.Location = new System.Drawing.Point(343, 308);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(196, 45);
            this.lblpw.TabIndex = 29;
            this.lblpw.Text = "Password:";
            this.lblpw.Click += new System.EventHandler(this.lblpw_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.txtusername.Location = new System.Drawing.Point(565, 190);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(374, 49);
            this.txtusername.TabIndex = 44;
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.Color.White;
            this.txtpw.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.txtpw.Location = new System.Drawing.Point(565, 308);
            this.txtpw.Multiline = true;
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(374, 49);
            this.txtpw.TabIndex = 45;
            // 
            // panel
            // 
            this.panel.Image = ((System.Drawing.Image)(resources.GetObject("panel.Image")));
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(298, 714);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 24;
            this.panel.TabStop = false;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(1, 207);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(287, 202);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lbllogin.Location = new System.Drawing.Point(633, 92);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(176, 75);
            this.lbllogin.TabIndex = 27;
            this.lbllogin.Text = "Login";
            this.lbllogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1026, 650);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbllogin;
    }
}