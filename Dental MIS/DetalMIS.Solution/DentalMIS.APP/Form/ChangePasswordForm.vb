Imports DentalMIS.MODEL
Imports DentalMIS.BLL
Public Class ChangePasswordForm
    Public user As User
    Private userSvc As IUserService
    Private Sub MyProfileForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            If textOldPassword.Text.Equals(user.Password) Then
                Dim msg = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then
                    userSvc = New UserService()
                    user.Status = If(user.Status = "Active", 1, 0)
                    user.Password = textPassword.Text
                    If userSvc.UserEdit(user) > 0 Then
                        MessageBox.Show("Password Changed", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MainForm.user = userSvc.UserSearchID(user.ID).FirstOrDefault()
                        Me.Dispose()
                    End If
                End If
            Else
                MessageBox.Show("Passwords are not match", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class