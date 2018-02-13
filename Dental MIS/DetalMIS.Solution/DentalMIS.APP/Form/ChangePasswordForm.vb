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
                If textPassword.Text.Equals(textOldPassword.Text) Then
                    MessageBox.Show("New password must not be equal to old password.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textPassword.Clear()
                    textPassword.Select()
                Else
                    If textPassword.Text.Length < 8 Then
                        MessageBox.Show("Password must contain minimum of 8 characters.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        textPassword.Clear()
                        textPassword.Select()
                    Else
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
                    End If

                End If
            Else
                MessageBox.Show("Passwords are not match", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textPassword.Clear()
                textOldPassword.Clear()
                textOldPassword.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class