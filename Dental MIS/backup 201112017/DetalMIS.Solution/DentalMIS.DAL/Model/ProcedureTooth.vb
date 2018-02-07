Public Class ProcedureTooth
    Public Property ID As Long
    Public Property ProcedureID As Long
    Public Property ToothNumber As Integer
End Class

Public Class ProcedureToothCreate
    Inherits ProcedureTooth
    Public Property CreatedBy As String
End Class

Public Class ProcedureToothEdit
    Inherits ProcedureTooth
    Public Property UpdatedBy As String
End Class

Public Class ProcedureToothView
    Inherits ProcedureTooth
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class
