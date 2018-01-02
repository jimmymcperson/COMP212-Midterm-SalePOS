namespace COMP212_Midterm_SalePOS
{
    partial class MainMenu
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
            this.MainMenuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.POSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StoreNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentFormToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenuMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuMenuStrip
            // 
            this.MainMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POSToolStripMenuItem,
            this.ManagementToolStripMenuItem,
            this.StatisticsToolStripMenuItem,
            this.SetupToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.AboutDeveloperToolStripMenuItem});
            this.MainMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMenuStrip.Name = "MainMenuMenuStrip";
            this.MainMenuMenuStrip.Size = new System.Drawing.Size(690, 24);
            this.MainMenuMenuStrip.TabIndex = 0;
            this.MainMenuMenuStrip.Text = "menuStrip1";
            // 
            // POSToolStripMenuItem
            // 
            this.POSToolStripMenuItem.Name = "POSToolStripMenuItem";
            this.POSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.POSToolStripMenuItem.Text = "POS";
            // 
            // ManagementToolStripMenuItem
            // 
            this.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem";
            this.ManagementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ManagementToolStripMenuItem.Text = "Management";
            this.ManagementToolStripMenuItem.Click += new System.EventHandler(this.ManagementToolStripMenuItem_Click);
            // 
            // StatisticsToolStripMenuItem
            // 
            this.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem";
            this.StatisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.StatisticsToolStripMenuItem.Text = "Statistics";
            // 
            // SetupToolStripMenuItem
            // 
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            this.SetupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SetupToolStripMenuItem.Text = "Setup";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // AboutDeveloperToolStripMenuItem
            // 
            this.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem";
            this.AboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.AboutDeveloperToolStripMenuItem.Text = "About Developer";
            this.AboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.AboutDeveloperToolStripMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StoreNameToolStripStatusLabel,
            this.CurrentFormToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 478);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(690, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StoreNameToolStripStatusLabel
            // 
            this.StoreNameToolStripStatusLabel.Name = "StoreNameToolStripStatusLabel";
            this.StoreNameToolStripStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.StoreNameToolStripStatusLabel.Text = "Centennial Catering:";
            // 
            // CurrentFormToolStripStatusLabel
            // 
            this.CurrentFormToolStripStatusLabel.Name = "CurrentFormToolStripStatusLabel";
            this.CurrentFormToolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.CurrentFormToolStripStatusLabel.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 500);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuMenuStrip);
            this.MainMenuStrip = this.MainMenuMenuStrip;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.MainMenuMenuStrip.ResumeLayout(false);
            this.MainMenuMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem POSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StoreNameToolStripStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel CurrentFormToolStripStatusLabel;
    }
}