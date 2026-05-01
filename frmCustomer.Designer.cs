namespace BMS
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.PictureBox();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtc_address = new System.Windows.Forms.TextBox();
            this.lblc_id = new System.Windows.Forms.Label();
            this.txtc_name = new System.Windows.Forms.TextBox();
            this.lblc_name = new System.Windows.Forms.Label();
            this.txtc_mail = new System.Windows.Forms.TextBox();
            this.lblc_mail = new System.Windows.Forms.Label();
            this.txtc_phone = new System.Windows.Forms.TextBox();
            this.lblc_phone = new System.Windows.Forms.Label();
            this.lblc_address = new System.Windows.Forms.Label();
            this.txtc_id = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcust = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbld2 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Bisque;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreport.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreport.Location = new System.Drawing.Point(32, 899);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(184, 63);
            this.btnreport.TabIndex = 28;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Bisque;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorder.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnorder.Location = new System.Drawing.Point(32, 512);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(184, 63);
            this.btnorder.TabIndex = 27;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click_1);
            // 
            // btnsuppliers
            // 
            this.btnsuppliers.BackColor = System.Drawing.Color.Bisque;
            this.btnsuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuppliers.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsuppliers.Location = new System.Drawing.Point(32, 799);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(184, 63);
            this.btnsuppliers.TabIndex = 26;
            this.btnsuppliers.Text = "Suppliers";
            this.btnsuppliers.UseVisualStyleBackColor = false;
            this.btnsuppliers.Click += new System.EventHandler(this.btnsuppliers_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Bisque;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduct.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproduct.Location = new System.Drawing.Point(32, 602);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(184, 63);
            this.btnproduct.TabIndex = 25;
            this.btnproduct.Text = "Products";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.Bisque;
            this.btncust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncust.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncust.Location = new System.Drawing.Point(32, 698);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(184, 63);
            this.btncust.TabIndex = 24;
            this.btncust.Text = "Customer";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // panel
            // 
            this.panel.Image = ((System.Drawing.Image)(resources.GetObject("panel.Image")));
            this.panel.Location = new System.Drawing.Point(-8, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(258, 1101);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 22;
            this.panel.TabStop = false;
            // 
            // dgcustomer
            // 
            this.dgcustomer.AllowUserToAddRows = false;
            this.dgcustomer.AllowUserToDeleteRows = false;
            this.dgcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgcustomer.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgcustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcustomer.GridColor = System.Drawing.Color.Bisque;
            this.dgcustomer.Location = new System.Drawing.Point(905, 130);
            this.dgcustomer.Name = "dgcustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgcustomer.RowHeadersWidth = 62;
            this.dgcustomer.RowTemplate.Height = 28;
            this.dgcustomer.Size = new System.Drawing.Size(874, 865);
            this.dgcustomer.TabIndex = 29;
            this.dgcustomer.TabStop = false;
            this.dgcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcustomer_CellContentClick);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Bisque;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndel.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndel.Location = new System.Drawing.Point(595, 631);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(169, 63);
            this.btndel.TabIndex = 35;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Bisque;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupdate.Location = new System.Drawing.Point(352, 631);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 63);
            this.btnupdate.TabIndex = 34;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtc_address
            // 
            this.txtc_address.BackColor = System.Drawing.Color.White;
            this.txtc_address.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_address.Location = new System.Drawing.Point(525, 422);
            this.txtc_address.Multiline = true;
            this.txtc_address.Name = "txtc_address";
            this.txtc_address.Size = new System.Drawing.Size(374, 46);
            this.txtc_address.TabIndex = 32;
            this.txtc_address.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblc_id
            // 
            this.lblc_id.AutoSize = true;
            this.lblc_id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_id.Location = new System.Drawing.Point(276, 173);
            this.lblc_id.Name = "lblc_id";
            this.lblc_id.Size = new System.Drawing.Size(177, 34);
            this.lblc_id.TabIndex = 30;
            this.lblc_id.Text = "Customer id:";
            // 
            // txtc_name
            // 
            this.txtc_name.BackColor = System.Drawing.Color.White;
            this.txtc_name.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_name.Location = new System.Drawing.Point(525, 227);
            this.txtc_name.Multiline = true;
            this.txtc_name.Name = "txtc_name";
            this.txtc_name.Size = new System.Drawing.Size(374, 48);
            this.txtc_name.TabIndex = 37;
            // 
            // lblc_name
            // 
            this.lblc_name.AutoSize = true;
            this.lblc_name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_name.Location = new System.Drawing.Point(270, 241);
            this.lblc_name.Name = "lblc_name";
            this.lblc_name.Size = new System.Drawing.Size(220, 34);
            this.lblc_name.TabIndex = 36;
            this.lblc_name.Text = "Customer name:";
            // 
            // txtc_mail
            // 
            this.txtc_mail.BackColor = System.Drawing.Color.White;
            this.txtc_mail.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_mail.Location = new System.Drawing.Point(525, 289);
            this.txtc_mail.Multiline = true;
            this.txtc_mail.Name = "txtc_mail";
            this.txtc_mail.Size = new System.Drawing.Size(374, 50);
            this.txtc_mail.TabIndex = 39;
            // 
            // lblc_mail
            // 
            this.lblc_mail.AutoSize = true;
            this.lblc_mail.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_mail.Location = new System.Drawing.Point(276, 305);
            this.lblc_mail.Name = "lblc_mail";
            this.lblc_mail.Size = new System.Drawing.Size(223, 34);
            this.lblc_mail.TabIndex = 38;
            this.lblc_mail.Text = "Customer email:";
            // 
            // txtc_phone
            // 
            this.txtc_phone.BackColor = System.Drawing.Color.White;
            this.txtc_phone.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_phone.Location = new System.Drawing.Point(525, 357);
            this.txtc_phone.Multiline = true;
            this.txtc_phone.Name = "txtc_phone";
            this.txtc_phone.Size = new System.Drawing.Size(374, 50);
            this.txtc_phone.TabIndex = 41;
            // 
            // lblc_phone
            // 
            this.lblc_phone.AutoSize = true;
            this.lblc_phone.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_phone.Location = new System.Drawing.Point(276, 373);
            this.lblc_phone.Name = "lblc_phone";
            this.lblc_phone.Size = new System.Drawing.Size(229, 34);
            this.lblc_phone.TabIndex = 40;
            this.lblc_phone.Text = "Customer phone:";
            // 
            // lblc_address
            // 
            this.lblc_address.AutoSize = true;
            this.lblc_address.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_address.Location = new System.Drawing.Point(256, 437);
            this.lblc_address.Name = "lblc_address";
            this.lblc_address.Size = new System.Drawing.Size(246, 34);
            this.lblc_address.TabIndex = 42;
            this.lblc_address.Text = "Customer address:";
            this.lblc_address.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // txtc_id
            // 
            this.txtc_id.BackColor = System.Drawing.Color.White;
            this.txtc_id.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_id.Location = new System.Drawing.Point(525, 158);
            this.txtc_id.Multiline = true;
            this.txtc_id.Name = "txtc_id";
            this.txtc_id.Size = new System.Drawing.Size(374, 49);
            this.txtc_id.TabIndex = 43;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch.Location = new System.Drawing.Point(478, 525);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 63);
            this.btnsearch.TabIndex = 44;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblcust
            // 
            this.lblcust.AutoSize = true;
            this.lblcust.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcust.Location = new System.Drawing.Point(481, 76);
            this.lblcust.Name = "lblcust";
            this.lblcust.Size = new System.Drawing.Size(199, 45);
            this.lblcust.TabIndex = 46;
            this.lblcust.Text = "Customers";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld2.Location = new System.Drawing.Point(1601, 87);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(0, 25);
            this.lbld2.TabIndex = 48;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld.Location = new System.Drawing.Point(1601, 19);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 30);
            this.lbld.TabIndex = 47;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.lbld2);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblcust);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtc_id);
            this.Controls.Add(this.lblc_address);
            this.Controls.Add(this.txtc_phone);
            this.Controls.Add(this.lblc_phone);
            this.Controls.Add(this.txtc_mail);
            this.Controls.Add(this.lblc_mail);
            this.Controls.Add(this.txtc_name);
            this.Controls.Add(this.lblc_name);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtc_address);
            this.Controls.Add(this.lblc_id);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.panel);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                        ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtc_address;
        private System.Windows.Forms.Label lblc_id;
        private System.Windows.Forms.TextBox txtc_name;
        private System.Windows.Forms.Label lblc_name;
        private System.Windows.Forms.TextBox txtc_mail;
        private System.Windows.Forms.Label lblc_mail;
        private System.Windows.Forms.TextBox txtc_phone;
        private System.Windows.Forms.Label lblc_phone;
        private System.Windows.Forms.Label lblc_address;
        private System.Windows.Forms.TextBox txtc_id;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcust;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Timer timer1;
    }
}