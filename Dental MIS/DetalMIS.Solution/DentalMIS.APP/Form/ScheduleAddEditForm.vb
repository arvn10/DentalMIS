Imports System.Windows.Forms.Calendar
Imports DentalMIS.MODEL
Public Class ScheduleAddEditForm
    Public activeUser As String
    Public selectedDate As Date
    Public schedule As Schedule
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
            textTitle.Text = schedule.Title
            dateTimePickerStart.Value = schedule.StartTime
            dateTimePickerEnd.Value = schedule.EndTime

        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim valid As Boolean = True
        For Each control As Control In Me.Controls
            If (control.GetType() Is GetType(TextBox)) Then
                Dim textBox As TextBox = CType(control, TextBox)
                If textBox.Text = String.Empty And textBox.Tag = "*" Then
                    valid = False
                End If
            ElseIf (control.GetType() Is GetType(ComboBox)) Then
                Dim comboBox As ComboBox = CType(control, ComboBox)
                If (comboBox.Text = String.Empty Or comboBox.Text.Contains("Select")) And comboBox.Tag = "*" Then
                    valid = False
                End If
            End If
        Next

        If valid Then
            If dateTimePickerStart.Value >= dateTimePickerEnd.Value Then
                MessageBox.Show("Start Time Cannot be greater than or equal to End Time.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If HeaderLabel.Text.Contains("New") Then
                    Dim ifExist As Integer
                    If scheduleControl.schedules.Count > 0 Then
                        ifExist = scheduleControl.schedules.Where(Function(s) s.StartTime >= dateTimePickerStart.Value Or s.EndTime = dateTimePickerEnd.Value).Count
                    Else
                        ifExist = 0
                    End If

                    If ifExist > 0 Then
                        MessageBox.Show("Schedule already taken or there is a conflict with your selected schedule.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim schedule As New Schedule
                        schedule.ID = 0
                        schedule.Title = textTitle.Text
                        schedule.Description = textDescription.Text
                        schedule.StartTime = dateTimePickerStart.Value
                        schedule.EndTime = dateTimePickerEnd.Value
                        schedule.ActionType = "Insert"
                        schedule.BackgroundColor = panelColor.BackColor.Name
                        schedule.CreatedBy = activeUser
                        scheduleControl.schedules.Add(schedule)
                        scheduleControl.GetSchedules()
                        Me.Dispose()
                    End If
                Else

                End If
            End If
        Else
            MessageBox.Show("Fill up all the required fields", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class