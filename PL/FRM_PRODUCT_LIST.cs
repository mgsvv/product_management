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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.dgp.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void FRM_PRODUCT_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dgp_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
