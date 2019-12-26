Imports Microsoft.VisualBasic
Imports System
Namespace Q144523
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim categoryIDLabel As System.Windows.Forms.Label
			Dim categoryNameLabel As System.Windows.Forms.Label
			Dim descriptionLabel As System.Windows.Forms.Label
			Dim productIDLabel As System.Windows.Forms.Label
			Dim productNameLabel As System.Windows.Forms.Label
			Dim supplierIDLabel As System.Windows.Forms.Label
			Dim categoryIDLabel1 As System.Windows.Forms.Label
            Me.nwindDataSet = New nwindDataSet()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.categoriesTableAdapter = New nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.categoriesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
			Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
			Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
			Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
			Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
			Me.categoriesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
			Me.categoryIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.categoryNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.descriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.picturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.productsTableAdapter = New nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.productNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.supplierIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.categoryIDSpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.categoriesRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.categoriesRepositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.productsRepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.productsRepositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			categoryIDLabel = New System.Windows.Forms.Label()
			categoryNameLabel = New System.Windows.Forms.Label()
			descriptionLabel = New System.Windows.Forms.Label()
			productIDLabel = New System.Windows.Forms.Label()
			productNameLabel = New System.Windows.Forms.Label()
			supplierIDLabel = New System.Windows.Forms.Label()
			categoryIDLabel1 = New System.Windows.Forms.Label()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.categoriesBindingNavigator.SuspendLayout()
			CType(Me.categoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoryNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.descriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.supplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoryIDSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' categoriesBindingNavigator
			' 
			Me.categoriesBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
			Me.categoriesBindingNavigator.BindingSource = Me.categoriesBindingSource
			Me.categoriesBindingNavigator.CountItem = Me.bindingNavigatorCountItem
			Me.categoriesBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
			Me.categoriesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.categoriesBindingNavigatorSaveItem})
			Me.categoriesBindingNavigator.Location = New System.Drawing.Point(0, 0)
			Me.categoriesBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
			Me.categoriesBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
			Me.categoriesBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
			Me.categoriesBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
			Me.categoriesBindingNavigator.Name = "categoriesBindingNavigator"
			Me.categoriesBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
			Me.categoriesBindingNavigator.Size = New System.Drawing.Size(561, 25)
			Me.categoriesBindingNavigator.TabIndex = 0
			Me.categoriesBindingNavigator.Text = "bindingNavigator1"
			' 
			' bindingNavigatorMoveFirstItem
			' 
			Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveFirstItem.Image = (CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
			Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveFirstItem.Text = "Move first"
			' 
			' bindingNavigatorMovePreviousItem
			' 
			Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMovePreviousItem.Image = (CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
			Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
			' 
			' bindingNavigatorSeparator
			' 
			Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
			Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
			' 
			' bindingNavigatorPositionItem
			' 
			Me.bindingNavigatorPositionItem.AccessibleName = "Position"
			Me.bindingNavigatorPositionItem.AutoSize = False
			Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
			Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
			Me.bindingNavigatorPositionItem.Text = "0"
			Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
			' 
			' bindingNavigatorCountItem
			' 
			Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
			Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
			Me.bindingNavigatorCountItem.Text = "of {0}"
			Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
			' 
			' bindingNavigatorSeparator1
			' 
			Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator"
			Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' bindingNavigatorMoveNextItem
			' 
			Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveNextItem.Image = (CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
			Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveNextItem.Text = "Move next"
			' 
			' bindingNavigatorMoveLastItem
			' 
			Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorMoveLastItem.Image = (CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
			Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorMoveLastItem.Text = "Move last"
			' 
			' bindingNavigatorSeparator2
			' 
			Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator"
			Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' bindingNavigatorAddNewItem
			' 
			Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorAddNewItem.Image = (CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
			Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorAddNewItem.Text = "Add new"
			' 
			' bindingNavigatorDeleteItem
			' 
			Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.bindingNavigatorDeleteItem.Image = (CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image))
			Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
			Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
			Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
			Me.bindingNavigatorDeleteItem.Text = "Delete"
			' 
			' categoriesBindingNavigatorSaveItem
			' 
			Me.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.categoriesBindingNavigatorSaveItem.Image = (CType(resources.GetObject("categoriesBindingNavigatorSaveItem.Image"), System.Drawing.Image))
			Me.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem"
			Me.categoriesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
			Me.categoriesBindingNavigatorSaveItem.Text = "Save Data"
'			Me.categoriesBindingNavigatorSaveItem.Click += New System.EventHandler(Me.categoriesBindingNavigatorSaveItem_Click);
			' 
			' categoryIDLabel
			' 
			categoryIDLabel.AutoSize = True
			categoryIDLabel.Location = New System.Drawing.Point(12, 40)
			categoryIDLabel.Name = "categoryIDLabel"
			categoryIDLabel.Size = New System.Drawing.Size(66, 13)
			categoryIDLabel.TabIndex = 1
			categoryIDLabel.Text = "Category ID:"
			' 
			' categoryIDSpinEdit
			' 
			Me.categoryIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "CategoryID", True))
			Me.categoryIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.categoryIDSpinEdit.Location = New System.Drawing.Point(101, 37)
			Me.categoryIDSpinEdit.Name = "categoryIDSpinEdit"
			Me.categoryIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.categoryIDSpinEdit.Size = New System.Drawing.Size(100, 20)
			Me.categoryIDSpinEdit.TabIndex = 2
			Me.categoryIDSpinEdit.Tag = "categoriesRepositoryItemSpinEdit"
			' 
			' categoryNameLabel
			' 
			categoryNameLabel.AutoSize = True
			categoryNameLabel.Location = New System.Drawing.Point(12, 66)
			categoryNameLabel.Name = "categoryNameLabel"
			categoryNameLabel.Size = New System.Drawing.Size(83, 13)
			categoryNameLabel.TabIndex = 3
			categoryNameLabel.Text = "Category Name:"
			' 
			' categoryNameTextEdit
			' 
			Me.categoryNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "CategoryName", True))
			Me.categoryNameTextEdit.Location = New System.Drawing.Point(101, 63)
			Me.categoryNameTextEdit.Name = "categoryNameTextEdit"
			Me.categoryNameTextEdit.Size = New System.Drawing.Size(100, 20)
			Me.categoryNameTextEdit.TabIndex = 4
			Me.categoryNameTextEdit.Tag = "categoriesRepositoryItemTextEdit"
			' 
			' descriptionLabel
			' 
			descriptionLabel.AutoSize = True
			descriptionLabel.Location = New System.Drawing.Point(15, 92)
			descriptionLabel.Name = "descriptionLabel"
			descriptionLabel.Size = New System.Drawing.Size(63, 13)
			descriptionLabel.TabIndex = 5
			descriptionLabel.Text = "Description:"
			' 
			' descriptionTextEdit
			' 
			Me.descriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "Description", True))
			Me.descriptionTextEdit.Location = New System.Drawing.Point(101, 89)
			Me.descriptionTextEdit.Name = "descriptionTextEdit"
			Me.descriptionTextEdit.Size = New System.Drawing.Size(100, 20)
			Me.descriptionTextEdit.TabIndex = 6
			Me.descriptionTextEdit.Tag = "categoriesRepositoryItemTextEdit"
			' 
			' picturePictureEdit
			' 
			Me.picturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "Picture", True))
			Me.picturePictureEdit.Location = New System.Drawing.Point(227, 40)
			Me.picturePictureEdit.Name = "picturePictureEdit"
			Me.picturePictureEdit.Size = New System.Drawing.Size(100, 96)
			Me.picturePictureEdit.TabIndex = 8
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "CategoriesProducts"
			Me.productsBindingSource.DataSource = Me.categoriesBindingSource
			' 
			' productIDLabel
			' 
			productIDLabel.AutoSize = True
			productIDLabel.Location = New System.Drawing.Point(363, 44)
			productIDLabel.Name = "productIDLabel"
			productIDLabel.Size = New System.Drawing.Size(61, 13)
			productIDLabel.TabIndex = 8
			productIDLabel.Text = "Product ID:"
			' 
			' productIDSpinEdit
			' 
			Me.productIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "ProductID", True))
			Me.productIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.productIDSpinEdit.Location = New System.Drawing.Point(447, 41)
			Me.productIDSpinEdit.Name = "productIDSpinEdit"
			Me.productIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.productIDSpinEdit.Size = New System.Drawing.Size(100, 20)
			Me.productIDSpinEdit.TabIndex = 9
			Me.productIDSpinEdit.Tag = "productsRepositoryItemSpinEdit"
			' 
			' productNameLabel
			' 
			productNameLabel.AutoSize = True
			productNameLabel.Location = New System.Drawing.Point(363, 70)
			productNameLabel.Name = "productNameLabel"
			productNameLabel.Size = New System.Drawing.Size(78, 13)
			productNameLabel.TabIndex = 10
			productNameLabel.Text = "Product Name:"
			' 
			' productNameTextEdit
			' 
			Me.productNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "ProductName", True))
			Me.productNameTextEdit.Location = New System.Drawing.Point(447, 67)
			Me.productNameTextEdit.Name = "productNameTextEdit"
			Me.productNameTextEdit.Size = New System.Drawing.Size(100, 20)
			Me.productNameTextEdit.TabIndex = 11
			Me.productNameTextEdit.Tag = "productsRepositoryItemTextEdit"
			' 
			' supplierIDLabel
			' 
			supplierIDLabel.AutoSize = True
			supplierIDLabel.Location = New System.Drawing.Point(363, 96)
			supplierIDLabel.Name = "supplierIDLabel"
			supplierIDLabel.Size = New System.Drawing.Size(62, 13)
			supplierIDLabel.TabIndex = 12
			supplierIDLabel.Text = "Supplier ID:"
			' 
			' supplierIDSpinEdit
			' 
			Me.supplierIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "SupplierID", True))
			Me.supplierIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.supplierIDSpinEdit.Location = New System.Drawing.Point(447, 93)
			Me.supplierIDSpinEdit.Name = "supplierIDSpinEdit"
			Me.supplierIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.supplierIDSpinEdit.Size = New System.Drawing.Size(100, 20)
			Me.supplierIDSpinEdit.TabIndex = 13
			Me.supplierIDSpinEdit.Tag = "productsRepositoryItemSpinEdit"
			' 
			' categoryIDLabel1
			' 
			categoryIDLabel1.AutoSize = True
			categoryIDLabel1.Location = New System.Drawing.Point(363, 122)
			categoryIDLabel1.Name = "categoryIDLabel1"
			categoryIDLabel1.Size = New System.Drawing.Size(66, 13)
			categoryIDLabel1.TabIndex = 14
			categoryIDLabel1.Text = "Category ID:"
			' 
			' categoryIDSpinEdit1
			' 
			Me.categoryIDSpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "CategoryID", True))
			Me.categoryIDSpinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.categoryIDSpinEdit1.Location = New System.Drawing.Point(447, 119)
			Me.categoryIDSpinEdit1.Name = "categoryIDSpinEdit1"
			Me.categoryIDSpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.categoryIDSpinEdit1.Size = New System.Drawing.Size(100, 20)
			Me.categoryIDSpinEdit1.TabIndex = 15
			Me.categoryIDSpinEdit1.Tag = "productsRepositoryItemSpinEdit"
			' 
			' persistentRepository1
			' 
			Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.categoriesRepositoryItemSpinEdit, Me.categoriesRepositoryItemTextEdit, Me.productsRepositoryItemSpinEdit, Me.productsRepositoryItemTextEdit})
			' 
			' categoriesRepositoryItemSpinEdit
			' 
			Me.categoriesRepositoryItemSpinEdit.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			Me.categoriesRepositoryItemSpinEdit.Appearance.Options.UseBackColor = True
			Me.categoriesRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.categoriesRepositoryItemSpinEdit.Name = "categoriesRepositoryItemSpinEdit"
			' 
			' categoriesRepositoryItemTextEdit
			' 
			Me.categoriesRepositoryItemTextEdit.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			Me.categoriesRepositoryItemTextEdit.Appearance.Options.UseBackColor = True
			Me.categoriesRepositoryItemTextEdit.Name = "categoriesRepositoryItemTextEdit"
			' 
			' productsRepositoryItemSpinEdit
			' 
			Me.productsRepositoryItemSpinEdit.Appearance.BackColor = System.Drawing.Color.Blue
			Me.productsRepositoryItemSpinEdit.Appearance.Options.UseBackColor = True
			Me.productsRepositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.productsRepositoryItemSpinEdit.Name = "productsRepositoryItemSpinEdit"
			' 
			' productsRepositoryItemTextEdit
			' 
			Me.productsRepositoryItemTextEdit.Appearance.BackColor = System.Drawing.Color.Blue
			Me.productsRepositoryItemTextEdit.Appearance.Options.UseBackColor = True
			Me.productsRepositoryItemTextEdit.Name = "productsRepositoryItemTextEdit"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(561, 157)
			Me.Controls.Add(categoryIDLabel1)
			Me.Controls.Add(Me.categoryIDSpinEdit1)
			Me.Controls.Add(supplierIDLabel)
			Me.Controls.Add(Me.supplierIDSpinEdit)
			Me.Controls.Add(productNameLabel)
			Me.Controls.Add(Me.productNameTextEdit)
			Me.Controls.Add(productIDLabel)
			Me.Controls.Add(Me.productIDSpinEdit)
			Me.Controls.Add(Me.picturePictureEdit)
			Me.Controls.Add(descriptionLabel)
			Me.Controls.Add(Me.descriptionTextEdit)
			Me.Controls.Add(categoryNameLabel)
			Me.Controls.Add(Me.categoryNameTextEdit)
			Me.Controls.Add(categoryIDLabel)
			Me.Controls.Add(Me.categoryIDSpinEdit)
			Me.Controls.Add(Me.categoriesBindingNavigator)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.categoriesBindingNavigator.ResumeLayout(False)
			Me.categoriesBindingNavigator.PerformLayout()
			CType(Me.categoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoryNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.descriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.supplierIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoryIDSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsRepositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsRepositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
        Private categoriesBindingNavigator As System.Windows.Forms.BindingNavigator
		Private bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
		Private bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
		Private bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
		Private bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents categoriesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
		Private categoryIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private categoryNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private descriptionTextEdit As DevExpress.XtraEditors.TextEdit
		Private picturePictureEdit As DevExpress.XtraEditors.PictureEdit
        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
        Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private productNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private supplierIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private categoryIDSpinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private categoriesRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private categoriesRepositoryItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private productsRepositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private productsRepositoryItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	End Class
End Namespace

