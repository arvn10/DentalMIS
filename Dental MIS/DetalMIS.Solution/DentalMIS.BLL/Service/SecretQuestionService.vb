Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Imports DentalMIS.DAL
Public Class SecretQuestionService
    Implements ISecretQuestionService
    Private secretQuestionRepository As SecretQuestionRepository

    Public Sub New()
        secretQuestionRepository = New SecretQuestionRepository
    End Sub

    Public Function SecretQuestionCreate(param As SecretQuestion) As Long Implements ISecretQuestionService.SecretQuestionCreate
        Return secretQuestionRepository.SecretQuestionCreate(param)
    End Function

    Public Function SecretQuestionEdit(param As SecretQuestion) As Long Implements ISecretQuestionService.SecretQuestionEdit
        Return secretQuestionRepository.SecretQuestionEdit(param)
    End Function

    Public Function SecretQuestionSelect(searchText As String) As List(Of SecretQuestion) Implements ISecretQuestionService.SecretQuestionSelect
        Return secretQuestionRepository.SecretQuestionSelect(searchText)
    End Function

    Public Function SecretQuestionSelectID(id As Long) As SecretQuestion Implements ISecretQuestionService.SecretQuestionSelectID
        Return secretQuestionRepository.SecretQuestionSelectID(id)
    End Function
End Class
