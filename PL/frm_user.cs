﻿using System;
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
    public partial class frm_user : Form
    {
        public frm_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_USERS frm = new FRM_ADD_USERS();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_USERS frm = new FRM_USERS();
            frm.ShowDialog();
        }
    }
}
