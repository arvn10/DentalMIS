<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleAddEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleAddEditForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textDescription = New System.Windows.Forms.TextBox()
        Me.dateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.panelColor = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buttonColor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelHeader.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHeader.Controls.Add(Me.HeaderLabel)
        Me.PanelHeader.Controls.Add(Me.ButtonClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(371, 46)
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
        Me.HeaderLabel.Size = New System.Drawing.Size(115, 29)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "Schedule"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(320, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "*Title"
        '
        'textTitle
        '
        Me.textTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textTitle.Location = New System.Drawing.Point(12, 67)
        Me.textTitle.Name = "textTitle"
        Me.textTitle.Size = New System.Drawing.Size(347, 23)
        Me.textTitle.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "*Description"
        '
        'textDescription
        '
        Me.textDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textDescription.Location = New System.Drawing.Point(12, 112)
        Me.textDescription.Multiline = True
        Me.textDescription.Name = "textDescription"
        Me.textDescription.Size = New System.Drawing.Size(347, 102)
        Me.textDescription.TabIndex = 24
        '
        'dateTimePickerStart
        '
        Me.dateTimePickerStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerStart.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.dateTimePickerStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePickerStart.Location = New System.Drawing.Point(12, 236)
        Me.dateTimePickerStart.Name = "dateTimePickerStart"
        Me.dateTimePickerStart.Size = New System.Drawing.Size(347, 22)
        Me.dateTimePickerStart.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "*Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "*End"
        '
        'dateTimePickerEnd
        '
        Me.dateTimePickerEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.dateTimePickerEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePickerEnd.Location = New System.Drawing.Point(12, 280)
        Me.dateTimePickerEnd.Name = "dateTimePickerEnd"
        Me.dateTimePickerEnd.Size = New System.Drawing.Size(347, 22)
        Me.dateTimePickerEnd.TabIndex = 28
        '
        'panelColor
        '
        Me.panelColor.BackColor = System.Drawing.Color.White
        Me.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelColor.Location = New System.Drawing.Point(139, 325)
        Me.panelColor.Name = "panelColor"
        Me.panelColor.Size = New System.Drawing.Size(220, 22)
        Me.panelColor.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "*Color"
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
        Me.buttonSave.IconRightVisible = True
        Me.buttonSave.IconRightZoom = 0R
        Me.buttonSave.IconVisible = True
        Me.buttonSave.IconZoom = 50.0R
        Me.buttonSave.IsTab = False
        Me.buttonSave.Location = New System.Drawing.Point(274, 353)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 37
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buttonColor
        '
        Me.buttonColor.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonColor.BorderRadius = 0
        Me.buttonColor.ButtonText = "Choose Color"
        Me.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonColor.DisabledColor = System.Drawing.Color.Gray
        Me.buttonColor.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonColor.Iconimage = CType(resources.GetObject("buttonColor.Iconimage"), System.Drawing.Image)
        Me.buttonColor.Iconimage_right = Nothing
        Me.buttonColor.Iconimage_right_Selected = Nothing
        Me.buttonColor.Iconimage_Selected = Nothing
        Me.buttonColor.IconMarginLeft = 0
        Me.buttonColor.IconMarginRight = 0
        Me.buttonColor.IconRightVisible = True
        Me.buttonColor.IconRightZoom = 0R
        Me.buttonColor.IconVisible = True
        Me.buttonColor.IconZoom = 50.0R
        Me.buttonColor.IsTab = False
        Me.buttonColor.Location = New System.Drawing.Point(12, 325)
        Me.buttonColor.Name = "buttonColor"
        Me.buttonColor.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonColor.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonColor.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonColor.selected = False
        Me.buttonColor.Size = New System.Drawing.Size(122, 22)
        Me.buttonColor.TabIndex = 38
        Me.buttonColor.Text = "Choose Color"
        Me.buttonColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonColor.Textcolor = System.Drawing.Color.White
        Me.buttonColor.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ScheduleAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(371, 397)
        Me.Controls.Add(Me.buttonColor)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.panelColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateTimePickerEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dateTimePickerStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textTitle)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScheduleAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleAddEditForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents textTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textDescription As TextBox
    Friend WithEvents dateTimePickerStart As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dateTimePickerEnd As DateTimePicker
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents panelColor As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents buttonColor As Bunifu.Framework.UI.BunifuFlatButton
End Class
