Imports System.Windows.Forms.Calendar

Public Class ScheduleControl
    Public schedules As New List(Of CalendarItem)()

    Public Sub LoadData()
        For Each item As CalendarItem In schedules
            If calendarSchedule.ViewIntersects(item) Then
                calendarSchedule.Items.Add(item)
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
    End Sub

    Private Sub DateTimePickerDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDate.ValueChanged
        calendarSchedule.SetViewRange(DateTimePickerDate.Value, DateTimePickerDate.Value)
    End Sub

    Private Sub calendarSchedule_ItemDeleting(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemDeleting
        MessageBox.Show(e.Item.Text)
    End Sub

    Private Sub calendarSchedule_ItemCreating(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreating
        Try
            Dim form As New ScheduleAddEditForm()
            form.scheduleControl = Me
            form.activeUser = MainForm.LabelMenu.Text
            form.selectedDate = e.Item.StartDate
            form.HeaderLabel.Text = "Schedule - New"
            form.schedule = e.Item
            form.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub calendarSchedule_LoadItems(sender As Object, e As CalendarLoadEventArgs) Handles calendarSchedule.LoadItems
        LoadData()
    End Sub
End Class
