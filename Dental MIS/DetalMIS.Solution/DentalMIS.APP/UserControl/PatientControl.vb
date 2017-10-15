Public Class PatientControl
    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        PatientAddEditForm.ShowDialog()
    End Sub
End Class
