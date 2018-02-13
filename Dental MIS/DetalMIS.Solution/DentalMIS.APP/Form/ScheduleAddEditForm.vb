Imports System.Windows.Forms.Calendar
Public Class ScheduleAddEditForm
    Public activeUser As String
    Public selectedDate As Date
    Public schedule As CalendarItem
    Public scheduleControl As ScheduleControl
    Dim scheduleID As Long
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonColor_Click(sender As Object, e As EventArgs) Handles buttonColor.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            panelColor.BackColor = ColorDialog.Color
        End If
    End Sub

    Private Sub ScheduleAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        dateTimePickerStart.MinDate = selectedDate.ToString("yyyy-MM-dd ") + " 00:00:00"
        dateTimePickerStart.MaxDate = selectedDate.ToString("yyyy-MM-dd ") + " 23:59:59"

        dateTimePickerEnd.MinDate = selectedDate.ToString("yyyy-MM-dd ") + " 00:00:00"
        dateTimePickerEnd.MaxDate = selectedDate.ToString("yyyy-MM-dd ") + " 23:59:59"

        dateTimePickerStart.Value = selectedDate
        dateTimePickerEnd.Value = selectedDate

        If HeaderLabel.Text.Contains("Edit") Then
            Dim description As String
            textTitle.Text = schedule.Text
            dateTimePickerStart.Value = schedule.StartDate
            dateTimePickerEnd.Value = schedule.EndDate

        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If HeaderLabel.Text.Contains("New") Then
            schedule.Text = textTitle.Text
            schedule.StartDate = dateTimePickerStart.Value
            schedule.EndDate = dateTimePickerEnd.Value
            schedule.ApplyColor(panelColor.BackColor)
            schedule.ForeColor = Color.Black
            schedule.Tag = $"0,{textDescription.Text},{activeUser}"
            Me.Dispose()
        Else

        End If
    End Sub
End Class