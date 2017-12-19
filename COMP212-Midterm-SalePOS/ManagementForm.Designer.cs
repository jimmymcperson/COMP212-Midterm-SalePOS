namespace COMP212_Midterm_SalePOS
{
    partial class ManagementForm
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.SalePriceLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SalePriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(13, 13);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(32, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User:";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextBox.Location = new System.Drawing.Point(51, 10);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.ReadOnly = true;
            this.UserTextBox.Size = new System.Drawing.Size(144, 20);
            this.UserTextBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(13, 51);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Location = new System.Drawing.Point(13, 92);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(97, 13);
            this.PurchasePriceLabel.TabIndex = 3;
            this.PurchasePriceLabel.Text = "Purchase Price ($):";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(71, 49);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(167, 21);
            this.CategoryComboBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PriceTextBox.Location = new System.Drawing.Point(116, 89);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(122, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(285, 52);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(78, 13);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // SalePriceLabel
            // 
            this.SalePriceLabel.AutoSize = true;
            this.SalePriceLabel.Location = new System.Drawing.Point(285, 92);
            this.SalePriceLabel.Name = "SalePriceLabel";
            this.SalePriceLabel.Size = new System.Drawing.Size(55, 13);
            this.SalePriceLabel.TabIndex = 7;
            this.SalePriceLabel.Text = "SalePrice:";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(369, 49);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.ProductNameTextBox.TabIndex = 8;
            // 
            // SalePriceTextBox
            // 
            this.SalePriceTextBox.Location = new System.Drawing.Point(369, 89);
            this.SalePriceTextBox.Name = "SalePriceTextBox";
            this.SalePriceTextBox.Size = new System.Drawing.Size(192, 20);
            this.SalePriceTextBox.TabIndex = 9;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(604, 50);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(607, 92);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "ID:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(660, 49);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(78, 20);
            this.QuantityTextBox.TabIndex = 12;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(660, 84);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.IDTextBox.TabIndex = 13;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 168);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 14;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(82, 141);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(638, 72);
            this.DescriptionTextBox.TabIndex = 15;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(103, 295);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(59, 13);
            this.SearchByLabel.TabIndex = 16;
            this.SearchByLabel.Text = "Search By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(323, 229);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 18;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(414, 295);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(464, 292);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(163, 20);
            this.SearchTextBox.TabIndex = 20;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(16, 334);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(722, 176);
            this.ProductsDataGridView.TabIndex = 21;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 522);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.SalePriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.SalePriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.PurchasePriceLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserLabel);
            this.Name = "ManagementForm";
            this.Text = "Add New Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label SalePriceLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox SalePriceTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
    }
}