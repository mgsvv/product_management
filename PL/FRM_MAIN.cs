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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;

        static void frm_FormClosed(object sander, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
            
               

    

                public FRM_MAIN()
        {
            InitializeComponent();
        if (frm == null)
            frm = this;
                    
                        
            this.الاصنافToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.bACKUPToolStripMenuItem.Enabled = false;
            this.rESTOREBACKUPToolStripMenuItem.Enabled = false;
        }

        private void اضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_PRODUCT frm = new ADD_PRODUCT();
            frm.ShowDialog(); 


        }

        private void تسجيلدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void ادارةعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER cust = new FRM_CUSTOMER();
            cust.ShowDialog();
        }
    }
}
