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
    public partial class frmOrdercust : Form
    {
        public frmOrdercust()
        {
           
            InitializeComponent();
            lblbill.Hide();
            lblc_id.Hide();
            txtc_id.Hide();
        }

        private void lblbill_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            lblacust.Hide();
            lblc_address.Hide();
            lblc_id.Hide();
            lblc_name.Hide();
            lblc_mail.Hide();
            lblc_phone.Hide();
            lblc_address.Hide();
            txtc_address.Hide();
            txtc_id.Hide() ;
            txtc_mail.Hide() ;
            txtc_phone.Hide() ;
            txtc_name.Hide() ;
            lblbill.Show();
            btnadd.Hide();
            btnnext.Hide();
            

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void frmOrdercust_Load(object sender, EventArgs e)
        {

        }
    }
}
