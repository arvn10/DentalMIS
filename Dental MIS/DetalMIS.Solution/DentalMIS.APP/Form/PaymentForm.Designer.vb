<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.PanelHeader.Size = New System.Drawing.Size(540, 46)
        Me.PanelHeader.TabIndex = 23
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
        Me.ButtonClose.Location = New System.Drawing.Point(489, 10)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(42, 26)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 403)
        Me.Panel1.TabIndex = 24
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
End Class
