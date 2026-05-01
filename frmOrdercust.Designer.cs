namespace BMS
{
    partial class frmOrdercust
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdercust));
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblbill = new System.Windows.Forms.Label();
            this.lblacust = new System.Windows.Forms.Label();
            this.txtc_id = new System.Windows.Forms.TextBox();
            this.lblc_address = new System.Windows.Forms.Label();
            this.txtc_phone = new System.Windows.Forms.TextBox();
            this.lblc_phone = new System.Windows.Forms.Label();
            this.txtc_mail = new System.Windows.Forms.TextBox();
            this.lblc_mail = new System.Windows.Forms.Label();
            this.txtc_name = new System.Windows.Forms.TextBox();
            this.lblc_name = new System.Windows.Forms.Label();
            this.txtc_address = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblc_id = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnadd.Location = new System.Drawing.Point(726, 642);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(184, 63);
            this.btnadd.TabIndex = 190;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnext
            // 
            this.btnnext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnnext.Location = new System.Drawing.Point(1011, 667);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(211, 63);
            this.btnnext.TabIndex = 178;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblbill
            // 
            this.lblbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.lblbill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblbill.Location = new System.Drawing.Point(148, 324);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(363, 669);
            this.lblbill.TabIndex = 192;
            this.lblbill.Text = "label1";
            this.lblbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbill.Click += new System.EventHandler(this.lblbill_Click);
            // 
            // lblacust
            // 
            this.lblacust.AutoSize = true;
            this.lblacust.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblacust.Location = new System.Drawing.Point(887, 30);
            this.lblacust.Name = "lblacust";
            this.lblacust.Size = new System.Drawing.Size(335, 45);
            this.lblacust.TabIndex = 191;
            this.lblacust.Text = "Add Your Details";
            // 
            // txtc_id
            // 
            this.txtc_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.txtc_id.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.txtc_id.Location = new System.Drawing.Point(878, 207);
            this.txtc_id.Multiline = true;
            this.txtc_id.Name = "txtc_id";
            this.txtc_id.Size = new System.Drawing.Size(374, 49);
            this.txtc_id.TabIndex = 189;
            // 
            // lblc_address
            // 
            this.lblc_address.AutoSize = true;
            this.lblc_address.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblc_address.Location = new System.Drawing.Point(546, 546);
            this.lblc_address.Name = "lblc_address";
            this.lblc_address.Size = new System.Drawing.Size(332, 41);
            this.lblc_address.TabIndex = 188;
            this.lblc_address.Text = "Enter your address:";
            // 
            // txtc_phone
            // 
            this.txtc_phone.BackColor = System.Drawing.Color.White;
            this.txtc_phone.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.txtc_phone.Location = new System.Drawing.Point(878, 367);
            this.txtc_phone.Multiline = true;
            this.txtc_phone.Name = "txtc_phone";
            this.txtc_phone.Size = new System.Drawing.Size(374, 50);
            this.txtc_phone.TabIndex = 187;
            // 
            // lblc_phone
            // 
            this.lblc_phone.AutoSize = true;
            this.lblc_phone.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblc_phone.Location = new System.Drawing.Point(546, 458);
            this.lblc_phone.Name = "lblc_phone";
            this.lblc_phone.Size = new System.Drawing.Size(309, 41);
            this.lblc_phone.TabIndex = 186;
            this.lblc_phone.Text = "Enter your phone:";
            // 
            // txtc_mail
            // 
            this.txtc_mail.BackColor = System.Drawing.Color.White;
            this.txtc_mail.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_mail.Location = new System.Drawing.Point(878, 449);
            this.txtc_mail.Multiline = true;
            this.txtc_mail.Name = "txtc_mail";
            this.txtc_mail.Size = new System.Drawing.Size(374, 50);
            this.txtc_mail.TabIndex = 185;
            // 
            // lblc_mail
            // 
            this.lblc_mail.AutoSize = true;
            this.lblc_mail.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblc_mail.Location = new System.Drawing.Point(546, 383);
            this.lblc_mail.Name = "lblc_mail";
            this.lblc_mail.Size = new System.Drawing.Size(304, 41);
            this.lblc_mail.TabIndex = 184;
            this.lblc_mail.Text = "Enter your email:";
            // 
            // txtc_name
            // 
            this.txtc_name.BackColor = System.Drawing.Color.White;
            this.txtc_name.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.txtc_name.Location = new System.Drawing.Point(878, 292);
            this.txtc_name.Multiline = true;
            this.txtc_name.Name = "txtc_name";
            this.txtc_name.Size = new System.Drawing.Size(374, 48);
            this.txtc_name.TabIndex = 183;
            // 
            // lblc_name
            // 
            this.lblc_name.AutoSize = true;
            this.lblc_name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblc_name.Location = new System.Drawing.Point(549, 299);
            this.lblc_name.Name = "lblc_name";
            this.lblc_name.Size = new System.Drawing.Size(299, 41);
            this.lblc_name.TabIndex = 182;
            this.lblc_name.Text = "Enter your name:";
            // 
            // txtc_address
            // 
            this.txtc_address.BackColor = System.Drawing.Color.White;
            this.txtc_address.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.txtc_address.Location = new System.Drawing.Point(878, 541);
            this.txtc_address.Multiline = true;
            this.txtc_address.Name = "txtc_address";
            this.txtc_address.Size = new System.Drawing.Size(374, 46);
            this.txtc_address.TabIndex = 181;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblc_id
            // 
            this.lblc_id.AutoSize = true;
            this.lblc_id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.lblc_id.Location = new System.Drawing.Point(546, 222);
            this.lblc_id.Name = "lblc_id";
            this.lblc_id.Size = new System.Drawing.Size(177, 34);
            this.lblc_id.TabIndex = 180;
            this.lblc_id.Text = "Customer id:";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-25, -19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(505, 310);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 231;
            this.logo.TabStop = false;
            // 
            // frmOrdercust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblacust);
            this.Controls.Add(this.txtc_id);
            this.Controls.Add(this.lblc_address);
            this.Controls.Add(this.txtc_phone);
            this.Controls.Add(this.lblc_phone);
            this.Controls.Add(this.txtc_mail);
            this.Controls.Add(this.lblc_mail);
            this.Controls.Add(this.txtc_name);
            this.Controls.Add(this.lblc_name);
            this.Controls.Add(this.txtc_address);
            this.Controls.Add(this.lblc_id);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblbill);
            this.Name = "frmOrdercust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdercust";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrdercust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.Label lblacust;
        private System.Windows.Forms.TextBox txtc_id;
        private System.Windows.Forms.Label lblc_address;
        private System.Windows.Forms.TextBox txtc_phone;
        private System.Windows.Forms.Label lblc_phone;
        private System.Windows.Forms.TextBox txtc_mail;
        private System.Windows.Forms.Label lblc_mail;
        private System.Windows.Forms.TextBox txtc_name;
        private System.Windows.Forms.Label lblc_name;
        private System.Windows.Forms.TextBox txtc_address;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblc_id;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox logo;
    }
}