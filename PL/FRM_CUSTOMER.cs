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
    public partial class FRM_CUSTOMER  : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID, posi;
        public FRM_CUSTOMER()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            dataGridView1.Columns[0].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.search_customer(textBox5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cust.ADD_CUSTOMER(tfirst.Text, tlast.Text, ttele.Text, temal.Text);
            MessageBox.Show("تم الاضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            tfirst.Clear();
            tlast.Clear();
            ttele.Clear();
            temal.Clear();
            tfirst.Focus();
        }

        private void tfirst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                tlast.Focus();
            }
        }

        private void tlast_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temal.Focus();
            }
        }

        private void temal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ttele.Focus();
            }
        }

        private void ttele_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode==Keys.Enter)
            {
                btnadd.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID= Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            this.tfirst.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.tlast.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.temal.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.ttele.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();



        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           
            
                cust.edit_CUSTOMERS(tfirst.Text, tlast.Text, ttele.Text, temal.Text,ID);
                MessageBox.Show("تم التعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
         if  (e.KeyCode==Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف العميل؟","الحذف", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cust.delete_customer(ID);
                MessageBox.Show("تم الحذف ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            }
            
        }
        void navigate(int index)
        {
            DataTable dt = cust.GET_ALL_CUSTOMERS();
            tfirst.Text = dt.Rows[index][1].ToString();
            tlast.Text = dt.Rows[index][2].ToString();
            ttele.Text = dt.Rows[index][3].ToString();
            temal.Text = dt.Rows[index][4].ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            posi = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            navigate(posi);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (posi==0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            posi -= 1;
            navigate(posi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (posi == cust.GET_ALL_CUSTOMERS().Rows.Count-1)
            {
                MessageBox.Show("هذا اخر عنصر");
                return;
            }
            posi += 1;
            navigate(posi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            navigate(0);
        }
    }

}
