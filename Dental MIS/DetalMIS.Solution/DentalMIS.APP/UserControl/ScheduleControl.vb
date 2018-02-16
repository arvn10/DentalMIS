Imports System.Windows.Forms.Calendar
Imports DentalMIS.MODEL
Imports DentalMIS.BLL
Public Class ScheduleControl
    Public calendarItems As New List(Of CalendarItem)()
    Private scheduleSvc As IScheduleService
    Public schedules As New List(Of Schedule)
    Public Sub GetSchedules()
        If schedules.Count = 0 Then
            scheduleSvc = New ScheduleService()
            schedules = scheduleSvc.ScheduleSelect(DateTimePickerDate.Value.Date)
        End If

        For Each schedule As Schedule In schedules
            If schedule.ActionType <> "Delete" Then
                Dim calendar As New CalendarItem(calendarSchedule, schedule.StartTime, schedule.EndTime, schedule.Title)
                calendar.ApplyColor(Color.FromName(schedule.BackgroundColor))
                calendar.ForeColor = Color.Black
                calendar.Tag = $"{schedule.ID},{schedule.Description},{schedule.CreatedBy},{schedule.UpdatedBy}"
                calendarItems.Add(calendar)
            End If
        Next

        LoadSchedule()
    End Sub

    Public Sub LoadSchedule()
        For Each calendar As CalendarItem In calendarItems
            If calendarSchedule.ViewIntersects(calendar) Then
                calendarSchedule.Items.Add(calendar)
            End If
        Next
    End Sub
    Private Sub ToolStripButtonSave_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSave.Click
        For Each item As CalendarItem In calendarSchedule.Items
            Console.WriteLine(item)
        Next
    End Sub

    Private Sub OtherToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using dlg As New ColorDialog()
            If dlg.ShowDialog() = DialogResult.OK Then
                For Each item As CalendarItem In calendarSchedule.GetSelectedItems
                    item.BackgroundColor = dlg.Color
                    item.BorderColor = dlg.Color
                    calendarSchedule.Invalidate(item)
                Next
            End If
        End Using
    End Sub

    Private Sub ScheduleControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        calendarSchedule.ViewStart = DateTimePickerDate.Value
        calendarSchedule.ViewEnd = DateTimePickerDate.Value
        GetSchedules()
    End Sub

    Private Sub DateTimePickerDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDate.ValueChanged
        calendarSchedule.SetViewRange(DateTimePickerDate.Value, DateTimePickerDate.Value)
        schedules.Clear()
        GetSchedules()
    End Sub

    Private Sub calendarSchedule_ItemDeleting(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemDeleting
        MessageBox.Show(e.Item.Tag)
    End Sub

    Private Sub calendarSchedule_ItemCreating(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreating
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_LoadItems(sender As Object, e As CalendarLoadEventArgs) Handles calendarSchedule.LoadItems
        LoadSchedule()
    End Sub

    Private Sub calendarSchedule_ItemDoubleClick(sender As Object, e As CalendarItemEventArgs) Handles calendarSchedule.ItemDoubleClick
        MessageBox.Show(e.Item.Text)
    End Sub

    Private Sub calendarSchedule_ItemMouseHover(sender As Object, e As CalendarItemEventArgs) Handles calendarSchedule.ItemMouseHover
        If e.Item.Text <> String.Empty Then
            Dim toolTipText As String
            Dim scheduleDetails As String() = IIf(e.Item.Tag <> String.Empty, e.Item.Tag.ToString().Split(", "), "")
            If scheduleDetails.Length > 0 Then
                toolTipText = "Title : " + e.Item.Text + vbNewLine +
                              "Description : " + scheduleDetails(1) + vbNewLine +
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
        Try
            Dim form As New ScheduleAddEditForm()
            form.scheduleControl = Me
            form.activeUser = MainForm.LabelMenu.Text
            form.selectedDate = DateTimePickerDate.Value.Date
            form.HeaderLabel.Text = "Schedule - New"
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calendarSchedule_Leave(sender As Object, e As EventArgs) Handles calendarSchedule.Leave

    End Sub
End Class
