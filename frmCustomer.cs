using BMS;
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

namespace BMS
{
    public partial class frmCustomer : Form
    {
         Connection con;

        public frmCustomer()
        {
            InitializeComponent();
            con = new Connection();
          
        }
        private void ShowCust()
        {
            string Query = "select * from tblCustomer";
            dgcustomer.DataSource = con.GetData(Query);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ShowCust();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            UpdateTime();
        }
        private void ClearFields()
        {
            txtc_id.Clear();
            txtc_name.Clear();
            txtc_phone.Clear();
            txtc_mail.Clear();
            txtc_address.Clear();
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



        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtc_id.Text))
            {
                MessageBox.Show("Enter Id");
                return;
            }
            else
            {
                int id = int.Parse(txtc_id.Text);
                Customer customer = Customer.GetCustomerById(id, con); // Fetch customer from DB

                if (customer != null)
                {
                    txtc_name.Text = customer.Name;
                    txtc_phone.Text = customer.Phone;
                    txtc_mail.Text = customer.Email;
                    txtc_address.Text = customer.Address;
                }
                else
                {
                    MessageBox.Show("Data does not exist");
                }
            }



        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtc_id.Text) ||
                string.IsNullOrWhiteSpace(txtc_name.Text) ||
                string.IsNullOrWhiteSpace(txtc_phone.Text) ||
                string.IsNullOrWhiteSpace(txtc_mail.Text) ||
                string.IsNullOrWhiteSpace(txtc_address.Text))
            {
                MessageBox.Show("Missing information");
                return;
            }

            else
            {
                int id = int.Parse(txtc_id.Text);
                string cname = txtc_name.Text;
                string cphone = txtc_phone.Text;
                string caddress = txtc_address.Text;
                string cemail = txtc_mail.Text;

                Customer customer = new Customer(cname, cphone, cemail, caddress)
                {
                    Id = id
                };
                customer.UpdateCustomer(customer, con);

                MessageBox.Show("Record updated");
                ClearFields();
                ShowCust();

            }
        }


        private void btnorder_Click_1(object sender, EventArgs e)
        {
            frmorder frmorder = new frmorder();
            frmorder.Show();
            this.Hide();
        }

        private void dgcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btncust_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(); frmCustomer.Show();
            this.Hide();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtc_id.Text))
            {
                MessageBox.Show("Missing ID");
                return;
            }
            else
            {
                DialogResult dis = MessageBox.Show("Do you want to delete this record?", "Alert", MessageBoxButtons.YesNo);
                if (dis == DialogResult.Yes)
                {
                    int id = int.Parse(txtc_id.Text);
                    string cname = txtc_name.Text;
                    string cphone = txtc_phone.Text;
                    string caddress = txtc_address.Text;
                    string cemail = txtc_mail.Text;

                    Customer customer = new Customer(cname, cphone, cemail, caddress)
                    {
                        Id = id
                    };
                   
                    customer.DeleteCustomer(id, con);

                    MessageBox.Show("Record deleted");
                    ClearFields();
                    ShowCust();
                }
                else if (dis == DialogResult.No)
                {
                    frmCustomer frmCustomer = new frmCustomer();
                    frmCustomer.Show();
                    this.Hide();
                }
            }

        }


        private void btnproduct_Click(object sender, EventArgs e)
        {
            frmProduct p = new frmProduct(); p.Show(); this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(); s.Show(); this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(); fr.Show(); this.Hide();
        }


    }

}