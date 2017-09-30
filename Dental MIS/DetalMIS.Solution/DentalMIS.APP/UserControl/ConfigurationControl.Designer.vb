<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigurationControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procedure Type")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patient Marital Status")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Backup")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Database", New System.Windows.Forms.TreeNode() {TreeNode9})
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeViewConfig = New System.Windows.Forms.TreeView()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 77)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1094, 43)
        Me.BunifuSeparator1.TabIndex = 5
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Configuration"
        '
        'TreeViewConfig
        '
        Me.TreeViewConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewConfig.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TreeViewConfig.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TreeViewConfig.Location = New System.Drawing.Point(19, 113)
        Me.TreeViewConfig.Name = "TreeViewConfig"
        TreeNode6.ImageIndex = 1
        TreeNode6.Name = "procedureType"
        TreeNode6.Text = "Procedure Type"
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = "patientMaritalStatus"
        TreeNode7.Text = "Patient Marital Status"
        TreeNode8.ImageIndex = 3
        TreeNode8.Name = "NodeUser"
        TreeNode8.Text = "User"
        TreeNode9.ImageIndex = 5
        TreeNode9.Name = "databaseBackup"
        TreeNode9.Text = "Backup"
        TreeNode10.ImageIndex = 4
        TreeNode10.Name = "database"
        TreeNode10.Text = "Database"
        Me.TreeViewConfig.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode10})
        Me.TreeViewConfig.Size = New System.Drawing.Size(236, 695)
        Me.TreeViewConfig.TabIndex = 6
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Location = New System.Drawing.Point(261, 113)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(815, 695)
        Me.PanelMain.TabIndex = 7
        '
        'ConfigurationControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.TreeViewConfig)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfigurationControl"
        Me.Size = New System.Drawing.Size(1094, 826)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents TreeViewConfig As TreeView
    Friend WithEvents PanelMain As Panel
End Class
