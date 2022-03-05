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
    public partial class ADD_PRODUCT : Form
    {
        public string state = "add";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public ADD_PRODUCT()
        {
            InitializeComponent();
            txtcmb.DataSource = prd.GET_ALL_CATAGORIES();
            txtcmb.DisplayMember = "description_cat";
            txtcmb.ValueMember = "id_cat";


        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور|*.jpg;*.png;*.gif*;.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb.Image.Save(ms, pb.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.ADD_PRODUCT(Convert.ToInt32(txtcmb.SelectedValue), txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteimage);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRef.Clear();
                txtDes.Clear();
                txtPrice.Clear();
                txtQte.Clear();
                txtRef.Focus();
            }
            else
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb.Image.Save(ms, pb.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.update_product(Convert.ToInt32(txtcmb.SelectedValue), txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteimage);
                MessageBox.Show("تمت التحديث بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        
          
        

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.verifyProductdi(txtRef.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("الصنف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }

        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
        }

        private void ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }
    }
}
