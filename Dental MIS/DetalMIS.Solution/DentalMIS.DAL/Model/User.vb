Public Class User
    Public Property ID As Long
    Public Property UserTypeID As Long
    Public Property UserType As String
    Public Property Username As String
    Public Property Password As String
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property Status As String
End Class

Public Class UserCreate
    Inherits User
    Public Property CreatedBy As String
End Class

Public Class UserEdit
    Inherits User
    Public Property UpdatedBy As String
End Class

Public Class UserView
    Inherits User
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class