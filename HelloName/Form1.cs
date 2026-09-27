using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtYourname_TextChanged(null, null);
        }

        private void lblYourname_MouseMove(object sender, MouseEventArgs e)
        {
            lblYourname.ForeColor = Color.Blue;
        }

        private void lblYourname_MouseLeave(object sender, EventArgs e)
        {
            lblYourname.ForeColor = Color.Black;
        }

        private void btnSayhello_Click(object sender, EventArgs e)
        {
            string s = "Hello " + txtYourname.Text;
            lblResult.Text = s;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourname.Text = "";
            lblResult.Text = "";
            txtYourname.Focus();
        }

        private void txtYourname_TextChanged(object sender, EventArgs e)
        {
            if (txtYourname.Text == "")
                btnSayhello.Enabled = false;
            else
                btnSayhello.Enabled = true;
            btnClear.Enabled = Convert.ToBoolean(txtYourname.Text.Length);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
