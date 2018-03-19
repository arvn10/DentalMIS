<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProcedureAddEditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureAddEditForm))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPagePayment = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPageProcedure = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageTooth = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridTooth = New System.Windows.Forms.DataGridView()
        Me.procedureToothID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toothID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tooth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripButtonToothNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonToothEdit = New System.Windows.Forms.ToolStripButton()
        Me.TabPageRemarks = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewRemark = New System.Windows.Forms.DataGridView()
        Me.procedureRemarkID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateAdded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripButtonRemarkNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRemarkEdit = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboProcedureType = New System.Windows.Forms.ComboBox()
        Me.dtPickerTransDate = New System.Windows.Forms.DateTimePicker()
        Me.textPrice = New System.Windows.Forms.TextBox()
        Me.textCharge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PanelHeader.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePayment.SuspendLayout()
        Me.TabPageProcedure.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageTooth.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridTooth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        Me.TabPageRemarks.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse
        '
        Me.BunifuElipse.ElipseRadius = 5
        Me.BunifuElipse.TargetControl = Me
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
        Me.PanelHeader.Size = New System.Drawing.Size(443, 46)
        Me.PanelHeader.TabIndex = 21
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(9, 10)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(276, 29)
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
        Me.ButtonClose.Location = New System.Drawing.Point(392, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'buttonSave
        '
        Me.buttonSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
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
        Me.buttonSave.IconRightVisible = True
        Me.buttonSave.IconRightZoom = 0R
        Me.buttonSave.IconVisible = True
        Me.buttonSave.IconZoom = 50.0R
        Me.buttonSave.IsTab = False
        Me.buttonSave.Location = New System.Drawing.Point(354, 415)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 48
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPagePayment
        '
        Me.TabPagePayment.Controls.Add(Me.Panel1)
        Me.TabPagePayment.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePayment.Name = "TabPagePayment"
        Me.TabPagePayment.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePayment.Size = New System.Drawing.Size(435, 337)
        Me.TabPagePayment.TabIndex = 2
        Me.TabPagePayment.Text = "Payment"
        Me.TabPagePayment.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 331)
        Me.Panel1.TabIndex = 0
        '
        'TabPageProcedure
        '
        Me.TabPageProcedure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageProcedure.Controls.Add(Me.TabControl1)
        Me.TabPageProcedure.Controls.Add(Me.Label7)
        Me.TabPageProcedure.Controls.Add(Me.Label6)
        Me.TabPageProcedure.Controls.Add(Me.comboProcedureType)
        Me.TabPageProcedure.Controls.Add(Me.dtPickerTransDate)
        Me.TabPageProcedure.Controls.Add(Me.textPrice)
        Me.TabPageProcedure.Controls.Add(Me.textCharge)
        Me.TabPageProcedure.Controls.Add(Me.Label1)
        Me.TabPageProcedure.Controls.Add(Me.Label3)
        Me.TabPageProcedure.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProcedure.Name = "TabPageProcedure"
        Me.TabPageProcedure.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProcedure.Size = New System.Drawing.Size(435, 337)
        Me.TabPageProcedure.TabIndex = 0
        Me.TabPageProcedure.Text = "Procedure Details"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageTooth)
        Me.TabControl1.Controls.Add(Me.TabPageRemarks)
        Me.TabControl1.Location = New System.Drawing.Point(6, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(422, 235)
        Me.TabControl1.TabIndex = 54
        '
        'TabPageTooth
        '
        Me.TabPageTooth.Controls.Add(Me.Panel2)
        Me.TabPageTooth.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTooth.Name = "TabPageTooth"
        Me.TabPageTooth.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTooth.Size = New System.Drawing.Size(414, 209)
        Me.TabPageTooth.TabIndex = 0
        Me.TabPageTooth.Text = "Tooth"
        Me.TabPageTooth.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridTooth)
        Me.Panel2.Controls.Add(Me.MenuStrip3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 203)
        Me.Panel2.TabIndex = 0
        '
        'DataGridTooth
        '
        Me.DataGridTooth.AllowUserToAddRows = False
        Me.DataGridTooth.AllowUserToDeleteRows = False
        Me.DataGridTooth.AllowUserToResizeColumns = False
        Me.DataGridTooth.AllowUserToResizeRows = False
        Me.DataGridTooth.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridTooth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridTooth.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTooth.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTooth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTooth.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.procedureToothID, Me.toothID, Me.tooth})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridTooth.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridTooth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridTooth.Location = New System.Drawing.Point(0, 27)
        Me.DataGridTooth.MultiSelect = False
        Me.DataGridTooth.Name = "DataGridTooth"
        Me.DataGridTooth.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTooth.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridTooth.RowHeadersVisible = False
        Me.DataGridTooth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTooth.Size = New System.Drawing.Size(408, 176)
        Me.DataGridTooth.TabIndex = 51
        '
        'procedureToothID
        '
        Me.procedureToothID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.procedureToothID.HeaderText = "ID"
        Me.procedureToothID.Name = "procedureToothID"
        Me.procedureToothID.ReadOnly = True
        Me.procedureToothID.Visible = False
        '
        'toothID
        '
        Me.toothID.HeaderText = "ToothID"
        Me.toothID.Name = "toothID"
        Me.toothID.ReadOnly = True
        Me.toothID.Visible = False
        '
        'tooth
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooth.DefaultCellStyle = DataGridViewCellStyle2
        Me.tooth.HeaderText = "Tooth"
        Me.tooth.Name = "tooth"
        Me.tooth.ReadOnly = True
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonToothNew, Me.ToolStripButtonToothEdit})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(408, 27)
        Me.MenuStrip3.TabIndex = 55
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripButtonToothNew
        '
        Me.ToolStripButtonToothNew.Image = CType(resources.GetObject("ToolStripButtonToothNew.Image"), System.Drawing.Image)
        Me.ToolStripButtonToothNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonToothNew.Name = "ToolStripButtonToothNew"
        Me.ToolStripButtonToothNew.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripButtonToothNew.Text = "New"
        '
        'ToolStripButtonToothEdit
        '
        Me.ToolStripButtonToothEdit.Image = CType(resources.GetObject("ToolStripButtonToothEdit.Image"), System.Drawing.Image)
        Me.ToolStripButtonToothEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonToothEdit.Name = "ToolStripButtonToothEdit"
        Me.ToolStripButtonToothEdit.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripButtonToothEdit.Text = "Edit"
        '
        'TabPageRemarks
        '
        Me.TabPageRemarks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageRemarks.Controls.Add(Me.Panel3)
        Me.TabPageRemarks.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRemarks.Name = "TabPageRemarks"
        Me.TabPageRemarks.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRemarks.Size = New System.Drawing.Size(414, 209)
        Me.TabPageRemarks.TabIndex = 1
        Me.TabPageRemarks.Text = "Remark"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridViewRemark)
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(408, 203)
        Me.Panel3.TabIndex = 0
        '
        'DataGridViewRemark
        '
        Me.DataGridViewRemark.AllowUserToAddRows = False
        Me.DataGridViewRemark.AllowUserToDeleteRows = False
        Me.DataGridViewRemark.AllowUserToResizeColumns = False
        Me.DataGridViewRemark.AllowUserToResizeRows = False
        Me.DataGridViewRemark.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewRemark.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRemark.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewRemark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRemark.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.procedureRemarkID, Me.remark, Me.dateAdded})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRemark.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewRemark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRemark.Location = New System.Drawing.Point(0, 27)
        Me.DataGridViewRemark.MultiSelect = False
        Me.DataGridViewRemark.Name = "DataGridViewRemark"
        Me.DataGridViewRemark.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRemark.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewRemark.RowHeadersVisible = False
        Me.DataGridViewRemark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRemark.Size = New System.Drawing.Size(408, 176)
        Me.DataGridViewRemark.TabIndex = 53
        '
        'procedureRemarkID
        '
        Me.procedureRemarkID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.procedureRemarkID.HeaderText = "ID"
        Me.procedureRemarkID.Name = "procedureRemarkID"
        Me.procedureRemarkID.ReadOnly = True
        Me.procedureRemarkID.Visible = False
        '
        'remark
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remark.DefaultCellStyle = DataGridViewCellStyle6
        Me.remark.HeaderText = "Remark"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        '
        'dateAdded
        '
        Me.dateAdded.HeaderText = "Date Added"
        Me.dateAdded.Name = "dateAdded"
        Me.dateAdded.ReadOnly = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonRemarkNew, Me.ToolStripButtonRemarkEdit})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(408, 27)
        Me.MenuStrip2.TabIndex = 55
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripButtonRemarkNew
        '
        Me.ToolStripButtonRemarkNew.Image = CType(resources.GetObject("ToolStripButtonRemarkNew.Image"), System.Drawing.Image)
        Me.ToolStripButtonRemarkNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemarkNew.Name = "ToolStripButtonRemarkNew"
        Me.ToolStripButtonRemarkNew.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripButtonRemarkNew.Text = "New"
        '
        'ToolStripButtonRemarkEdit
        '
        Me.ToolStripButtonRemarkEdit.Image = CType(resources.GetObject("ToolStripButtonRemarkEdit.Image"), System.Drawing.Image)
        Me.ToolStripButtonRemarkEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemarkEdit.Name = "ToolStripButtonRemarkEdit"
        Me.ToolStripButtonRemarkEdit.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripButtonRemarkEdit.Text = "Edit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "*Procedure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "*Transaction Date"
        '
        'comboProcedureType
        '
        Me.comboProcedureType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProcedureType.FormattingEnabled = True
        Me.comboProcedureType.Location = New System.Drawing.Point(6, 22)
        Me.comboProcedureType.Name = "comboProcedureType"
        Me.comboProcedureType.Size = New System.Drawing.Size(208, 23)
        Me.comboProcedureType.TabIndex = 0
        Me.comboProcedureType.Tag = "*"
        '
        'dtPickerTransDate
        '
        Me.dtPickerTransDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerTransDate.Location = New System.Drawing.Point(220, 67)
        Me.dtPickerTransDate.Name = "dtPickerTransDate"
        Me.dtPickerTransDate.Size = New System.Drawing.Size(208, 22)
        Me.dtPickerTransDate.TabIndex = 51
        '
        'textPrice
        '
        Me.textPrice.BackColor = System.Drawing.SystemColors.Window
        Me.textPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textPrice.Location = New System.Drawing.Point(220, 22)
        Me.textPrice.Name = "textPrice"
        Me.textPrice.ReadOnly = True
        Me.textPrice.Size = New System.Drawing.Size(208, 23)
        Me.textPrice.TabIndex = 38
        '
        'textCharge
        '
        Me.textCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textCharge.Location = New System.Drawing.Point(6, 67)
        Me.textCharge.Name = "textCharge"
        Me.textCharge.Size = New System.Drawing.Size(208, 23)
        Me.textCharge.TabIndex = 1
        Me.textCharge.Tag = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "*Charge"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageProcedure)
        Me.TabControl.Controls.Add(Me.TabPagePayment)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 46)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(443, 363)
        Me.TabControl.TabIndex = 53
        '
        'ProcedureAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(443, 457)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcedureAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedure"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePayment.ResumeLayout(False)
        Me.TabPageProcedure.ResumeLayout(False)
        Me.TabPageProcedure.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageTooth.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridTooth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.TabPageRemarks.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewRemark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageProcedure As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboProcedureType As ComboBox
    Friend WithEvents dtPickerTransDate As DateTimePicker
    Friend WithEvents textPrice As TextBox
    Friend WithEvents textCharge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPagePayment As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageTooth As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridTooth As DataGridView
    Friend WithEvents TabPageRemarks As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridViewRemark As DataGridView
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripButtonToothNew As ToolStripButton
    Friend WithEvents ToolStripButtonToothEdit As ToolStripButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripButtonRemarkNew As ToolStripButton
    Friend WithEvents ToolStripButtonRemarkEdit As ToolStripButton
    Friend WithEvents procedureToothID As DataGridViewTextBoxColumn
    Friend WithEvents toothID As DataGridViewTextBoxColumn
    Friend WithEvents tooth As DataGridViewTextBoxColumn
    Friend WithEvents procedureRemarkID As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
    Friend WithEvents dateAdded As DataGridViewTextBoxColumn
End Class
