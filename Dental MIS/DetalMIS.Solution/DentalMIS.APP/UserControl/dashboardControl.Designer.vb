<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
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
        Me.components = New System.ComponentModel.Container()
        Dim CalendarHighlightRange1 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange2 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange3 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange4 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange5 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.calendarSchedule = New System.Windows.Forms.Calendar.Calendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountToPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.procedureDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-3, 63)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(820, 35)
        Me.BunifuSeparator1.TabIndex = 3
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
        Me.Label1.Size = New System.Drawing.Size(175, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dashboard"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.calendarSchedule)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 553)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduled Patient's For Today"
        '
        'calendarSchedule
        '
        Me.calendarSchedule.AllowItemEdit = False
        Me.calendarSchedule.AllowItemResize = False
        Me.calendarSchedule.AllowNew = False
        Me.calendarSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calendarSchedule.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CalendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday
        CalendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday
        CalendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday
        CalendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday
        CalendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday
        CalendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00")
        Me.calendarSchedule.HighlightRanges = New System.Windows.Forms.Calendar.CalendarHighlightRange() {CalendarHighlightRange1, CalendarHighlightRange2, CalendarHighlightRange3, CalendarHighlightRange4, CalendarHighlightRange5}
        Me.calendarSchedule.Location = New System.Drawing.Point(3, 22)
        Me.calendarSchedule.Name = "calendarSchedule"
        Me.calendarSchedule.Size = New System.Drawing.Size(336, 528)
        Me.calendarSchedule.TabIndex = 10
        Me.calendarSchedule.Text = "Calendar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGrid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(357, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 553)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient's With Outstanding Balance"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fullName, Me.procedure, Me.amountToPay, Me.amountPaid, Me.balance, Me.procedureDate})
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.Location = New System.Drawing.Point(3, 22)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(445, 528)
        Me.DataGrid.TabIndex = 47
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'fullName
        '
        Me.fullName.HeaderText = "Fullname"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'procedure
        '
        Me.procedure.HeaderText = "Procedure"
        Me.procedure.Name = "procedure"
        Me.procedure.ReadOnly = True
        '
        'amountToPay
        '
        Me.amountToPay.HeaderText = "Amount To Pay"
        Me.amountToPay.Name = "amountToPay"
        Me.amountToPay.ReadOnly = True
        '
        'amountPaid
        '
        Me.amountPaid.HeaderText = "Amount Paid"
        Me.amountPaid.Name = "amountPaid"
        Me.amountPaid.ReadOnly = True
        '
        'balance
        '
        Me.balance.HeaderText = "Balance"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        '
        'procedureDate
        '
        Me.procedureDate.HeaderText = "Procedure Date"
        Me.procedureDate.Name = "procedureDate"
        Me.procedureDate.ReadOnly = True
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents calendarSchedule As Calendar.Calendar
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents procedure As DataGridViewTextBoxColumn
    Friend WithEvents amountToPay As DataGridViewTextBoxColumn
    Friend WithEvents amountPaid As DataGridViewTextBoxColumn
    Friend WithEvents balance As DataGridViewTextBoxColumn
    Friend WithEvents procedureDate As DataGridViewTextBoxColumn
End Class
