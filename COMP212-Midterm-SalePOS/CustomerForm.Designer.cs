namespace COMP212_Midterm_SalePOS
{
    partial class CustomerForm
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
            this.CustomerUserControl = new COMP212_Midterm_SalePOS.UserControl1();
            this.SuspendLayout();
            // 
            // CustomerUserControl
            // 
            this.CustomerUserControl.Location = new System.Drawing.Point(12, 12);
            this.CustomerUserControl.Name = "CustomerUserControl";
            this.CustomerUserControl.Size = new System.Drawing.Size(670, 312);
            this.CustomerUserControl.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 334);
            this.Controls.Add(this.CustomerUserControl);
            this.Name = "CustomerForm";
            this.Text = "Manage Customers";
            this.Activated += new System.EventHandler(this.CustomerForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 CustomerUserControl;
    }
}