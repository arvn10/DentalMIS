Public Class Patient
    Public Property ID As Long
    Public Property PatientMaritalStatusID As Long
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property MiddleInitial As String
    Public Property Address As String
    Public Property Age As Integer
    Public Property Gender As String
    Public Property Occupation As String
    Public Property MaritalStatus As String
End Class

Public Class PatientCreate
    Inherits Patient
    Public Property CreatedBy As String
End Class

Public Class PatientEdit
    Inherits Patient
    Public Property UpdatedBy As String
End Class

Public Class PatientView
    Inherits Patient
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class


