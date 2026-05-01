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
    public partial class frmSupplier : Form
    {
        Connection con;
        public frmSupplier()
        {
            InitializeComponent();
            con = new Connection();
        }
        private void ShowSupp()
        {
            string Query = "select * from tblSupplier";
            dgsupplies.DataSource = con.GetData(Query);
        }
        private void ClearFields()
        {
            txts_id.Clear();
            txts_name.Clear();
            txts_phone.Clear();
            txts_mail.Clear();
            txts_address.Clear();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txts_id.Text) ||
                string.IsNullOrWhiteSpace(txts_name.Text) ||
                string.IsNullOrWhiteSpace(txts_phone.Text) ||
                string.IsNullOrWhiteSpace(txts_mail.Text) ||
                string.IsNullOrWhiteSpace(txts_address.Text))
            {
                MessageBox.Show("Missing information. Please fill all fields.");
                return false;
            }

            if (!int.TryParse(txts_id.Text, out _) || !long.TryParse(txts_phone.Text, out _))
            {
                MessageBox.Show("Invalid ID or Phone number format.");
                return false;
            }

            return true;
        }
        private void lblc_phone_Click(object sender, EventArgs e)
        {

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

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier s = new frmSupplier(); s.Show(); this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txts_id.Text) || !int.TryParse(txts_id.Text, out int id))
            {
                MessageBox.Show("Enter a valid Supplier ID.");
                return;
            }

            var supplier = Supplier.Search(con, id);

            if (supplier != null)
            {
                txts_name.Text = supplier.Name;
                txts_phone.Text = supplier.Phone.ToString();
                txts_mail.Text = supplier.Email;
                txts_address.Text = supplier.Address;
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }


        }

            private void btnupdate_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                var supplier = new Supplier
                {
                    Id = int.Parse(txts_id.Text),
                    Name = txts_name.Text,
                    Email = txts_mail.Text,
                    Phone = long.Parse(txts_phone.Text),
                    Address = txts_address.Text
                };

                supplier.Update(con);

                MessageBox.Show("Supplier record updated successfully.");
                ClearFields();
                ShowSupp();
            }
        }

        private void dgsupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            UpdateTime();
            ShowSupp();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                var supplier = new Supplier
                {
                    Id = int.Parse(txts_id.Text),
                    Name = txts_name.Text,
                    Email = txts_mail.Text,
                    Phone = long.Parse(txts_phone.Text),
                    Address = txts_address.Text
                };

                supplier.Add(con);

                MessageBox.Show("New supplier added successfully.");
                ClearFields();
                ShowSupp();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txts_id.Text) || !int.TryParse(txts_id.Text, out int id))
            {
                MessageBox.Show("Enter a valid Supplier ID.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Supplier.Delete(con, id);
                MessageBox.Show("Supplier record deleted successfully.");
                ClearFields();
                ShowSupp();
            }
            }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(); fr.Show(); this.Hide();
        }
    }
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }

        public void Add(Connection con)
        {
            string query = $"INSERT INTO tblSupplier VALUES({Id}, '{Name}', '{Email}', {Phone}, '{Address}')";
            con.SetData(query);
        }

        public void Update(Connection con)
        {
            string query = $"UPDATE tblSupplier SET Supplier_name ='{Name}', Supplier_email ='{Email}', Supplier_phone = {Phone}, Supplier_address = '{Address}' WHERE Supplier_id={Id}";
            con.SetData(query);
        }

        public static Supplier Search(Connection con, int id)
        {
            string query = $"SELECT Supplier_name, Supplier_email, Supplier_phone, Supplier_address FROM tblSupplier WHERE Supplier_id = {id}";
            SqlDataReader reader = con.GetDataReader(query);

            if (reader.Read())
            {
                var supplier = new Supplier
                {
                    Id = id,
                    Name = reader["Supplier_name"].ToString(),
                    Email = reader["Supplier_email"].ToString(),
                    Phone = long.Parse(reader["Supplier_phone"].ToString()),
                    Address = reader["Supplier_address"].ToString()
                };
                reader.Close();
                return supplier;
            }

            reader.Close();
            return null;
        }

        public static void Delete(Connection con, int id)
        {
            string query = $"DELETE FROM tblSupplier WHERE Supplier_id = {id}";
            con.SetData(query);
        }
    }
}
