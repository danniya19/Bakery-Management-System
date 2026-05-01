namespace BMS
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lbls_address = new System.Windows.Forms.Label();
            this.txts_phone = new System.Windows.Forms.TextBox();
            this.lbls_phone = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txts_address = new System.Windows.Forms.TextBox();
            this.dgsupplies = new System.Windows.Forms.DataGridView();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.PictureBox();
            this.lblsupplier = new System.Windows.Forms.Label();
            this.txts_id = new System.Windows.Forms.TextBox();
            this.txts_mail = new System.Windows.Forms.TextBox();
            this.lbls_mail = new System.Windows.Forms.Label();
            this.txts_name = new System.Windows.Forms.TextBox();
            this.lbls_name = new System.Windows.Forms.Label();
            this.lbls_id = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbld2 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch.Location = new System.Drawing.Point(607, 475);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 63);
            this.btnsearch.TabIndex = 60;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbls_address
            // 
            this.lbls_address.AutoSize = true;
            this.lbls_address.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_address.Location = new System.Drawing.Point(283, 368);
            this.lbls_address.Name = "lbls_address";
            this.lbls_address.Size = new System.Drawing.Size(238, 34);
            this.lbls_address.TabIndex = 59;
            this.lbls_address.Text = "Supplier address:";
            // 
            // txts_phone
            // 
            this.txts_phone.BackColor = System.Drawing.Color.White;
            this.txts_phone.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txts_phone.Location = new System.Drawing.Point(537, 297);
            this.txts_phone.Multiline = true;
            this.txts_phone.Name = "txts_phone";
            this.txts_phone.Size = new System.Drawing.Size(374, 50);
            this.txts_phone.TabIndex = 58;
            // 
            // lbls_phone
            // 
            this.lbls_phone.AutoSize = true;
            this.lbls_phone.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_phone.Location = new System.Drawing.Point(283, 313);
            this.lbls_phone.Name = "lbls_phone";
            this.lbls_phone.Size = new System.Drawing.Size(221, 34);
            this.lbls_phone.TabIndex = 57;
            this.lbls_phone.Text = "Supplier phone:";
            this.lbls_phone.Click += new System.EventHandler(this.lblc_phone_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Bisque;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndel.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndel.Location = new System.Drawing.Point(607, 571);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(169, 63);
            this.btndel.TabIndex = 56;
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
            this.btnupdate.Location = new System.Drawing.Point(364, 571);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 63);
            this.btnupdate.TabIndex = 55;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txts_address
            // 
            this.txts_address.BackColor = System.Drawing.Color.White;
            this.txts_address.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txts_address.Location = new System.Drawing.Point(537, 362);
            this.txts_address.Multiline = true;
            this.txts_address.Name = "txts_address";
            this.txts_address.Size = new System.Drawing.Size(374, 46);
            this.txts_address.TabIndex = 54;
            // 
            // dgsupplies
            // 
            this.dgsupplies.AllowUserToAddRows = false;
            this.dgsupplies.AllowUserToDeleteRows = false;
            this.dgsupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgsupplies.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgsupplies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsupplies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgsupplies.GridColor = System.Drawing.Color.Bisque;
            this.dgsupplies.Location = new System.Drawing.Point(950, 105);
            this.dgsupplies.Name = "dgsupplies";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsupplies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgsupplies.RowHeadersWidth = 62;
            this.dgsupplies.RowTemplate.Height = 28;
            this.dgsupplies.Size = new System.Drawing.Size(874, 837);
            this.dgsupplies.TabIndex = 53;
            this.dgsupplies.TabStop = false;
            this.dgsupplies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsupplies_CellContentClick);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Bisque;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreport.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreport.Location = new System.Drawing.Point(44, 900);
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
            this.btnorder.Location = new System.Drawing.Point(44, 513);
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
            this.btnsuppliers.Location = new System.Drawing.Point(44, 800);
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
            this.btnproduct.Location = new System.Drawing.Point(44, 603);
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
            this.btncust.Location = new System.Drawing.Point(44, 699);
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
            this.panel.Location = new System.Drawing.Point(4, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(258, 1101);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 46;
            this.panel.TabStop = false;
            // 
            // lblsupplier
            // 
            this.lblsupplier.AutoSize = true;
            this.lblsupplier.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsupplier.Location = new System.Drawing.Point(496, 26);
            this.lblsupplier.Name = "lblsupplier";
            this.lblsupplier.Size = new System.Drawing.Size(186, 45);
            this.lblsupplier.TabIndex = 68;
            this.lblsupplier.Text = "Suppliers";
            // 
            // txts_id
            // 
            this.txts_id.BackColor = System.Drawing.Color.White;
            this.txts_id.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txts_id.Location = new System.Drawing.Point(538, 107);
            this.txts_id.Multiline = true;
            this.txts_id.Name = "txts_id";
            this.txts_id.Size = new System.Drawing.Size(374, 49);
            this.txts_id.TabIndex = 67;
            // 
            // txts_mail
            // 
            this.txts_mail.BackColor = System.Drawing.Color.White;
            this.txts_mail.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txts_mail.Location = new System.Drawing.Point(538, 238);
            this.txts_mail.Multiline = true;
            this.txts_mail.Name = "txts_mail";
            this.txts_mail.Size = new System.Drawing.Size(374, 50);
            this.txts_mail.TabIndex = 66;
            // 
            // lbls_mail
            // 
            this.lbls_mail.AutoSize = true;
            this.lbls_mail.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_mail.Location = new System.Drawing.Point(283, 254);
            this.lbls_mail.Name = "lbls_mail";
            this.lbls_mail.Size = new System.Drawing.Size(215, 34);
            this.lbls_mail.TabIndex = 65;
            this.lbls_mail.Text = "Supplier email:";
            // 
            // txts_name
            // 
            this.txts_name.BackColor = System.Drawing.Color.White;
            this.txts_name.Font = new System.Drawing.Font("Rockwell Nova", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txts_name.Location = new System.Drawing.Point(538, 176);
            this.txts_name.Multiline = true;
            this.txts_name.Name = "txts_name";
            this.txts_name.Size = new System.Drawing.Size(374, 48);
            this.txts_name.TabIndex = 64;
            // 
            // lbls_name
            // 
            this.lbls_name.AutoSize = true;
            this.lbls_name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_name.Location = new System.Drawing.Point(283, 190);
            this.lbls_name.Name = "lbls_name";
            this.lbls_name.Size = new System.Drawing.Size(212, 34);
            this.lbls_name.TabIndex = 63;
            this.lbls_name.Text = "Supplier name:";
            // 
            // lbls_id
            // 
            this.lbls_id.AutoSize = true;
            this.lbls_id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_id.Location = new System.Drawing.Point(283, 122);
            this.lbls_id.Name = "lbls_id";
            this.lbls_id.Size = new System.Drawing.Size(169, 34);
            this.lbls_id.TabIndex = 62;
            this.lbls_id.Text = "Supplier id:";
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld2.Location = new System.Drawing.Point(1497, 77);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(0, 25);
            this.lbld2.TabIndex = 74;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbld.Location = new System.Drawing.Point(1497, 9);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 30);
            this.lbld.TabIndex = 73;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Bisque;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadd.Location = new System.Drawing.Point(364, 475);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(169, 63);
            this.btnadd.TabIndex = 75;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1856, 994);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbld2);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblsupplier);
            this.Controls.Add(this.txts_id);
            this.Controls.Add(this.txts_mail);
            this.Controls.Add(this.lbls_mail);
            this.Controls.Add(this.txts_name);
            this.Controls.Add(this.lbls_name);
            this.Controls.Add(this.lbls_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbls_address);
            this.Controls.Add(this.txts_phone);
            this.Controls.Add(this.lbls_phone);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txts_address);
            this.Controls.Add(this.dgsupplies);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.panel);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsupplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbls_address;
        private System.Windows.Forms.TextBox txts_phone;
        private System.Windows.Forms.Label lbls_phone;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txts_address;
        private System.Windows.Forms.DataGridView dgsupplies;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.Label lblsupplier;
        private System.Windows.Forms.TextBox txts_id;
        private System.Windows.Forms.TextBox txts_mail;
        private System.Windows.Forms.Label lbls_mail;
        private System.Windows.Forms.TextBox txts_name;
        private System.Windows.Forms.Label lbls_name;
        private System.Windows.Forms.Label lbls_id;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Button btnadd;
    }
}