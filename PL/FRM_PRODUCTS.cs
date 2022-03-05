using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace product_management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }

            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SerechProduct(txtserech.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_PRODUCT frm = new ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADD_PRODUCT frm = new ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtcmb.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Text="تحديث المنتج" +  this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOk.Text = "تحديث";
            frm.state = "update";
            frm.txtRef.ReadOnly = true;
            frm.ShowDialog();
           

        }

       
    }
}
