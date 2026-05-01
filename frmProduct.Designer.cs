namespace BMS
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblp_cat = new System.Windows.Forms.Label();
            this.txtp_desc = new System.Windows.Forms.TextBox();
            this.lblp_desc = new System.Windows.Forms.Label();
            this.txtp_name = new System.Windows.Forms.TextBox();
            this.lblp_name = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtp_cat = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.PictureBox();
            this.lblup = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtqunat = new System.Windows.Forms.TextBox();
            this.txtp_id = new System.Windows.Forms.TextBox();
            this.lblp_id = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbld2 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch.Location = new System.Drawing.Point(383, 666);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 63);
            this.btnsearch.TabIndex = 62;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblp_cat
            // 
            this.lblp_cat.AutoSize = true;
            this.lblp_cat.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblp_cat.Location = new System.Drawing.Point(268, 448);
            this.lblp_cat.Name = "lblp_cat";
            this.lblp_cat.Size = new System.Drawing.Size(246, 34);
            this.lblp_cat.TabIndex = 61;
            this.lblp_cat.Text = "Product Categroy:";
            // 
            // txtp_desc
            // 
            this.txtp_desc.BackColor = System.Drawing.Color.White;
            this.txtp_desc.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtp_desc.Location = new System.Drawing.Point(559, 368);
            this.txtp_desc.Multiline = true;
            this.txtp_desc.Name = "txtp_desc";
            this.txtp_desc.Size = new System.Drawing.Size(374, 50);
            this.txtp_desc.TabIndex = 60;
            // 
            // lblp_desc
            // 
            this.lblp_desc.AutoSize = true;
            this.lblp_desc.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblp_desc.Location = new System.Drawing.Point(268, 384);
            this.lblp_desc.Name = "lblp_desc";
            this.lblp_desc.Size = new System.Drawing.Size(285, 34);
            this.lblp_desc.TabIndex = 59;
            this.lblp_desc.Text = "Product Description:";
            // 
            // txtp_name
            // 
            this.txtp_name.BackColor = System.Drawing.Color.White;
            this.txtp_name.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtp_name.Location = new System.Drawing.Point(559, 300);
            this.txtp_name.Multiline = true;
            this.txtp_name.Name = "txtp_name";
            this.txtp_name.Size = new System.Drawing.Size(374, 50);
            this.txtp_name.TabIndex = 58;
            // 
            // lblp_name
            // 
            this.lblp_name.AutoSize = true;
            this.lblp_name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblp_name.Location = new System.Drawing.Point(268, 316);
            this.lblp_name.Name = "lblp_name";
            this.lblp_name.Size = new System.Drawing.Size(209, 34);
            this.lblp_name.TabIndex = 57;
            this.lblp_name.Text = "Product Name:";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Bisque;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupdate.Location = new System.Drawing.Point(668, 666);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 63);
            this.btnupdate.TabIndex = 55;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtp_cat
            // 
            this.txtp_cat.BackColor = System.Drawing.Color.White;
            this.txtp_cat.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtp_cat.Location = new System.Drawing.Point(559, 436);
            this.txtp_cat.Multiline = true;
            this.txtp_cat.Name = "txtp_cat";
            this.txtp_cat.Size = new System.Drawing.Size(374, 46);
            this.txtp_cat.TabIndex = 54;
            this.txtp_cat.TextChanged += new System.EventHandler(this.txtc_address_TextChanged);
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProduct.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduct.GridColor = System.Drawing.Color.Bisque;
            this.dgProduct.Location = new System.Drawing.Point(970, 143);
            this.dgProduct.Name = "dgProduct";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduct.RowHeadersWidth = 62;
            this.dgProduct.RowTemplate.Height = 28;
            this.dgProduct.Size = new System.Drawing.Size(874, 822);
            this.dgProduct.TabIndex = 53;
            this.dgProduct.TabStop = false;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Bisque;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreport.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreport.Location = new System.Drawing.Point(44, 867);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(184, 63);
            this.btnreport.TabIndex = 52;
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
            this.btnorder.Location = new System.Drawing.Point(44, 480);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(184, 63);
            this.btnorder.TabIndex = 51;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnsuppliers
            // 
            this.btnsuppliers.BackColor = System.Drawing.Color.Bisque;
            this.btnsuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuppliers.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsuppliers.Location = new System.Drawing.Point(44, 767);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(184, 63);
            this.btnsuppliers.TabIndex = 50;
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
            this.btnproduct.Location = new System.Drawing.Point(44, 570);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(184, 63);
            this.btnproduct.TabIndex = 49;
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
            this.btncust.Location = new System.Drawing.Point(44, 666);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(184, 63);
            this.btncust.TabIndex = 48;
            this.btncust.Text = "Customer";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // panel
            // 
            this.panel.Image = ((System.Drawing.Image)(resources.GetObject("panel.Image")));
            this.panel.Location = new System.Drawing.Point(-5, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(258, 1101);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 46;
            this.panel.TabStop = false;
            // 
            // lblup
            // 
            this.lblup.AutoSize = true;
            this.lblup.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblup.Location = new System.Drawing.Point(482, 126);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(331, 45);
            this.lblup.TabIndex = 64;
            this.lblup.Text = "Update Inventory";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblprice.Location = new System.Drawing.Point(268, 511);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(92, 34);
            this.lblprice.TabIndex = 66;
            this.lblprice.Text = "Price:";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.Location = new System.Drawing.Point(559, 499);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(374, 46);
            this.txtprice.TabIndex = 65;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblquantity.Location = new System.Drawing.Point(268, 582);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(136, 34);
            this.lblquantity.TabIndex = 68;
            this.lblquantity.Text = "Quantity:";
            // 
            // txtqunat
            // 
            this.txtqunat.BackColor = System.Drawing.Color.White;
            this.txtqunat.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqunat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqunat.Location = new System.Drawing.Point(559, 570);
            this.txtqunat.Multiline = true;
            this.txtqunat.Name = "txtqunat";
            this.txtqunat.Size = new System.Drawing.Size(374, 46);
            this.txtqunat.TabIndex = 67;
            // 
            // txtp_id
            // 
            this.txtp_id.BackColor = System.Drawing.Color.White;
            this.txtp_id.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtp_id.Location = new System.Drawing.Point(559, 220);
            this.txtp_id.Multiline = true;
            this.txtp_id.Name = "txtp_id";
            this.txtp_id.Size = new System.Drawing.Size(374, 50);
            this.txtp_id.TabIndex = 70;
            // 
            // lblp_id
            // 
            this.lblp_id.AutoSize = true;
            this.lblp_id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblp_id.Location = new System.Drawing.Point(268, 248);
            this.lblp_id.Name = "lblp_id";
            this.lblp_id.Size = new System.Drawing.Size(164, 34);
            this.lblp_id.TabIndex = 69;
            this.lblp_id.Text = "Product Id:";
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld2.Location = new System.Drawing.Point(1560, 98);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(0, 25);
            this.lbld2.TabIndex = 72;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld.Location = new System.Drawing.Point(1560, 30);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 30);
            this.lbld.TabIndex = 71;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1856, 1050);
            this.Controls.Add(this.lbld2);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.txtp_id);
            this.Controls.Add(this.lblp_id);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.txtqunat);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblp_cat);
            this.Controls.Add(this.txtp_desc);
            this.Controls.Add(this.lblp_desc);
            this.Controls.Add(this.txtp_name);
            this.Controls.Add(this.lblp_name);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtp_cat);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.panel);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblp_cat;
        private System.Windows.Forms.TextBox txtp_desc;
        private System.Windows.Forms.Label lblp_desc;
        private System.Windows.Forms.TextBox txtp_name;
        private System.Windows.Forms.Label lblp_name;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtp_cat;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.Label lblup;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtqunat;
        private System.Windows.Forms.TextBox txtp_id;
        private System.Windows.Forms.Label lblp_id;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lbld;
    }
}