Public Class Doctor
    Public Property ID As Long
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property MiddleInitial As String
    Public Property Status As String
End Class

Public Class DoctorCreate
    Inherits Doctor
    Public Property CreatedBy As String
End Class

Public Class DoctorEdit
    Inherits Doctor
    Public Property UpdatedBy As String
End Class

Public Class DoctorView
    Inherits Doctor
    Public Property CreatedBy As String
    Public Property UpdatedBy As String
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime?
End Class
