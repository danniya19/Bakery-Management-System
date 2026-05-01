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
    public partial class frmcakes : Form
    {
        public frmcakes()
        {
            InitializeComponent();
        }

        private void lblcat_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblco_cake_Click(object sender, EventArgs e)
        {

        }

        private void nco_cake_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblcr_cake_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmcat fc = new frmcat();
            fc.Show();
            this.Hide();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            frmOrdercust foc = new frmOrdercust();
            foc.Show();
            this.Hide();
        }
    }
}
