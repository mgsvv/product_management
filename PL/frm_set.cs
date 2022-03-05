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
    public partial class frm_set : Form
    {
        public frm_set()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD_PRODUCT frm = new ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }
    }
}
