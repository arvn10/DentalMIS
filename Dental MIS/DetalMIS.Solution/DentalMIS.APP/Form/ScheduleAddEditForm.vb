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

        dateTimePickerStart.Value = selectedDate
        dateTimePickerStart.MinDate = selectedDate.ToString("yyyy-MM-dd") + " 08:00:00"
        dateTimePickerStart.MaxDate = selectedDate.ToString("yyyy-MM-dd") + " 17:00:00"
        If HeaderLabel.Text.Contains("Edit") Then
            scheduleID = schedule.ID
            textTitle.Text = schedule.Title
            dateTimePickerStart.Value = schedule.StartTime
            textDescription.Text = schedule.Description
            panelColor.BackColor = Color.FromArgb(schedule.BackgroundColor)
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
            Dim ifExist As Boolean = False
            'If dateTimePickerStart.Value >= dateTimePickerEnd.Value Then
            '    MessageBox.Show("Start Time Cannot be greater than or equal to End Time.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Else
            For Each sc As Schedule In scheduleControl.schedules
                If HeaderLabel.Text.Contains("New") Then
                    If sc.StartTime >= dateTimePickerStart.Value And sc.EndTime <= dateTimePickerStart.Value.AddMinutes(30) Then
                        ifExist = True
                    End If
                Else
                    If (schedule.StartTime <> dateTimePickerStart.Value And schedule.EndTime <> dateTimePickerStart.Value.AddMinutes(30)) And (sc.StartTime >= dateTimePickerStart.Value And sc.EndTime <= dateTimePickerStart.Value.AddMinutes(30)) Then
                        ifExist = True
                    End If
                End If
            Next

            If ifExist Then
                MessageBox.Show("Schedule Already Taken", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If HeaderLabel.Text.Contains("New") Then
                    schedule = New Schedule
                    If scheduleControl.schedules.Count = 0 Then
                        schedule.Index = 1
                    Else
                        schedule.Index = scheduleControl.schedules(scheduleControl.schedules.Count - 1).Index + 1
                    End If

                    schedule.ID = 0
                    schedule.Title = textTitle.Text
                    schedule.Description = textDescription.Text
                    schedule.StartTime = dateTimePickerStart.Value
                    schedule.EndTime = dateTimePickerStart.Value.AddMinutes(30)
                    schedule.ActionType = "Insert"
                    schedule.BackgroundColor = panelColor.BackColor.ToArgb
                    schedule.CreatedBy = activeUser
                    scheduleControl.schedules.Add(schedule)
                    scheduleControl.GetSchedules()
                    Me.Dispose()
                    'End If
                Else
                    Dim msg = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If msg = DialogResult.Yes Then
                        Dim tempSchedule As Schedule = scheduleControl.schedules.Where(Function(s) s.Index = schedule.Index).FirstOrDefault()
                        Dim index As Integer = scheduleControl.schedules.IndexOf(tempSchedule)

                        schedule.Index = schedule.Index
                        schedule.ID = scheduleID
                        schedule.Title = textTitle.Text
                        schedule.Description = textDescription.Text
                        schedule.StartTime = dateTimePickerStart.Value
                        schedule.EndTime = dateTimePickerStart.Value.AddMinutes(30)
                        schedule.ActionType = IIf(scheduleID = 0, "Insert", "Update")
                        schedule.BackgroundColor = panelColor.BackColor.ToArgb
                        schedule.UpdatedBy = activeUser
                        scheduleControl.schedules(index) = schedule
                        scheduleControl.GetSchedules()
                        Me.Dispose()
                    End If
                End If
            End If
            'End If
        Else
            MessageBox.Show("Fill up all the required fields", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class