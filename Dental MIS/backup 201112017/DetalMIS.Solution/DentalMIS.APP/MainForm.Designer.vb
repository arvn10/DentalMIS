<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.buttonLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonConfiguration = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonPatient = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelMenu = New System.Windows.Forms.Label()
        Me.ButtonMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelHeader.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        CType(Me.ButtonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.HeaderLabel)
        Me.PanelHeader.Controls.Add(Me.BunifuImageButton1)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Controls.Add(Me.ButtonClose)
        Me.PanelAnimator.SetDecoration(Me.PanelHeader, BunifuAnimatorNS.DecorationType.None)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(182, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(996, 46)
        Me.PanelHeader.TabIndex = 3
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.PanelAnimator.SetDecoration(Me.HeaderLabel, BunifuAnimatorNS.DecorationType.None)
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(49, 10)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(276, 29)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "OLAES DENTAL CLINIC"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(899, 7)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(42, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ButtonClose, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(945, 7)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 34)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me.PanelHeader
        Me.BunifuDragControl.Vertical = True
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.buttonLogout)
        Me.PanelSideMenu.Controls.Add(Me.ButtonConfiguration)
        Me.PanelSideMenu.Controls.Add(Me.ButtonPatient)
        Me.PanelSideMenu.Controls.Add(Me.LabelMenu)
        Me.PanelSideMenu.Controls.Add(Me.ButtonMenu)
        Me.PanelSideMenu.Controls.Add(Me.ButtonDashboard)
        Me.PanelAnimator.SetDecoration(Me.PanelSideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(182, 706)
        Me.PanelSideMenu.TabIndex = 4
        '
        'buttonLogout
        '
        Me.buttonLogout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonLogout.BorderRadius = 0
        Me.buttonLogout.ButtonText = "     Logout"
        Me.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.buttonLogout, BunifuAnimatorNS.DecorationType.None)
        Me.buttonLogout.DisabledColor = System.Drawing.Color.Gray
        Me.buttonLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonLogout.Iconimage = CType(resources.GetObject("buttonLogout.Iconimage"), System.Drawing.Image)
        Me.buttonLogout.Iconimage_right = Nothing
        Me.buttonLogout.Iconimage_right_Selected = Nothing
        Me.buttonLogout.Iconimage_Selected = Nothing
        Me.buttonLogout.IconMarginLeft = 0
        Me.buttonLogout.IconMarginRight = 0
        Me.buttonLogout.IconRightVisible = True
        Me.buttonLogout.IconRightZoom = 0R
        Me.buttonLogout.IconVisible = True
        Me.buttonLogout.IconZoom = 70.0R
        Me.buttonLogout.IsTab = False
        Me.buttonLogout.Location = New System.Drawing.Point(0, 645)
        Me.buttonLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonLogout.Name = "buttonLogout"
        Me.buttonLogout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonLogout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonLogout.selected = False
        Me.buttonLogout.Size = New System.Drawing.Size(182, 48)
        Me.buttonLogout.TabIndex = 8
        Me.buttonLogout.Text = "     Logout"
        Me.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonLogout.Textcolor = System.Drawing.Color.White
        Me.buttonLogout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonConfiguration
        '
        Me.ButtonConfiguration.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonConfiguration.BorderRadius = 0
        Me.ButtonConfiguration.ButtonText = "     Configuration"
        Me.ButtonConfiguration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ButtonConfiguration, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonConfiguration.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonConfiguration.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonConfiguration.Iconimage = CType(resources.GetObject("ButtonConfiguration.Iconimage"), System.Drawing.Image)
        Me.ButtonConfiguration.Iconimage_right = Nothing
        Me.ButtonConfiguration.Iconimage_right_Selected = Nothing
        Me.ButtonConfiguration.Iconimage_Selected = Nothing
        Me.ButtonConfiguration.IconMarginLeft = 0
        Me.ButtonConfiguration.IconMarginRight = 0
        Me.ButtonConfiguration.IconRightVisible = True
        Me.ButtonConfiguration.IconRightZoom = 0R
        Me.ButtonConfiguration.IconVisible = True
        Me.ButtonConfiguration.IconZoom = 70.0R
        Me.ButtonConfiguration.IsTab = False
        Me.ButtonConfiguration.Location = New System.Drawing.Point(0, 167)
        Me.ButtonConfiguration.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonConfiguration.Name = "ButtonConfiguration"
        Me.ButtonConfiguration.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonConfiguration.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonConfiguration.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonConfiguration.selected = False
        Me.ButtonConfiguration.Size = New System.Drawing.Size(182, 48)
        Me.ButtonConfiguration.TabIndex = 7
        Me.ButtonConfiguration.Text = "     Configuration"
        Me.ButtonConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConfiguration.Textcolor = System.Drawing.Color.White
        Me.ButtonConfiguration.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonPatient
        '
        Me.ButtonPatient.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPatient.BorderRadius = 0
        Me.ButtonPatient.ButtonText = "     Patient"
        Me.ButtonPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ButtonPatient, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonPatient.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonPatient.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonPatient.Iconimage = CType(resources.GetObject("ButtonPatient.Iconimage"), System.Drawing.Image)
        Me.ButtonPatient.Iconimage_right = Nothing
        Me.ButtonPatient.Iconimage_right_Selected = Nothing
        Me.ButtonPatient.Iconimage_Selected = Nothing
        Me.ButtonPatient.IconMarginLeft = 0
        Me.ButtonPatient.IconMarginRight = 0
        Me.ButtonPatient.IconRightVisible = True
        Me.ButtonPatient.IconRightZoom = 0R
        Me.ButtonPatient.IconVisible = True
        Me.ButtonPatient.IconZoom = 70.0R
        Me.ButtonPatient.IsTab = False
        Me.ButtonPatient.Location = New System.Drawing.Point(0, 113)
        Me.ButtonPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPatient.Name = "ButtonPatient"
        Me.ButtonPatient.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonPatient.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonPatient.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonPatient.selected = False
        Me.ButtonPatient.Size = New System.Drawing.Size(182, 48)
        Me.ButtonPatient.TabIndex = 5
        Me.ButtonPatient.Text = "     Patient"
        Me.ButtonPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPatient.Textcolor = System.Drawing.Color.White
        Me.ButtonPatient.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelMenu
        '
        Me.LabelMenu.AutoSize = True
        Me.PanelAnimator.SetDecoration(Me.LabelMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LabelMenu.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMenu.ForeColor = System.Drawing.Color.White
        Me.LabelMenu.Location = New System.Drawing.Point(9, 13)
        Me.LabelMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMenu.Name = "LabelMenu"
        Me.LabelMenu.Size = New System.Drawing.Size(109, 25)
        Me.LabelMenu.TabIndex = 4
        Me.LabelMenu.Text = "Main Menu"
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMenu.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ButtonMenu, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMenu.Image = CType(resources.GetObject("ButtonMenu.Image"), System.Drawing.Image)
        Me.ButtonMenu.ImageActive = Nothing
        Me.ButtonMenu.Location = New System.Drawing.Point(129, 5)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(44, 36)
        Me.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonMenu.TabIndex = 3
        Me.ButtonMenu.TabStop = False
        Me.ButtonMenu.Zoom = 10
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDashboard.BorderRadius = 0
        Me.ButtonDashboard.ButtonText = "     Dashboard"
        Me.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ButtonDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonDashboard.Iconimage = CType(resources.GetObject("ButtonDashboard.Iconimage"), System.Drawing.Image)
        Me.ButtonDashboard.Iconimage_right = Nothing
        Me.ButtonDashboard.Iconimage_right_Selected = Nothing
        Me.ButtonDashboard.Iconimage_Selected = Nothing
        Me.ButtonDashboard.IconMarginLeft = 0
        Me.ButtonDashboard.IconMarginRight = 0
        Me.ButtonDashboard.IconRightVisible = True
        Me.ButtonDashboard.IconRightZoom = 0R
        Me.ButtonDashboard.IconVisible = True
        Me.ButtonDashboard.IconZoom = 70.0R
        Me.ButtonDashboard.IsTab = False
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 58)
        Me.ButtonDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonDashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonDashboard.selected = True
        Me.ButtonDashboard.Size = New System.Drawing.Size(182, 48)
        Me.ButtonDashboard.TabIndex = 6
        Me.ButtonDashboard.Text = "     Dashboard"
        Me.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Textcolor = System.Drawing.Color.White
        Me.ButtonDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse
        '
        Me.BunifuElipse.ElipseRadius = 5
        Me.BunifuElipse.TargetControl = Me
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.PanelAnimator.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0!
        Animation9.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation9
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.Gray
        Me.PanelAnimator.SetDecoration(Me.PanelMain, BunifuAnimatorNS.DecorationType.None)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(182, 46)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(996, 660)
        Me.PanelMain.TabIndex = 8
        Me.PanelMain.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1178, 706)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MainForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelSideMenu.PerformLayout()
        CType(Me.ButtonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents buttonLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonConfiguration As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonPatient As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelMenu As Label
    Friend WithEvents ButtonMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelMain As Panel
End Class
