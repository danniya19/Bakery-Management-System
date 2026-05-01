namespace BMS
{
    partial class frmorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmorder));
            this.lbld = new System.Windows.Forms.Label();
            this.lbld2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnreport = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.lblodr = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblacust = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtc_id = new System.Windows.Forms.TextBox();
            this.lblc_address = new System.Windows.Forms.Label();
            this.txtc_phone = new System.Windows.Forms.TextBox();
            this.lblc_phone = new System.Windows.Forms.Label();
            this.txtc_mail = new System.Windows.Forms.TextBox();
            this.lblc_mail = new System.Windows.Forms.Label();
            this.txtc_name = new System.Windows.Forms.TextBox();
            this.lblc_name = new System.Windows.Forms.Label();
            this.txtc_address = new System.Windows.Forms.TextBox();
            this.lblc_id = new System.Windows.Forms.Label();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.lblbill = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnplace = new System.Windows.Forms.Button();
            this.btnohistory = new System.Windows.Forms.Button();
            this.dgorder = new System.Windows.Forms.DataGridView();
            this.lblohis = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnprint = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld.Location = new System.Drawing.Point(1622, 31);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 30);
            this.lbld.TabIndex = 21;
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld2.Location = new System.Drawing.Point(1622, 99);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(0, 25);
            this.lbld2.TabIndex = 22;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreport.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnreport.Location = new System.Drawing.Point(38, 896);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(184, 63);
            this.btnreport.TabIndex = 52;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorder.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnorder.Location = new System.Drawing.Point(38, 509);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(184, 63);
            this.btnorder.TabIndex = 51;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click_1);
            // 
            // btnsuppliers
            // 
            this.btnsuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnsuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuppliers.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnsuppliers.Location = new System.Drawing.Point(38, 796);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(184, 63);
            this.btnsuppliers.TabIndex = 50;
            this.btnsuppliers.Text = "Suppliers";
            this.btnsuppliers.UseVisualStyleBackColor = false;
            this.btnsuppliers.Click += new System.EventHandler(this.btnsuppliers_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduct.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btnproduct.Location = new System.Drawing.Point(38, 599);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(184, 63);
            this.btnproduct.TabIndex = 49;
            this.btnproduct.Text = "Products";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btncust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncust.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.btncust.Location = new System.Drawing.Point(38, 695);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(184, 63);
            this.btncust.TabIndex = 48;
            this.btncust.Text = "Customer";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click_1);
            // 
            // lblodr
            // 
            this.lblodr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblodr.AutoSize = true;
            this.lblodr.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblodr.Location = new System.Drawing.Point(818, 31);
            this.lblodr.Name = "lblodr";
            this.lblodr.Size = new System.Drawing.Size(122, 45);
            this.lblodr.TabIndex = 57;
            this.lblodr.Text = "Order";
            // 
            // btnnext
            // 
            this.btnnext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnnext.BackColor = System.Drawing.Color.Bisque;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnext.Location = new System.Drawing.Point(1479, 920);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(272, 63);
            this.btnnext.TabIndex = 89;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnplaceodr_Click);
            // 
            // lblacust
            // 
            this.lblacust.AutoSize = true;
            this.lblacust.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblacust.Location = new System.Drawing.Point(492, 31);
            this.lblacust.Name = "lblacust";
            this.lblacust.Size = new System.Drawing.Size(434, 45);
            this.lblacust.TabIndex = 104;
            this.lblacust.Text = "Add / Search Customers";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadd.Location = new System.Drawing.Point(474, 488);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(184, 63);
            this.btnadd.TabIndex = 103;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtc_id
            // 
            this.txtc_id.BackColor = System.Drawing.Color.White;
            this.txtc_id.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_id.Location = new System.Drawing.Point(577, 119);
            this.txtc_id.Multiline = true;
            this.txtc_id.Name = "txtc_id";
            this.txtc_id.Size = new System.Drawing.Size(374, 49);
            this.txtc_id.TabIndex = 102;
            // 
            // lblc_address
            // 
            this.lblc_address.AutoSize = true;
            this.lblc_address.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_address.Location = new System.Drawing.Point(304, 422);
            this.lblc_address.Name = "lblc_address";
            this.lblc_address.Size = new System.Drawing.Size(246, 34);
            this.lblc_address.TabIndex = 101;
            this.lblc_address.Text = "Customer address:";
            // 
            // txtc_phone
            // 
            this.txtc_phone.BackColor = System.Drawing.Color.White;
            this.txtc_phone.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_phone.Location = new System.Drawing.Point(577, 342);
            this.txtc_phone.Multiline = true;
            this.txtc_phone.Name = "txtc_phone";
            this.txtc_phone.Size = new System.Drawing.Size(374, 50);
            this.txtc_phone.TabIndex = 100;
            // 
            // lblc_phone
            // 
            this.lblc_phone.AutoSize = true;
            this.lblc_phone.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_phone.Location = new System.Drawing.Point(321, 358);
            this.lblc_phone.Name = "lblc_phone";
            this.lblc_phone.Size = new System.Drawing.Size(229, 34);
            this.lblc_phone.TabIndex = 99;
            this.lblc_phone.Text = "Customer phone:";
            // 
            // txtc_mail
            // 
            this.txtc_mail.BackColor = System.Drawing.Color.White;
            this.txtc_mail.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_mail.Location = new System.Drawing.Point(577, 273);
            this.txtc_mail.Multiline = true;
            this.txtc_mail.Name = "txtc_mail";
            this.txtc_mail.Size = new System.Drawing.Size(374, 50);
            this.txtc_mail.TabIndex = 98;
            // 
            // lblc_mail
            // 
            this.lblc_mail.AutoSize = true;
            this.lblc_mail.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_mail.Location = new System.Drawing.Point(318, 289);
            this.lblc_mail.Name = "lblc_mail";
            this.lblc_mail.Size = new System.Drawing.Size(223, 34);
            this.lblc_mail.TabIndex = 97;
            this.lblc_mail.Text = "Customer email:";
            // 
            // txtc_name
            // 
            this.txtc_name.BackColor = System.Drawing.Color.White;
            this.txtc_name.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_name.Location = new System.Drawing.Point(577, 188);
            this.txtc_name.Multiline = true;
            this.txtc_name.Name = "txtc_name";
            this.txtc_name.Size = new System.Drawing.Size(374, 48);
            this.txtc_name.TabIndex = 96;
            // 
            // lblc_name
            // 
            this.lblc_name.AutoSize = true;
            this.lblc_name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_name.Location = new System.Drawing.Point(321, 202);
            this.lblc_name.Name = "lblc_name";
            this.lblc_name.Size = new System.Drawing.Size(220, 34);
            this.lblc_name.TabIndex = 95;
            this.lblc_name.Text = "Customer name:";
            // 
            // txtc_address
            // 
            this.txtc_address.BackColor = System.Drawing.Color.White;
            this.txtc_address.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtc_address.Location = new System.Drawing.Point(577, 416);
            this.txtc_address.Multiline = true;
            this.txtc_address.Name = "txtc_address";
            this.txtc_address.Size = new System.Drawing.Size(374, 46);
            this.txtc_address.TabIndex = 92;
            // 
            // lblc_id
            // 
            this.lblc_id.AutoSize = true;
            this.lblc_id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblc_id.Location = new System.Drawing.Point(327, 134);
            this.lblc_id.Name = "lblc_id";
            this.lblc_id.Size = new System.Drawing.Size(177, 34);
            this.lblc_id.TabIndex = 91;
            this.lblc_id.Text = "Customer id:";
            // 
            // dgcustomer
            // 
            this.dgcustomer.AllowUserToAddRows = false;
            this.dgcustomer.AllowUserToDeleteRows = false;
            this.dgcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgcustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.dgcustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcustomer.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgcustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.dgcustomer.Location = new System.Drawing.Point(975, 128);
            this.dgcustomer.Name = "dgcustomer";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgcustomer.RowHeadersWidth = 62;
            this.dgcustomer.RowTemplate.Height = 28;
            this.dgcustomer.Size = new System.Drawing.Size(874, 831);
            this.dgcustomer.TabIndex = 90;
            this.dgcustomer.TabStop = false;
            this.dgcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcustomer_CellContentClick);
            // 
            // lblbill
            // 
            this.lblbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.lblbill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(122)))), ((int)(((byte)(35)))));
            this.lblbill.Location = new System.Drawing.Point(386, 82);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(1000, 1000);
            this.lblbill.TabIndex = 105;
            this.lblbill.Text = "label1";
            this.lblbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbill.Click += new System.EventHandler(this.lblbill_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch.Location = new System.Drawing.Point(703, 488);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 63);
            this.btnsearch.TabIndex = 106;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnplace
            // 
            this.btnplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.btnplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnplace.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnplace.Location = new System.Drawing.Point(618, 911);
            this.btnplace.Name = "btnplace";
            this.btnplace.Size = new System.Drawing.Size(272, 63);
            this.btnplace.TabIndex = 107;
            this.btnplace.Text = "Place order";
            this.btnplace.UseVisualStyleBackColor = false;
            this.btnplace.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnohistory
            // 
            this.btnohistory.BackColor = System.Drawing.Color.Bisque;
            this.btnohistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnohistory.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnohistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnohistory.Location = new System.Drawing.Point(1468, 796);
            this.btnohistory.Name = "btnohistory";
            this.btnohistory.Size = new System.Drawing.Size(292, 63);
            this.btnohistory.TabIndex = 108;
            this.btnohistory.Text = "Order History";
            this.btnohistory.UseVisualStyleBackColor = false;
            this.btnohistory.Click += new System.EventHandler(this.btnohistory_Click);
            // 
            // dgorder
            // 
            this.dgorder.AllowUserToAddRows = false;
            this.dgorder.AllowUserToDeleteRows = false;
            this.dgorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgorder.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgorder.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgorder.GridColor = System.Drawing.Color.Bisque;
            this.dgorder.Location = new System.Drawing.Point(373, 61);
            this.dgorder.Name = "dgorder";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgorder.RowHeadersWidth = 62;
            this.dgorder.RowTemplate.Height = 28;
            this.dgorder.Size = new System.Drawing.Size(952, 983);
            this.dgorder.TabIndex = 109;
            this.dgorder.TabStop = false;
            this.dgorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgorder_CellContentClick);
            // 
            // lblohis
            // 
            this.lblohis.AutoSize = true;
            this.lblohis.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblohis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblohis.Location = new System.Drawing.Point(731, 27);
            this.lblohis.Name = "lblohis";
            this.lblohis.Size = new System.Drawing.Size(269, 45);
            this.lblohis.TabIndex = 110;
            this.lblohis.Text = "Order History";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.BackColor = System.Drawing.Color.Bisque;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprint.Location = new System.Drawing.Point(1479, 885);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(272, 63);
            this.btnprint.TabIndex = 111;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-3, 241);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(287, 209);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 149;
            this.logo.TabStop = false;
            // 
            // panel
            // 
            this.panel.Image = ((System.Drawing.Image)(resources.GetObject("panel.Image")));
            this.panel.Location = new System.Drawing.Point(-3, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(298, 1076);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 148;
            this.panel.TabStop = false;
            // 
            // frmorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnohistory);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnplace);
            this.Controls.Add(this.lblohis);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblacust);
            this.Controls.Add(this.txtc_id);
            this.Controls.Add(this.lblc_address);
            this.Controls.Add(this.txtc_phone);
            this.Controls.Add(this.lblc_phone);
            this.Controls.Add(this.txtc_mail);
            this.Controls.Add(this.lblc_mail);
            this.Controls.Add(this.lblc_name);
            this.Controls.Add(this.txtc_address);
            this.Controls.Add(this.lblc_id);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.lblodr);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.lbld2);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtc_name);
            this.Controls.Add(this.lblbill);
            this.Controls.Add(this.dgorder);
            this.Name = "frmorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.Label lblodr;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblacust;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtc_id;
        private System.Windows.Forms.Label lblc_address;
        private System.Windows.Forms.TextBox txtc_phone;
        private System.Windows.Forms.Label lblc_phone;
        private System.Windows.Forms.TextBox txtc_mail;
        private System.Windows.Forms.Label lblc_mail;
        private System.Windows.Forms.TextBox txtc_name;
        private System.Windows.Forms.Label lblc_name;
        private System.Windows.Forms.TextBox txtc_address;
        private System.Windows.Forms.Label lblc_id;
        private System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnplace;
        private System.Windows.Forms.Button btnohistory;
        private System.Windows.Forms.DataGridView dgorder;
        private System.Windows.Forms.Label lblohis;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox panel;
    }
}