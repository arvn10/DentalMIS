Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class SecretQuestionAddEdit
    Public activeUser As String
    Public secretQuestionID As Long
    Public secretQuestionControl As SecretQuestionControl

    Dim secretQuestion As SecretQuestion


    Private secretQuestionSvc As ISecretQuestionService

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If textQuestion.Text <> String.Empty Then
            secretQuestionSvc = New SecretQuestionService
            If HeaderLabel.Text.Contains("New") Then
                secretQuestion = New SecretQuestion()
                secretQuestion.Question = textQuestion.Text
                secretQuestion.CreatedBy = activeUser

                If secretQuestionSvc.SecretQuestionCreate(secretQuestion) > 0 Then
                    MessageBox.Show("Secret Question Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    secretQuestionControl.LoadData("")
                    Me.Dispose()
                End If
            Else
                Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    secretQuestion.Question = textQuestion.Text
                    secretQuestion.UpdatedBy = activeUser

                    If secretQuestionSvc.SecretQuestionEdit(secretQuestion) > 0 Then
                        MessageBox.Show("Secret Question Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        secretQuestionControl.LoadData("")
                        Me.Dispose()
                    End If
                End If
            End If
        Else
            MessageBox.Show("Fill up required Field(s)", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SecretQuestionAddEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If HeaderLabel.Text.Contains("Edit") Then
            secretQuestionSvc = New SecretQuestionService
            secretQuestion = New SecretQuestion()
            secretQuestion = secretQuestionSvc.SecretQuestionSelectID(secretQuestionID)
            textQuestion.Text = secretQuestion.Question
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class