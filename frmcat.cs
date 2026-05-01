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
    public partial class frmcat : Form
    {
        public frmcat()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            frmcakes fc = new frmcakes();
            fc.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmcup frmcup = new frmcup();
            frmcup.Show();
            this.Hide();
        }

        private void sav_Click(object sender, EventArgs e)
        {
            frmsavouries fs = new frmsavouries();
            fs.Show();
            this.Hide();
        }
    }
}
