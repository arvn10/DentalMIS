<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentControl))
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tooth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountToPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedureDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.textSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Payment"
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
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fullName, Me.tooth, Me.procedure, Me.amountToPay, Me.amountPaid, Me.balance, Me.paymentStatus, Me.procedureDate, Me.updatedBy, Me.updatedDate})
        Me.DataGrid.Location = New System.Drawing.Point(14, 125)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(793, 533)
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
        'fullName
        '
        Me.fullName.HeaderText = "Fullname"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'tooth
        '
        Me.tooth.HeaderText = "Tooth"
        Me.tooth.Name = "tooth"
        Me.tooth.ReadOnly = True
        '
        'procedure
        '
        Me.procedure.HeaderText = "Procedure"
        Me.procedure.Name = "procedure"
        Me.procedure.ReadOnly = True
        '
        'amountToPay
        '
        Me.amountToPay.HeaderText = "Amount To Pay"
        Me.amountToPay.Name = "amountToPay"
        Me.amountToPay.ReadOnly = True
        '
        'amountPaid
        '
        Me.amountPaid.HeaderText = "Amount Paid"
        Me.amountPaid.Name = "amountPaid"
        Me.amountPaid.ReadOnly = True
        '
        'balance
        '
        Me.balance.HeaderText = "Balance"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        '
        'paymentStatus
        '
        Me.paymentStatus.HeaderText = "Status"
        Me.paymentStatus.Name = "paymentStatus"
        Me.paymentStatus.ReadOnly = True
        '
        'procedureDate
        '
        Me.procedureDate.HeaderText = "Procedure Date"
        Me.procedureDate.Name = "procedureDate"
        Me.procedureDate.ReadOnly = True
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
        Me.buttonRefresh.Location = New System.Drawing.Point(737, 91)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonRefresh.selected = False
        Me.buttonRefresh.Size = New System.Drawing.Size(32, 33)
        Me.buttonRefresh.TabIndex = 49
        Me.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonRefresh.Textcolor = System.Drawing.Color.White
        Me.buttonRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Enter Search Text :"
        '
        'buttonEdit
        '
        Me.buttonEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonEdit.BorderRadius = 0
        Me.buttonEdit.ButtonText = ""
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
        Me.buttonEdit.Location = New System.Drawing.Point(775, 91)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonEdit.selected = False
        Me.buttonEdit.Size = New System.Drawing.Size(32, 33)
        Me.buttonEdit.TabIndex = 47
        Me.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEdit.Textcolor = System.Drawing.Color.White
        Me.buttonEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'textSearch
        '
        Me.textSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSearch.Location = New System.Drawing.Point(136, 96)
        Me.textSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(596, 24)
        Me.textSearch.TabIndex = 46
        '
        'PaymentControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.textSearch)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentControl"
        Me.Size = New System.Drawing.Size(820, 671)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents buttonRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents textSearch As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents tooth As DataGridViewTextBoxColumn
    Friend WithEvents procedure As DataGridViewTextBoxColumn
    Friend WithEvents amountToPay As DataGridViewTextBoxColumn
    Friend WithEvents amountPaid As DataGridViewTextBoxColumn
    Friend WithEvents balance As DataGridViewTextBoxColumn
    Friend WithEvents paymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents procedureDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
End Class
