Public Interface IUserService
    Function UserCreate(param As UserCreate) As Long
    Function UserEdit(param As UserEdit) As Long
    Function UserSearchID(ID As Long) As List(Of UserView)
    Function UserSearchStatus(Status As Long) As List(Of UserView)
    Function UserSearchLike(SearchText As String) As List(Of UserView)
    Function UserLogin(Username As String, Password As String) As List(Of UserView)
End Interface
