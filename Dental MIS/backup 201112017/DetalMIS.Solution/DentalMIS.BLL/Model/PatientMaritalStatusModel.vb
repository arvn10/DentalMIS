Public Class PatientMaritalStatus
    Public Property ID As Long
    Public Property Name As String
    Public Property Status As String
End Class

Public Class PatientMaritalStatusCreate
    Inherits PatientMaritalStatus
    Public Property CreatedBy As String
End Class

Public Class PatientMaritalStatusEdit
    Inherits PatientMaritalStatus
    Public Property UpdatedBy As String
End Class

Public Class PatientMaritalStatusView
    Inherits PatientMaritalStatus
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class


