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
    public partial class frmlogin : Form
    { Connection con;
        public frmlogin()
        {
            InitializeComponent();
            con = new Connection();
        }

        private bool IsValidAdmin(string username, string password)
        {
            string query = $"SELECT * FROM tblAdmin WHERE username = '{username}' AND password = '{password}'";
            SqlDataReader reader = con.GetDataReader(query);
            bool result = reader.Read();
            reader.Close();
            return result;
        }


        private bool IsValidUser(string username, string password)
        {
            string query = $"SELECT * FROM tbluser WHERE username = '{username}' AND password = '{password}'";
            SqlDataReader reader = con.GetDataReader(query);
            bool result = reader.Read();
            reader.Close();
            return result;
        }


        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpw.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Username and Password");
                return;
            }
            else if (IsValidAdmin(username, password))
            {
                MessageBox.Show("Login successful!");
                frmDashboard fd = new frmDashboard();
                fd.Show();
                this.Hide();
            }
            else if (IsValidUser(username, password))
            {
                MessageBox.Show("Login successful as User!");
                
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!" + "\n" + "TRY AGAIN !!!!");

                txtpw.Clear();
                txtusername.Clear();


            }
        }
        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void lblpw_Click(object sender, EventArgs e)
        {

        }
    }
}
