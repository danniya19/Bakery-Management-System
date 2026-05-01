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
    public partial class frmcup : Form
    {
        public frmcup()
        {
            InitializeComponent();
        }

        private void frmcup_Load(object sender, EventArgs e)
        {

        }

        private void lblc_cup_Click(object sender, EventArgs e)
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
