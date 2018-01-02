﻿namespace COMP212_Midterm_SalePOS
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
            this.CustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StoreNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentFormToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductTabControl = new System.Windows.Forms.TabControl();
            this.FoodTabPage = new System.Windows.Forms.TabPage();
            this.FoodFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DrinkTabPage = new System.Windows.Forms.TabPage();
            this.DrinkFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MovieTabPage = new System.Windows.Forms.TabPage();
            this.MovieFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BillNoTextBox = new System.Windows.Forms.TextBox();
            this.BillNoLabel = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MainMenuMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.ProductTabControl.SuspendLayout();
            this.FoodTabPage.SuspendLayout();
            this.DrinkTabPage.SuspendLayout();
            this.MovieTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
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
            this.AboutDeveloperToolStripMenuItem,
            this.CustomersToolStripMenuItem});
            this.MainMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMenuStrip.Name = "MainMenuMenuStrip";
            this.MainMenuMenuStrip.Size = new System.Drawing.Size(814, 24);
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
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.CustomersToolStripMenuItem.Text = "Customers";
            this.CustomersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StoreNameToolStripStatusLabel,
            this.CurrentFormToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 568);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(814, 22);
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
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.RefreshButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.DescriptionTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.AddProductButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.SearchTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.ProductTabControl);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.BillNoTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.BillNoLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.PurchaseButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.TotalPriceLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.TotalPriceTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.ClearButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.RemoveButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.CartDataGridView);
            this.MainSplitContainer.Size = new System.Drawing.Size(814, 544);
            this.MainSplitContainer.SplitterDistance = 521;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(16, 468);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(229, 68);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(264, 485);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(242, 51);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "ADD PRODUCT";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(372, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // ProductTabControl
            // 
            this.ProductTabControl.Controls.Add(this.FoodTabPage);
            this.ProductTabControl.Controls.Add(this.DrinkTabPage);
            this.ProductTabControl.Controls.Add(this.MovieTabPage);
            this.ProductTabControl.Location = new System.Drawing.Point(12, 40);
            this.ProductTabControl.Name = "ProductTabControl";
            this.ProductTabControl.SelectedIndex = 0;
            this.ProductTabControl.Size = new System.Drawing.Size(498, 421);
            this.ProductTabControl.TabIndex = 0;
            // 
            // FoodTabPage
            // 
            this.FoodTabPage.Controls.Add(this.FoodFlowLayoutPanel);
            this.FoodTabPage.Location = new System.Drawing.Point(4, 22);
            this.FoodTabPage.Name = "FoodTabPage";
            this.FoodTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FoodTabPage.Size = new System.Drawing.Size(490, 395);
            this.FoodTabPage.TabIndex = 0;
            this.FoodTabPage.Text = "Food";
            this.FoodTabPage.UseVisualStyleBackColor = true;
            // 
            // FoodFlowLayoutPanel
            // 
            this.FoodFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.FoodFlowLayoutPanel.Name = "FoodFlowLayoutPanel";
            this.FoodFlowLayoutPanel.Size = new System.Drawing.Size(484, 389);
            this.FoodFlowLayoutPanel.TabIndex = 0;
            // 
            // DrinkTabPage
            // 
            this.DrinkTabPage.Controls.Add(this.DrinkFlowLayoutPanel);
            this.DrinkTabPage.Location = new System.Drawing.Point(4, 22);
            this.DrinkTabPage.Name = "DrinkTabPage";
            this.DrinkTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DrinkTabPage.Size = new System.Drawing.Size(490, 395);
            this.DrinkTabPage.TabIndex = 1;
            this.DrinkTabPage.Text = "Drink";
            this.DrinkTabPage.UseVisualStyleBackColor = true;
            // 
            // DrinkFlowLayoutPanel
            // 
            this.DrinkFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrinkFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.DrinkFlowLayoutPanel.Name = "DrinkFlowLayoutPanel";
            this.DrinkFlowLayoutPanel.Size = new System.Drawing.Size(484, 389);
            this.DrinkFlowLayoutPanel.TabIndex = 0;
            // 
            // MovieTabPage
            // 
            this.MovieTabPage.Controls.Add(this.MovieFlowLayoutPanel);
            this.MovieTabPage.Location = new System.Drawing.Point(4, 22);
            this.MovieTabPage.Name = "MovieTabPage";
            this.MovieTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTabPage.Size = new System.Drawing.Size(490, 395);
            this.MovieTabPage.TabIndex = 2;
            this.MovieTabPage.Text = "Movie";
            this.MovieTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieFlowLayoutPanel
            // 
            this.MovieFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MovieFlowLayoutPanel.Name = "MovieFlowLayoutPanel";
            this.MovieFlowLayoutPanel.Size = new System.Drawing.Size(484, 389);
            this.MovieFlowLayoutPanel.TabIndex = 0;
            // 
            // BillNoTextBox
            // 
            this.BillNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillNoTextBox.Location = new System.Drawing.Point(49, 36);
            this.BillNoTextBox.Name = "BillNoTextBox";
            this.BillNoTextBox.ReadOnly = true;
            this.BillNoTextBox.Size = new System.Drawing.Size(78, 20);
            this.BillNoTextBox.TabIndex = 7;
            // 
            // BillNoLabel
            // 
            this.BillNoLabel.AutoSize = true;
            this.BillNoLabel.Location = new System.Drawing.Point(3, 41);
            this.BillNoLabel.Name = "BillNoLabel";
            this.BillNoLabel.Size = new System.Drawing.Size(40, 13);
            this.BillNoLabel.TabIndex = 6;
            this.BillNoLabel.Text = "Bill No.";
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.Location = new System.Drawing.Point(28, 485);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(230, 51);
            this.PurchaseButton.TabIndex = 5;
            this.PurchaseButton.Text = "PURCHASE";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(85, 443);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.TotalPriceLabel.TabIndex = 4;
            this.TotalPriceLabel.Text = "Total Price:";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceTextBox.ForeColor = System.Drawing.Color.Lime;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(152, 432);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(125, 29);
            this.TotalPriceTextBox.TabIndex = 3;
            this.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(183, 36);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(183, 7);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(3, 65);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.Size = new System.Drawing.Size(274, 360);
            this.CartDataGridView.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(391, 14);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(115, 20);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh/Clear";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 590);
            this.Controls.Add(this.MainSplitContainer);
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
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ProductTabControl.ResumeLayout(false);
            this.FoodTabPage.ResumeLayout(false);
            this.DrinkTabPage.ResumeLayout(false);
            this.MovieTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem CustomersToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TabControl ProductTabControl;
        private System.Windows.Forms.TabPage FoodTabPage;
        private System.Windows.Forms.FlowLayoutPanel FoodFlowLayoutPanel;
        private System.Windows.Forms.TabPage DrinkTabPage;
        private System.Windows.Forms.FlowLayoutPanel DrinkFlowLayoutPanel;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label BillNoLabel;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox BillNoTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TabPage MovieTabPage;
        private System.Windows.Forms.FlowLayoutPanel MovieFlowLayoutPanel;
        private System.Windows.Forms.Button RefreshButton;
    }
}