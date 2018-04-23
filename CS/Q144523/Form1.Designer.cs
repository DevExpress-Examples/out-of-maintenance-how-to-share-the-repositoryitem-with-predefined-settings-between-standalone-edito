namespace Q144523 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            this.nwindDataSet = new Q144523.nwindDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Q144523.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.categoryNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.picturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.productsTableAdapter = new Q144523.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.productNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.supplierIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.categoryIDSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.categoriesRepositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.categoriesRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.productsRepositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.productsRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            categoryIDLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).BeginInit();
            this.categoriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesRepositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsRepositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsRepositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingNavigator
            // 
            this.categoriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriesBindingNavigator.BindingSource = this.categoriesBindingSource;
            this.categoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriesBindingNavigatorSaveItem});
            this.categoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriesBindingNavigator.Name = "categoriesBindingNavigator";
            this.categoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriesBindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.categoriesBindingNavigator.TabIndex = 0;
            this.categoriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoriesBindingNavigatorSaveItem
            // 
            this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
            this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
            this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesBindingNavigatorSaveItem_Click);
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(12, 40);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 1;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDSpinEdit
            // 
            this.categoryIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "CategoryID", true));
            this.categoryIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.categoryIDSpinEdit.Location = new System.Drawing.Point(101, 37);
            this.categoryIDSpinEdit.Name = "categoryIDSpinEdit";
            this.categoryIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.categoryIDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryIDSpinEdit.TabIndex = 2;
            this.categoryIDSpinEdit.Tag = "categoriesRepositoryItemSpinEdit";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(12, 66);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(83, 13);
            categoryNameLabel.TabIndex = 3;
            categoryNameLabel.Text = "Category Name:";
            // 
            // categoryNameTextEdit
            // 
            this.categoryNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "CategoryName", true));
            this.categoryNameTextEdit.Location = new System.Drawing.Point(101, 63);
            this.categoryNameTextEdit.Name = "categoryNameTextEdit";
            this.categoryNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextEdit.TabIndex = 4;
            this.categoryNameTextEdit.Tag = "categoriesRepositoryItemTextEdit";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 92);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(101, 89);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextEdit.TabIndex = 6;
            this.descriptionTextEdit.Tag = "categoriesRepositoryItemTextEdit";
            // 
            // picturePictureEdit
            // 
            this.picturePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "Picture", true));
            this.picturePictureEdit.Location = new System.Drawing.Point(227, 40);
            this.picturePictureEdit.Name = "picturePictureEdit";
            this.picturePictureEdit.Size = new System.Drawing.Size(100, 96);
            this.picturePictureEdit.TabIndex = 8;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "CategoriesProducts";
            this.productsBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(363, 44);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 8;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDSpinEdit
            // 
            this.productIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "ProductID", true));
            this.productIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productIDSpinEdit.Location = new System.Drawing.Point(447, 41);
            this.productIDSpinEdit.Name = "productIDSpinEdit";
            this.productIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.productIDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.productIDSpinEdit.TabIndex = 9;
            this.productIDSpinEdit.Tag = "productsRepositoryItemSpinEdit";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(363, 70);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 10;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextEdit
            // 
            this.productNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "ProductName", true));
            this.productNameTextEdit.Location = new System.Drawing.Point(447, 67);
            this.productNameTextEdit.Name = "productNameTextEdit";
            this.productNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.productNameTextEdit.TabIndex = 11;
            this.productNameTextEdit.Tag = "productsRepositoryItemTextEdit";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(363, 96);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 12;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // supplierIDSpinEdit
            // 
            this.supplierIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "SupplierID", true));
            this.supplierIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.supplierIDSpinEdit.Location = new System.Drawing.Point(447, 93);
            this.supplierIDSpinEdit.Name = "supplierIDSpinEdit";
            this.supplierIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.supplierIDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.supplierIDSpinEdit.TabIndex = 13;
            this.supplierIDSpinEdit.Tag = "productsRepositoryItemSpinEdit";
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Location = new System.Drawing.Point(363, 122);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel1.TabIndex = 14;
            categoryIDLabel1.Text = "Category ID:";
            // 
            // categoryIDSpinEdit1
            // 
            this.categoryIDSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "CategoryID", true));
            this.categoryIDSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.categoryIDSpinEdit1.Location = new System.Drawing.Point(447, 119);
            this.categoryIDSpinEdit1.Name = "categoryIDSpinEdit1";
            this.categoryIDSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.categoryIDSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.categoryIDSpinEdit1.TabIndex = 15;
            this.categoryIDSpinEdit1.Tag = "productsRepositoryItemSpinEdit";
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.categoriesRepositoryItemSpinEdit,
            this.categoriesRepositoryItemTextEdit,
            this.productsRepositoryItemSpinEdit,
            this.productsRepositoryItemTextEdit});
            // 
            // categoriesRepositoryItemSpinEdit
            // 
            this.categoriesRepositoryItemSpinEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.categoriesRepositoryItemSpinEdit.Appearance.Options.UseBackColor = true;
            this.categoriesRepositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.categoriesRepositoryItemSpinEdit.Name = "categoriesRepositoryItemSpinEdit";
            // 
            // categoriesRepositoryItemTextEdit
            // 
            this.categoriesRepositoryItemTextEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.categoriesRepositoryItemTextEdit.Appearance.Options.UseBackColor = true;
            this.categoriesRepositoryItemTextEdit.Name = "categoriesRepositoryItemTextEdit";
            // 
            // productsRepositoryItemSpinEdit
            // 
            this.productsRepositoryItemSpinEdit.Appearance.BackColor = System.Drawing.Color.Blue;
            this.productsRepositoryItemSpinEdit.Appearance.Options.UseBackColor = true;
            this.productsRepositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.productsRepositoryItemSpinEdit.Name = "productsRepositoryItemSpinEdit";
            // 
            // productsRepositoryItemTextEdit
            // 
            this.productsRepositoryItemTextEdit.Appearance.BackColor = System.Drawing.Color.Blue;
            this.productsRepositoryItemTextEdit.Appearance.Options.UseBackColor = true;
            this.productsRepositoryItemTextEdit.Name = "productsRepositoryItemTextEdit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 157);
            this.Controls.Add(categoryIDLabel1);
            this.Controls.Add(this.categoryIDSpinEdit1);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDSpinEdit);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextEdit);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDSpinEdit);
            this.Controls.Add(this.picturePictureEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextEdit);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameTextEdit);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDSpinEdit);
            this.Controls.Add(this.categoriesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).EndInit();
            this.categoriesBindingNavigator.ResumeLayout(false);
            this.categoriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesRepositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsRepositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsRepositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Q144523.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingNavigator categoriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriesBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit categoryIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit categoryNameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.PictureEdit picturePictureEdit;
        private Q144523.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraEditors.SpinEdit productIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit productNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit supplierIDSpinEdit;
        private DevExpress.XtraEditors.SpinEdit categoryIDSpinEdit1;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit categoriesRepositoryItemSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit categoriesRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit productsRepositoryItemSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit productsRepositoryItemTextEdit;
    }
}

