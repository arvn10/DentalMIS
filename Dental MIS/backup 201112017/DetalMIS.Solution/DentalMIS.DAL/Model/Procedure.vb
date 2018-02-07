Public Class Procedure
    Public Property ID As Long
    Public Property PatientID As Long
    Public Property ProcedureTypeID As Long
    Public Property ProcedureName As string
    Public Property Notes As String
    Public Property Prescription As String
    Public Property ProcedureDate As Date
    Public Property Status As String
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class

'Public Class ProcedureCreate
'    Inherits Procedure
'    Public Property CreatedBy As String
'End Class

'Public Class ProcedureEdit
'    Inherits Procedure
'    Public Property UpdatedBy As String
'End Class

'Public Class ProcedureView
'    Inherits Procedure
'    Public Property CreatedBy As String
'    Public Property CreatedDate As DateTime
'    Public Property UpdatedBy As String
'    Public Property UpdatedDate As DateTime?
'End Class
