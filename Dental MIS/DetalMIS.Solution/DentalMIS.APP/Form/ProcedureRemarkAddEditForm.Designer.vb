<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcedureRemarkAddEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureRemarkAddEditForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.textRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtPickerTransDate = New System.Windows.Forms.DateTimePicker()
        Me.PanelHeader.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelHeader.Size = New System.Drawing.Size(411, 46)
        Me.PanelHeader.TabIndex = 22
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
        Me.ButtonClose.Location = New System.Drawing.Point(360, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'BunifuElipse
        '
        Me.BunifuElipse.ElipseRadius = 5
        Me.BunifuElipse.TargetControl = Me
        '
        'textRemark
        '
        Me.textRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textRemark.Location = New System.Drawing.Point(12, 67)
        Me.textRemark.Multiline = True
        Me.textRemark.Name = "textRemark"
        Me.textRemark.Size = New System.Drawing.Size(387, 45)
        Me.textRemark.TabIndex = 0
        Me.textRemark.Tag = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "*Remark"
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
        Me.buttonSave.Location = New System.Drawing.Point(314, 163)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 2
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "*Date"
        '
        'dtPickerTransDate
        '
        Me.dtPickerTransDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerTransDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerTransDate.Location = New System.Drawing.Point(12, 134)
        Me.dtPickerTransDate.Name = "dtPickerTransDate"
        Me.dtPickerTransDate.Size = New System.Drawing.Size(208, 22)
        Me.dtPickerTransDate.TabIndex = 1
        '
        'ProcedureRemarkAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 207)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtPickerTransDate)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.textRemark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProcedureRemarkAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProcedureRemarkAddEditForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents textRemark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dtPickerTransDate As DateTimePicker
End Class
