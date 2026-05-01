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
    public partial class frmcatc : Form
    {
        public frmcatc()
        {
            InitializeComponent();
        }

        private void cake_Click(object sender, EventArgs e)
        {
            frmcakec frmcakec = new frmcakec();
            frmcakec.Show();
            this.Hide();
        }

        private void cup_Click(object sender, EventArgs e)
        {
            frmcupc frmcupc = new frmcupc();
            frmcupc.Show();
            this.Hide();
        }

        private void sav_Click(object sender, EventArgs e)
        {
            frmsavc frm = new frmsavc();
            frm.Show();
            this.Hide();

        }
    }
}
