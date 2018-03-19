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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procedure Type")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audit Trail")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Backup")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Database", New System.Windows.Forms.TreeNode() {TreeNode4})
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
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 63)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(820, 35)
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
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Configuration"
        '
        'TreeViewConfig
        '
        Me.TreeViewConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewConfig.BackColor = System.Drawing.Color.White
        Me.TreeViewConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewConfig.Location = New System.Drawing.Point(14, 92)
        Me.TreeViewConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeViewConfig.Name = "TreeViewConfig"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "procedureType"
        TreeNode1.Text = "Procedure Type"
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "NodeUser"
        TreeNode2.Text = "User"
        TreeNode3.Name = "NodeAuditTrail"
        TreeNode3.Text = "Audit Trail"
        TreeNode4.ImageIndex = 5
        TreeNode4.Name = "databaseBackup"
        TreeNode4.Text = "Backup"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "database"
        TreeNode5.Text = "Database"
        Me.TreeViewConfig.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode5})
        Me.TreeViewConfig.Size = New System.Drawing.Size(178, 565)
        Me.TreeViewConfig.TabIndex = 6
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Location = New System.Drawing.Point(196, 92)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(612, 565)
        Me.PanelMain.TabIndex = 7
        '
        'ConfigurationControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.TreeViewConfig)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ConfigurationControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents TreeViewConfig As TreeView
    Friend WithEvents PanelMain As Panel
End Class
