Imports DentalMIS.MODEL

Public Class ProcedureRemarkAddEditForm
    Public procedureAddEditForm As ProcedureAddEditForm
    Public remarkID As String
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            Dim remark As New ProcedureRemark
            If String.IsNullOrEmpty(textRemark.Text) Or String.IsNullOrWhiteSpace(textRemark.Text) Then
                MessageBox.Show("Fillup all required field(s)", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If HeaderLabel.Text.Contains("New") Then
                    If procedureAddEditForm.remarks.Where(Function(s) s.Remark = textRemark.Text And s.DateAdded = dtPickerTransDate.Value.Date).Count > 0 Then
                        MessageBox.Show("Remark already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        textRemark.Clear()
                    Else
                        remark.ID = "N-" & procedureAddEditForm.remarks.Count + 1
                        remark.Remark = textRemark.Text
                        remark.DateAdded = dtPickerTransDate.Value.Date
                        procedureAddEditForm.remarks.Add(remark)
                        procedureAddEditForm.LoadRemark(procedureAddEditForm.remarks)
                        MessageBox.Show("Remark Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                Else
                    Dim confirmation = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirmation = DialogResult.Yes Then
                        For Each data As ProcedureRemark In procedureAddEditForm.remarks.ToList()
                            If data.ID = remarkID Then
                                data.Remark = textRemark.Text
                                data.DateAdded = dtPickerTransDate.Value.Date
                            End If
                        Next
                        MessageBox.Show("Remark Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procedureAddEditForm.LoadRemark(procedureAddEditForm.remarks)
                        Me.Dispose()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try
    End Sub
End Class