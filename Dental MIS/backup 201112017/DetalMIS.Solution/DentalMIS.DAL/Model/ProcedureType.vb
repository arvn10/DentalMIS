Public Class ProcedureType
    Public Property ID As Long
    Public Property Name As String
    Public Property BasePrice As Double
    Public Property PaymentType As String
    Public Property RequireMedCert As String
    Public Property Status As String
End Class

Public Class ProcedureTypeCreate
    Inherits ProcedureType
    Public Property CreatedBy As String
End Class

Public Class ProcedureTypeEdit
    Inherits ProcedureType
    Public Property UpdatedBy As String
End Class

Public Class ProcedureTypeView
    Inherits ProcedureType
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class
