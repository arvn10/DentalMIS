Imports System.Windows.Forms.Calendar
Public Class ScheduleAddEditForm
    Public activeUser As String
    Public selectedDate As Date
    Public schedule As CalendarItem
    Public scheduleControl As ScheduleControl
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonColor_Click(sender As Object, e As EventArgs) Handles buttonColor.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            panelColor.BackColor = ColorDialog.Color
        End If
    End Sub

    Private Sub ScheduleAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        dateTimePickerStart.Value = selectedDate
        dateTimePickerEnd.Value = selectedDate
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        schedule.Text = textTitle.Text
        schedule.StartDate = dateTimePickerStart.Value
        schedule.EndDate = dateTimePickerEnd.Value
        schedule.ApplyColor(panelColor.BackColor)
        schedule.ForeColor = Color.Black
        schedule.Tag = $"id:0, description:{textDescription.Text}, activeUser:{activeUser}"
        Me.Dispose()
    End Sub
End Class