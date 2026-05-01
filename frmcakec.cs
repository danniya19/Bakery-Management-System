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
    public partial class frmcakec : Form
    {
        public frmcakec()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            frmorder frmorder = new frmorder();
            frmorder.Show();
            this.Hide();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmcat fc = new frmcat();
            fc.Show();
            this.Hide();
        }
    }
}
