Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class UserService
    Implements IUserService

    Private userService As DAL.UserRepository

    Public Sub New()
        userService = New UserRepository
    End Sub

    Public Function UserCreate(param As UserCreate) As Long Implements IUserService.UserCreate
        Return userService.UserCreate(New DAL.UserCreate With {
                                        .UserTypeID = param.UserTypeID,
                                        .Username = param.Username,
                                        .Password = param.Password,
                                        .Firstname = param.Firstname,
                                        .Lastname = param.Lastname,
                                        .Status = param.Status,
                                        .CreatedBy = param.CreatedBy
                                      })
    End Function

    Public Function UserEdit(param As UserEdit) As Long Implements IUserService.UserEdit
        Return userService.UserEdit(New DAL.UserEdit With {
                                        .ID = param.ID,
                                        .UserTypeID = param.UserTypeID,
                                        .Username = param.Username,
                                        .Password = param.Password,
                                        .Firstname = param.Firstname,
                                        .Lastname = param.Lastname,
                                        .Status = param.Status,
                                        .UpdatedBy = param.UpdatedBy
                                      })
    End Function

    Public Function UserSearchID(ID As Long) As List(Of UserView) Implements IUserService.UserSearchID
        Dim datas As List(Of UserView) = (From data As DAL.UserView In userService.UserSearchID(ID)
                                          Select New UserView With {
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

    Public Function UserSearchStatus(Status As Long) As List(Of UserView) Implements IUserService.UserSearchStatus
        Dim datas As List(Of UserView) = (From data As DAL.UserView In userService.UserSearchStatus(Status)
                                          Select New UserView With {
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

    Public Function UserSearchLike(SearchText As Long) As List(Of UserView) Implements IUserService.UserSearchLike
        Dim datas As List(Of UserView) = (From data As DAL.UserView In userService.UserSearchLike(SearchText)
                                          Select New UserView With {
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

    Public Function UserLogin(Username As String, Password As String) As List(Of UserView) Implements IUserService.UserLogin
        Dim datas As List(Of UserView) = (From data As DAL.UserView In userService.UserLogin(Username, Password)
                                          Select New UserView With {
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
