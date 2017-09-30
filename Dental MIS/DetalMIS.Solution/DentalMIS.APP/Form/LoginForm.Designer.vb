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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.LabelConnecting = New System.Windows.Forms.Label()
        Me.ButtonSettingDisconnected = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonSettingConnected = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.textPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelDatabase = New System.Windows.Forms.Panel()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.textDbPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textDbUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textDatabase = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textServer = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BackgroundCheckDBCon = New System.ComponentModel.BackgroundWorker()
        Me.FormAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelLogin.SuspendLayout()
        CType(Me.ButtonSettingDisconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonSettingConnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PanelLogin.Controls.Add(Me.LabelConnecting)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.ButtonClose)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.buttonLogin)
        Me.PanelLogin.Controls.Add(Me.textPassword)
        Me.PanelLogin.Controls.Add(Me.textUsername)
        Me.PanelLogin.Controls.Add(Me.ButtonSettingDisconnected)
        Me.PanelLogin.Controls.Add(Me.ButtonSettingConnected)
        Me.FormAnimator.SetDecoration(Me.PanelLogin, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLogin.ForeColor = System.Drawing.Color.White
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(471, 527)
        Me.PanelLogin.TabIndex = 0
        '
        'LabelConnecting
        '
        Me.LabelConnecting.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.LabelConnecting, BunifuAnimatorNS.DecorationType.None)
        Me.LabelConnecting.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelConnecting.Location = New System.Drawing.Point(12, 469)
        Me.LabelConnecting.Name = "LabelConnecting"
        Me.LabelConnecting.Size = New System.Drawing.Size(270, 23)
        Me.LabelConnecting.TabIndex = 9
        Me.LabelConnecting.Text = "Connecting to Database..."
        '
        'ButtonSettingDisconnected
        '
        Me.ButtonSettingDisconnected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSettingDisconnected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSettingDisconnected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.ButtonSettingDisconnected, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonSettingDisconnected.Enabled = False
        Me.ButtonSettingDisconnected.Image = CType(resources.GetObject("ButtonSettingDisconnected.Image"), System.Drawing.Image)
        Me.ButtonSettingDisconnected.ImageActive = Nothing
        Me.ButtonSettingDisconnected.Location = New System.Drawing.Point(339, 12)
        Me.ButtonSettingDisconnected.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSettingDisconnected.Name = "ButtonSettingDisconnected"
        Me.ButtonSettingDisconnected.Size = New System.Drawing.Size(56, 42)
        Me.ButtonSettingDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonSettingDisconnected.TabIndex = 8
        Me.ButtonSettingDisconnected.TabStop = False
        Me.ButtonSettingDisconnected.Zoom = 10
        '
        'ButtonSettingConnected
        '
        Me.ButtonSettingConnected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSettingConnected.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSettingConnected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.ButtonSettingConnected, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonSettingConnected.Image = CType(resources.GetObject("ButtonSettingConnected.Image"), System.Drawing.Image)
        Me.ButtonSettingConnected.ImageActive = Nothing
        Me.ButtonSettingConnected.Location = New System.Drawing.Point(339, 12)
        Me.ButtonSettingConnected.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSettingConnected.Name = "ButtonSettingConnected"
        Me.ButtonSettingConnected.Size = New System.Drawing.Size(56, 42)
        Me.ButtonSettingConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonSettingConnected.TabIndex = 7
        Me.ButtonSettingConnected.TabStop = False
        Me.ButtonSettingConnected.Visible = False
        Me.ButtonSettingConnected.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "OLAES DENTAL CLINIC"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.ButtonClose, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(401, 12)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(56, 42)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USERNAME"
        '
        'buttonLogin
        '
        Me.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
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
        Me.buttonLogin.Location = New System.Drawing.Point(13, 388)
        Me.buttonLogin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonLogin.selected = False
        Me.buttonLogin.Size = New System.Drawing.Size(444, 59)
        Me.buttonLogin.TabIndex = 2
        Me.buttonLogin.Text = "LOGIN"
        Me.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonLogin.Textcolor = System.Drawing.Color.White
        Me.buttonLogin.TextFont = New System.Drawing.Font("Century Gothic", 12.0!)
        '
        'textPassword
        '
        Me.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textPassword, BunifuAnimatorNS.DecorationType.None)
        Me.textPassword.Enabled = False
        Me.textPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textPassword.ForeColor = System.Drawing.Color.White
        Me.textPassword.HintForeColor = System.Drawing.Color.White
        Me.textPassword.HintText = ""
        Me.textPassword.isPassword = True
        Me.textPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.textPassword.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.textPassword.LineThickness = 3
        Me.textPassword.Location = New System.Drawing.Point(13, 295)
        Me.textPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(444, 37)
        Me.textPassword.TabIndex = 1
        Me.textPassword.Text = "password"
        Me.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textUsername
        '
        Me.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textUsername, BunifuAnimatorNS.DecorationType.None)
        Me.textUsername.Enabled = False
        Me.textUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textUsername.ForeColor = System.Drawing.Color.White
        Me.textUsername.HintForeColor = System.Drawing.Color.White
        Me.textUsername.HintText = ""
        Me.textUsername.isPassword = False
        Me.textUsername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.textUsername.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.textUsername.LineThickness = 3
        Me.textUsername.Location = New System.Drawing.Point(13, 193)
        Me.textUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(444, 37)
        Me.textUsername.TabIndex = 0
        Me.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'PanelDatabase
        '
        Me.PanelDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.PanelDatabase.Controls.Add(Me.buttonSave)
        Me.PanelDatabase.Controls.Add(Me.textDbPassword)
        Me.PanelDatabase.Controls.Add(Me.Label7)
        Me.PanelDatabase.Controls.Add(Me.textDbUsername)
        Me.PanelDatabase.Controls.Add(Me.Label6)
        Me.PanelDatabase.Controls.Add(Me.textDatabase)
        Me.PanelDatabase.Controls.Add(Me.Label4)
        Me.PanelDatabase.Controls.Add(Me.Label5)
        Me.PanelDatabase.Controls.Add(Me.textServer)
        Me.FormAnimator.SetDecoration(Me.PanelDatabase, BunifuAnimatorNS.DecorationType.None)
        Me.PanelDatabase.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDatabase.ForeColor = System.Drawing.Color.White
        Me.PanelDatabase.Location = New System.Drawing.Point(140, 0)
        Me.PanelDatabase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDatabase.Name = "PanelDatabase"
        Me.PanelDatabase.Size = New System.Drawing.Size(332, 527)
        Me.PanelDatabase.TabIndex = 2
        '
        'buttonSave
        '
        Me.buttonSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonSave.BorderRadius = 0
        Me.buttonSave.ButtonText = "SAVE"
        Me.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormAnimator.SetDecoration(Me.buttonSave, BunifuAnimatorNS.DecorationType.None)
        Me.buttonSave.DisabledColor = System.Drawing.Color.Gray
        Me.buttonSave.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonSave.Iconimage = Nothing
        Me.buttonSave.Iconimage_right = Nothing
        Me.buttonSave.Iconimage_right_Selected = Nothing
        Me.buttonSave.Iconimage_Selected = Nothing
        Me.buttonSave.IconMarginLeft = 0
        Me.buttonSave.IconMarginRight = 0
        Me.buttonSave.IconRightVisible = True
        Me.buttonSave.IconRightZoom = 0R
        Me.buttonSave.IconVisible = True
        Me.buttonSave.IconZoom = 90.0R
        Me.buttonSave.IsTab = False
        Me.buttonSave.Location = New System.Drawing.Point(8, 377)
        Me.buttonSave.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(311, 59)
        Me.buttonSave.TabIndex = 15
        Me.buttonSave.Text = "SAVE"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Century Gothic", 12.0!)
        '
        'textDbPassword
        '
        Me.textDbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textDbPassword, BunifuAnimatorNS.DecorationType.None)
        Me.textDbPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textDbPassword.ForeColor = System.Drawing.Color.White
        Me.textDbPassword.HintForeColor = System.Drawing.Color.White
        Me.textDbPassword.HintText = ""
        Me.textDbPassword.isPassword = True
        Me.textDbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDbPassword.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textDbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDbPassword.LineThickness = 3
        Me.textDbPassword.Location = New System.Drawing.Point(8, 310)
        Me.textDbPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textDbPassword.Name = "textDbPassword"
        Me.textDbPassword.Size = New System.Drawing.Size(311, 37)
        Me.textDbPassword.TabIndex = 13
        Me.textDbPassword.Text = "root"
        Me.textDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(7, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "PASSWORD"
        '
        'textDbUsername
        '
        Me.textDbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textDbUsername, BunifuAnimatorNS.DecorationType.None)
        Me.textDbUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textDbUsername.ForeColor = System.Drawing.Color.White
        Me.textDbUsername.HintForeColor = System.Drawing.Color.White
        Me.textDbUsername.HintText = ""
        Me.textDbUsername.isPassword = False
        Me.textDbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDbUsername.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textDbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDbUsername.LineThickness = 3
        Me.textDbUsername.Location = New System.Drawing.Point(8, 220)
        Me.textDbUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textDbUsername.Name = "textDbUsername"
        Me.textDbUsername.Size = New System.Drawing.Size(311, 37)
        Me.textDbUsername.TabIndex = 11
        Me.textDbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(7, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "USERNAME"
        '
        'textDatabase
        '
        Me.textDatabase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textDatabase, BunifuAnimatorNS.DecorationType.None)
        Me.textDatabase.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textDatabase.ForeColor = System.Drawing.Color.White
        Me.textDatabase.HintForeColor = System.Drawing.Color.White
        Me.textDatabase.HintText = ""
        Me.textDatabase.isPassword = False
        Me.textDatabase.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDatabase.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textDatabase.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textDatabase.LineThickness = 3
        Me.textDatabase.Location = New System.Drawing.Point(8, 130)
        Me.textDatabase.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textDatabase.Name = "textDatabase"
        Me.textDatabase.Size = New System.Drawing.Size(311, 37)
        Me.textDatabase.TabIndex = 9
        Me.textDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DATABASE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.FormAnimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SERVER"
        '
        'textServer
        '
        Me.textServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormAnimator.SetDecoration(Me.textServer, BunifuAnimatorNS.DecorationType.None)
        Me.textServer.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.textServer.ForeColor = System.Drawing.Color.White
        Me.textServer.HintForeColor = System.Drawing.Color.White
        Me.textServer.HintText = ""
        Me.textServer.isPassword = False
        Me.textServer.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textServer.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.textServer.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.textServer.LineThickness = 3
        Me.textServer.Location = New System.Drawing.Point(8, 48)
        Me.textServer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textServer.Name = "textServer"
        Me.textServer.Size = New System.Drawing.Size(311, 37)
        Me.textServer.TabIndex = 5
        Me.textServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BackgroundCheckDBCon
        '
        '
        'FormAnimator
        '
        Me.FormAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.FormAnimator.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.FormAnimator.DefaultAnimation = Animation3
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 527)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelDatabase)
        Me.FormAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.ButtonSettingDisconnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonSettingConnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatabase.ResumeLayout(False)
        Me.PanelDatabase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelDatabase As Panel
    Friend WithEvents textUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents buttonLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents textPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSettingConnected As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonSettingDisconnected As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackgroundCheckDBCon As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LabelConnecting As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textServer As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textDbPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents textDbUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents textDatabase As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
End Class
