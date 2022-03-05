
namespace product_management.PL
{
    partial class FRM_BACKUP
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(12, 115);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(159, 30);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "انشاء نسخه احتياطية";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(374, 115);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(159, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtfilename.Location = new System.Drawing.Point(71, 71);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(340, 26);
            this.txtfilename.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nahdi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "تحديد مسار النسخ الاحتياطي";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "....";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "استراد نسخة احتياطية";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btncreate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Nahdi", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النسخ الاحتياطي";
            this.Load += new System.EventHandler(this.FRM_BACKUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}