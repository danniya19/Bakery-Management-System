using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class frmaccount1 : Form
    {
        Connection con;
        public frmaccount1()
        {
            InitializeComponent();
            con = new Connection();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string phone = txtphone.Text;
            string email = txtmail.Text;
            string add = txtaddress.Text;
            string pass = txtpass.Text;

            string query1 = $"INSERT INTO tblCustomer (Customer_name, Customer_email, Customer_phone, Customer_address) values ('{name}', '{email}', {phone}, '{add}')";
            con.SetData(query1);

            string query2 = $"insert into tbluser values ('{name}','{pass}')";
            con.SetData(query2);

            MessageBox.Show("Account created Succesfully");
                frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
            this.Hide();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
