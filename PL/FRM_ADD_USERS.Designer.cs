
namespace product_management.PL
{
    partial class FRM_ADD_USERS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtpwd2 = new System.Windows.Forms.TextBox();
            this.txtacess = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاكيد كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "صلاحية المستخدم";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(134, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 26);
            this.txtname.TabIndex = 0;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(134, 65);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(188, 26);
            this.txtfullname.TabIndex = 1;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(134, 97);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(188, 26);
            this.txtpwd.TabIndex = 2;
            // 
            // txtpwd2
            // 
            this.txtpwd2.Location = new System.Drawing.Point(134, 129);
            this.txtpwd2.Name = "txtpwd2";
            this.txtpwd2.Size = new System.Drawing.Size(188, 26);
            this.txtpwd2.TabIndex = 3;
            this.txtpwd2.Validated += new System.EventHandler(this.txtpwd2_Validated);
            // 
            // txtacess
            // 
            this.txtacess.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtacess.FormattingEnabled = true;
            this.txtacess.Items.AddRange(new object[] {
            "admin",
            "employ"});
            this.txtacess.Location = new System.Drawing.Point(134, 161);
            this.txtacess.Name = "txtacess";
            this.txtacess.Size = new System.Drawing.Size(188, 27);
            this.txtacess.TabIndex = 4;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::product_management.Properties.Resources.add_48px1;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(96, 217);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(113, 43);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "اضافة";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.Image = global::product_management.Properties.Resources.shutdown_48px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(209, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_ADD_USERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtacess);
            this.Controls.Add(this.txtpwd2);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nahdi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_USERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.Load += new System.EventHandler(this.FRM_ADD_USERS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtfullname;
        public System.Windows.Forms.TextBox txtpwd;
        public System.Windows.Forms.TextBox txtpwd2;
        public System.Windows.Forms.ComboBox txtacess;
    }
}