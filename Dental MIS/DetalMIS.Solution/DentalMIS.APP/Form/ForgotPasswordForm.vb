Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ForgotPasswordForm
    Private secretQuestionSvc As ISecretQuestionService
    Private userService As IUserService
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        secretQuestionSvc = New SecretQuestionService
        comboSecretQuestion.DisplayMember = "Question"
        comboSecretQuestion.ValueMember = "ID"
        comboSecretQuestion.DataSource = secretQuestionSvc.SecretQuestionSelect("")
        comboSecretQuestion.Text = ""
    End Sub

    Private Sub buttonRecover_Click(sender As Object, e As EventArgs) Handles buttonRecover.Click

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
                textPassword.Text = user.Password
            End If
        Else
            MessageBox.Show("Fill up all required fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class