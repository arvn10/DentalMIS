Imports DentalMIS.MODEL
Public Interface IProcedureService
    Function ProcedureCreate(param As Procedure) As Long
    Function ProcedureEdit(param As Procedure) As Long
    Function ProcedureSearchID(id As Long) As Procedure
    Function ProcedureSearchPatientID(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of Procedure)
    Function ProcedureSearchPaymentStatus(paymentStatus As String) As List(Of Procedure)
    Function ProcedureSearchPaymentLike(searchText As String) As List(Of Procedure)
End Interface
