namespace WindowsFormsApp1
{
    partial class frmUpdatetable
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
            this.lblChoosetitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChoosetitle
            // 
            this.lblChoosetitle.AutoSize = true;
            this.lblChoosetitle.Location = new System.Drawing.Point(50, 71);
            this.lblChoosetitle.Name = "lblChoosetitle";
            this.lblChoosetitle.Size = new System.Drawing.Size(97, 20);
            this.lblChoosetitle.TabIndex = 0;
            this.lblChoosetitle.Text = "Choose Title";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Customer_ID";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(189, 116);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(305, 26);
            this.txtPhonenumber.TabIndex = 2;
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
            "Sim_Card",
            "Sd_Card",
            "Amount"});
            this.cboTitle.Location = new System.Drawing.Point(189, 63);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(305, 28);
            this.cboTitle.TabIndex = 3;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged_2);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(530, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 79);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update_Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdatetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 379);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblChoosetitle);
            this.Name = "frmUpdatetable";
            this.Text = "Update_Data_Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoosetitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Button btnUpdate;
    }
}