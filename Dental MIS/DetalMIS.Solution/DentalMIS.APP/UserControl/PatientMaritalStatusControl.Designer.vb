﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMaritalStatusControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMaritalStatusControl))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.buttonRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Enter Search Text :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Patient Marital Status"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEdit.BorderRadius = 0
        Me.ButtonEdit.ButtonText = ""
        Me.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEdit.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonEdit.Iconimage = CType(resources.GetObject("ButtonEdit.Iconimage"), System.Drawing.Image)
        Me.ButtonEdit.Iconimage_right = Nothing
        Me.ButtonEdit.Iconimage_right_Selected = Nothing
        Me.ButtonEdit.Iconimage_Selected = Nothing
        Me.ButtonEdit.IconMarginLeft = 0
        Me.ButtonEdit.IconMarginRight = 0
        Me.ButtonEdit.IconRightVisible = True
        Me.ButtonEdit.IconRightZoom = 0R
        Me.ButtonEdit.IconVisible = True
        Me.ButtonEdit.IconZoom = 50.0R
        Me.ButtonEdit.IsTab = False
        Me.ButtonEdit.Location = New System.Drawing.Point(775, 88)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonEdit.selected = False
        Me.ButtonEdit.Size = New System.Drawing.Size(32, 33)
        Me.ButtonEdit.TabIndex = 33
        Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEdit.Textcolor = System.Drawing.Color.White
        Me.ButtonEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonNew
        '
        Me.ButtonNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNew.BorderRadius = 0
        Me.ButtonNew.ButtonText = ""
        Me.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNew.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonNew.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonNew.Iconimage = CType(resources.GetObject("ButtonNew.Iconimage"), System.Drawing.Image)
        Me.ButtonNew.Iconimage_right = Nothing
        Me.ButtonNew.Iconimage_right_Selected = Nothing
        Me.ButtonNew.Iconimage_Selected = Nothing
        Me.ButtonNew.IconMarginLeft = 0
        Me.ButtonNew.IconMarginRight = 0
        Me.ButtonNew.IconRightVisible = True
        Me.ButtonNew.IconRightZoom = 0R
        Me.ButtonNew.IconVisible = True
        Me.ButtonNew.IconZoom = 50.0R
        Me.ButtonNew.IsTab = False
        Me.ButtonNew.Location = New System.Drawing.Point(737, 88)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonNew.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonNew.selected = False
        Me.ButtonNew.Size = New System.Drawing.Size(32, 33)
        Me.ButtonNew.TabIndex = 32
        Me.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNew.Textcolor = System.Drawing.Color.White
        Me.ButtonNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.Location = New System.Drawing.Point(135, 93)
        Me.TextSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(559, 24)
        Me.TextSearch.TabIndex = 31
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 59)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(820, 35)
        Me.BunifuSeparator1.TabIndex = 29
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'buttonRefresh
        '
        Me.buttonRefresh.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonRefresh.BorderRadius = 0
        Me.buttonRefresh.ButtonText = ""
        Me.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.buttonRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonRefresh.Iconimage = CType(resources.GetObject("buttonRefresh.Iconimage"), System.Drawing.Image)
        Me.buttonRefresh.Iconimage_right = Nothing
        Me.buttonRefresh.Iconimage_right_Selected = Nothing
        Me.buttonRefresh.Iconimage_Selected = Nothing
        Me.buttonRefresh.IconMarginLeft = 0
        Me.buttonRefresh.IconMarginRight = 0
        Me.buttonRefresh.IconRightVisible = True
        Me.buttonRefresh.IconRightZoom = 0R
        Me.buttonRefresh.IconVisible = True
        Me.buttonRefresh.IconZoom = 50.0R
        Me.buttonRefresh.IsTab = False
        Me.buttonRefresh.Location = New System.Drawing.Point(699, 88)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonRefresh.selected = False
        Me.buttonRefresh.Size = New System.Drawing.Size(32, 33)
        Me.buttonRefresh.TabIndex = 37
        Me.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonRefresh.Textcolor = System.Drawing.Color.White
        Me.buttonRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.cname, Me.status, Me.createdBy, Me.createdDate, Me.updatedBy, Me.updatedDate})
        Me.DataGrid.Location = New System.Drawing.Point(14, 127)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(793, 533)
        Me.DataGrid.TabIndex = 46
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 43
        '
        'cname
        '
        Me.cname.HeaderText = "Name"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'createdBy
        '
        Me.createdBy.HeaderText = "Created By"
        Me.createdBy.Name = "createdBy"
        Me.createdBy.ReadOnly = True
        '
        'createdDate
        '
        Me.createdDate.HeaderText = "Created Date"
        Me.createdDate.Name = "createdDate"
        Me.createdDate.ReadOnly = True
        '
        'updatedBy
        '
        Me.updatedBy.HeaderText = "Updated By"
        Me.updatedBy.Name = "updatedBy"
        Me.updatedBy.ReadOnly = True
        '
        'updatedDate
        '
        Me.updatedDate.HeaderText = "Updated Date"
        Me.updatedDate.Name = "updatedDate"
        Me.updatedDate.ReadOnly = True
        '
        'PatientMaritalStatusControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PatientMaritalStatusControl"
        Me.Size = New System.Drawing.Size(820, 671)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents buttonRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents cname As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents createdBy As DataGridViewTextBoxColumn
    Friend WithEvents createdDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
End Class
