using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BMS
{
    public partial class frmReports : Form
    {
        Connection con;
        private ReportManager reportManager;

        public frmReports()
        {
            InitializeComponent();
            con = new Connection();
            reportManager = new ReportManager(con);
        }
       

        private void HideAllControls()
        {
            lbled2.Hide();
            lblsd2.Hide();
            lbltsp.Hide();
            label1.Hide();
            dtsd2.Hide();
            dted2.Hide();
            btnsearch3.Hide();
            lbldsr.Hide();
            dtdsr.Hide();
            btnsearch2.Hide();
            lbldsro.Hide();
            btngen.Hide();
            lblpr.Hide();
            lbltgp.Hide();
            lble_date.Hide();
            lbls_date.Hide();
            dtedate.Hide();
            dtsdate.Hide();
            btnsearch1.Hide();
            pqs_chart.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pqs_chart_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            HideAllControls();
            lblpr.Show();
            pqs_chart.Show();

         

            string startdate = dtsdate.Value.ToString("yyyy-MM-dd");
            string enddate = dtedate.Value.ToString("yyyy-MM-dd");

            string query = $"SELECT  tblOrderItems.Product_name, SUM(tblOrderItems.Quantity) AS Total_Quantity FROM tblOrder JOIN tblOrderItems ON tblOrder.Order_id = tblOrderItems.Order_id WHERE tblOrder.Order_date BETWEEN '{startdate}' AND '{enddate}' GROUP BY tblOrderItems.Product_name ORDER BY Total_Quantity Desc";

            pqs_chart.DataSource = con.GetData(query);
            pqs_chart.Series["Sales  Summary"].XValueMember = "Product_name";
            pqs_chart.Series["Sales  Summary"].YValueMembers = "Total_Quantity";
            pqs_chart.Titles.Add("Product Quantity Sales Report");

        }


        private void lble_date_Click(object sender, EventArgs e)
        {

        }

        private void dtedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbls_date_Click(object sender, EventArgs e)
        {

        }

        private void dtsdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblpr_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {

        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {

        }

        private void btncust_Click(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void btnorder_Click_1(object sender, EventArgs e)
        {

            frmorder fo = new frmorder();
            fo.Show();
            this.Hide();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            pqs_chart.Hide();
            lbltgprn.Hide();
            dgrep.Hide();
        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            frmProduct p = new frmProduct(); p.Show(); this.Hide();
        }

        private void btncust_Click_1(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(); frmCustomer.Show();
            this.Hide();
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(); s.Show(); this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(); fr.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAllControls();
            dgrep.Show();
            lbltgprn.Show();

            var totalSalesData = reportManager.GetProductTotalSalesReport();
            if (totalSalesData != null)
            {
                dgrep.DataSource = totalSalesData;
            }
            else
            {
                MessageBox.Show("No sales data available.");
            }

        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {

            string date = dtdsr.Value.ToString("yyyy-MM-dd");
            string totalSales = reportManager.GetTotalSalesByDate(date);

            if (!string.IsNullOrEmpty(totalSales))
            {
                lbldsro.Text = $"Total sales on {date} is: Rs {totalSales}";
            }
            else
            {
                lbldsro.Text = "No sales recorded for the selected date.";
            }

            lbldsro.Show();


        }

        private void btnsearch3_Click(object sender, EventArgs e)
        {
            string startDate = dtsd2.Value.ToString("yyyy-MM-dd");
            string endDate = dted2.Value.ToString("yyyy-MM-dd");
            string totalSales = reportManager.GetTotalSalesByDate(startDate, endDate);

            if (!string.IsNullOrEmpty(totalSales))
            {
                lbltsp.Text = $"Total sales from {startDate} to {endDate} is: Rs {totalSales}";
            }
            else
            {
                lbltsp.Text = "No sales recorded for the selected period.";
            }

            lbltsp.Show();

        }
    }
    public class ReportManager
    {
        private readonly Connection con;

        public ReportManager(Connection connection)
        {
            con = connection;
        }

    
        public DataTable GetProductTotalSalesReport()
        {
            string query = $@"
                SELECT tblOrderItems.Product_name, SUM(tblOrderItems.Quantity * tblProduct.Price) AS Total_Sales
                FROM tblOrderItems
                JOIN tblProduct ON tblOrderItems.Product_name = tblProduct.Product_name
                GROUP BY tblOrderItems.Product_name
                ORDER BY Total_Sales DESC";

            return con.GetData(query);
        }
        public string GetTotalSalesByDate(string date)
        {
            string query = $@"
                SELECT SUM(Total) AS Total_Sales
                FROM tblOrder
                WHERE Order_date = '{date}'";

            using (SqlDataReader reader = con.GetDataReader(query))
            {
                if (reader.Read())
                {
                    return reader["Total_Sales"].ToString();
                }
            }
            return null;
        }
        //method overloading
        public string GetTotalSalesByDate(string startDate, string endDate)
        {
            string query = $@"
                SELECT SUM(Total) AS Total_Sales
                FROM tblOrder
                WHERE Order_date BETWEEN '{startDate}' AND '{endDate}'";

            using (SqlDataReader reader = con.GetDataReader(query))
            {
                if (reader.Read())
                {
                    return reader["Total_Sales"].ToString();
                }
            }
            return null;
        }
    }
}

