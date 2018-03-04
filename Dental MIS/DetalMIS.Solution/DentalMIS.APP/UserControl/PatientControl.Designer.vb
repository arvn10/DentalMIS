<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonShowAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonViewDR = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 23)
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
        'textSearch
        '
        Me.textSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSearch.Location = New System.Drawing.Point(135, 96)
        Me.textSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(672, 24)
        Me.textSearch.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Enter Search Text :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(14, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 531)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Firstname, Me.Lastname, Me.Address, Me.Gender, Me.Age, Me.createdBy, Me.createdDate, Me.updatedBy, Me.updatedDate})
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.Location = New System.Drawing.Point(3, 41)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(787, 487)
        Me.DataGrid.TabIndex = 45
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 43
        '
        'Firstname
        '
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        '
        'Lastname
        '
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonShowAll, Me.ToolStripButtonNew, Me.ToolStripButtonEdit, Me.ToolStripButtonViewDR})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 46
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonShowAll
        '
        Me.ToolStripButtonShowAll.Image = CType(resources.GetObject("ToolStripButtonShowAll.Image"), System.Drawing.Image)
        Me.ToolStripButtonShowAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonShowAll.Name = "ToolStripButtonShowAll"
        Me.ToolStripButtonShowAll.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripButtonShowAll.Text = "Show All"
        '
        'ToolStripButtonNew
        '
        Me.ToolStripButtonNew.Image = CType(resources.GetObject("ToolStripButtonNew.Image"), System.Drawing.Image)
        Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
        Me.ToolStripButtonNew.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButtonNew.Text = "New"
        '
        'ToolStripButtonEdit
        '
        Me.ToolStripButtonEdit.Image = CType(resources.GetObject("ToolStripButtonEdit.Image"), System.Drawing.Image)
        Me.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEdit.Name = "ToolStripButtonEdit"
        Me.ToolStripButtonEdit.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButtonEdit.Text = "Edit"
        '
        'ToolStripButtonViewDR
        '
        Me.ToolStripButtonViewDR.Image = CType(resources.GetObject("ToolStripButtonViewDR.Image"), System.Drawing.Image)
        Me.ToolStripButtonViewDR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonViewDR.Name = "ToolStripButtonViewDR"
        Me.ToolStripButtonViewDR.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripButtonViewDR.Text = "View Dental Record"
        '
        'PatientControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textSearch)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PatientControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents textSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents createdBy As DataGridViewTextBoxColumn
    Friend WithEvents createdDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonShowAll As ToolStripButton
    Friend WithEvents ToolStripButtonNew As ToolStripButton
    Friend WithEvents ToolStripButtonEdit As ToolStripButton
    Friend WithEvents ToolStripButtonViewDR As ToolStripButton
End Class
