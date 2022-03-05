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
    public partial class FRM_USERS : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public FRM_USERS()
        {
            InitializeComponent();
            this.dgvuser.DataSource = login.searchusers("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_ADD_USERS frm = new FRM_ADD_USERS();
            frm.btnsave.Text = "حفظ المستخدم";
            frm.ShowDialog();
            this.dgvuser.DataSource = login.searchusers("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USERS frm = new FRM_ADD_USERS();
            frm.txtname.Text = dgvuser.CurrentRow.Cells[0].Value.ToString();
            frm.txtfullname.Text = dgvuser.CurrentRow.Cells[1].Value.ToString();
            frm.txtpwd.Text = dgvuser.CurrentRow.Cells[2].Value.ToString();
            frm.txtpwd2.Text = dgvuser.CurrentRow.Cells[2].Value.ToString();
            frm.txtacess.Text = dgvuser.CurrentRow.Cells[3].Value.ToString();
            frm.btnsave.Text = "تعديل";
            frm.ShowDialog();

        }

        private void FRM_USERS_Load(object sender, EventArgs e)
        {

        }

        private void txtserech_TextChanged(object sender, EventArgs e)
        {
            this.dgvuser.DataSource = login.searchusers(txtserech.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
