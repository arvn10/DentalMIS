Imports DentalMIS.MODEL
Public Interface IProcedureService
    Function ProcedureCreate(param As Procedure) As Long
    Function ProcedureEdit(param As Procedure) As Long
    Function ProcedureSearchID(id As Long) As Procedure
    Function ProcedureSearchPatientID(patientID As Long, [from] As String, [to] As String) As List(Of Procedure)
End Interface
