<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientAddEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAddEditForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.textFirstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textLastname = New System.Windows.Forms.TextBox()
        Me.textMI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textAge = New System.Windows.Forms.TextBox()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textOccupation = New System.Windows.Forms.TextBox()
        Me.buttonSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dateBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textHouseNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textStreet = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textCity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textContactNumber = New System.Windows.Forms.TextBox()
        Me.comboSuffix = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.PanelHeader.Size = New System.Drawing.Size(661, 46)
        Me.PanelHeader.TabIndex = 19
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
        Me.ButtonClose.Location = New System.Drawing.Point(610, 10)
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
        'textFirstname
        '
        Me.textFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textFirstname.Location = New System.Drawing.Point(12, 80)
        Me.textFirstname.Name = "textFirstname"
        Me.textFirstname.Size = New System.Drawing.Size(208, 23)
        Me.textFirstname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "*Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "*Lastname"
        '
        'textLastname
        '
        Me.textLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textLastname.Location = New System.Drawing.Point(226, 80)
        Me.textLastname.Name = "textLastname"
        Me.textLastname.Size = New System.Drawing.Size(208, 23)
        Me.textLastname.TabIndex = 1
        '
        'textMI
        '
        Me.textMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textMI.Location = New System.Drawing.Point(440, 80)
        Me.textMI.Name = "textMI"
        Me.textMI.Size = New System.Drawing.Size(132, 23)
        Me.textMI.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Middle Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "*Age"
        '
        'textAge
        '
        Me.textAge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textAge.Location = New System.Drawing.Point(153, 170)
        Me.textAge.Name = "textAge"
        Me.textAge.ReadOnly = True
        Me.textAge.Size = New System.Drawing.Size(67, 23)
        Me.textAge.TabIndex = 100
        '
        'comboGender
        '
        Me.comboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboGender.Location = New System.Drawing.Point(226, 170)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(208, 23)
        Me.comboGender.TabIndex = 7
        Me.comboGender.Tag = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "*Sex"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Occupation"
        '
        'textOccupation
        '
        Me.textOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textOccupation.Location = New System.Drawing.Point(12, 260)
        Me.textOccupation.Multiline = True
        Me.textOccupation.Name = "textOccupation"
        Me.textOccupation.Size = New System.Drawing.Size(422, 41)
        Me.textOccupation.TabIndex = 10
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
        Me.buttonSave.Location = New System.Drawing.Point(564, 303)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.buttonSave.OnHoverTextColor = System.Drawing.Color.White
        Me.buttonSave.selected = False
        Me.buttonSave.Size = New System.Drawing.Size(85, 33)
        Me.buttonSave.TabIndex = 36
        Me.buttonSave.Text = "  Save"
        Me.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSave.Textcolor = System.Drawing.Color.White
        Me.buttonSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dateBirthdate
        '
        Me.dateBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dateBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBirthdate.Location = New System.Drawing.Point(12, 170)
        Me.dateBirthdate.Name = "dateBirthdate"
        Me.dateBirthdate.Size = New System.Drawing.Size(135, 23)
        Me.dateBirthdate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "*Birth Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "*House Number"
        '
        'textHouseNumber
        '
        Me.textHouseNumber.BackColor = System.Drawing.Color.White
        Me.textHouseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textHouseNumber.Location = New System.Drawing.Point(12, 125)
        Me.textHouseNumber.Name = "textHouseNumber"
        Me.textHouseNumber.Size = New System.Drawing.Size(101, 23)
        Me.textHouseNumber.TabIndex = 4
        Me.textHouseNumber.Tag = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "*Street/Building Name/Municipality"
        '
        'textStreet
        '
        Me.textStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textStreet.Location = New System.Drawing.Point(119, 125)
        Me.textStreet.Name = "textStreet"
        Me.textStreet.Size = New System.Drawing.Size(315, 23)
        Me.textStreet.TabIndex = 5
        Me.textStreet.Tag = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(437, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Tag = "*"
        Me.Label10.Text = "*Province"
        '
        'textCity
        '
        Me.textCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textCity.Location = New System.Drawing.Point(440, 125)
        Me.textCity.Name = "textCity"
        Me.textCity.Size = New System.Drawing.Size(208, 23)
        Me.textCity.TabIndex = 6
        Me.textCity.Tag = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "*Civil Status"
        '
        'comboCivilStatus
        '
        Me.comboCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCivilStatus.FormattingEnabled = True
        Me.comboCivilStatus.Items.AddRange(New Object() {"Single", "Maried", "Widowed", "Separated"})
        Me.comboCivilStatus.Location = New System.Drawing.Point(12, 215)
        Me.comboCivilStatus.Name = "comboCivilStatus"
        Me.comboCivilStatus.Size = New System.Drawing.Size(208, 23)
        Me.comboCivilStatus.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(223, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "*Contact Number"
        '
        'textContactNumber
        '
        Me.textContactNumber.BackColor = System.Drawing.Color.White
        Me.textContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.textContactNumber.Location = New System.Drawing.Point(226, 215)
        Me.textContactNumber.Name = "textContactNumber"
        Me.textContactNumber.Size = New System.Drawing.Size(208, 23)
        Me.textContactNumber.TabIndex = 9
        Me.textContactNumber.Tag = "*"
        '
        'comboSuffix
        '
        Me.comboSuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSuffix.FormattingEnabled = True
        Me.comboSuffix.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "JR", "SR"})
        Me.comboSuffix.Location = New System.Drawing.Point(578, 80)
        Me.comboSuffix.Name = "comboSuffix"
        Me.comboSuffix.Size = New System.Drawing.Size(70, 23)
        Me.comboSuffix.TabIndex = 3
        Me.comboSuffix.Tag = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(575, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Suffix"
        '
        'PatientAddEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(661, 348)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.comboSuffix)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.textContactNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.comboCivilStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.textCity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textStreet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.textHouseNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dateBirthdate)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textOccupation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textMI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textFirstname)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientAddEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
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
    Friend WithEvents textFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textMI As TextBox
    Friend WithEvents textOccupation As TextBox
    Friend WithEvents buttonSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dateBirthdate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents textHouseNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents textContactNumber As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents comboCivilStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textStreet As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents comboSuffix As ComboBox
End Class
