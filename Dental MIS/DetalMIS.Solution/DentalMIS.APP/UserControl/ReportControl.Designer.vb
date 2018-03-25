<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportControl))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paid")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Not Paid")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schedule")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patient")
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ButtonSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dtPickerTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtPickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeViewConfig = New System.Windows.Forms.TreeView()
        Me.transactionReport1 = New DentalMIS.APP.TransactionReport()
        Me.scheduleReport1 = New DentalMIS.APP.ScheduleReport()
        Me.patientReport1 = New DentalMIS.APP.PatientReport()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
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
        Me.Label1.Size = New System.Drawing.Size(112, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Report"
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.CrystalReportViewer1)
        Me.PanelMain.Controls.Add(Me.ButtonSearch)
        Me.PanelMain.Controls.Add(Me.dtPickerTo)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.dtPickerFrom)
        Me.PanelMain.Controls.Add(Me.Label3)
        Me.PanelMain.Location = New System.Drawing.Point(194, 93)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(612, 565)
        Me.PanelMain.TabIndex = 9
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 39)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(610, 525)
        Me.CrystalReportViewer1.TabIndex = 58
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSearch.BorderRadius = 0
        Me.ButtonSearch.ButtonText = " Search"
        Me.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearch.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonSearch.Iconimage = CType(resources.GetObject("ButtonSearch.Iconimage"), System.Drawing.Image)
        Me.ButtonSearch.Iconimage_right = Nothing
        Me.ButtonSearch.Iconimage_right_Selected = Nothing
        Me.ButtonSearch.Iconimage_Selected = Nothing
        Me.ButtonSearch.IconMarginLeft = 0
        Me.ButtonSearch.IconMarginRight = 0
        Me.ButtonSearch.IconRightVisible = True
        Me.ButtonSearch.IconRightZoom = 0R
        Me.ButtonSearch.IconVisible = True
        Me.ButtonSearch.IconZoom = 50.0R
        Me.ButtonSearch.IsTab = False
        Me.ButtonSearch.Location = New System.Drawing.Point(331, 10)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ButtonSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonSearch.selected = False
        Me.ButtonSearch.Size = New System.Drawing.Size(92, 26)
        Me.ButtonSearch.TabIndex = 57
        Me.ButtonSearch.Text = " Search"
        Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearch.Textcolor = System.Drawing.Color.White
        Me.ButtonSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerTo.Location = New System.Drawing.Point(207, 13)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(118, 20)
        Me.dtPickerTo.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "To : "
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerFrom.Location = New System.Drawing.Point(48, 13)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(118, 20)
        Me.dtPickerFrom.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "From : "
        '
        'TreeViewConfig
        '
        Me.TreeViewConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewConfig.BackColor = System.Drawing.Color.White
        Me.TreeViewConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewConfig.Location = New System.Drawing.Point(12, 93)
        Me.TreeViewConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeViewConfig.Name = "TreeViewConfig"
        TreeNode1.Name = "All"
        TreeNode1.Text = "All"
        TreeNode2.Name = "paid"
        TreeNode2.Text = "Paid"
        TreeNode3.Name = "notPaid"
        TreeNode3.Text = "Not Paid"
        TreeNode4.Name = "Transaction"
        TreeNode4.Text = "Transaction"
        TreeNode5.Name = "schedule"
        TreeNode5.Text = "Schedule"
        TreeNode6.Name = "patient"
        TreeNode6.Text = "Patient"
        Me.TreeViewConfig.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.TreeViewConfig.Size = New System.Drawing.Size(178, 565)
        Me.TreeViewConfig.TabIndex = 8
        '
        'ReportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.TreeViewConfig)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents TreeViewConfig As TreeView
    Friend WithEvents ButtonSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtPickerTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtPickerFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents transactionReport1 As TransactionReport
    Friend WithEvents scheduleReport1 As ScheduleReport
    Friend WithEvents patientReport1 As PatientReport
End Class
