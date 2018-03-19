<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcedureTypeAddEditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureTypeAddEditForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboPaymentType = New System.Windows.Forms.ComboBox()
        Me.textName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBasePrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboMedCert = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDetails = New System.Windows.Forms.TabPage()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPageNotAllowed = New System.Windows.Forms.TabPage()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonShowAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboRequireTooth = New System.Windows.Forms.ComboBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedureName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.visibilityType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelHeader.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDetails.SuspendLayout()
        Me.TabPageNotAllowed.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.HeaderLabel)
        Me.PanelHeader.Controls.Add(Me.ButtonClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(410, 46)
        Me.PanelHeader.TabIndex = 2
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(5, 12)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(207, 23)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "OLAES DENTAL CLINIC"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(359, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "*Payment Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "*Name :"
        '
        'comboPaymentType
        '
        Me.comboPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPaymentType.FormattingEnabled = True
        Me.comboPaymentType.Items.AddRange(New Object() {"Full Payment", "Installment"})
        Me.comboPaymentType.Location = New System.Drawing.Point(7, 67)
        Me.comboPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.comboPaymentType.Name = "comboPaymentType"
        Me.comboPaymentType.Size = New System.Drawing.Size(192, 24)
        Me.comboPaymentType.TabIndex = 3
        '
        'textName
        '
        Me.textName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textName.Location = New System.Drawing.Point(7, 25)
        Me.textName.Margin = New System.Windows.Forms.Padding(2)
        Me.textName.Name = "textName"
        Me.textName.Size = New System.Drawing.Size(192, 22)
        Me.textName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "*Base Price :"
        '
        'textBasePrice
        '
        Me.textBasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBasePrice.Location = New System.Drawing.Point(203, 25)
        Me.textBasePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.textBasePrice.Name = "textBasePrice"
        Me.textBasePrice.Size = New System.Drawing.Size(192, 22)
        Me.textBasePrice.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "*Require Med. Cert. :"
        '
        'comboMedCert
        '
        Me.comboMedCert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMedCert.FormattingEnabled = True
        Me.comboMedCert.Items.AddRange(New Object() {"Yes", "No"})
        Me.comboMedCert.Location = New System.Drawing.Point(203, 67)
        Me.comboMedCert.Margin = New System.Windows.Forms.Padding(2)
        Me.comboMedCert.Name = "comboMedCert"
        Me.comboMedCert.Size = New System.Drawing.Size(192, 24)
        Me.comboMedCert.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "*Status :"
        Me.Label5.Visible = False
        '
        'comboStatus
        '
        Me.comboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.comboStatus.Location = New System.Drawing.Point(203, 111)
        Me.comboStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(192, 24)
        Me.comboStatus.TabIndex = 6
        Me.comboStatus.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelHeader
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDetails)
        Me.TabControl1.Controls.Add(Me.TabPageNotAllowed)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(410, 206)
        Me.TabControl1.TabIndex = 25
        '
        'TabPageDetails
        '
        Me.TabPageDetails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageDetails.Controls.Add(Me.Label6)
        Me.TabPageDetails.Controls.Add(Me.comboRequireTooth)
        Me.TabPageDetails.Controls.Add(Me.buttonSave)
        Me.TabPageDetails.Controls.Add(Me.textBasePrice)
        Me.TabPageDetails.Controls.Add(Me.Label5)
        Me.TabPageDetails.Controls.Add(Me.textName)
        Me.TabPageDetails.Controls.Add(Me.comboStatus)
        Me.TabPageDetails.Controls.Add(Me.comboPaymentType)
        Me.TabPageDetails.Controls.Add(Me.Label3)
        Me.TabPageDetails.Controls.Add(Me.Label1)
        Me.TabPageDetails.Controls.Add(Me.comboMedCert)
        Me.TabPageDetails.Controls.Add(Me.Label4)
        Me.TabPageDetails.Controls.Add(Me.Label2)
        Me.TabPageDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDetails.Name = "TabPageDetails"
        Me.TabPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetails.Size = New System.Drawing.Size(402, 180)
        Me.TabPageDetails.TabIndex = 0
        Me.TabPageDetails.Text = "Procedure Details"
        '
        'buttonSave
        '
        Me.buttonSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonSave.BorderRadius = 0
        Me.buttonSave.ButtonText = "  Save"
        Me.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSave.DisabledColor = System.Drawing.Color.Gray
        Me.buttonSave.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonSave.Iconimage = CType(resources.GetObject("buttonSave.Iconimage"), System.Drawing.Image)
        Me.buttonSave.Iconimage_right = Nothing
        Me.buttonSave.Iconimage_right_Selected = Nothing
        Me.buttonSave.Iconimage_Selected = Nothing
        Me.buttonSave.IconMarginLeft = 0
        Me.buttonSave.IconMarginRight = 0
        Me.buttonSave.IconRightVisible = False
        Me.buttonSave.IconRightZoom = 0R
        Me.buttonSave.IconVisible = False
        Me.buttonSave.IconZoom = 50.0R
        Me.buttonSave.IsTab = False
        Me.buttonSave.Location = New System.Drawing.Point(310, 140)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 25
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPageNotAllowed
        '
        Me.TabPageNotAllowed.Controls.Add(Me.DataGrid)
        Me.TabPageNotAllowed.Controls.Add(Me.ToolStrip1)
        Me.TabPageNotAllowed.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNotAllowed.Name = "TabPageNotAllowed"
        Me.TabPageNotAllowed.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNotAllowed.Size = New System.Drawing.Size(402, 180)
        Me.TabPageNotAllowed.TabIndex = 1
        Me.TabPageNotAllowed.Text = "Procedure Type Pairing"
        Me.TabPageNotAllowed.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.procedureName, Me.visibilityType, Me.status, Me.createdBy, Me.createdDate, Me.updatedBy, Me.updatedDate})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.Location = New System.Drawing.Point(3, 28)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(396, 149)
        Me.DataGrid.TabIndex = 47
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonShowAll, Me.ToolStripButtonNew, Me.ToolStripButtonEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(396, 25)
        Me.ToolStrip1.TabIndex = 48
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 93)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "*Require Tooth? :"
        '
        'comboRequireTooth
        '
        Me.comboRequireTooth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRequireTooth.FormattingEnabled = True
        Me.comboRequireTooth.Items.AddRange(New Object() {"Yes", "Optional"})
        Me.comboRequireTooth.Location = New System.Drawing.Point(7, 111)
        Me.comboRequireTooth.Margin = New System.Windows.Forms.Padding(2)
        Me.comboRequireTooth.Name = "comboRequireTooth"
        Me.comboRequireTooth.Size = New System.Drawing.Size(192, 24)
        Me.comboRequireTooth.TabIndex = 5
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 24
        '
        'procedureName
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.procedureName.DefaultCellStyle = DataGridViewCellStyle2
        Me.procedureName.HeaderText = "Procedure Name"
        Me.procedureName.Name = "procedureName"
        Me.procedureName.ReadOnly = True
        '
        'visibilityType
        '
        Me.visibilityType.HeaderText = "Visiblity Type"
        Me.visibilityType.Name = "visibilityType"
        Me.visibilityType.ReadOnly = True
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
        Me.createdBy.Visible = False
        '
        'createdDate
        '
        Me.createdDate.HeaderText = "Created Date"
        Me.createdDate.Name = "createdDate"
        Me.createdDate.ReadOnly = True
        Me.createdDate.Visible = False
        '
        'updatedBy
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedBy.DefaultCellStyle = DataGridViewCellStyle3
        Me.updatedBy.HeaderText = "Updated By"
        Me.updatedBy.Name = "updatedBy"
        Me.updatedBy.ReadOnly = True
        Me.updatedBy.Visible = False
        '
        'updatedDate
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.updatedDate.HeaderText = "Updated Date"
        Me.updatedDate.Name = "updatedDate"
        Me.updatedDate.ReadOnly = True
        Me.updatedDate.Visible = False
        '
        'ProcedureTypeAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(410, 252)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProcedureTypeAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedure Type"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDetails.ResumeLayout(False)
        Me.TabPageDetails.PerformLayout()
        Me.TabPageNotAllowed.ResumeLayout(False)
        Me.TabPageNotAllowed.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboPaymentType As ComboBox
    Friend WithEvents textName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textBasePrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents comboMedCert As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDetails As TabPage
    Friend WithEvents TabPageNotAllowed As TabPage
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonShowAll As ToolStripButton
    Friend WithEvents ToolStripButtonNew As ToolStripButton
    Friend WithEvents ToolStripButtonEdit As ToolStripButton
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents comboRequireTooth As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents procedureName As DataGridViewTextBoxColumn
    Friend WithEvents visibilityType As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents createdBy As DataGridViewTextBoxColumn
    Friend WithEvents createdDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
End Class
