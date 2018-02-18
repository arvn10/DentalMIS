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

    Public Function ProcedureSearchPatientID(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of Procedure) Implements IProcedureService.ProcedureSearchPatientID
        Return procedureRepository.ProcedureSearchPatientID(patientID, toothNumber, [from], [to])
    End Function

    Public Function ProcedureSearchPaymentStatus(paymentStatus As String) As List(Of Procedure) Implements IProcedureService.ProcedureSearchPaymentStatus
        Return procedureRepository.ProcedureSearchPaymentStatus(paymentStatus)
    End Function

    Public Function ProcedureSearchPaymentLike(searchText As String) As List(Of Procedure) Implements IProcedureService.ProcedureSearchPaymentLike
        Return procedureRepository.ProcedureSearchPaymentLike(searchText)
    End Function

    Public Function ProcedureSearchPaymentReport(paymentStatus As String, from As Date, [to] As Date) As List(Of ProcedureReport) Implements IProcedureService.ProcedureSearchPaymentReport
        Return procedureRepository.ProcedureSearchPaymentReport(paymentStatus, from, [to])
    End Function
End Class
