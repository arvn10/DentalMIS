<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackUpForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.buttonBrowse = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buttonStart = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textSavePath = New System.Windows.Forms.TextBox()
        Me.CircleProgressBar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.bwExport = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
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
        Me.PanelHeader.Size = New System.Drawing.Size(455, 46)
        Me.PanelHeader.TabIndex = 27
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(5, 12)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(177, 23)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "Backup Database"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.ImageActive = Nothing
        Me.ButtonClose.Location = New System.Drawing.Point(404, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'buttonBrowse
        '
        Me.buttonBrowse.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonBrowse.BorderRadius = 0
        Me.buttonBrowse.ButtonText = "Browse"
        Me.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonBrowse.DisabledColor = System.Drawing.Color.Gray
        Me.buttonBrowse.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonBrowse.Iconimage = CType(resources.GetObject("buttonBrowse.Iconimage"), System.Drawing.Image)
        Me.buttonBrowse.Iconimage_right = Nothing
        Me.buttonBrowse.Iconimage_right_Selected = Nothing
        Me.buttonBrowse.Iconimage_Selected = Nothing
        Me.buttonBrowse.IconMarginLeft = 0
        Me.buttonBrowse.IconMarginRight = 0
        Me.buttonBrowse.IconRightVisible = True
        Me.buttonBrowse.IconRightZoom = 0R
        Me.buttonBrowse.IconVisible = True
        Me.buttonBrowse.IconZoom = 50.0R
        Me.buttonBrowse.IsTab = False
        Me.buttonBrowse.Location = New System.Drawing.Point(240, 404)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonBrowse.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonBrowse.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonBrowse.selected = False
        Me.buttonBrowse.Size = New System.Drawing.Size(100, 33)
        Me.buttonBrowse.TabIndex = 50
        Me.buttonBrowse.Text = "Browse"
        Me.buttonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonBrowse.Textcolor = System.Drawing.Color.White
        Me.buttonBrowse.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buttonStart
        '
        Me.buttonStart.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonStart.BorderRadius = 0
        Me.buttonStart.ButtonText = "Start"
        Me.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonStart.DisabledColor = System.Drawing.Color.Gray
        Me.buttonStart.Iconcolor = System.Drawing.Color.Transparent
        Me.buttonStart.Iconimage = CType(resources.GetObject("buttonStart.Iconimage"), System.Drawing.Image)
        Me.buttonStart.Iconimage_right = Nothing
        Me.buttonStart.Iconimage_right_Selected = Nothing
        Me.buttonStart.Iconimage_Selected = Nothing
        Me.buttonStart.IconMarginLeft = 0
        Me.buttonStart.IconMarginRight = 0
        Me.buttonStart.IconRightVisible = True
        Me.buttonStart.IconRightZoom = 0R
        Me.buttonStart.IconVisible = True
        Me.buttonStart.IconZoom = 50.0R
        Me.buttonStart.IsTab = False
        Me.buttonStart.Location = New System.Drawing.Point(346, 404)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonStart.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonStart.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonStart.selected = False
        Me.buttonStart.Size = New System.Drawing.Size(100, 33)
        Me.buttonStart.TabIndex = 49
        Me.buttonStart.Text = "Start"
        Me.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonStart.Textcolor = System.Drawing.Color.White
        Me.buttonStart.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Save Backup File To:"
        '
        'textSavePath
        '
        Me.textSavePath.Location = New System.Drawing.Point(9, 293)
        Me.textSavePath.Multiline = True
        Me.textSavePath.Name = "textSavePath"
        Me.textSavePath.Size = New System.Drawing.Size(437, 105)
        Me.textSavePath.TabIndex = 47
        '
        'CircleProgressBar
        '
        Me.CircleProgressBar.animated = False
        Me.CircleProgressBar.animationIterval = 5
        Me.CircleProgressBar.animationSpeed = 300
        Me.CircleProgressBar.AutoSize = True
        Me.CircleProgressBar.BackColor = System.Drawing.Color.White
        Me.CircleProgressBar.BackgroundImage = CType(resources.GetObject("CircleProgressBar.BackgroundImage"), System.Drawing.Image)
        Me.CircleProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.CircleProgressBar.ForeColor = System.Drawing.Color.SeaGreen
        Me.CircleProgressBar.LabelVisible = True
        Me.CircleProgressBar.LineProgressThickness = 8
        Me.CircleProgressBar.LineThickness = 5
        Me.CircleProgressBar.Location = New System.Drawing.Point(119, 57)
        Me.CircleProgressBar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.CircleProgressBar.MaxValue = 100
        Me.CircleProgressBar.Name = "CircleProgressBar"
        Me.CircleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.CircleProgressBar.ProgressColor = System.Drawing.Color.SeaGreen
        Me.CircleProgressBar.Size = New System.Drawing.Size(224, 224)
        Me.CircleProgressBar.TabIndex = 46
        Me.CircleProgressBar.Value = 0
        '
        'bwExport
        '
        Me.bwExport.WorkerReportsProgress = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'BackUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 447)
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textSavePath)
        Me.Controls.Add(Me.CircleProgressBar)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BackUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Database"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents buttonBrowse As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents buttonStart As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents textSavePath As TextBox
    Friend WithEvents CircleProgressBar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents bwExport As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
