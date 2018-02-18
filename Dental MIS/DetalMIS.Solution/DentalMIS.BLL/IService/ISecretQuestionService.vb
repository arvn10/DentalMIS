Imports DentalMIS.MODEL
Public Interface ISecretQuestionService
    Function SecretQuestionCreate(param As SecretQuestion) As Long
    Function SecretQuestionEdit(param As SecretQuestion) As Long
    Function SecretQuestionSelect(searchText As String) As List(Of SecretQuestion)
    Function SecretQuestionSelectID(id As Long) As SecretQuestion
End Interface
