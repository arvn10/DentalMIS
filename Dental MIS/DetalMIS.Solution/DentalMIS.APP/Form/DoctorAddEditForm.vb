Imports DentalMIS.BLL
Public Class DoctorAddEditForm
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub comboStatus_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If HeaderLabel.Text.Contains("New") Then

        Else

        End If
    End Sub

End Class