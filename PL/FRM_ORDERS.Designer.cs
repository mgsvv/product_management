
namespace product_management.PL
{
    partial class FRM_ORDERS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdt = new System.Windows.Forms.DateTimePicker();
            this.labelsalesman = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.txtdesorder = new System.Windows.Forms.TextBox();
            this.txtsalesman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxcust = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.custfname = new System.Windows.Forms.TextBox();
            this.custlast = new System.Windows.Forms.TextBox();
            this.custT = new System.Windows.Forms.TextBox();
            this.custEM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dgLproduct = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addpro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxcust.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLproduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.labelsalesman);
            this.groupBox1.Controls.Add(this.txtorderid);
            this.groupBox1.Controls.Add(this.txtdesorder);
            this.groupBox1.Controls.Add(this.txtsalesman);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // txtdt
            // 
            this.txtdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdt.Location = new System.Drawing.Point(141, 170);
            this.txtdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(132, 26);
            this.txtdt.TabIndex = 7;
            this.txtdt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelsalesman
            // 
            this.labelsalesman.AutoSize = true;
            this.labelsalesman.Location = new System.Drawing.Point(280, 218);
            this.labelsalesman.Name = "labelsalesman";
            this.labelsalesman.Size = new System.Drawing.Size(69, 19);
            this.labelsalesman.TabIndex = 6;
            this.labelsalesman.Text = "اسم البائع";
            // 
            // txtorderid
            // 
            this.txtorderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorderid.Location = new System.Drawing.Point(141, 57);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.ReadOnly = true;
            this.txtorderid.Size = new System.Drawing.Size(130, 26);
            this.txtorderid.TabIndex = 5;
            // 
            // txtdesorder
            // 
            this.txtdesorder.Location = new System.Drawing.Point(141, 97);
            this.txtdesorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdesorder.Multiline = true;
            this.txtdesorder.Name = "txtdesorder";
            this.txtdesorder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdesorder.Size = new System.Drawing.Size(132, 51);
            this.txtdesorder.TabIndex = 0;
            this.txtdesorder.TextChanged += new System.EventHandler(this.txtdesorder_TextChanged);
            // 
            // txtsalesman
            // 
            this.txtsalesman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalesman.Location = new System.Drawing.Point(141, 218);
            this.txtsalesman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsalesman.Name = "txtsalesman";
            this.txtsalesman.ReadOnly = true;
            this.txtsalesman.Size = new System.Drawing.Size(130, 26);
            this.txtsalesman.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الاصدار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "وصف الفاتورة";
            // 
            // groupBoxcust
            // 
            this.groupBoxcust.Controls.Add(this.button6);
            this.groupBoxcust.Controls.Add(this.txtcustid);
            this.groupBoxcust.Controls.Add(this.custfname);
            this.groupBoxcust.Controls.Add(this.custlast);
            this.groupBoxcust.Controls.Add(this.custT);
            this.groupBoxcust.Controls.Add(this.custEM);
            this.groupBoxcust.Controls.Add(this.label9);
            this.groupBoxcust.Controls.Add(this.label8);
            this.groupBoxcust.Controls.Add(this.label7);
            this.groupBoxcust.Controls.Add(this.label6);
            this.groupBoxcust.Controls.Add(this.label5);
            this.groupBoxcust.Location = new System.Drawing.Point(432, 13);
            this.groupBoxcust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxcust.Name = "groupBoxcust";
            this.groupBoxcust.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxcust.Size = new System.Drawing.Size(445, 253);
            this.groupBoxcust.TabIndex = 1;
            this.groupBoxcust.TabStop = false;
            this.groupBoxcust.Text = "بيانات العميل";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(130, 51);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 25);
            this.button6.TabIndex = 0;
            this.button6.Text = "....";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtcustid
            // 
            this.txtcustid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcustid.Location = new System.Drawing.Point(176, 51);
            this.txtcustid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.ReadOnly = true;
            this.txtcustid.Size = new System.Drawing.Size(146, 26);
            this.txtcustid.TabIndex = 2;
            // 
            // custfname
            // 
            this.custfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custfname.Location = new System.Drawing.Point(176, 86);
            this.custfname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custfname.Name = "custfname";
            this.custfname.ReadOnly = true;
            this.custfname.Size = new System.Drawing.Size(146, 26);
            this.custfname.TabIndex = 3;
            // 
            // custlast
            // 
            this.custlast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custlast.Location = new System.Drawing.Point(176, 123);
            this.custlast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custlast.Name = "custlast";
            this.custlast.ReadOnly = true;
            this.custlast.Size = new System.Drawing.Size(146, 26);
            this.custlast.TabIndex = 4;
            // 
            // custT
            // 
            this.custT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custT.Location = new System.Drawing.Point(176, 156);
            this.custT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custT.Name = "custT";
            this.custT.ReadOnly = true;
            this.custT.Size = new System.Drawing.Size(146, 26);
            this.custT.TabIndex = 5;
            // 
            // custEM
            // 
            this.custEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custEM.Location = new System.Drawing.Point(176, 191);
            this.custEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custEM.Name = "custEM";
            this.custEM.ReadOnly = true;
            this.custEM.Size = new System.Drawing.Size(146, 26);
            this.custEM.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "الهاتف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "الاسم العائلي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "البريد الالكتروني";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "الاسم الشخصي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم العميل";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.dgLproduct);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtdis);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtqte);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtnum);
            this.groupBox3.Location = new System.Drawing.Point(51, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(819, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(749, 46);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 26);
            this.button7.TabIndex = 22;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(749, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 27);
            this.label18.TabIndex = 21;
            this.label18.Text = "اختيار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgLproduct
            // 
            this.dgLproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLproduct.ColumnHeadersVisible = false;
            this.dgLproduct.ContextMenuStrip = this.contextMenuStrip1;
            this.dgLproduct.Location = new System.Drawing.Point(0, 75);
            this.dgLproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLproduct.MultiSelect = false;
            this.dgLproduct.Name = "dgLproduct";
            this.dgLproduct.ReadOnly = true;
            this.dgLproduct.RowHeadersWidth = 51;
            this.dgLproduct.RowTemplate.Height = 24;
            this.dgLproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLproduct.Size = new System.Drawing.Size(813, 201);
            this.dgLproduct.TabIndex = 0;
            this.dgLproduct.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgLproduct_RowsRemoved);
            this.dgLproduct.DoubleClick += new System.EventHandler(this.dgLproduct_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.rEMOVEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 76);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.rEMOVEToolStripMenuItem.Text = "REMOVE";
            this.rEMOVEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(8, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 27);
            this.label17.TabIndex = 19;
            this.label17.Text = "Total";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(8, 47);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(121, 26);
            this.txttotal.TabIndex = 20;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(128, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 27);
            this.label16.TabIndex = 17;
            this.label16.Text = "الخصم %";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdis
            // 
            this.txtdis.Location = new System.Drawing.Point(128, 47);
            this.txtdis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdis.MaxLength = 3;
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(90, 26);
            this.txtdis.TabIndex = 18;
            this.txtdis.Text = "0";
            this.txtdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            this.txtdis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdis_KeyDown);
            this.txtdis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdis_KeyPress);
            this.txtdis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdis_KeyUp);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(307, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "الكمية";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(307, 47);
            this.txtqte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqte.MaxLength = 8;
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(90, 26);
            this.txtqte.TabIndex = 16;
            this.txtqte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqte_KeyDown);
            this.txtqte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqte_KeyPress);
            this.txtqte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtqte_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(218, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 27);
            this.label14.TabIndex = 13;
            this.label14.Text = "الاجمالي";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(216, 47);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(92, 26);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(480, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 27);
            this.label13.TabIndex = 11;
            this.label13.Text = "  اسم المنتج";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(480, 47);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(183, 26);
            this.txtname.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(392, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 27);
            this.label12.TabIndex = 9;
            this.label12.Text = "السعر";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(397, 47);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprice.MaxLength = 8;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(85, 26);
            this.txtprice.TabIndex = 10;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            this.txtprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyUp);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(661, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "رقم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(661, 47);
            this.txtnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnum.Name = "txtnum";
            this.txtnum.ReadOnly = true;
            this.txtnum.Size = new System.Drawing.Size(90, 26);
            this.txtnum.TabIndex = 8;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(648, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "الاجمالي";
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(728, 563);
            this.txtsum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(151, 26);
            this.txtsum.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Image = global::product_management.Properties.Resources.shutdown_48px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(739, 597);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 63);
            this.button5.TabIndex = 7;
            this.button5.Text = "خروج";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = global::product_management.Properties.Resources.stack_of_paper_48px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(597, 597);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 63);
            this.button4.TabIndex = 6;
            this.button4.Text = "طباعة";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnsale
            // 
            this.btnsale.Enabled = false;
            this.btnsale.Image = global::product_management.Properties.Resources.ok_48px;
            this.btnsale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsale.Location = new System.Drawing.Point(453, 597);
            this.btnsale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(141, 63);
            this.btnsale.TabIndex = 5;
            this.btnsale.Text = "بيع";
            this.btnsale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsale.UseVisualStyleBackColor = true;
            this.btnsale.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::product_management.Properties.Resources.new_copy_48px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(312, 597);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "فاتورة جديدة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addpro
            // 
            this.addpro.Image = global::product_management.Properties.Resources.poster_48px;
            this.addpro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addpro.Location = new System.Drawing.Point(53, 558);
            this.addpro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addpro.Name = "addpro";
            this.addpro.Size = new System.Drawing.Size(231, 41);
            this.addpro.TabIndex = 3;
            this.addpro.Text = "اضافة المنتج جديد";
            this.addpro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addpro.UseVisualStyleBackColor = true;
            this.addpro.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 661);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnsale);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addpro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxcust);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nahdi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية بيع";
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxcust.ResumeLayout(false);
            this.groupBoxcust.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLproduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtdt;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.TextBox txtsalesman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox custfname;
        private System.Windows.Forms.TextBox custlast;
        private System.Windows.Forms.TextBox custT;
        private System.Windows.Forms.TextBox custEM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgLproduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        public System.Windows.Forms.Button btnsale;
        public System.Windows.Forms.TextBox txtdesorder;
        public System.Windows.Forms.Button addpro;
        public System.Windows.Forms.Label labelsalesman;
        public System.Windows.Forms.GroupBox groupBoxcust;
    }
}