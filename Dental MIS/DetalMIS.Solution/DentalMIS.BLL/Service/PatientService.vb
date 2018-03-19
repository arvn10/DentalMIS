Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class PatientService
    Implements IPatientService
    Private patientService As PatientReporsitory

    Public Sub New()
        patientService = New PatientReporsitory
    End Sub

    Public Function PatientCreate(param As Patient) As Long Implements IPatientService.PatientCreate
        Return patientService.PatientCreate(param)
    End Function

    Public Function PatientEdit(param As Patient) As Long Implements IPatientService.PatientEdit
        Return patientService.PatientEdit(param)
    End Function

    Public Function PatientSearchID(id As Long) As Patient Implements IPatientService.PatientSearchID
        Return patientService.PatientSearchID(id)
    End Function

    Public Function PatientSearchLike(searchText As String) As List(Of Patient) Implements IPatientService.PatientSearchLike
        Return patientService.PatientSearchLike(searchText)
    End Function

    Public Function PatientSearchReport(from As Date, [to] As Date) As List(Of PatientReport) Implements IPatientService.PatientSearchReport
        Return patientService.PatientSearchReport(from, [to])
    End Function
End Class
