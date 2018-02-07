Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class ProcedureService
    Implements IProcedureService
    Private procedureRepository As ProcedureRepository
    Public Sub New()
        procedureRepository = New ProcedureRepository
    End Sub

    Public Function ProcedureCreate(param As Procedure) As Long Implements IProcedureService.ProcedureCreate
        Return procedureRepository.ProcedureCreate(param)
    End Function

    Public Function ProcedureEdit(param As Procedure) As Long Implements IProcedureService.ProcedureEdit
        Return procedureRepository.ProcedureEdit(param)
    End Function

    Public Function ProcedureSearchID(id As Long) As Procedure Implements IProcedureService.ProcedureSearchID
        Return procedureRepository.ProcedureSearchID(id)
    End Function

    Public Function ProcedureSearchPatientID(patientID As Long, [from] As String, [to] As String) As List(Of Procedure) Implements IProcedureService.ProcedureSearchPatientID
        Return procedureRepository.ProcedureSearchPatientID(patientID, [from], [to])
    End Function
End Class
