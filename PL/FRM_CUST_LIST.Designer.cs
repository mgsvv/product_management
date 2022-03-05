
namespace product_management.PL
{
    partial class FRM_CUST_LIST
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
            this.DGcust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGcust)).BeginInit();
            this.SuspendLayout();
            // 
            // DGcust
            // 
            this.DGcust.AllowUserToDeleteRows = false;
            this.DGcust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGcust.Location = new System.Drawing.Point(0, 0);
            this.DGcust.Name = "DGcust";
            this.DGcust.ReadOnly = true;
            this.DGcust.RowHeadersWidth = 51;
            this.DGcust.RowTemplate.Height = 24;
            this.DGcust.Size = new System.Drawing.Size(800, 450);
            this.DGcust.TabIndex = 0;
            this.DGcust.DoubleClick += new System.EventHandler(this.DGcust_DoubleClick);
            // 
            // FRM_CUST_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGcust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUST_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة العملاء";
            this.Load += new System.EventHandler(this.FRM_CUST_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGcust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGcust;
    }
}