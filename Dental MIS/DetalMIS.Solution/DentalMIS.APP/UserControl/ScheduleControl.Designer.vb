<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleControl))
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerDate = New System.Windows.Forms.DateTimePicker()
        Me.calendarSchedule = New System.Windows.Forms.Calendar.Calendar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(149, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Schedule"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerDate)
        Me.GroupBox1.Controls.Add(Me.calendarSchedule)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 567)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Date :"
        '
        'DateTimePickerDate
        '
        Me.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDate.Location = New System.Drawing.Point(48, 53)
        Me.DateTimePickerDate.Name = "DateTimePickerDate"
        Me.DateTimePickerDate.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePickerDate.TabIndex = 49
        '
        'calendarSchedule
        '
        Me.calendarSchedule.AllowItemEdit = False
        Me.calendarSchedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calendarSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.calendarSchedule.Location = New System.Drawing.Point(3, 79)
        Me.calendarSchedule.Name = "calendarSchedule"
        Me.calendarSchedule.Size = New System.Drawing.Size(814, 485)
        Me.calendarSchedule.TabIndex = 9
        Me.calendarSchedule.Text = "Calendar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(814, 25)
        Me.ToolStrip1.TabIndex = 48
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonSave
        '
        Me.ToolStripButtonSave.Image = CType(resources.GetObject("ToolStripButtonSave.Image"), System.Drawing.Image)
        Me.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        Me.ToolStripButtonSave.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButtonSave.Text = "Save"
        Me.ToolStripButtonSave.ToolTipText = "Save"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ScheduleControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ScheduleControl"
        Me.Size = New System.Drawing.Size(820, 671)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calendarSchedule As Calendar.Calendar
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerDate As DateTimePicker
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonSave As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
End Class
