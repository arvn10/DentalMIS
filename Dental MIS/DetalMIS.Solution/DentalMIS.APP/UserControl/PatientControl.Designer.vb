﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.DataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maritalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.buttonView = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buttonEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buttonNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 63)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(820, 35)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.firstname, Me.lastname, Me.address, Me.age, Me.gender, Me.maritalStatus, Me.occupation})
        Me.DataGrid.DoubleBuffered = True
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.DataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid.Location = New System.Drawing.Point(14, 130)
        Me.DataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid.RowTemplate.Height = 24
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(793, 526)
        Me.DataGrid.TabIndex = 2
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'firstname
        '
        Me.firstname.HeaderText = "Firstname"
        Me.firstname.Name = "firstname"
        '
        'lastname
        '
        Me.lastname.HeaderText = "Lastname"
        Me.lastname.Name = "lastname"
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'age
        '
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        '
        'maritalStatus
        '
        Me.maritalStatus.HeaderText = "Marital Status"
        Me.maritalStatus.Name = "maritalStatus"
        '
        'occupation
        '
        Me.occupation.HeaderText = "Occupation"
        Me.occupation.Name = "occupation"
        '
        'textSearch
        '
        Me.textSearch.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.textSearch.Location = New System.Drawing.Point(147, 96)
        Me.textSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(346, 24)
        Me.textSearch.TabIndex = 6
        '
        'buttonView
        '
        Me.buttonView.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonView.BorderRadius = 0
        Me.buttonView.ButtonText = "  View"
        Me.buttonView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonView.DisabledColor = System.Drawing.Color.Gray
        Me.buttonView.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonView.Iconimage = CType(resources.GetObject("buttonView.Iconimage"), System.Drawing.Image)
        Me.buttonView.Iconimage_right = Nothing
        Me.buttonView.Iconimage_right_Selected = Nothing
        Me.buttonView.Iconimage_Selected = Nothing
        Me.buttonView.IconMarginLeft = 0
        Me.buttonView.IconMarginRight = 0
        Me.buttonView.IconRightVisible = True
        Me.buttonView.IconRightZoom = 0R
        Me.buttonView.IconVisible = True
        Me.buttonView.IconZoom = 50.0R
        Me.buttonView.IsTab = False
        Me.buttonView.Location = New System.Drawing.Point(722, 91)
        Me.buttonView.Name = "buttonView"
        Me.buttonView.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonView.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonView.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonView.selected = False
        Me.buttonView.Size = New System.Drawing.Size(85, 33)
        Me.buttonView.TabIndex = 10
        Me.buttonView.Text = "  View"
        Me.buttonView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonView.Textcolor = System.Drawing.Color.White
        Me.buttonView.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buttonEdit
        '
        Me.buttonEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonEdit.BorderRadius = 0
        Me.buttonEdit.ButtonText = "  Edit"
        Me.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonEdit.DisabledColor = System.Drawing.Color.Gray
        Me.buttonEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonEdit.Iconimage = CType(resources.GetObject("buttonEdit.Iconimage"), System.Drawing.Image)
        Me.buttonEdit.Iconimage_right = Nothing
        Me.buttonEdit.Iconimage_right_Selected = Nothing
        Me.buttonEdit.Iconimage_Selected = Nothing
        Me.buttonEdit.IconMarginLeft = 0
        Me.buttonEdit.IconMarginRight = 0
        Me.buttonEdit.IconRightVisible = True
        Me.buttonEdit.IconRightZoom = 0R
        Me.buttonEdit.IconVisible = True
        Me.buttonEdit.IconZoom = 50.0R
        Me.buttonEdit.IsTab = False
        Me.buttonEdit.Location = New System.Drawing.Point(632, 91)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonEdit.selected = False
        Me.buttonEdit.Size = New System.Drawing.Size(85, 33)
        Me.buttonEdit.TabIndex = 9
        Me.buttonEdit.Text = "  Edit"
        Me.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEdit.Textcolor = System.Drawing.Color.White
        Me.buttonEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buttonNew
        '
        Me.buttonNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonNew.BorderRadius = 0
        Me.buttonNew.ButtonText = "  New"
        Me.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonNew.DisabledColor = System.Drawing.Color.Gray
        Me.buttonNew.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonNew.Iconimage = CType(resources.GetObject("buttonNew.Iconimage"), System.Drawing.Image)
        Me.buttonNew.Iconimage_right = Nothing
        Me.buttonNew.Iconimage_right_Selected = Nothing
        Me.buttonNew.Iconimage_Selected = Nothing
        Me.buttonNew.IconMarginLeft = 0
        Me.buttonNew.IconMarginRight = 0
        Me.buttonNew.IconRightVisible = True
        Me.buttonNew.IconRightZoom = 0R
        Me.buttonNew.IconVisible = True
        Me.buttonNew.IconZoom = 50.0R
        Me.buttonNew.IsTab = False
        Me.buttonNew.Location = New System.Drawing.Point(541, 91)
        Me.buttonNew.Name = "buttonNew"
        Me.buttonNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonNew.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonNew.selected = False
        Me.buttonNew.Size = New System.Drawing.Size(85, 33)
        Me.buttonNew.TabIndex = 8
        Me.buttonNew.Text = "  New"
        Me.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonNew.Textcolor = System.Drawing.Color.White
        Me.buttonNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Enter Search Text :"
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
        Me.buttonRefresh.Location = New System.Drawing.Point(503, 91)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonRefresh.selected = False
        Me.buttonRefresh.Size = New System.Drawing.Size(32, 33)
        Me.buttonRefresh.TabIndex = 29
        Me.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonRefresh.Textcolor = System.Drawing.Color.White
        Me.buttonRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PatientControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonView)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonNew)
        Me.Controls.Add(Me.textSearch)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PatientControl"
        Me.Size = New System.Drawing.Size(820, 671)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents DataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents maritalStatus As DataGridViewTextBoxColumn
    Friend WithEvents occupation As DataGridViewTextBoxColumn
    Friend WithEvents textSearch As TextBox
    Friend WithEvents buttonNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents buttonEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents buttonView As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonRefresh As Bunifu.Framework.UI.BunifuFlatButton
End Class
