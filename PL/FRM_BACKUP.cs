using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace product_management.PL
{
    public partial class FRM_BACKUP : Form
    {

        SqlConnection con = new SqlConnection(@"server=.\;database=product_DB;integrated security=true ");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtfilename.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string filename = txtfilename.Text + "Product_DB" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + "-" + DateTime.Now.ToLongDateString().Replace(':','-') ;
            string strquery = "backup database Product_DB to disk ='" + filename + ".bak'";
            cmd = new SqlCommand(strquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء نسخه احتياطية ", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
