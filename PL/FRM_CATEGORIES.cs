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
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"server=.\;database=product_DB;integrated security=true ");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select id_cat as 'رقم الصنف',description_cat as 'اسم الصنف' from categorise", sqlcon);
            da.Fill(dt);
            dgLIST.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "رقم الصنف");
            txtDES.DataBindings.Add("text", dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            lepos.Text = (bmb.Position+1) + "/" + bmb.Count;
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFIRST_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnLAST_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnPREV_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNEX_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNEW.Enabled = false;
            btnADD.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtDES.Focus();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الاضاقة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;
            btnADD.Enabled = false;
            btnNEW.Enabled = true;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التحديث", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lepos.Text = (bmb.Position + 1) + "/" + bmb.Count;
            
            
        }
    }
}
