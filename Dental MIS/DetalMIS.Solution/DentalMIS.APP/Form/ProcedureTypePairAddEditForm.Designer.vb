<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcedureTypePairAddEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureTypePairAddEditForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboProcedureType = New System.Windows.Forms.ComboBox()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboVisibilityType = New System.Windows.Forms.ComboBox()
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
        Me.PanelHeader.Size = New System.Drawing.Size(416, 46)
        Me.PanelHeader.TabIndex = 3
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(5, 12)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(207, 23)
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
        Me.ButtonClose.Location = New System.Drawing.Point(365, 10)
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
        Me.Label7.Location = New System.Drawing.Point(9, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "*Procedure"
        '
        'comboProcedureType
        '
        Me.comboProcedureType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProcedureType.FormattingEnabled = True
        Me.comboProcedureType.Location = New System.Drawing.Point(12, 67)
        Me.comboProcedureType.Name = "comboProcedureType"
        Me.comboProcedureType.Size = New System.Drawing.Size(392, 23)
        Me.comboProcedureType.TabIndex = 0
        Me.comboProcedureType.Tag = "*"
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
        Me.buttonSave.Location = New System.Drawing.Point(319, 186)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 3
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "*Status"
        Me.Label1.Visible = False
        '
        'comboStatus
        '
        Me.comboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.comboStatus.Location = New System.Drawing.Point(12, 157)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(392, 23)
        Me.comboStatus.TabIndex = 2
        Me.comboStatus.Tag = "*"
        Me.comboStatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "*Procedure Type Visibility"
        '
        'comboVisibilityType
        '
        Me.comboVisibilityType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboVisibilityType.FormattingEnabled = True
        Me.comboVisibilityType.Items.AddRange(New Object() {"Show", "Hide"})
        Me.comboVisibilityType.Location = New System.Drawing.Point(12, 112)
        Me.comboVisibilityType.Name = "comboVisibilityType"
        Me.comboVisibilityType.Size = New System.Drawing.Size(392, 23)
        Me.comboVisibilityType.TabIndex = 1
        Me.comboVisibilityType.Tag = "*"
        '
        'ProcedureTypePairAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(416, 226)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboVisibilityType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboProcedureType)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcedureTypePairAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedure Type"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents comboProcedureType As ComboBox
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboVisibilityType As ComboBox
End Class
