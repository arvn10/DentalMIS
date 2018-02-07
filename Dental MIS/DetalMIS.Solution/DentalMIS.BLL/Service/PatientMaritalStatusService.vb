Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class PatientMaritalStatusService
    Implements IPatientMaritalStatusService
    Private patientMaritalStatusService As PatientMaritalStatusRepository

    Public Sub New()
        patientMaritalStatusService = New PatientMaritalStatusRepository
    End Sub

    Public Function PatientMaritalStatusCreate(param As PatientMaritalStatus) As Long Implements IPatientMaritalStatusService.PatientMaritalStatusCreate
        Return patientMaritalStatusService.PatientMaritalStatusCreate(
            New PatientMaritalStatus With {
                .Name = param.Name,
                .Status = param.Status,
                .CreatedBy = param.CreatedBy
            }
        )
    End Function

    Public Function PatientMaritalStatusEdit(param As PatientMaritalStatus) As Long Implements IPatientMaritalStatusService.PatientMaritalStatusEdit
        Return patientMaritalStatusService.PatientMaritalStatusEdit(
            New PatientMaritalStatus With {
                .ID = param.ID,
                .Name = param.Name,
                .Status = param.Status,
                .UpdatedBy = param.UpdatedBy
            }
        )
    End Function

    Public Function PatientMaritalStatusSearchID(id As Long) As List(Of PatientMaritalStatus) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchID
        Dim datas As List(Of PatientMaritalStatus) =
            (From data As PatientMaritalStatus In patientMaritalStatusService.PatientMaritalStatusSearchID(id)
             Select New PatientMaritalStatus With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function PatientMaritalStatusSearchStatus(Status As Integer) As List(Of PatientMaritalStatus) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchStatus
        Dim datas As List(Of PatientMaritalStatus) =
            (From data As PatientMaritalStatus In patientMaritalStatusService.PatientMaritalStatusSearchStatus(Status)
             Select New PatientMaritalStatus With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function PatientMaritalStatusSearchLike(SearchValue As String) As List(Of PatientMaritalStatus) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchLike
        Dim datas As List(Of PatientMaritalStatus) =
            (From data As PatientMaritalStatus In patientMaritalStatusService.PatientMaritalStatusSearchLike(SearchValue)
             Select New PatientMaritalStatus With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function
End Class
