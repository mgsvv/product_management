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
    public partial class frm_main2 : Form
    {
        private static frm_main2 frm;

        static void frm_FormClosed(object sander, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_main2 GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_main2();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public frm_main2()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;


            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_set frm = new frm_set();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_inv frm = new frm_inv();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_user frm = new frm_user();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER frm = new FRM_CUSTOMER();
            frm.ShowDialog();
        }
        
         private void button6_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_main2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reports frm = new frm_reports();
            frm.ShowDialog();
        }
    }
}
