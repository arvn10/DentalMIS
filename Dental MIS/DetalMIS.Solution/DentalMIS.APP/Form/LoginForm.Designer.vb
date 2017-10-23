<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.LabelConnecting = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonSettingConnected = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonSettingDisconnected = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BackgroundCheckDBCon = New System.ComponentModel.BackgroundWorker()
        Me.FormAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelLogin.SuspendLayout()
        CType(Me.ButtonSettingConnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonSettingDisconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PanelLogin.Controls.Add(Me.textPassword)
        Me.PanelLogin.Controls.Add(Me.textUsername)
        Me.PanelLogin.Controls.Add(Me.LabelConnecting)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.buttonLogin)
        Me.PanelLogin.Controls.Add(Me.ButtonSettingConnected)
        Me.PanelLogin.Controls.Add(Me.ButtonSettingDisconnected)
        Me.FormAnimator.SetDecoration(Me.PanelLogin, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLogin.ForeColor = System.Drawing.Color.White
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(314, 277)
        Me.PanelLogin.TabIndex = 0
        '
        'textPassword
        '
        Me.textPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormAnimator.SetDecoration(Me.textPassword, BunifuAnimatorNS.DecorationType.None)
        Me.textPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(11, 147)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPassword.Size = New System.Drawing.Size(288, 31)
        Me.textPassword.TabIndex = 11
        Me.textPassword.Text = "qweqeq"
        '
        'textUsername
        '
        Me.textUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormAnimator.SetDecoration(Me.textUsername, BunifuAnimatorNS.DecorationType.None)
        Me.textUsername.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(11, 89)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(288, 31)
        Me.textUsername.TabIndex = 10
        Me.textUsername.Text = "asdasd"
        '
        'LabelConnecting
        '
        Me.LabelConnecting.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.LabelConnecting, BunifuAnimatorNS.DecorationType.None)
        Me.LabelConnecting.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelConnecting.Location = New System.Drawing.Point(7, 247)
        Me.LabelConnecting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConnecting.Name = "LabelConnecting"
        Me.LabelConnecting.Size = New System.Drawing.Size(220, 21)
        Me.LabelConnecting.TabIndex = 9
        Me.LabelConnecting.Text = "Connecting to Database..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USERNAME"
        '
        'buttonLogin
        '
        Me.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonLogin.BorderRadius = 0
        Me.buttonLogin.ButtonText = "LOGIN"
        Me.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.buttonLogin, BunifuAnimatorNS.DecorationType.None)
        Me.buttonLogin.DisabledColor = System.Drawing.Color.Gray
        Me.buttonLogin.Enabled = False
        Me.buttonLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonLogin.Iconimage = Nothing
        Me.buttonLogin.Iconimage_right = Nothing
        Me.buttonLogin.Iconimage_right_Selected = Nothing
        Me.buttonLogin.Iconimage_Selected = Nothing
        Me.buttonLogin.IconMarginLeft = 0
        Me.buttonLogin.IconMarginRight = 0
        Me.buttonLogin.IconRightVisible = True
        Me.buttonLogin.IconRightZoom = 0R
        Me.buttonLogin.IconVisible = True
        Me.buttonLogin.IconZoom = 90.0R
        Me.buttonLogin.IsTab = False
        Me.buttonLogin.Location = New System.Drawing.Point(11, 198)
        Me.buttonLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonLogin.selected = False
        Me.buttonLogin.Size = New System.Drawing.Size(288, 38)
        Me.buttonLogin.TabIndex = 2
        Me.buttonLogin.Text = "LOGIN"
        Me.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonLogin.Textcolor = System.Drawing.Color.White
        Me.buttonLogin.TextFont = New System.Drawing.Font("Century Gothic", 12.0!)
        '
        'ButtonSettingConnected
        '
        Me.ButtonSettingConnected.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSettingConnected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSettingConnected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.ButtonSettingConnected, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonSettingConnected.Image = CType(resources.GetObject("ButtonSettingConnected.Image"), System.Drawing.Image)
        Me.ButtonSettingConnected.ImageActive = Nothing
        Me.ButtonSettingConnected.Location = New System.Drawing.Point(258, 11)
        Me.ButtonSettingConnected.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSettingConnected.Name = "ButtonSettingConnected"
        Me.ButtonSettingConnected.Size = New System.Drawing.Size(42, 34)
        Me.ButtonSettingConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonSettingConnected.TabIndex = 7
        Me.ButtonSettingConnected.TabStop = False
        Me.ButtonSettingConnected.Visible = False
        Me.ButtonSettingConnected.Zoom = 10
        '
        'ButtonSettingDisconnected
        '
        Me.ButtonSettingDisconnected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSettingDisconnected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSettingDisconnected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.ButtonSettingDisconnected, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonSettingDisconnected.Enabled = False
        Me.ButtonSettingDisconnected.Image = CType(resources.GetObject("ButtonSettingDisconnected.Image"), System.Drawing.Image)
        Me.ButtonSettingDisconnected.ImageActive = Nothing
        Me.ButtonSettingDisconnected.Location = New System.Drawing.Point(258, 11)
        Me.ButtonSettingDisconnected.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSettingDisconnected.Name = "ButtonSettingDisconnected"
        Me.ButtonSettingDisconnected.Size = New System.Drawing.Size(42, 34)
        Me.ButtonSettingDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonSettingDisconnected.TabIndex = 8
        Me.ButtonSettingDisconnected.TabStop = False
        Me.ButtonSettingDisconnected.Zoom = 10
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me.PanelLogin
        Me.BunifuDragControl.Vertical = True
        '
        'BunifuElipse
        '
        Me.BunifuElipse.ElipseRadius = 5
        Me.BunifuElipse.TargetControl = Me
        '
        'BackgroundCheckDBCon
        '
        Me.BackgroundCheckDBCon.WorkerReportsProgress = True
        '
        'FormAnimator
        '
        Me.FormAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.FormAnimator.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.FormAnimator.DefaultAnimation = Animation7
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 277)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.ButtonSettingConnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonSettingDisconnected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents buttonLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSettingConnected As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonSettingDisconnected As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackgroundCheckDBCon As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LabelConnecting As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents textUsername As TextBox
End Class
