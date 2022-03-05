using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management.PL
{
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (dt.Rows.Count>0)
            {
                if (dt.Rows[0][2].ToString() == "admin")
                {

                    frm_main2.GetMainForm.button1.Enabled = true;
                    frm_main2.GetMainForm.button2.Enabled = true;
                    frm_main2.GetMainForm.button3.Enabled = true;
                    frm_main2.GetMainForm.button4.Enabled = true;
                    frm_main2.GetMainForm.button5.Enabled = true;
                    frm_main2.GetMainForm.button5.Visible = true;
                    frm_main2.GetMainForm.button6.Enabled = true;
                    Program.salesman = dt.Rows[0]["fullname"].ToString();

                    this.Close();

                }
                else if(dt.Rows[0][2].ToString() == "employ")
                {

                    frm_main2.GetMainForm.button1.Enabled = true;
                    frm_main2.GetMainForm.button2.Enabled = true;
                    frm_main2.GetMainForm.button3.Enabled = true;
                    frm_main2.GetMainForm.button4.Enabled = true;
                    frm_main2.GetMainForm.button5.Visible = false;
                    frm_main2.GetMainForm.button6.Enabled = true;
                    Program.salesman = dt.Rows[0]["fullname"].ToString();

                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("login failed");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();
            }
        }
    }
}
