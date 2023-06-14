Namespace GridSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridSample.Form1))
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(450, 383)
            Me.treeList1.TabIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(470, 383)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.treeList1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(925, 383)
            Me.splitContainerControl1.SplitterPosition = 450
            Me.splitContainerControl1.TabIndex = 2
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.InsertGalleryImage("open_16x16.png", "images/actions/open_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/open_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "open_16x16.png")
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(925, 383)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
