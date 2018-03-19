Imports System.Windows.Forms.Calendar
Imports DentalMIS.MODEL
Imports DentalMIS.BLL
Public Class ScheduleControl
    Public calendarItems As New List(Of CalendarItem)()
    Private scheduleSvc As IScheduleService
    Public schedules As New List(Of Schedule)
    Public Sub GetSchedules()
        calendarItems.Clear()
        If schedules.Count = 0 Then
            scheduleSvc = New ScheduleService()
            schedules = scheduleSvc.ScheduleSelect(DateTimePickerDate.Value.Date)
        End If

        For Each schedule As Schedule In schedules
            If Not schedule.IsDeleted Then
                Dim calendar As New CalendarItem(calendarSchedule, schedule.StartTime, schedule.EndTime, schedule.Title)
                calendar.ApplyColor(Color.FromArgb(schedule.BackgroundColor))
                calendar.ForeColor = Color.Black
                calendar.Tag = $"{schedule.Index},{schedule.ID},{schedule.Description},{schedule.CreatedBy},{schedule.UpdatedBy}"
                calendarItems.Add(calendar)
            End If
        Next

        LoadSchedule()
    End Sub

    Public Sub LoadSchedule()
        calendarSchedule.Items.Clear()

        For Each calendar As CalendarItem In calendarItems
            If calendarSchedule.ViewIntersects(calendar) Then
                calendarSchedule.Items.Add(calendar)
            End If
        Next
    End Sub
    Private Sub ToolStripButtonSave_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSave.Click
        Dim msg = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            scheduleSvc = New ScheduleService()
            Dim processedItem As Integer = 0
            For Each item As Schedule In schedules
                If item.ActionType = "Insert" Then
                    If scheduleSvc.ScheduleCreate(item) > 0 Then
                        processedItem += 1
                    End If
                ElseIf item.ActionType = "Update" Then

                    If scheduleSvc.ScheduleEdit(item) > 0 Then
                        processedItem += 1
                    End If
                End If
            Next

            If processedItem > 0 Then
                MessageBox.Show("Calendar Saved!", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                schedules.Clear()
                GetSchedules()
            End If
        End If
    End Sub

    Private Sub ScheduleControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        calendarSchedule.ViewStart = DateTimePickerDate.Value
        calendarSchedule.ViewEnd = DateTimePickerDate.Value

        If DateTimePickerDate.Value.Date < DateTime.Now.Date Then
            ToolStripButtonNew.Enabled = False
        ElseIf DateTime.Now.DayOfWeek = DayOfWeek.Sunday Then
            ToolStripButtonNew.Enabled = False
        Else
            ToolStripButtonNew.Enabled = True
            ToolStripButtonSave.Enabled = True
        End If
        GetSchedules()
    End Sub

    Private Sub DateTimePickerDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDate.ValueChanged
        If DateTimePickerDate.Value.Date < DateTime.Now.Date Then
            ToolStripButtonNew.Enabled = False
        ElseIf DateTime.Now.DayOfWeek = DayOfWeek.Sunday Then
            ToolStripButtonNew.Enabled = False
        Else
            ToolStripButtonNew.Enabled = True
            ToolStripButtonSave.Enabled = True
        End If
        calendarSchedule.SetViewRange(DateTimePickerDate.Value, DateTimePickerDate.Value)
        schedules.Clear()
        GetSchedules()
    End Sub

    Private Sub calendarSchedule_ItemDeleting(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemDeleting
        Dim msg = MessageBox.Show("Delete Schedule?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            Dim parts As String() = IIf(e.Item.Tag <> String.Empty, e.Item.Tag.ToString().Split(","), "")
            Dim tempSchedule As Schedule = schedules.Where(Function(s) s.Index = Convert.ToInt32(parts(0))).FirstOrDefault()
            Dim index As Integer = schedules.IndexOf(tempSchedule)
            tempSchedule.IsDeleted = True
            tempSchedule.ActionType = "Update"
            tempSchedule.UpdatedBy = MainForm.user.ID
            schedules(index) = tempSchedule
        End If
    End Sub

    Private Sub calendarSchedule_ItemCreating(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreating
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_LoadItems(sender As Object, e As CalendarLoadEventArgs) Handles calendarSchedule.LoadItems
        LoadSchedule()
    End Sub

    Private Sub calendarSchedule_ItemDoubleClick(sender As Object, e As CalendarItemEventArgs) Handles calendarSchedule.ItemDoubleClick
        Try
            Dim schedule As New Schedule
            Dim parts As String() = IIf(e.Item.Tag <> String.Empty, e.Item.Tag.ToString().Split(","), "")
            Dim form As New ScheduleAddEditForm

            schedule.Index = Convert.ToInt32(parts(0))
            schedule.ID = Convert.ToInt64(parts(1))
            schedule.Title = e.Item.Text
            schedule.Description = parts(3)
            schedule.StartTime = e.Item.StartDate
            schedule.EndTime = e.Item.EndDate
            schedule.BackgroundColor = e.Item.BackgroundColor.ToArgb

            form.scheduleControl = Me
            form.schedule = schedule
            form.activeUser = MainForm.user.ID
            form.selectedDate = DateTimePickerDate.Value.Date
            form.HeaderLabel.Text = "Schedule - Edit"
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calendarSchedule_ItemMouseHover(sender As Object, e As CalendarItemEventArgs) Handles calendarSchedule.ItemMouseHover
        If e.Item.Text <> String.Empty Then
            Dim toolTipText As String
            Dim scheduleDetails As String() = IIf(e.Item.Tag <> String.Empty, e.Item.Tag.ToString().Split(", "), "")
            If scheduleDetails.Length > 0 Then
                toolTipText = "Title : " + e.Item.Text + vbNewLine +
                              "Description : " + scheduleDetails(2) + vbNewLine +
                              "Start Time : " + e.Item.StartDate.ToString("yyyy-MM-dd hh:mm:ss tt") + vbNewLine +
                              "End Time : " + e.Item.EndDate.ToString("yyyy-MM-dd hh:mm:ss tt")

                ToolTip1.Show(toolTipText, Me, Point.Add(Me.PointToClient(MousePosition), New Size(20, 20)))
                Timer1.Start()
            End If
        Else
            ToolTip1.Hide(Me)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Me.ToolTip1.Hide(Me)
    End Sub

    Private Sub calendarSchedule_ItemCreated(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreated
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemTextEditing(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemTextEditing
        e.Cancel = True
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
        On Error Resume Next
        Dim form As New ScheduleAddEditForm()
        form.scheduleControl = Me
        form.activeUser = MainForm.user.ID
        form.selectedDate = DateTimePickerDate.Value.Date
        form.HeaderLabel.Text = "Schedule - New"
        form.ShowDialog()
    End Sub
End Class
