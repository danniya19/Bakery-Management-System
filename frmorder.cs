using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using BMS;
using System.Data;

namespace BMS
{
    public partial class frmorder : Form
    {
        private Connection _con;
        private CustomerManager _customerManager;
        private OrderManager _orderManager;
        private Order _order;
        private List<Product1> _products;
        private Customer _customer;
        private string b = "";
        private int totalqaunity = 0;
        private int Total = 0;

        public frmorder()
        {
            InitializeComponent();
            _con = new Connection();
            _customerManager = new CustomerManager(_con);
            _products = LoadProducts();  // A method to load products from DB
            _orderManager = new OrderManager(_con, _products);
        }

     
        private void frmorder_Load(object sender, EventArgs e)
        {
            ShowCust();
            dgorder.Hide();
            lblohis.Hide();
            lblacust.Show();
            lblc_id.Show();
            lblc_name.Show();
            lblc_address.Show();
            lblc_mail.Show();
            lblc_phone.Show();
            txtc_address.Show();
            txtc_id.Show();
            txtc_name.Show();
            txtc_phone.Show();
            txtc_mail.Show();
            dgcustomer.Show();
            lblbill.Hide();
            btnadd.Show();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            btnsearch.Show();
            UpdateTime();
            btnplace.Hide();
            btnprint.Hide();
            btnnext.Hide();
            btnohistory.Hide();
            btnplace.Show();
        }
        private void btnohistory_Click(object sender, EventArgs e)
        {
            lblodr.Hide();
            btnnext.Hide();
           
            lblacust.Hide();
            lblc_id.Hide();
            lblc_name.Hide();
            lblc_address.Hide();
            lblc_mail.Hide();
            lblc_phone.Hide();
            txtc_address.Hide();
            txtc_id.Hide();
            txtc_name.Hide();
            txtc_phone.Hide();
            txtc_mail.Hide();
            dgcustomer.Hide();
            lblbill.Show();
            btnadd.Hide();
            btnsearch.Hide();
            btnplace.Hide();
            lblbill.Hide();
            btnohistory.Hide();
            dgorder.Show();
            btnprint.Hide();
           
            DataTable orderHistory = Order.GetOrderHistory(_con);

            // Set the DataGridView's data source to the order history DataTable
            dgorder.DataSource = orderHistory;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnorder_Click(object sender, EventArgs e)
        {
            frmorder frmorder = new frmorder();
            frmorder.Show();
            this.Hide();
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(); frmCustomer.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<Product1> LoadProducts()
        {
            var products = new List<Product1>();
            string query = "SELECT id, Product_name, Price, Quantity_available FROM tblProduct";
            SqlDataReader reader = _con.GetDataReader(query);

            while (reader.Read())
            {
                products.Add(new Product1(
                    int.Parse(reader["id"].ToString()),
                    reader["Product_name"].ToString(),
                    int.Parse(reader["Price"].ToString()),
                    int.Parse(reader["Quantity_available"].ToString())));
            }
            reader.Close();
            return products;
        }

        private void btnplaceodr_Click(object sender, EventArgs e)
        {
            //// Ensure at least one item is selected
            //if (IsAnyItemSelected())
            //{
            //    // Create a dictionary of product quantities
            //    var productQuantities = GetSelectedProducts();

            //    if (productQuantities.Count > 0)
            //    {
            //        // Process the order
            //        ProcessOrder(productQuantities);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Select at least one product.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Select Atleast one item");
            //}

        }

        // Helper method to check if any item is selected
        //private bool IsAnyItemSelected()
        //{
        //    return nchick_p.Value > 0 || nco_cake.Value > 0 || ncr_cake.Value > 0 ||
        //           nc_cp.Value > 0 || nstr_cake.Value > 0 || nS_m.Value > 0 ||
        //           nv_p.Value > 0 || nC_cake.Value > 0 || nrv_cake.Value > 0 ||
        //           nc_p.Value > 0 || nv_c.Value > 0 || ns_d.Value > 0 ||
        //           nrv_cup.Value > 0 || ns_q.Value > 0 || nc_e.Value > 0 ||
        //           nl_cup.Value > 0 || ncm_tart.Value > 0 || nec_c.Value > 0 ||
        //           nras_c.Value > 0 || nor_cup.Value > 0 || nb_q.Value > 0 ||
        //           nps_c.Value > 0 || ncs_tart.Value > 0 || ncp_cup.Value > 0 ||
        //           ns_tart.Value > 0 || nlb_cake.Value > 0;
        //}

        // Helper method to gather selected products and quantities into a dictionary
        //private Dictionary<int, int> GetSelectedProducts()
        //{
        //    var productQuantities = new Dictionary<int, int>();

        //    if (nC_cake.Value > 0) productQuantities.Add(1, (int)nC_cake.Value);
        //    if (nS_m.Value > 0) productQuantities.Add(2, (int)nS_m.Value);
        //    if (nchick_p.Value > 0) productQuantities.Add(3, (int)nchick_p.Value);
        //    if (nv_p.Value > 0) productQuantities.Add(4, (int)nv_p.Value);
        //    if (ncr_cake.Value > 0) productQuantities.Add(5, (int)ncr_cake.Value);
        //    if (nrv_cake.Value > 0) productQuantities.Add(6, (int)nrv_cake.Value);
        //    if (nc_cp.Value > 0) productQuantities.Add(7, (int)nc_cp.Value);
        //    if (nc_p.Value > 0) productQuantities.Add(8, (int)nc_p.Value);
        //    if (nco_cake.Value > 0) productQuantities.Add(9, (int)nco_cake.Value);
        //    if (nstr_cake.Value > 0) productQuantities.Add(10, (int)nstr_cake.Value);
        //    if (nv_c.Value > 0) productQuantities.Add(11, (int)nv_c.Value);
        //    if (ns_d.Value > 0) productQuantities.Add(12, (int)ns_d.Value);
        //    if (nrv_cup.Value > 0) productQuantities.Add(13, (int)nrv_cup.Value);
        //    if (ns_q.Value > 0) productQuantities.Add(14, (int)ns_q.Value);
        //    if (nc_e.Value > 0) productQuantities.Add(15, (int)nc_e.Value);
        //    if (nl_cup.Value > 0) productQuantities.Add(16, (int)nl_cup.Value);
        //    if (ncm_tart.Value > 0) productQuantities.Add(17, (int)ncm_tart.Value);
        //    if (nec_c.Value > 0) productQuantities.Add(18, (int)nec_c.Value);
        //    if (nras_c.Value > 0) productQuantities.Add(19, (int)nras_c.Value);
        //    if (nor_cup.Value > 0) productQuantities.Add(20, (int)nor_cup.Value);
        //    if (nb_q.Value > 0) productQuantities.Add(21, (int)nb_q.Value);
        //    if (nps_c.Value > 0) productQuantities.Add(22, (int)nps_c.Value);
        //    if (ncs_tart.Value > 0) productQuantities.Add(23, (int)ncs_tart.Value);
        //    if (ncp_cup.Value > 0) productQuantities.Add(24, (int)ncp_cup.Value);
        //    if (ns_tart.Value > 0) productQuantities.Add(25, (int)ns_tart.Value);
        //    if (nlb_cake.Value > 0) productQuantities.Add(26, (int)nlb_cake.Value);

        //    return productQuantities;
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            lbld.Text = DateTime.Now.ToLongTimeString();
            lbld2.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void btnorder_Click_1(object sender, EventArgs e)
        {
            frmorder frmorder = new frmorder();
            frmorder.Show();
            this.Hide();
        }

        private void btncust_Click_1(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(); frmCustomer.Show();
            this.Hide();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtc_cake_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dgcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string billText = "";
        private void lblbill_Click(object sender, EventArgs e)
        {

        }

        // Helper method to process the order
        private void ProcessOrder(Dictionary<int, int> productQuantities)
        {
            // Fetch product data
            string query = "SELECT id, Product_name, Price, Quantity_available FROM tblProduct";
            SqlDataReader read = _con.GetDataReader(query);

            while (read.Read())
            {
                int id = int.Parse(read["id"].ToString());
                string pname = read["Product_name"].ToString();
                int price = int.Parse(read["Price"].ToString());
                int avaiquant = int.Parse(read["Quantity_available"].ToString());

                // Check if the product is selected and if there's enough stock
                if (productQuantities.ContainsKey(id))
                {
                    int quantity = productQuantities[id];

                    if (avaiquant >= quantity)
                    {
                        // Update totals
                        totalqaunity += quantity;
                        int totcost = quantity * price;
                        Total += totcost;

                        // Update stock in the database
                        int newq = avaiquant - quantity;
                        string updateQuery = $"UPDATE tblProduct SET Quantity_available = {newq} WHERE id = {id}";
                        conn.Open();
                        cmd = new SqlCommand(updateQuery, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        // Append to order string
                        b += $"{quantity} * {pname}     Price: {price}    Total: {totcost}\n";
                    }
                    else
                    {
                        // Show message if stock is insufficient
                        MessageBox.Show($"{avaiquant} of {pname} is available. Please reduce the quantity.");
                        return;
                    }
                }
            }
            read.Close();

            // Hide the order input controls
            HideOrderControls();

            // Show customer controls and load customer data
            ShowCustomerControls();
            ShowCust();
            btnprint.Hide();
           
        }

        // Hide the product selection controls
        private void HideOrderControls()
        {
            btnohistory.Hide();
            lblodr.Hide();
            btnnext.Hide();

        }

        // Show customer-related controls
        private void ShowCustomerControls()
        {
            lblacust.Show();
            lblc_id.Show();
            lblc_name.Show();
            lblc_address.Show();
            lblc_mail.Show();
            lblc_phone.Show();
            txtc_address.Show();
            txtc_id.Show();
            txtc_name.Show();
            txtc_phone.Show();
            txtc_mail.Show();
            dgcustomer.Show();
            btnadd.Show();
            btnsearch.Show();
            btnplace.Show();
        }

        private void ShowCust()
        {
            string Query = "select * from tblCustomer";
            dgcustomer.DataSource = _con.GetData(Query);
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
         //   if (string.IsNullOrEmpty(txtc_name.Text) || string.IsNullOrEmpty(txtc_phone.Text) ||
         //string.IsNullOrEmpty(txtc_mail.Text) || string.IsNullOrEmpty(txtc_address.Text))
         //   {
         //       MessageBox.Show("Please fill in all the fields.");
         //   }
         //   else
         //   {
         //       // Create a new customer object and save it to the database
         //       Customer newCustomer = new Customer(txtc_name.Text, txtc_phone.Text, txtc_mail.Text, txtc_address.Text);
         //       _customerManager.AddCustomer(newCustomer);  // Add customer using CustomerManager

         //       MessageBox.Show("New customer added successfully!");

         //       // Refresh the customer list
         //       ShowCust();

         //       // Optionally, clear the input fields after adding
         //       ClearCustomerFields();
         //   }
        }

        // Helper method to clear the customer input fields
        private void ClearCustomerFields()
        {
            txtc_name.Clear();
            txtc_phone.Clear();
            txtc_mail.Clear();
            txtc_address.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtc_id.Text == "")
            {
                MessageBox.Show("Enter Id");
                return;
            }
            else
            {
                int customerId = int.Parse(txtc_id.Text);
                _customer = _customerManager.GetCustomerById(customerId);
                if (_customer != null)
                {
                    txtc_name.Text = _customer.Name;
                    txtc_phone.Text = _customer.Phone;
                    txtc_mail.Text = _customer.Email;
                    txtc_address.Text = _customer.Address;
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Validate customer information
            //if (txtc_id.Text == "" || txtc_name.Text == "" || txtc_phone.Text == "" || txtc_mail.Text == "" || txtc_address.Text == "")
            //{
            //    MessageBox.Show("Missing information");
            //}
            //else
            //{
            lblodr.Hide();
            //    btnnext.Hide();
            //    //lblchick_p.Hide();
            //    //lblco_cake.Hide();
            //    //lblcr_cake.Hide();
            //    //lblc_cake.Hide();
            //    //lblc_cup.Hide();
            //    //lblc_p.Hide();
            //    //lblrv_cake.Hide();
            //    //lblv_p.Hide();
            //    //lblStr_cake.Hide();
            //    //lblsm.Hide();
            //    //nchick_p.Hide();
            //    //nco_cake.Hide();
            //    //ncr_cake.Hide();
            //    //nc_cp.Hide();
            //    //nstr_cake.Hide();
            //    //nS_m.Hide();
            //    //nv_p.Hide();
            //    //nC_cake.Hide();
            //    //nrv_cake.Hide();
            //    //nc_p.Hide();
            lblacust.Hide();
                lblc_id.Hide();
                lblc_name.Hide();
                lblc_address.Hide();
                lblc_mail.Hide();
                lblc_phone.Hide();
                txtc_address.Hide();
                txtc_id.Hide();
                txtc_name.Hide();
                txtc_phone.Hide();
                txtc_mail.Hide();
                dgcustomer.Hide();
                lblbill.Show();
                btnadd.Hide();
                btnsearch.Hide();
                btnplace.Hide();
                btnprint.Show();
                //lblv_p.Hide();
                //lblStr_cake.Hide();
                //lblsm.Hide();
                //lblcm_tart.Hide();
                //lblvcake.Hide();
                //lbls_d.Hide();
                //lblrv_cup.Hide();
                //lbls_q.Hide();
                //lblc_e.Hide();
                //lbll_cup.Hide();
                //lblcm_tart.Hide();
                //lblec_c.Hide();
                //lblR_c.Hide();
                //lbllb_cake.Hide();
                //nlb_cake.Hide();
                //lblor_cup.Hide();
                //lblb_q.Hide();
                //lblp_c.Hide();
                //lblcs_t.Hide();
                //lblcp_cup.Hide();
                //lbls_tart.Hide();
                //nv_c.Hide();
                //ns_d.Hide();
                //nrv_cup.Hide();
                //ns_q.Hide();
                //nc_e.Hide();
                //nl_cup.Hide();
                //ncm_tart.Hide();
                //nec_c.Hide();
                //nras_c.Hide();
                //nor_cup.Hide();
                //nb_q.Hide();
                //nps_c.Hide();
                //ncs_tart.Hide();
                //ncp_cup.Hide();
                //ns_tart.Hide();


                //int c_id = int.Parse(txtc_id.Text);
                billText += $"\n\n\t\t\t\t\t\t\t\t\t\tTEMPETATIONS BAKESHOP \n \t\t\t\t\t\t\t\t\t\t*\n\n\t\t\t\t\t\t\t\t\t {DateTime.Now.ToLongTimeString()}\n {DateTime.Now.ToString("dddd, dd MMMM yyyy")}\n\n ";

            //    try
            //    {   

            //        // Create and save the order
            //        _order = new SalesOrder(_con, c_id, this.Total);
            //        _order.Save();

            //        // Retrieve the order ID
            //        string query2 = $"SELECT Order_id FROM tblOrder WHERE customer_id = {c_id}";
            //        SqlDataReader read = _con.GetDataReader(query2);
            //        int oid = 0;
            //        if (read.Read())
            //        {
            //            billText += $"Order Id: {read["Order_id"].ToString()}\n";
            //            oid = int.Parse(read["Order_id"].ToString());
            //        }
            //        read.Close();

            //        // Insert the ordered items into tblOrderItems
            //        InsertOrderItems(oid);

            //        // Retrieve and display customer info
            //        string query3 = $"SELECT Customer_name, Customer_email, Customer_phone, Customer_address FROM tblCustomer WHERE Customer_id = {c_id}";
            //        SqlDataReader read2 = _con.GetDataReader(query3);
            //        if (read2.Read())
            //        {
            //            billText += $"Customer Name: {read2["Customer_name"].ToString()}\n" +
            //                        $"Customer Phone: {read2["Customer_phone"].ToString()}\n";
            //        }
            //        read2.Close();

            //        // Display the final bill
            //        billText += $"\n\n{b} \n\n\n Total: {Total}\n\n\n*Thank you for shopping*\n";
            lblbill.Text = billText;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QR7621L4\SQLEXPRESS02;Initial Catalog=Bakery_Management_System;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True");

        SqlCommand cmd;






        // Insert order items into tblOrderItems
        //private void InsertOrderItems(int oid)
        //{
        //    string query = "SELECT id, Product_name, Price, Quantity_available FROM tblProduct";
        //    SqlDataReader read = _con.GetDataReader(query);

        //    while (read.Read())
        //    {
        //        int id = int.Parse(read["id"].ToString());
        //        string pname = read["Product_name"].ToString();
        //        int price = int.Parse(read["Price"].ToString());
        //        int avaiquant = int.Parse(read["Quantity_available"].ToString());

        //        // Get the corresponding NumericUpDown control for the product
        //        NumericUpDown N = GetProductControl(id);
        //        int quantity = (int)N.Value;

        //        if (quantity != 0)
        //        {
        //            int totcost = quantity * price;
        //            string query4 = $"INSERT INTO tblOrderItems VALUES ({oid}, '{pname}', {quantity}, {totcost})";
        //            conn.Open();
        //            cmd = new SqlCommand(query4, conn);
        //            cmd.ExecuteNonQuery(); // Execute the insert query for each order item
        //            conn.Close();
        //        }
        //    }
        //    read.Close();
        //}

        // Get the NumericUpDown control for a given product
        //private NumericUpDown GetProductControl(int productId)
        //{
        //    switch (productId)
        //    {
        //        case 1: return nC_cake;
        //        case 2: return nS_m;
        //        case 3: return nchick_p;
        //        case 4: return nv_p;
        //        case 5: return ncr_cake;
        //        case 6: return nrv_cake;
        //        case 7: return nc_cp;
        //        case 8: return nc_p;
        //        case 9: return nco_cake;
        //        case 10: return nstr_cake;
        //        case 11: return nv_c;
        //        case 12: return ns_d;
        //        case 13: return nrv_cup;
        //        case 14: return ns_q;
        //        case 15: return nc_e;
        //        case 16: return nl_cup;
        //        case 17: return ncm_tart;
        //        case 18: return nec_c;
        //        case 19: return nras_c;
        //        case 20: return nor_cup;
        //        case 21: return nb_q;
        //        case 22: return nps_c;
        //        case 23: return ncs_tart;
        //        case 24: return ncp_cup;
        //        case 25: return ns_tart;
        //        case 26: return nlb_cake;
        //        default: return null;
        //    }
        //}


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Set margins
            int leftMargin = 90;
            int topMargin = 50;
            int x = leftMargin;
            int y = topMargin;

            string[] lines = billText.Split('\n');

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            foreach (string line in lines)
            {
                // Draw text
                RectangleF rect = new RectangleF(leftMargin, y, e.MarginBounds.Width - 2 * leftMargin, font.Height);
                e.Graphics.DrawString(line, font, brush, rect, format);
                y += 20;
            }
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void dgorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(); s.Show(); this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            frmProduct p = new frmProduct(); p.Show(); this.Hide();
        }

        private void numericUpDown8_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(); fr.Show(); this.Hide();
        }
    }



    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer(string name, string phone, string email, string address)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }

        // Save customer to the database
        public void Save(Connection con)
        {
            string query = "INSERT INTO tblCustomer (Customer_name, Customer_email, Customer_phone, Customer_address) " +
                           "VALUES ('" + Name + "', '" + Email + "', '" + Phone + "', '" + Address + "')";
            con.SetData(query);  // Using SetData to execute the query
        }

        // Get customer by ID from the database
        public static Customer GetCustomerById(int id, Connection con)
        {
            string query = $"SELECT Customer_name, Customer_email, Customer_phone, Customer_address FROM tblCustomer WHERE Customer_id = {id}";

            SqlDataReader read = null;

            try
            {
                read = con.GetDataReader(query);

                if (read.Read())
                {
                    var customer = new Customer(
                        read["Customer_name"].ToString(),
                        read["Customer_phone"].ToString(),
                        read["Customer_email"].ToString(),
                        read["Customer_address"].ToString());

                    return customer;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception if necessary
                throw new Exception("Error fetching customer data", ex);
            }
            finally
            {
                // Ensure the reader is closed in all cases
                read.Close();
            }

            return null; // Return null if no data is found

        }
        public DataTable GetAllCustomers(Connection con)
        {
            string query = "SELECT * FROM tblCustomer";
            return con.GetData(query);  // Uses the GetData method from Connection
        }

        

        public void UpdateCustomer(Customer customer, Connection con)
        {
            string query = $@"
            UPDATE tblCustomer 
            SET Customer_name = '{customer.Name}', 
                Customer_email = '{customer.Email}', 
                Customer_phone = {customer.Phone}, 
                Customer_address = '{customer.Address}' 
            WHERE Customer_id = {customer.Id}";

            con.SetData(query);
        }

        public void DeleteCustomer(int id,Connection con)
        {
            string query = $"DELETE FROM tblCustomer WHERE Customer_id = {id}";
            con.SetData(query);
        }
    }
        // Order Class
        public abstract class Order
        {
            protected Connection _con;
            protected int _customerId;
            protected int _total;

            public Order(Connection con, int customerId, int total)
            {
                _con = con;
                _customerId = customerId;
                _total = total;
            }

        // Abstract method to save the order
        public abstract void Save();
          

            // Method to get order history
            public static DataTable GetOrderHistory(Connection con)
            {
                string query = "SELECT tblOrder.Order_id, tblCustomer.Customer_name, tblCustomer.Customer_phone, tblOrder.Order_date, tblOrder.Total " +
                               "FROM tblCustomer " +
                               "JOIN tblOrder ON tblOrder.Customer_id = tblCustomer.Customer_id";
                return con.GetData(query);  // Using GetData to execute the query
            }
        }

        // SalesOrder Class (inherits from Order)
        public class SalesOrder : Order
        {
            public SalesOrder(Connection con, int customerId, int total) : base(con, customerId, total) { }
        public override void Save()
        {
            string query = $"INSERT INTO tblOrder (Customer_id, Order_date, Total) VALUES ({_customerId}, '{DateTime.Now.ToString("yyyy-MM-dd")}', {_total})";
            _con.SetData(query);  // Using SetData to execute the insert query
        }

    }

        // OrderManager Class
        public class OrderManager
        {
            private Connection _con;
            private List<Product1> _products; 
            private int _total;

            public OrderManager(Connection conn, List<Product1> products) 
            {
                _con = conn;
                _products = products;
                _total = 0;
            }

            public void PlaceOrder(int customerId, Dictionary<int, int> productQuantities)
            {
                foreach (var item in productQuantities)
                {
                    var product = _products.FirstOrDefault(p => p.Id == item.Key);
                    if (product != null && product.HasSufficientStock(item.Value))
                    {
                        product.ReduceStock(item.Value);
                        _total += product.Price * item.Value;
                        UpdateProductStock(product);
                    }
                }

                SaveOrder(customerId);
            }

            private void SaveOrder(int customerId)
            {
                SalesOrder order = new SalesOrder(_con, customerId, _total);
                order.Save();
            }

            private void UpdateProductStock(Product1 product)
            {
                string query = $"UPDATE tblProduct SET Quantity_available = {product.QuantityAvailable} WHERE id = {product.Id}";
                _con.SetData(query);  // Using SetData to execute the update query
            }
        }

        // CustomerManager Class
        public class CustomerManager
        {
            private Connection _con;

            public CustomerManager(Connection conn)
            {
                _con = conn;
            }

            public Customer GetCustomerById(int id)
            {
                return Customer.GetCustomerById(id, _con);
            }

            public void AddCustomer(Customer customer)
            {
                customer.Save(_con);
            }
        }

        // Product Class
        public class Product1
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int QuantityAvailable { get; set; }

            public Product1(int id, string name, int price, int quantityAvailable)
            {
                Id = id;
                Name = name;
                Price = price;
                QuantityAvailable = quantityAvailable;
            }

            public bool HasSufficientStock(int quantity)
            {
                return QuantityAvailable >= quantity;
            }

            public void ReduceStock(int quantity)
            {
                QuantityAvailable -= quantity;
            }
        }
    }
