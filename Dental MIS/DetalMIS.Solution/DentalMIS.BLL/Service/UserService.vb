Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class UserService
    Implements IUserService

    Private userService As UserRepository

    Public Sub New()
        userService = New UserRepository
    End Sub

    Public Function UserCreate(param As User) As Long Implements IUserService.UserCreate
        Return userService.UserCreate(param)
    End Function

    Public Function UserEdit(param As User) As Long Implements IUserService.UserEdit
        Return userService.UserEdit(param)
    End Function

    Public Function UserSearchID(ID As Long) As List(Of User) Implements IUserService.UserSearchID
        Return userService.UserSearchID(ID)
    End Function

    Public Function UserSearchLike(SearchText As String) As List(Of User) Implements IUserService.UserSearchLike
        Return userService.UserSearchLike(SearchText)
    End Function

    Public Function UserLogin(Username As String, Password As String) As List(Of User) Implements IUserService.UserLogin
        Return userService.UserLogin(Username, Password)
    End Function

    Public Function ForgotPassword(username As String, secretQuestionID As Long, secretQuestionAnswer As String) As User Implements IUserService.ForgotPassword
        Return userService.ForgotPassword(username, secretQuestionID, secretQuestionAnswer)
    End Function
End Class
