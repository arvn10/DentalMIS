Imports DentalMIS.MODEL
Public Interface IUserService
    Function UserCreate(param As User) As Long
    Function UserEdit(param As User) As Long
    Function UserSearchID(ID As Long) As List(Of User)
    Function UserSearchLike(SearchText As String) As List(Of User)
    Function UserLogin(Username As String, Password As String) As List(Of User)
    Function ForgotPassword(username As String, secretQuestionID As Long, secretQuestionAnswer As String) As User
End Interface
