namespace BMS
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltgp = new System.Windows.Forms.Label();
            this.pqs_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnsearch1 = new System.Windows.Forms.Button();
            this.lble_date = new System.Windows.Forms.Label();
            this.dtedate = new System.Windows.Forms.DateTimePicker();
            this.lbls_date = new System.Windows.Forms.Label();
            this.dtsdate = new System.Windows.Forms.DateTimePicker();
            this.lblpr = new System.Windows.Forms.Label();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngen = new System.Windows.Forms.Button();
            this.dgrep = new System.Windows.Forms.DataGridView();
            this.lbltgprn = new System.Windows.Forms.Label();
            this.lbldsr = new System.Windows.Forms.Label();
            this.dtdsr = new System.Windows.Forms.DateTimePicker();
            this.btnsearch2 = new System.Windows.Forms.Button();
            this.lbldsro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtsd2 = new System.Windows.Forms.DateTimePicker();
            this.lblsd2 = new System.Windows.Forms.Label();
            this.lbled2 = new System.Windows.Forms.Label();
            this.dted2 = new System.Windows.Forms.DateTimePicker();
            this.btnsearch3 = new System.Windows.Forms.Button();
            this.lbltsp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pqs_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrep)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltgp
            // 
            this.lbltgp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltgp.AutoSize = true;
            this.lbltgp.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltgp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltgp.Location = new System.Drawing.Point(309, 283);
            this.lbltgp.Name = "lbltgp";
            this.lbltgp.Size = new System.Drawing.Size(487, 41);
            this.lbltgp.TabIndex = 87;
            this.lbltgp.Text = "Top Grossing Product Report";
            this.lbltgp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltgp.Click += new System.EventHandler(this.label1_Click);
            // 
            // pqs_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.pqs_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pqs_chart.Legends.Add(legend1);
            this.pqs_chart.Location = new System.Drawing.Point(294, 169);
            this.pqs_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pqs_chart.Name = "pqs_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Sales  Summary";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.pqs_chart.Series.Add(series1);
            this.pqs_chart.Size = new System.Drawing.Size(1517, 787);
            this.pqs_chart.TabIndex = 86;
            this.pqs_chart.Text = "Product Quantity Sales Summary";
            this.pqs_chart.Click += new System.EventHandler(this.pqs_chart_Click);
            // 
            // btnsearch1
            // 
            this.btnsearch1.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch1.Location = new System.Drawing.Point(1338, 92);
            this.btnsearch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch1.Name = "btnsearch1";
            this.btnsearch1.Size = new System.Drawing.Size(169, 56);
            this.btnsearch1.TabIndex = 85;
            this.btnsearch1.Text = "Search";
            this.btnsearch1.UseVisualStyleBackColor = false;
            this.btnsearch1.Click += new System.EventHandler(this.btnsearch1_Click);
            // 
            // lble_date
            // 
            this.lble_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lble_date.AutoSize = true;
            this.lble_date.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lble_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lble_date.Location = new System.Drawing.Point(812, 106);
            this.lble_date.Name = "lble_date";
            this.lble_date.Size = new System.Drawing.Size(185, 30);
            this.lble_date.TabIndex = 84;
            this.lble_date.Text = "Enter end date:\r\n";
            this.lble_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lble_date.Click += new System.EventHandler(this.lble_date_Click);
            // 
            // dtedate
            // 
            this.dtedate.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtedate.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtedate.CalendarTitleBackColor = System.Drawing.Color.Bisque;
            this.dtedate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtedate.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtedate.Location = new System.Drawing.Point(1042, 104);
            this.dtedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtedate.Name = "dtedate";
            this.dtedate.Size = new System.Drawing.Size(256, 36);
            this.dtedate.TabIndex = 83;
            this.dtedate.ValueChanged += new System.EventHandler(this.dtedate_ValueChanged);
            // 
            // lbls_date
            // 
            this.lbls_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbls_date.AutoSize = true;
            this.lbls_date.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbls_date.Location = new System.Drawing.Point(278, 109);
            this.lbls_date.Name = "lbls_date";
            this.lbls_date.Size = new System.Drawing.Size(197, 30);
            this.lbls_date.TabIndex = 82;
            this.lbls_date.Text = "Enter start date:\r\n";
            this.lbls_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbls_date.Click += new System.EventHandler(this.lbls_date_Click);
            // 
            // dtsdate
            // 
            this.dtsdate.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsdate.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtsdate.CalendarTitleBackColor = System.Drawing.Color.Bisque;
            this.dtsdate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtsdate.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsdate.Location = new System.Drawing.Point(521, 106);
            this.dtsdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtsdate.Name = "dtsdate";
            this.dtsdate.Size = new System.Drawing.Size(256, 36);
            this.dtsdate.TabIndex = 81;
            this.dtsdate.ValueChanged += new System.EventHandler(this.dtsdate_ValueChanged);
            // 
            // lblpr
            // 
            this.lblpr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpr.AutoSize = true;
            this.lblpr.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpr.Location = new System.Drawing.Point(744, 25);
            this.lblpr.Name = "lblpr";
            this.lblpr.Size = new System.Drawing.Size(572, 90);
            this.lblpr.TabIndex = 80;
            this.lblpr.Text = " Product Quantity Sales Report\r\n\r\n";
            this.lblpr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblpr.Click += new System.EventHandler(this.lblpr_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Bisque;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreport.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreport.Location = new System.Drawing.Point(40, 893);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(184, 63);
            this.btnreport.TabIndex = 120;
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
            this.btnorder.Location = new System.Drawing.Point(40, 506);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(184, 63);
            this.btnorder.TabIndex = 119;
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
            this.btnsuppliers.Location = new System.Drawing.Point(40, 793);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(184, 63);
            this.btnsuppliers.TabIndex = 118;
            this.btnsuppliers.Text = "Suppliers";
            this.btnsuppliers.UseVisualStyleBackColor = false;
            this.btnsuppliers.Click += new System.EventHandler(this.btnsuppliers_Click_1);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Bisque;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduct.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproduct.Location = new System.Drawing.Point(40, 596);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(184, 63);
            this.btnproduct.TabIndex = 117;
            this.btnproduct.Text = "Products";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click_1);
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.Bisque;
            this.btncust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncust.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncust.Location = new System.Drawing.Point(40, 692);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(184, 63);
            this.btncust.TabIndex = 116;
            this.btncust.Text = "Customer";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click_1);
            // 
            // panel
            // 
            this.panel.Image = ((System.Drawing.Image)(resources.GetObject("panel.Image")));
            this.panel.Location = new System.Drawing.Point(0, -3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(258, 1101);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel.TabIndex = 115;
            this.panel.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // btngen
            // 
            this.btngen.BackColor = System.Drawing.Color.Bisque;
            this.btngen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngen.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngen.Location = new System.Drawing.Point(832, 275);
            this.btngen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(195, 56);
            this.btngen.TabIndex = 122;
            this.btngen.Text = "Generate";
            this.btngen.UseVisualStyleBackColor = false;
            this.btngen.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrep
            // 
            this.dgrep.AllowUserToAddRows = false;
            this.dgrep.AllowUserToDeleteRows = false;
            this.dgrep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrep.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgrep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrep.GridColor = System.Drawing.Color.Bisque;
            this.dgrep.Location = new System.Drawing.Point(391, 118);
            this.dgrep.Name = "dgrep";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrep.RowHeadersWidth = 62;
            this.dgrep.RowTemplate.Height = 28;
            this.dgrep.Size = new System.Drawing.Size(874, 822);
            this.dgrep.TabIndex = 123;
            this.dgrep.TabStop = false;
            // 
            // lbltgprn
            // 
            this.lbltgprn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltgprn.AutoSize = true;
            this.lbltgprn.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltgprn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltgprn.Location = new System.Drawing.Point(714, 25);
            this.lbltgprn.Name = "lbltgprn";
            this.lbltgprn.Size = new System.Drawing.Size(551, 45);
            this.lbltgprn.TabIndex = 124;
            this.lbltgprn.Text = "Top Grossing Products Report\r\n";
            this.lbltgprn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbldsr
            // 
            this.lbldsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldsr.AutoSize = true;
            this.lbldsr.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldsr.Location = new System.Drawing.Point(309, 464);
            this.lbldsr.Name = "lbldsr";
            this.lbldsr.Size = new System.Drawing.Size(322, 41);
            this.lbldsr.TabIndex = 125;
            this.lbldsr.Text = "Daily Sales Report";
            this.lbldsr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtdsr
            // 
            this.dtdsr.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdsr.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtdsr.CalendarTitleBackColor = System.Drawing.Color.Bisque;
            this.dtdsr.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtdsr.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdsr.Location = new System.Drawing.Point(710, 468);
            this.dtdsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtdsr.Name = "dtdsr";
            this.dtdsr.Size = new System.Drawing.Size(256, 36);
            this.dtdsr.TabIndex = 126;
            // 
            // btnsearch2
            // 
            this.btnsearch2.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch2.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch2.Location = new System.Drawing.Point(1014, 449);
            this.btnsearch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch2.Name = "btnsearch2";
            this.btnsearch2.Size = new System.Drawing.Size(169, 56);
            this.btnsearch2.TabIndex = 127;
            this.btnsearch2.Text = "Search";
            this.btnsearch2.UseVisualStyleBackColor = false;
            this.btnsearch2.Click += new System.EventHandler(this.btnsearch2_Click);
            // 
            // lbldsro
            // 
            this.lbldsro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldsro.AutoSize = true;
            this.lbldsro.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldsro.Location = new System.Drawing.Point(497, 556);
            this.lbldsro.Name = "lbldsro";
            this.lbldsro.Size = new System.Drawing.Size(0, 41);
            this.lbldsro.TabIndex = 128;
            this.lbldsro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(309, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 41);
            this.label1.TabIndex = 129;
            this.label1.Text = "Total Sales for Selected Period";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtsd2
            // 
            this.dtsd2.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsd2.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtsd2.CalendarTitleBackColor = System.Drawing.Color.Bisque;
            this.dtsd2.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtsd2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsd2.Location = new System.Drawing.Point(540, 761);
            this.dtsd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtsd2.Name = "dtsd2";
            this.dtsd2.Size = new System.Drawing.Size(256, 36);
            this.dtsd2.TabIndex = 130;
            // 
            // lblsd2
            // 
            this.lblsd2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblsd2.AutoSize = true;
            this.lblsd2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsd2.Location = new System.Drawing.Point(311, 767);
            this.lblsd2.Name = "lblsd2";
            this.lblsd2.Size = new System.Drawing.Size(197, 30);
            this.lblsd2.TabIndex = 131;
            this.lblsd2.Text = "Enter start date:\r\n";
            this.lblsd2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbled2
            // 
            this.lbled2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbled2.AutoSize = true;
            this.lbled2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbled2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbled2.Location = new System.Drawing.Point(875, 761);
            this.lbled2.Name = "lbled2";
            this.lbled2.Size = new System.Drawing.Size(185, 30);
            this.lbled2.TabIndex = 132;
            this.lbled2.Text = "Enter end date:\r\n";
            this.lbled2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dted2
            // 
            this.dted2.CalendarFont = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dted2.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dted2.CalendarTitleBackColor = System.Drawing.Color.Bisque;
            this.dted2.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dted2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dted2.Location = new System.Drawing.Point(1086, 755);
            this.dted2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dted2.Name = "dted2";
            this.dted2.Size = new System.Drawing.Size(256, 36);
            this.dted2.TabIndex = 133;
            // 
            // btnsearch3
            // 
            this.btnsearch3.BackColor = System.Drawing.Color.Bisque;
            this.btnsearch3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch3.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsearch3.Location = new System.Drawing.Point(1398, 743);
            this.btnsearch3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch3.Name = "btnsearch3";
            this.btnsearch3.Size = new System.Drawing.Size(169, 56);
            this.btnsearch3.TabIndex = 134;
            this.btnsearch3.Text = "Search";
            this.btnsearch3.UseVisualStyleBackColor = false;
            this.btnsearch3.Click += new System.EventHandler(this.btnsearch3_Click);
            // 
            // lbltsp
            // 
            this.lbltsp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltsp.AutoSize = true;
            this.lbltsp.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltsp.Location = new System.Drawing.Point(514, 846);
            this.lbltsp.Name = "lbltsp";
            this.lbltsp.Size = new System.Drawing.Size(0, 41);
            this.lbltsp.TabIndex = 135;
            this.lbltsp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1856, 1050);
            this.Controls.Add(this.lbltsp);
            this.Controls.Add(this.btnsearch3);
            this.Controls.Add(this.dted2);
            this.Controls.Add(this.lbled2);
            this.Controls.Add(this.lblsd2);
            this.Controls.Add(this.dtsd2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldsro);
            this.Controls.Add(this.btnsearch2);
            this.Controls.Add(this.dtdsr);
            this.Controls.Add(this.lbldsr);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.dgrep);
            this.Controls.Add(this.lbltgp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnsearch1);
            this.Controls.Add(this.lble_date);
            this.Controls.Add(this.dtedate);
            this.Controls.Add(this.lbls_date);
            this.Controls.Add(this.dtsdate);
            this.Controls.Add(this.lblpr);
            this.Controls.Add(this.pqs_chart);
            this.Controls.Add(this.lbltgprn);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pqs_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltgp;
        private System.Windows.Forms.DataVisualization.Charting.Chart pqs_chart;
        private System.Windows.Forms.Button btnsearch1;
        private System.Windows.Forms.Label lble_date;
        private System.Windows.Forms.DateTimePicker dtedate;
        private System.Windows.Forms.Label lbls_date;
        private System.Windows.Forms.DateTimePicker dtsdate;
        private System.Windows.Forms.Label lblpr;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.DataGridView dgrep;
        private System.Windows.Forms.Label lbltgprn;
        private System.Windows.Forms.Label lbldsr;
        private System.Windows.Forms.DateTimePicker dtdsr;
        private System.Windows.Forms.Button btnsearch2;
        private System.Windows.Forms.Label lbldsro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtsd2;
        private System.Windows.Forms.Label lblsd2;
        private System.Windows.Forms.Label lbled2;
        private System.Windows.Forms.DateTimePicker dted2;
        private System.Windows.Forms.Button btnsearch3;
        private System.Windows.Forms.Label lbltsp;
    }
}