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
    public partial class frm_cust : Form
    {
        public frm_cust()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER frm = new FRM_CUSTOMER();
            frm.ShowDialog();
        }
    }
}
