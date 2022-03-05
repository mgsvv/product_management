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
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS orders = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();
        void calcuAmount()
        {
            if (txtprice.Text != string.Empty && txtqte.Text != string.Empty)
                txtAmount.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqte.Text)).ToString();
        }
        void calcTotalAmount()
        {
            if (txtdis.Text != string.Empty && txtAmount.Text!= string.Empty)
            {
                double discount = Convert.ToDouble(txtdis.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TotalAmount = Amount - (Amount * (discount / 100));
                txttotal.Text = TotalAmount.ToString();
            }
        }

        void clrbox()
        {
            txtnum.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtqte.Clear();
            txtAmount.Clear();
            txtdis.Clear();
            txttotal.Clear();
            button7.Focus();
        }
        void cleardata()
        {
            txtorderid.Clear();
            txtdesorder.Clear();
            txtdis.Text = "0";
            
            txtdt.ResetText();
            txtcustid.Clear();
            custfname.Clear();
            custlast.Clear();
            custEM.Clear();
            custT.Clear();
            clrbox();
            dt.Clear();
            dgLproduct.DataSource = null;
            txtsum.Clear();
            btnsale.Enabled = false;
            button2.Enabled = true;
            
        }

        void createdatatable()
        {
            dt.Columns.Add("رقم المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("السعر");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("الاجمالي");
            dt.Columns.Add("(%)نسبة الخصم");
            dt.Columns.Add("Total");
            dgLproduct.DataSource = dt;
           
        }
        
        
        
        public FRM_ORDERS()
        {
            InitializeComponent();
            createdatatable();
            txtsalesman.Text = Program.salesman;
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtorderid.Text = orders.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            button2.Enabled = false;
            btnsale.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_CUST_LIST frm = new FRM_CUST_LIST();
            frm.ShowDialog();
            txtcustid.Text = frm.DGcust.CurrentRow.Cells[0].Value.ToString();
            custfname.Text = frm.DGcust.CurrentRow.Cells[1].Value.ToString();
            custlast.Text = frm.DGcust.CurrentRow.Cells[2].Value.ToString();
            custT.Text = frm.DGcust.CurrentRow.Cells[3].Value.ToString();
            custEM.Text = frm.DGcust.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clrbox();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();

            frm.ShowDialog();
            txtnum.Text = frm.dgp.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = frm.dgp.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = frm.dgp.CurrentRow.Cells[3].Value.ToString();
            txtqte.Focus();
            
        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtprice.Text!=string.Empty)
                txtqte.Focus();
        }

        private void txtqte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqte.Text != string.Empty)
                txtdis.Focus();
        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            calcuAmount();
            calcTotalAmount();
        }

        private void txtqte_KeyUp(object sender, KeyEventArgs e)
        {
            calcuAmount();
            calcTotalAmount();
        }

        private void txtdis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdis_KeyUp(object sender, KeyEventArgs e)
        {
            calcTotalAmount();
        }

        private void txtdis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (orders.verfiqte(txtnum.Text, Convert.ToInt32(txtqte.Text)).Rows.Count < 1)

                {
                    MessageBox.Show("الكمية لا تكفي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                for (int i=0; i<dgLproduct.Rows.Count-1;i++)
                {
                    if (dgLproduct.Rows[i].Cells[0].Value.ToString() == txtnum.Text)
                    {
                        ;
                    }
                }
                DataRow r = dt.NewRow();
                r[0] = txtnum.Text;
                r[1] = txtname.Text;
                r[2] = txtprice.Text;
                r[3] = txtqte.Text;
                r[4] = txtAmount.Text;
                r[5] = txtdis.Text;
                r[6] = txttotal.Text;
                dt.Rows.Add(r);

                dgLproduct.DataSource = dt;
                clrbox();
                txtsum.Text = (from DataGridViewRow row in dgLproduct.Rows
                               where row.Cells[6].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();


            }
            
        }

        private void dgLproduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtnum.Text = this.dgLproduct.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = this.dgLproduct.CurrentRow.Cells[1].Value.ToString();
                txtprice.Text = this.dgLproduct.CurrentRow.Cells[2].Value.ToString();
                txtqte.Text = this.dgLproduct.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = this.dgLproduct.CurrentRow.Cells[4].Value.ToString();
                txtdis.Text = this.dgLproduct.CurrentRow.Cells[5].Value.ToString();
                txttotal.Text = this.dgLproduct.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgLproduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtsum.Text = (from DataGridViewRow row in dgLproduct.Rows
                           where row.Cells[6].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            txtdis.Text = "0";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgLproduct_DoubleClick(sender, e);
        }

        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgLproduct.Rows.RemoveAt(dgLproduct.CurrentRow.Index);
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgLproduct.Rows.Count - 1; i++)
            {
                dt.Clear();
                dgLproduct.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtorderid.Text==string.Empty|| txtcustid.Text==string.Empty||dgLproduct.Rows.Count<1||txtdesorder.Text==string.Empty)
            {
                MessageBox.Show("يرجي ادخال بيانات الفاتورة", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            orders.ADD_ORDER(Convert.ToInt32(txtorderid.Text), txtdt.Value, Convert.ToInt32(txtcustid.Text), txtdesorder.Text, txtsalesman.Text);

            for (int i=0; i<dgLproduct.Rows.Count-1;i++)
            {
                orders.ADD_ORDER_DETAILS(dgLproduct.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(txtorderid.Text),
                   Convert.ToInt32(dgLproduct.Rows[i].Cells[3].Value),
                    dgLproduct.Rows[i].Cells[2].Value.ToString(),
                   Convert.ToInt32(dgLproduct.Rows[i].Cells[5].Value),
                   dgLproduct.Rows[i].Cells[4].Value.ToString(),
                  dgLproduct.Rows[i].Cells[6].Value.ToString());
            }
            MessageBox.Show("تمت عملية البيع", "بيع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleardata();
        }

        private void txtdesorder_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_PRODUCT frm = new ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
