Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace GridSample

    Public Partial Class Form1
        Inherits Form

        Private list As List(Of Customer) = New List(Of Customer)()

        Public Sub New()
            InitializeComponent()
            FillTable()
        End Sub

        Private Sub FillTable()
            For i As Integer = 0 To 10 - 1
                Dim customer As Customer = New Customer()
                customer.Name = "John"
                customer.Age = 20 + i
                customer.Weight = 100 - i
                list.Add(customer)
            Next

            treeList1.DataSource = list
            gridControl1.DataSource = list
            Dim edit As RepositoryItemButtonEdit = New RepositoryItemButtonEdit()
            edit.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
            edit.Buttons(0).Image = imageCollection1.Images(0)
            AddHandler edit.ButtonClick, AddressOf edit_ButtonClick
            treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
            gridView1.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways
            treeList1.Columns("Age").ColumnEdit = edit
            gridView1.Columns("Age").ColumnEdit = edit
        End Sub

        Private Sub edit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.ShowDialog()
        End Sub
    End Class
End Namespace
