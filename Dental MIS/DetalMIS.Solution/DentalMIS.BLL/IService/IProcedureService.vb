Imports DentalMIS.MODEL
Public Interface IProcedureService
    Function ProcedureCreate(param As Procedure) As Long
    Function ProcedureEdit(param As Procedure) As Long
    Function ProcedureSearchID(id As Long) As Procedure
    Function ProcedureSearchPatientID(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of Procedure)
    Function ProcedureSearchPaymentStatus(paymentStatus As String) As List(Of Procedure)
    Function ProcedureSearchPaymentLike(searchText As String) As List(Of Procedure)
    Function ProcedureSearchPaymentReport(paymentStatus As String, [from] As Date, [to] As Date) As List(Of ProcedureReport)
    Function ProcedureToothCreate(param As ProcedureTooth) As Long
    Function ProcedureToothEdit(param As ProcedureTooth) As Long
    Function ProcedureToothSelectProcedureID(procedureID As Long) As List(Of ProcedureTooth)
    Function ProcedureToothSelectID(id As Long) As ProcedureTooth
    Function ProcedureRemarkCreate(param As ProcedureRemark) As Long
    Function ProcedureRemarkEdit(param As ProcedureRemark) As Long
    Function ProcedureRemarkSelectProcedureID(procedureID As Long) As List(Of ProcedureRemark)
    Function ProcedureRemarkSelectID(id As Long) As ProcedureRemark
    Function ProcedureSearchProcedureReport(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of ProcedureHistoryReport)
End Interface
