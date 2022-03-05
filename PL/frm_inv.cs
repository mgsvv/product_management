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
    public partial class frm_inv : Form
    {
        public frm_inv()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.txtdesorder.Text = "فاتورة بيع";
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST frm = new FRM_ORDER_LIST();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.btnsale.Text = "صرف";
            frm.txtdesorder.Text = "امر صرف";
            frm.addpro.Visible = false;
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.btnsale.Text = "استلام";
            frm.txtdesorder.Text = "امر استلام";
            frm.addpro.Visible = false;
            frm.labelsalesman.Visible = false;
            frm.groupBoxcust.Visible = false;
            frm.ShowDialog();
        }
    }
}
