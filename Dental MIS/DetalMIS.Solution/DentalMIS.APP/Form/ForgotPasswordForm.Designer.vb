<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.buttonRecover = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textSecretQuestionAnswer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textUsername = New System.Windows.Forms.TextBox()
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
        Me.PanelHeader.Size = New System.Drawing.Size(420, 46)
        Me.PanelHeader.TabIndex = 46
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(9, 10)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(197, 29)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "Forgot Password"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(369, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'buttonRecover
        '
        Me.buttonRecover.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRecover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRecover.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonRecover.BorderRadius = 0
        Me.buttonRecover.ButtonText = "Recover"
        Me.buttonRecover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonRecover.DisabledColor = System.Drawing.Color.Gray
        Me.buttonRecover.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonRecover.Iconimage = CType(resources.GetObject("buttonRecover.Iconimage"), System.Drawing.Image)
        Me.buttonRecover.Iconimage_right = Nothing
        Me.buttonRecover.Iconimage_right_Selected = Nothing
        Me.buttonRecover.Iconimage_Selected = Nothing
        Me.buttonRecover.IconMarginLeft = 0
        Me.buttonRecover.IconMarginRight = 0
        Me.buttonRecover.IconRightVisible = True
        Me.buttonRecover.IconRightZoom = 0R
        Me.buttonRecover.IconVisible = True
        Me.buttonRecover.IconZoom = 50.0R
        Me.buttonRecover.IsTab = False
        Me.buttonRecover.Location = New System.Drawing.Point(317, 271)
        Me.buttonRecover.Name = "buttonRecover"
        Me.buttonRecover.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRecover.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonRecover.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonRecover.selected = False
        Me.buttonRecover.Size = New System.Drawing.Size(92, 33)
        Me.buttonRecover.TabIndex = 4
        Me.buttonRecover.Text = "Recover"
        Me.buttonRecover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonRecover.Textcolor = System.Drawing.Color.White
        Me.buttonRecover.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 140)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Tag = "*"
        Me.Label8.Text = "*Answer :"
        '
        'textSecretQuestionAnswer
        '
        Me.textSecretQuestionAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSecretQuestionAnswer.Location = New System.Drawing.Point(14, 158)
        Me.textSecretQuestionAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.textSecretQuestionAnswer.Multiline = True
        Me.textSecretQuestionAnswer.Name = "textSecretQuestionAnswer"
        Me.textSecretQuestionAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textSecretQuestionAnswer.Size = New System.Drawing.Size(395, 44)
        Me.textSecretQuestionAnswer.TabIndex = 2
        Me.textSecretQuestionAnswer.Tag = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "*Secret Question :"
        '
        'comboSecretQuestion
        '
        Me.comboSecretQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSecretQuestion.FormattingEnabled = True
        Me.comboSecretQuestion.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.comboSecretQuestion.Location = New System.Drawing.Point(14, 114)
        Me.comboSecretQuestion.Margin = New System.Windows.Forms.Padding(2)
        Me.comboSecretQuestion.Name = "comboSecretQuestion"
        Me.comboSecretQuestion.Size = New System.Drawing.Size(395, 24)
        Me.comboSecretQuestion.TabIndex = 1
        Me.comboSecretQuestion.Tag = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 204)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "*"
        Me.Label1.Text = "Your Password Is :"
        '
        'textPassword
        '
        Me.textPassword.BackColor = System.Drawing.Color.White
        Me.textPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(14, 222)
        Me.textPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.textPassword.Multiline = True
        Me.textPassword.Name = "textPassword"
        Me.textPassword.ReadOnly = True
        Me.textPassword.Size = New System.Drawing.Size(395, 44)
        Me.textPassword.TabIndex = 3
        Me.textPassword.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Tag = "*"
        Me.Label2.Text = "*Username :"
        '
        'textUsername
        '
        Me.textUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(14, 66)
        Me.textUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(395, 22)
        Me.textUsername.TabIndex = 0
        Me.textUsername.Tag = "*"
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 310)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textSecretQuestionAnswer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboSecretQuestion)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.buttonRecover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents buttonRecover As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents textSecretQuestionAnswer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents comboSecretQuestion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textUsername As TextBox
End Class
