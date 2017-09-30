<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorAddEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorAddEditForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.textFirstname = New System.Windows.Forms.TextBox()
        Me.textLastname = New System.Windows.Forms.TextBox()
        Me.textMI = New System.Windows.Forms.TextBox()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
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
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(561, 57)
        Me.PanelHeader.TabIndex = 1
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 12)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(254, 32)
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
        Me.ButtonClose.Location = New System.Drawing.Point(493, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 32)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'textFirstname
        '
        Me.textFirstname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textFirstname.Location = New System.Drawing.Point(12, 104)
        Me.textFirstname.Name = "textFirstname"
        Me.textFirstname.Size = New System.Drawing.Size(198, 30)
        Me.textFirstname.TabIndex = 0
        '
        'textLastname
        '
        Me.textLastname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLastname.Location = New System.Drawing.Point(216, 104)
        Me.textLastname.Name = "textLastname"
        Me.textLastname.Size = New System.Drawing.Size(213, 30)
        Me.textLastname.TabIndex = 1
        '
        'textMI
        '
        Me.textMI.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMI.Location = New System.Drawing.Point(435, 104)
        Me.textMI.Name = "textMI"
        Me.textMI.Size = New System.Drawing.Size(113, 30)
        Me.textMI.TabIndex = 2
        '
        'comboStatus
        '
        Me.comboStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.comboStatus.Location = New System.Drawing.Point(13, 161)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(198, 29)
        Me.comboStatus.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Firstname :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "M.I. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lastname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Status :"
        '
        'buttonSave
        '
        Me.buttonSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonSave.BorderRadius = 0
        Me.buttonSave.ButtonText = "     Save"
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
        Me.buttonSave.Location = New System.Drawing.Point(435, 203)
        Me.buttonSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(113, 41)
        Me.buttonSave.TabIndex = 17
        Me.buttonSave.Text = "     Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DoctorAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(561, 257)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.textMI)
        Me.Controls.Add(Me.textLastname)
        Me.Controls.Add(Me.textFirstname)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DoctorAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoctorAddEditForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents textFirstname As TextBox
    Friend WithEvents textLastname As TextBox
    Friend WithEvents textMI As TextBox
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
End Class
