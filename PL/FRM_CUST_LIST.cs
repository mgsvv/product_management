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
    public partial class FRM_CUST_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUST_LIST()
        {
            InitializeComponent();
            this.DGcust.DataSource = cust.GET_ALL_CUSTOMERS();
            this.DGcust.Columns[0].Visible = false;
        }

        private void FRM_CUST_LIST_Load(object sender, EventArgs e)
        {

        }

        private void DGcust_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
