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
        Dim datas As List(Of User) = (From data As User In userService.UserSearchID(ID)
                                      Select New User With {
                                                   .ID = data.ID,
                                                   .UserTypeID = data.UserTypeID,
                                                   .UserType = data.UserType,
                                                   .Username = data.Username,
                                                   .Password = data.Password,
                                                   .Firstname = data.Firstname,
                                                   .Lastname = data.Lastname,
                                                   .Status = data.Status,
                                                   .CreatedBy = data.CreatedBy,
                                                   .CreatedDate = data.CreatedDate,
                                                   .UpdatedBy = data.UpdatedBy,
                                                   .UpdatedDate = data.UpdatedDate
                                              }).ToList()
        Return datas
    End Function

    Public Function UserSearchStatus(Status As Long) As List(Of User) Implements IUserService.UserSearchStatus
        Dim datas As List(Of User) = (From data As User In userService.UserSearchStatus(Status)
                                      Select New User With {
                                                   .ID = data.ID,
                                                   .UserTypeID = data.UserTypeID,
                                                   .UserType = data.UserType,
                                                   .Username = data.Username,
                                                   .Password = data.Password,
                                                   .Firstname = data.Firstname,
                                                   .Lastname = data.Lastname,
                                                   .Status = data.Status,
                                                   .CreatedBy = data.CreatedBy,
                                                   .CreatedDate = data.CreatedDate,
                                                   .UpdatedBy = data.UpdatedBy,
                                                   .UpdatedDate = data.UpdatedDate
                                              }).ToList()
        Return datas
    End Function

    Public Function UserSearchLike(SearchText As String) As List(Of User) Implements IUserService.UserSearchLike
        Dim datas As List(Of User) = (From data As User In userService.UserSearchLike(SearchText)
                                      Select New User With {
                                                   .ID = data.ID,
                                                   .UserTypeID = data.UserTypeID,
                                                   .UserType = data.UserType,
                                                   .Username = data.Username,
                                                   .Password = data.Password,
                                                   .Firstname = data.Firstname,
                                                   .Lastname = data.Lastname,
                                                   .Status = data.Status,
                                                   .CreatedBy = data.CreatedBy,
                                                   .CreatedDate = data.CreatedDate,
                                                   .UpdatedBy = data.UpdatedBy,
                                                   .UpdatedDate = data.UpdatedDate
                                              }).ToList()
        Return datas
    End Function

    Public Function UserLogin(Username As String, Password As String) As List(Of User) Implements IUserService.UserLogin
        Dim datas As List(Of User) = (From data As User In userService.UserLogin(Username, Password)
                                      Select New User With {
                                                   .ID = data.ID,
                                                   .UserTypeID = data.UserTypeID,
                                                   .UserType = data.UserType,
                                                   .Username = data.Username,
                                                   .Password = data.Password,
                                                   .Firstname = data.Firstname,
                                                   .Lastname = data.Lastname,
                                                   .Status = data.Status,
                                                   .CreatedBy = data.CreatedBy,
                                                   .CreatedDate = data.CreatedDate,
                                                   .UpdatedBy = data.UpdatedBy,
                                                   .UpdatedDate = data.UpdatedDate
                                              }).ToList()
        Return datas
    End Function
End Class
