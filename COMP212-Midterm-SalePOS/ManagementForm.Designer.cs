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
            this.components = new System.ComponentModel.Container();
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
            this.SearchCategoryLabel = new System.Windows.Forms.Label();
            this.SearchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SearchProductNameLabel = new System.Windows.Forms.Label();
            this.SearchProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new COMP212_Midterm_SalePOS.Database1DataSet();
            this.productTableAdapter = new COMP212_Midterm_SalePOS.Database1DataSetTableAdapters.ProductTableAdapter();
            this.SearchProductIDLabel = new System.Windows.Forms.Label();
            this.SearchProductIDTextBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
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
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // SearchCategoryLabel
            // 
            this.SearchCategoryLabel.AutoSize = true;
            this.SearchCategoryLabel.Location = new System.Drawing.Point(233, 303);
            this.SearchCategoryLabel.Name = "SearchCategoryLabel";
            this.SearchCategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.SearchCategoryLabel.TabIndex = 16;
            this.SearchCategoryLabel.Text = "Category";
            // 
            // SearchCategoryComboBox
            // 
            this.SearchCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCategoryComboBox.FormattingEnabled = true;
            this.SearchCategoryComboBox.Location = new System.Drawing.Point(288, 300);
            this.SearchCategoryComboBox.Name = "SearchCategoryComboBox";
            this.SearchCategoryComboBox.Size = new System.Drawing.Size(137, 21);
            this.SearchCategoryComboBox.TabIndex = 17;
            this.SearchCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchCategoryComboBox_SelectedIndexChanged);
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
            // SearchProductNameLabel
            // 
            this.SearchProductNameLabel.AutoSize = true;
            this.SearchProductNameLabel.Location = new System.Drawing.Point(450, 304);
            this.SearchProductNameLabel.Name = "SearchProductNameLabel";
            this.SearchProductNameLabel.Size = new System.Drawing.Size(72, 13);
            this.SearchProductNameLabel.TabIndex = 19;
            this.SearchProductNameLabel.Text = "ProductName";
            // 
            // SearchProductNameTextBox
            // 
            this.SearchProductNameTextBox.Location = new System.Drawing.Point(528, 300);
            this.SearchProductNameTextBox.Name = "SearchProductNameTextBox";
            this.SearchProductNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.SearchProductNameTextBox.TabIndex = 20;
            this.SearchProductNameTextBox.TextChanged += new System.EventHandler(this.SearchProductNameTextBox_TextChanged);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AutoGenerateColumns = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.insertedByDataGridViewTextBoxColumn,
            this.insertionDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.ProductsDataGridView.DataSource = this.productBindingSource;
            this.ProductsDataGridView.Location = new System.Drawing.Point(16, 334);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(722, 176);
            this.ProductsDataGridView.TabIndex = 21;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // insertedByDataGridViewTextBoxColumn
            // 
            this.insertedByDataGridViewTextBoxColumn.DataPropertyName = "InsertedBy";
            this.insertedByDataGridViewTextBoxColumn.HeaderText = "InsertedBy";
            this.insertedByDataGridViewTextBoxColumn.Name = "insertedByDataGridViewTextBoxColumn";
            // 
            // insertionDateDataGridViewTextBoxColumn
            // 
            this.insertionDateDataGridViewTextBoxColumn.DataPropertyName = "InsertionDate";
            this.insertionDateDataGridViewTextBoxColumn.HeaderText = "InsertionDate";
            this.insertionDateDataGridViewTextBoxColumn.Name = "insertionDateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // SearchProductIDLabel
            // 
            this.SearchProductIDLabel.AutoSize = true;
            this.SearchProductIDLabel.Location = new System.Drawing.Point(90, 303);
            this.SearchProductIDLabel.Name = "SearchProductIDLabel";
            this.SearchProductIDLabel.Size = new System.Drawing.Size(55, 13);
            this.SearchProductIDLabel.TabIndex = 24;
            this.SearchProductIDLabel.Text = "ProductID";
            // 
            // SearchProductIDTextBox
            // 
            this.SearchProductIDTextBox.Location = new System.Drawing.Point(151, 300);
            this.SearchProductIDTextBox.Name = "SearchProductIDTextBox";
            this.SearchProductIDTextBox.Size = new System.Drawing.Size(44, 20);
            this.SearchProductIDTextBox.TabIndex = 25;
            this.SearchProductIDTextBox.TextChanged += new System.EventHandler(this.SearchProductIDTextBox_TextChanged);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(16, 531);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(267, 13);
            this.NoteLabel.TabIndex = 26;
            this.NoteLabel.Text = "Note: double click product to update or delete the item.";
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(18, 273);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchByLabel.TabIndex = 27;
            this.SearchByLabel.Text = "Search by:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(641, 7);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(105, 23);
            this.RefreshButton.TabIndex = 28;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 556);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.SearchProductIDTextBox);
            this.Controls.Add(this.SearchProductIDLabel);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.SearchProductNameTextBox);
            this.Controls.Add(this.SearchProductNameLabel);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.SearchCategoryComboBox);
            this.Controls.Add(this.SearchCategoryLabel);
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
            this.Shown += new System.EventHandler(this.ManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
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
        private System.Windows.Forms.Label SearchCategoryLabel;
        private System.Windows.Forms.ComboBox SearchCategoryComboBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label SearchProductNameLabel;
        private System.Windows.Forms.TextBox SearchProductNameTextBox;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Database1DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label SearchProductIDLabel;
        private System.Windows.Forms.TextBox SearchProductIDTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}