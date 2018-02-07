Public Class DoctorControl


    Private Sub DoctorControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboFilter_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboStatus_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        DoctorAddEditForm.HeaderLabel.Text = "Doctor - New"
        DoctorAddEditForm.ShowDialog()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        DoctorAddEditForm.HeaderLabel.Text = "Doctor - Edit"
        DoctorAddEditForm.ShowDialog()
    End Sub
End Class
