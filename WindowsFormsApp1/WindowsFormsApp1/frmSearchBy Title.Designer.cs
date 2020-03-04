namespace WindowsFormsApp1
{
    partial class frmSearchBy_Title
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.lblChoosetitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(178, 108);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(269, 26);
            this.txtPhonenumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(288, 59);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Customer_ID",
            "Customer_Name",
            "Phone_Number",
            "Technical_Name",
            "Device_Model",
            "Device_Color",
            "Device_imei_1",
            "Device_imei_2",
            "Device_Error",
            "Password_Lock",
            "Sim_Card ",
            "Sd_Card",
            "Amount"});
            this.cboTitle.Location = new System.Drawing.Point(178, 46);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(269, 28);
            this.cboTitle.TabIndex = 4;
            this.cboTitle.Text = "Customer_ID";
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged_1);
            // 
            // lblChoosetitle
            // 
            this.lblChoosetitle.AutoSize = true;
            this.lblChoosetitle.Location = new System.Drawing.Point(32, 54);
            this.lblChoosetitle.Name = "lblChoosetitle";
            this.lblChoosetitle.Size = new System.Drawing.Size(97, 20);
            this.lblChoosetitle.TabIndex = 5;
            this.lblChoosetitle.Text = "Choose Title";
            // 
            // frmSearchBy_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.lblChoosetitle);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSearchBy_Title";
            this.Text = "Search By Title";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label lblChoosetitle;
    }
}