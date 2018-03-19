Public Class Procedure
    Public Property ID As Long
    Public Property PatientID As Long
    Public Property ProcedureTypeID As Long
    Public Property FullName As String
    Public Property Age As Integer
    Public Property Address As String
    Public Property Gender As String
    Public Property Tooth As String
    Public Property ProcedureName As String
    Public Property ProcedureDate As String
    Public Property PaymentType As String
    Public Property AmountToPay As Long
    Public Property AmountPaid As Long
    Public Property Balance As Long
    Public Property PaymentStatus As String
    Public Property ProcedureCreatedBy As String
    Public Property ProcedureCreatedDate As DateTime?
    Public Property ProcedureUpdatedBy As String
    Public Property ProcedureUpdatedDate As DateTime?
    Public Property PaymentCreatedBy As String
    Public Property PaymentCreatedDate As DateTime?
    Public Property PaymentUpdatedBy As String
    Public Property PaymentUpdatedDate As DateTime?
End Class

Public Class ProcedureReport
    Public Property ProcedureDate As Date
    Public Property FullName As String
    Public Property Tooth As String
    Public Property ProcedureName As String
    Public Property AmountToPay As Long
    Public Property AmountPaid As Long
    Public Property Balance As Long
    Public Property PaymentStatus As String
End Class

Public Class ProcedureHistoryReport
    Public Property ProcedureDate As Date
    Public Property Tooth As String
    Public Property ProcedureName As String
End Class