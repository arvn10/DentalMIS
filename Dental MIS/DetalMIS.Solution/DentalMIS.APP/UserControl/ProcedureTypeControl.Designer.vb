<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProcedureTypeControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureTypeControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedureName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.basePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requireMedCert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonShowAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(243, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Procedure Type"
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.Location = New System.Drawing.Point(135, 93)
        Me.TextSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(672, 24)
        Me.TextSearch.TabIndex = 23
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
        Me.BunifuSeparator1.TabIndex = 20
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Enter Search Text :"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.procedureName, Me.basePrice, Me.paymentType, Me.requireMedCert, Me.status, Me.createdBy, Me.createdDate, Me.updatedBy, Me.updatedDate})
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.Location = New System.Drawing.Point(3, 41)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(787, 487)
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
        'procedureName
        '
        Me.procedureName.HeaderText = "Name"
        Me.procedureName.Name = "procedureName"
        Me.procedureName.ReadOnly = True
        '
        'basePrice
        '
        Me.basePrice.HeaderText = "Base Price"
        Me.basePrice.Name = "basePrice"
        Me.basePrice.ReadOnly = True
        '
        'paymentType
        '
        Me.paymentType.HeaderText = "Payment Type"
        Me.paymentType.Name = "paymentType"
        Me.paymentType.ReadOnly = True
        '
        'requireMedCert
        '
        Me.requireMedCert.HeaderText = "Require Med. Cert?"
        Me.requireMedCert.Name = "requireMedCert"
        Me.requireMedCert.ReadOnly = True
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 531)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonShowAll, Me.ToolStripButtonNew, Me.ToolStripButtonEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 47
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
        'ProcedureTypeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProcedureTypeControl"
        Me.Size = New System.Drawing.Size(820, 671)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents procedureName As DataGridViewTextBoxColumn
    Friend WithEvents basePrice As DataGridViewTextBoxColumn
    Friend WithEvents paymentType As DataGridViewTextBoxColumn
    Friend WithEvents requireMedCert As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents createdBy As DataGridViewTextBoxColumn
    Friend WithEvents createdDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonShowAll As ToolStripButton
    Friend WithEvents ToolStripButtonNew As ToolStripButton
    Friend WithEvents ToolStripButtonEdit As ToolStripButton
End Class
