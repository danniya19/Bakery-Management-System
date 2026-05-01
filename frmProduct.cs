using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class frmProduct : Form
    {
        Connection con;
        private Product selectedProduct;
        public frmProduct()
        {
            InitializeComponent();
            con = new Connection();
        }
        private void ShowProd()
        {
            string Query = "select id , Product_name ,P_category ,Price ,Quantity_available , P_description from tblProduct";
            dgProduct.DataSource = con.GetData(Query);
        }
        private void LoadProductDetails(int id)
        {
            string query = $"SELECT Product_name, P_description, P_category, Price, Quantity_available FROM tblProduct WHERE id = {id}";
            SqlDataReader reader = con.GetDataReader(query);

            if (reader.Read())
            {
                selectedProduct = new Product
                {
                    Id = id,
                    Name = reader["Product_name"].ToString(),
                    Description = reader["P_description"].ToString(),
                    Category = reader["P_category"].ToString(),
                    Price = int.Parse(reader["Price"].ToString()),
                    QuantityAvailable = int.Parse(reader["Quantity_available"].ToString())
                };

                txtp_name.Text = selectedProduct.Name;
                txtp_desc.Text = selectedProduct.Description;
                txtp_cat.Text = selectedProduct.Category;
                txtprice.Text = selectedProduct.Price.ToString();
                txtqunat.Text = selectedProduct.QuantityAvailable.ToString();
            }
            else
            {
                MessageBox.Show("Data does not exist");
            }
            reader.Close();
        }

        private void UpdateProduct()
        {
            if (ValidateInputs())
            {
                selectedProduct.Name = txtp_name.Text;
                selectedProduct.Description = txtp_desc.Text;
                selectedProduct.Category = txtp_cat.Text;
                selectedProduct.Price = int.Parse(txtprice.Text);
                selectedProduct.QuantityAvailable = int.Parse(txtqunat.Text);

                string query = $"UPDATE tblProduct SET Product_name = '{selectedProduct.Name}', P_description = '{selectedProduct.Description}', P_category = '{selectedProduct.Category}', Price = {selectedProduct.Price}, Quantity_available = {selectedProduct.QuantityAvailable} WHERE id = {selectedProduct.Id}";
                con.SetData(query);

                MessageBox.Show("Record updated");
                ClearFields();
                ShowProd();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtp_id.Text) ||
                string.IsNullOrWhiteSpace(txtp_name.Text) ||
                string.IsNullOrWhiteSpace(txtp_desc.Text) ||
                string.IsNullOrWhiteSpace(txtp_cat.Text) ||
                string.IsNullOrWhiteSpace(txtprice.Text) ||
                string.IsNullOrWhiteSpace(txtqunat.Text))
            {
                MessageBox.Show("Missing information");
                return false;
            }

            if (!int.TryParse(txtprice.Text, out _) || !int.TryParse(txtqunat.Text, out _))
            {
                MessageBox.Show("Price and Quantity must be numeric");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtp_name.Clear();
            txtp_id.Clear();
            txtprice.Clear();
            txtqunat.Clear();
            txtp_cat.Clear();
            txtprice.Clear();
            txtp_desc.Clear();
        }
        private void txtc_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtp_id.Text))
            {
                MessageBox.Show("Enter ID");
                return;
            }

            int id = int.Parse(txtp_id.Text);
            LoadProductDetails(id);
        }
        

        private void btnupdate_Click(object sender, EventArgs e)
        {

            UpdateProduct();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            lbld.Text = DateTime.Now.ToLongTimeString();
            lbld2.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            ShowProd(); 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

          
            UpdateTime();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            frmorder fo = new frmorder();
            fo.Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            frmProduct p = new frmProduct(); p.Show(); this.Hide();
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(); frmCustomer.Show();
            this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(); fr.Show(); this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(); s.Show(); this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int QuantityAvailable { get; set; }
       
    }
}