Public Class ProcedureType
    Public Property ID As Long
    Public Property Name As String
    Public Property BasePrice As Double
    Public Property PaymentType As String
    Public Property RequireMedCert As String
    Public Property RequireTooth As String
    Public Property Status As String
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class

Public Class ProcedureTypePair
    Public Property ID As Long
    Public Property ProcedureID As Long
    Public Property ProcedureIDPair As Long
    Public Property ProcedureName As String
    Public Property VisibilityType As String
    Public Property Status As String
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class
