Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace Q144523
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			For Each c As Control In Controls
				If c.Tag IsNot Nothing AndAlso TypeOf c.Tag Is String Then
					Dim be As BaseEdit = TryCast(c, BaseEdit)
					If be Is Nothing Then
						Continue For
					End If
					Dim ri As RepositoryItem = persistentRepository1.Items(CStr(be.Tag))
					If ri IsNot Nothing Then
						be.Properties.Assign(ri)
					End If
				End If
			Next c
		End Sub

		Private Sub categoriesBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles categoriesBindingNavigatorSaveItem.Click
			Me.Validate()
			Me.categoriesBindingSource.EndEdit()
			Me.categoriesTableAdapter.Update(Me.nwindDataSet.Categories)

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)

		End Sub
	End Class
End Namespace