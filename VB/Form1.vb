Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Namespace GridSample
	Partial Public Class Form1
		Inherits Form
		Private list As New List(Of Customer)()

		Public Sub New()
			InitializeComponent()
			FillTable()

		End Sub

		Private Sub FillTable()
			For i As Integer = 0 To 9
				Dim customer As New Customer()
				customer.Name = "John"
				customer.Age = 20 + i
				customer.Weight = 100 - i
				list.Add(customer)
			Next i
			treeList1.DataSource = list
			gridControl1.DataSource = list

			Dim edit As New RepositoryItemButtonEdit()
			edit.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
			edit.Buttons(0).Image = imageCollection1.Images(0)
			AddHandler edit.ButtonClick, AddressOf edit_ButtonClick

			treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
			gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways

			treeList1.Columns("Age").ColumnEdit = edit
			gridView1.Columns("Age").ColumnEdit = edit
		End Sub

		Private Sub edit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.ShowDialog()
		End Sub
	End Class
End Namespace
