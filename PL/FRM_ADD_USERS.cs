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
    public partial class FRM_ADD_USERS : Form
    {
        public FRM_ADD_USERS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtname.Text== string.Empty||txtpwd.Text==string.Empty||txtpwd2.Text==string.Empty
                ||txtfullname.Text==string.Empty)
            {
                MessageBox.Show("خطا في بيانات المستخدم", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpwd.Text != txtpwd2.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BL.CLS_LOGIN user = new BL.CLS_LOGIN();
            user.ADD_USER(txtname.Text, txtfullname.Text, txtpwd.Text, txtacess.Text);
            MessageBox.Show("تم اضافة المستخدم", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Clear();
            txtfullname.Clear();
            txtpwd.Clear();
            txtpwd2.Clear();
            txtname.Focus();

        }

        private void txtpwd2_Validated(object sender, EventArgs e)
        {
            if(txtpwd.Text != txtpwd2.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(btnsave.Text=="اضافة")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(txtname.Text, txtfullname.Text, txtpwd.Text, txtacess.Text);
                MessageBox.Show("تم اضافة المستخدم", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (btnsave.Text=="تعديل")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(txtname.Text, txtfullname.Text, txtpwd.Text, txtacess.Text);
                MessageBox.Show("تم تعديل المستخدم", "مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            txtname.Clear();
            txtfullname.Clear();
            txtpwd.Clear();
            txtpwd2.Clear();
            txtname.Focus();

        }
        

        private void FRM_ADD_USERS_Load(object sender, EventArgs e)
        {

        }
    }
}
