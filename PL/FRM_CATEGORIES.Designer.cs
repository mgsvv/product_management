
namespace product_management.PL
{
    partial class FRM_CATEGORIES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgLIST = new System.Windows.Forms.DataGridView();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.lepos = new System.Windows.Forms.Label();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnLAST = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnNEX = new System.Windows.Forms.Button();
            this.btnPREV = new System.Windows.Forms.Button();
            this.btnFIRST = new System.Windows.Forms.Button();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnEXIT);
            this.groupBox1.Controls.Add(this.btnNEW);
            this.groupBox1.Controls.Add(this.btnDEL);
            this.groupBox1.Controls.Add(this.lepos);
            this.groupBox1.Controls.Add(this.btnEDIT);
            this.groupBox1.Controls.Add(this.btnLAST);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.btnNEX);
            this.groupBox1.Controls.Add(this.btnPREV);
            this.groupBox1.Controls.Add(this.btnFIRST);
            this.groupBox1.Controls.Add(this.txtDES);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(799, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgLIST);
            this.groupBox2.Location = new System.Drawing.Point(43, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(250, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة الأصناف ";
            // 
            // dgLIST
            // 
            this.dgLIST.AllowUserToAddRows = false;
            this.dgLIST.AllowUserToDeleteRows = false;
            this.dgLIST.AllowUserToResizeColumns = false;
            this.dgLIST.AllowUserToResizeRows = false;
            this.dgLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLIST.Location = new System.Drawing.Point(6, 26);
            this.dgLIST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLIST.Name = "dgLIST";
            this.dgLIST.RowHeadersWidth = 51;
            this.dgLIST.RowTemplate.Height = 24;
            this.dgLIST.Size = new System.Drawing.Size(238, 217);
            this.dgLIST.TabIndex = 0;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Image = global::product_management.Properties.Resources.shutdown_48px;
            this.btnEXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXIT.Location = new System.Drawing.Point(299, 194);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(95, 52);
            this.btnEXIT.TabIndex = 13;
            this.btnEXIT.Text = "خروج";
            this.btnEXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnNEW
            // 
            this.btnNEW.Image = global::product_management.Properties.Resources.new_copy_48px;
            this.btnNEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNEW.Location = new System.Drawing.Point(597, 194);
            this.btnNEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(95, 52);
            this.btnNEW.TabIndex = 12;
            this.btnNEW.Text = "جديد";
            this.btnNEW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.Image = global::product_management.Properties.Resources.Remove_48px;
            this.btnDEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDEL.Location = new System.Drawing.Point(501, 194);
            this.btnDEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(95, 52);
            this.btnDEL.TabIndex = 11;
            this.btnDEL.Text = "حذف";
            this.btnDEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // lepos
            // 
            this.lepos.AutoSize = true;
            this.lepos.Location = new System.Drawing.Point(621, 153);
            this.lepos.Name = "lepos";
            this.lepos.Size = new System.Drawing.Size(47, 19);
            this.lepos.TabIndex = 8;
            this.lepos.Text = "label3";
            this.lepos.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Image = global::product_management.Properties.Resources.design_48px;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.Location = new System.Drawing.Point(400, 194);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(95, 52);
            this.btnEDIT.TabIndex = 10;
            this.btnEDIT.Text = "تعديل";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnLAST
            // 
            this.btnLAST.Image = global::product_management.Properties.Resources.skip_to_start_48px;
            this.btnLAST.Location = new System.Drawing.Point(475, 140);
            this.btnLAST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLAST.Name = "btnLAST";
            this.btnLAST.Size = new System.Drawing.Size(48, 46);
            this.btnLAST.TabIndex = 7;
            this.btnLAST.UseVisualStyleBackColor = true;
            this.btnLAST.Click += new System.EventHandler(this.btnLAST_Click);
            // 
            // btnADD
            // 
            this.btnADD.Enabled = false;
            this.btnADD.Image = global::product_management.Properties.Resources.add_48px;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.Location = new System.Drawing.Point(698, 194);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 52);
            this.btnADD.TabIndex = 9;
            this.btnADD.Text = "إضافة ";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnNEX
            // 
            this.btnNEX.Image = global::product_management.Properties.Resources.rewind_48px;
            this.btnNEX.Location = new System.Drawing.Point(549, 140);
            this.btnNEX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNEX.Name = "btnNEX";
            this.btnNEX.Size = new System.Drawing.Size(48, 46);
            this.btnNEX.TabIndex = 6;
            this.btnNEX.UseVisualStyleBackColor = true;
            this.btnNEX.Click += new System.EventHandler(this.btnNEX_Click);
            // 
            // btnPREV
            // 
            this.btnPREV.Image = global::product_management.Properties.Resources.fast_forward_48px;
            this.btnPREV.Location = new System.Drawing.Point(686, 140);
            this.btnPREV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPREV.Name = "btnPREV";
            this.btnPREV.Size = new System.Drawing.Size(48, 46);
            this.btnPREV.TabIndex = 5;
            this.btnPREV.UseVisualStyleBackColor = true;
            this.btnPREV.Click += new System.EventHandler(this.btnPREV_Click);
            // 
            // btnFIRST
            // 
            this.btnFIRST.Image = global::product_management.Properties.Resources.end_48px;
            this.btnFIRST.Location = new System.Drawing.Point(750, 140);
            this.btnFIRST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFIRST.Name = "btnFIRST";
            this.btnFIRST.Size = new System.Drawing.Size(48, 46);
            this.btnFIRST.TabIndex = 4;
            this.btnFIRST.UseVisualStyleBackColor = true;
            this.btnFIRST.Click += new System.EventHandler(this.btnFIRST_Click);
            // 
            // txtDES
            // 
            this.txtDES.Location = new System.Drawing.Point(425, 89);
            this.txtDES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDES.Name = "txtDES";
            this.txtDES.Size = new System.Drawing.Size(253, 26);
            this.txtDES.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(605, 40);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(73, 26);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الصنف";
            // 
            // FRM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 267);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nahdi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORIES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف ";
            this.Load += new System.EventHandler(this.FRM_CATEGORIES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLIST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Label lepos;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnLAST;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnNEX;
        private System.Windows.Forms.Button btnPREV;
        private System.Windows.Forms.Button btnFIRST;
        private System.Windows.Forms.TextBox txtDES;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgLIST;
        private System.Windows.Forms.Button btnEXIT;
    }
}