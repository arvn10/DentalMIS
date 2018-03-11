Imports DentalMIS.MODEL
Imports DentalMIS.BLL
Public Class LoginFailedForm
    Private secretQuestionSvc As ISecretQuestionService
    Private userService As IUserService

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub LoginFailedForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        secretQuestionSvc = New SecretQuestionService
        comboSecretQuestion.DisplayMember = "Question"
        comboSecretQuestion.ValueMember = "ID"
        comboSecretQuestion.DataSource = secretQuestionSvc.SecretQuestionSelect("")
        comboSecretQuestion.Text = ""
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
                If comboBox.Text = String.Empty And comboBox.Tag = "*" Then
                    valid = False
                End If
            End If
        Next

        If valid Then
            userService = New UserService()
            Dim user As New User
            user = userService.ForgotPassword(textUsername.Text, comboSecretQuestion.SelectedValue, textSecretQuestionAnswer.Text)

            If user Is Nothing Then
                MessageBox.Show("Incorrect Details Provided", "Olaes Dental Clnic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If textNewPassword.Text.Equals(user.Password) Then
                    MessageBox.Show("New password must not be equal to old password.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textNewPassword.Clear()
                    textReNewPassword.Clear()
                    textNewPassword.Select()
                Else
                    If textNewPassword.Text.Length < 8 Then
                        MessageBox.Show("Password must contain minimum of 8 characters.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        textNewPassword.Clear()
                        textReNewPassword.Clear()
                        textNewPassword.Select()
                    Else
                        If Not textNewPassword.Text.Equals(textReNewPassword.Text) Then
                            MessageBox.Show("Passwords are not match", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            textReNewPassword.Clear()
                            textReNewPassword.Select()
                        Else
                            user.Status = IIf(user.Status = "Active", 1, 0)
                            user.Password = textReNewPassword.Text
                            user.UpdatedBy = user.ID
                            If userService.UserEdit(user) > 0 Then
                                MessageBox.Show("New Password Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Dispose()
                                LoginForm.textPassword.Clear()
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("Fill up all required fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class