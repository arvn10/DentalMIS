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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureAddEditForm))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboProcedureType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textCharge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textPrescription = New System.Windows.Forms.TextBox()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboTooth = New System.Windows.Forms.ComboBox()
        Me.dtPickerTransDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageProcedure = New System.Windows.Forms.TabPage()
        Me.TabPagePayment = New System.Windows.Forms.TabPage()
        Me.textAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textPaymentBalance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textPaymentCharge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelHeader.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPageProcedure.SuspendLayout()
        Me.TabPagePayment.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(217, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "*Procedure"
        '
        'comboProcedureType
        '
        Me.comboProcedureType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProcedureType.FormattingEnabled = True
        Me.comboProcedureType.Location = New System.Drawing.Point(220, 22)
        Me.comboProcedureType.Name = "comboProcedureType"
        Me.comboProcedureType.Size = New System.Drawing.Size(208, 23)
        Me.comboProcedureType.TabIndex = 0
        Me.comboProcedureType.Tag = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Price"
        '
        'textPrice
        '
        Me.textPrice.BackColor = System.Drawing.SystemColors.Window
        Me.textPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textPrice.Location = New System.Drawing.Point(6, 67)
        Me.textPrice.Name = "textPrice"
        Me.textPrice.ReadOnly = True
        Me.textPrice.Size = New System.Drawing.Size(208, 23)
        Me.textPrice.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "*Charge"
        '
        'textCharge
        '
        Me.textCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textCharge.Location = New System.Drawing.Point(220, 67)
        Me.textCharge.Name = "textCharge"
        Me.textCharge.Size = New System.Drawing.Size(208, 23)
        Me.textCharge.TabIndex = 1
        Me.textCharge.Tag = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Notes"
        '
        'textPrescription
        '
        Me.textPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPrescription.Location = New System.Drawing.Point(6, 157)
        Me.textPrescription.Multiline = True
        Me.textPrescription.Name = "textPrescription"
        Me.textPrescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textPrescription.Size = New System.Drawing.Size(422, 172)
        Me.textPrescription.TabIndex = 3
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "*Tooth"
        '
        'comboTooth
        '
        Me.comboTooth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTooth.FormattingEnabled = True
        Me.comboTooth.Location = New System.Drawing.Point(6, 22)
        Me.comboTooth.Name = "comboTooth"
        Me.comboTooth.Size = New System.Drawing.Size(208, 23)
        Me.comboTooth.TabIndex = 49
        Me.comboTooth.Tag = "*"
        '
        'dtPickerTransDate
        '
        Me.dtPickerTransDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerTransDate.Location = New System.Drawing.Point(6, 112)
        Me.dtPickerTransDate.Name = "dtPickerTransDate"
        Me.dtPickerTransDate.Size = New System.Drawing.Size(208, 22)
        Me.dtPickerTransDate.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "*Transaction Date"
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
        'TabPageProcedure
        '
        Me.TabPageProcedure.Controls.Add(Me.Label7)
        Me.TabPageProcedure.Controls.Add(Me.Label6)
        Me.TabPageProcedure.Controls.Add(Me.comboProcedureType)
        Me.TabPageProcedure.Controls.Add(Me.dtPickerTransDate)
        Me.TabPageProcedure.Controls.Add(Me.Label4)
        Me.TabPageProcedure.Controls.Add(Me.comboTooth)
        Me.TabPageProcedure.Controls.Add(Me.textPrice)
        Me.TabPageProcedure.Controls.Add(Me.Label1)
        Me.TabPageProcedure.Controls.Add(Me.Label5)
        Me.TabPageProcedure.Controls.Add(Me.textCharge)
        Me.TabPageProcedure.Controls.Add(Me.textPrescription)
        Me.TabPageProcedure.Controls.Add(Me.Label3)
        Me.TabPageProcedure.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProcedure.Name = "TabPageProcedure"
        Me.TabPageProcedure.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProcedure.Size = New System.Drawing.Size(435, 337)
        Me.TabPageProcedure.TabIndex = 0
        Me.TabPageProcedure.Text = "Procedure Details"
        Me.TabPageProcedure.UseVisualStyleBackColor = True
        '
        'TabPagePayment
        '
        Me.TabPagePayment.Controls.Add(Me.textAmountPaid)
        Me.TabPagePayment.Controls.Add(Me.Label10)
        Me.TabPagePayment.Controls.Add(Me.textPaymentBalance)
        Me.TabPagePayment.Controls.Add(Me.Label9)
        Me.TabPagePayment.Controls.Add(Me.textPaymentCharge)
        Me.TabPagePayment.Controls.Add(Me.Label8)
        Me.TabPagePayment.Controls.Add(Me.DataGrid)
        Me.TabPagePayment.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePayment.Name = "TabPagePayment"
        Me.TabPagePayment.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePayment.Size = New System.Drawing.Size(435, 337)
        Me.TabPagePayment.TabIndex = 1
        Me.TabPagePayment.Text = "Payment Details"
        Me.TabPagePayment.UseVisualStyleBackColor = True
        '
        'textAmountPaid
        '
        Me.textAmountPaid.BackColor = System.Drawing.Color.White
        Me.textAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textAmountPaid.Location = New System.Drawing.Point(102, 279)
        Me.textAmountPaid.Name = "textAmountPaid"
        Me.textAmountPaid.ReadOnly = True
        Me.textAmountPaid.Size = New System.Drawing.Size(325, 23)
        Me.textAmountPaid.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Amount Paid :"
        '
        'textPaymentBalance
        '
        Me.textPaymentBalance.BackColor = System.Drawing.Color.White
        Me.textPaymentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textPaymentBalance.Location = New System.Drawing.Point(102, 308)
        Me.textPaymentBalance.Name = "textPaymentBalance"
        Me.textPaymentBalance.ReadOnly = True
        Me.textPaymentBalance.Size = New System.Drawing.Size(325, 23)
        Me.textPaymentBalance.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Balance :"
        '
        'textPaymentCharge
        '
        Me.textPaymentCharge.BackColor = System.Drawing.Color.White
        Me.textPaymentCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textPaymentCharge.Location = New System.Drawing.Point(102, 250)
        Me.textPaymentCharge.Name = "textPaymentCharge"
        Me.textPaymentCharge.ReadOnly = True
        Me.textPaymentCharge.Size = New System.Drawing.Size(325, 23)
        Me.textPaymentCharge.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Charge :"
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.amountPaid, Me.paymentDate, Me.updatedBy, Me.updatedDate})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid.Location = New System.Drawing.Point(3, 3)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(429, 241)
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
        'amountPaid
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountPaid.DefaultCellStyle = DataGridViewCellStyle14
        Me.amountPaid.HeaderText = "Amount Paid"
        Me.amountPaid.Name = "amountPaid"
        Me.amountPaid.ReadOnly = True
        '
        'paymentDate
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDate.DefaultCellStyle = DataGridViewCellStyle15
        Me.paymentDate.HeaderText = "Payment Date"
        Me.paymentDate.Name = "paymentDate"
        Me.paymentDate.ReadOnly = True
        '
        'updatedBy
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedBy.DefaultCellStyle = DataGridViewCellStyle16
        Me.updatedBy.HeaderText = "Updated By"
        Me.updatedBy.Name = "updatedBy"
        Me.updatedBy.ReadOnly = True
        '
        'updatedDate
        '
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedDate.DefaultCellStyle = DataGridViewCellStyle17
        Me.updatedDate.HeaderText = "Updated Date"
        Me.updatedDate.Name = "updatedDate"
        Me.updatedDate.ReadOnly = True
        '
        'ProcedureAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 455)
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
        Me.TabControl.ResumeLayout(False)
        Me.TabPageProcedure.ResumeLayout(False)
        Me.TabPageProcedure.PerformLayout()
        Me.TabPagePayment.ResumeLayout(False)
        Me.TabPagePayment.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents comboProcedureType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textCharge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textPrescription As TextBox
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents comboTooth As ComboBox
    Friend WithEvents dtPickerTransDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageProcedure As TabPage
    Friend WithEvents TabPagePayment As TabPage
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents textAmountPaid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textPaymentBalance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textPaymentCharge As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents amountPaid As DataGridViewTextBoxColumn
    Friend WithEvents paymentDate As DataGridViewTextBoxColumn
    Friend WithEvents updatedBy As DataGridViewTextBoxColumn
    Friend WithEvents updatedDate As DataGridViewTextBoxColumn
End Class
