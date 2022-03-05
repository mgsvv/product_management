using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace product_management.PL
{
    public partial class FRM_ORDER_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            this.dgvorders.DataSource = order.serach_orders("");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ORDER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void txtserech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvorders.DataSource = order.serach_orders(txtserech.Text);
            }
            catch
            {
                return;
            }
        }
    }
}
