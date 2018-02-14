<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpDatabaseControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackUpDatabaseControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCircleProgressbar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.textSavePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonStart = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buttonBrowse = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Backup Database"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 63)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(820, 35)
        Me.BunifuSeparator1.TabIndex = 9
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCircleProgressbar
        '
        Me.BunifuCircleProgressbar.animated = False
        Me.BunifuCircleProgressbar.animationIterval = 5
        Me.BunifuCircleProgressbar.animationSpeed = 300
        Me.BunifuCircleProgressbar.AutoSize = True
        Me.BunifuCircleProgressbar.BackColor = System.Drawing.Color.White
        Me.BunifuCircleProgressbar.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar.LabelVisible = True
        Me.BunifuCircleProgressbar.LineProgressThickness = 8
        Me.BunifuCircleProgressbar.LineThickness = 5
        Me.BunifuCircleProgressbar.Location = New System.Drawing.Point(116, 110)
        Me.BunifuCircleProgressbar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar.MaxValue = 100
        Me.BunifuCircleProgressbar.Name = "BunifuCircleProgressbar"
        Me.BunifuCircleProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar.Size = New System.Drawing.Size(224, 224)
        Me.BunifuCircleProgressbar.TabIndex = 11
        Me.BunifuCircleProgressbar.Value = 0
        '
        'textSavePath
        '
        Me.textSavePath.Location = New System.Drawing.Point(5, 362)
        Me.textSavePath.Multiline = True
        Me.textSavePath.Name = "textSavePath"
        Me.textSavePath.Size = New System.Drawing.Size(437, 149)
        Me.textSavePath.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Save Backup File To:"
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
        Me.buttonStart.Location = New System.Drawing.Point(342, 517)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonStart.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonStart.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonStart.selected = False
        Me.buttonStart.Size = New System.Drawing.Size(100, 33)
        Me.buttonStart.TabIndex = 44
        Me.buttonStart.Text = "Start"
        Me.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonStart.Textcolor = System.Drawing.Color.White
        Me.buttonStart.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.buttonBrowse.Location = New System.Drawing.Point(5, 517)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonBrowse.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonBrowse.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonBrowse.selected = False
        Me.buttonBrowse.Size = New System.Drawing.Size(100, 33)
        Me.buttonBrowse.TabIndex = 45
        Me.buttonBrowse.Text = "Browse"
        Me.buttonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonBrowse.Textcolor = System.Drawing.Color.White
        Me.buttonBrowse.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BackUpDatabaseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textSavePath)
        Me.Controls.Add(Me.BunifuCircleProgressbar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Name = "BackUpDatabaseControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCircleProgressbar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents textSavePath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonStart As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents buttonBrowse As Bunifu.Framework.UI.BunifuFlatButton
End Class
