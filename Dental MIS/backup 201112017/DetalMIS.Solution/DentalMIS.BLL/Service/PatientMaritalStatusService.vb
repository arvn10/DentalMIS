Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class PatientMaritalStatusService
    Implements IPatientMaritalStatusService
    Private patientMaritalStatusService As DAL.PatientMaritalStatusRepository

    Public Sub New()
        patientMaritalStatusService = New DAL.PatientMaritalStatusRepository
    End Sub

    Public Function PatientMaritalStatusCreate(param As PatientMaritalStatusCreate) As Long Implements IPatientMaritalStatusService.PatientMaritalStatusCreate
        Return patientMaritalStatusService.PatientMaritalStatusCreate(
            New DAL.PatientMaritalStatusCreate With {
                .Name = param.Name,
                .Status = param.Status,
                .CreatedBy = param.CreatedBy
            }
        )
    End Function

    Public Function PatientMaritalStatusEdit(param As PatientMaritalStatusEdit) As Long Implements IPatientMaritalStatusService.PatientMaritalStatusEdit
        Return patientMaritalStatusService.PatientMaritalStatusEdit(
            New DAL.PatientMaritalStatusEdit With {
                .ID = param.ID,
                .Name = param.Name,
                .Status = param.Status,
                .UpdatedBy = param.UpdatedBy
            }
        )
    End Function

    Public Function PatientMaritalStatusSearchID(id As Long) As List(Of PatientMaritalStatusView) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchID
        Dim datas As List(Of PatientMaritalStatusView) =
            (From data As DAL.PatientMaritalStatusView In patientMaritalStatusService.PatientMaritalStatusSearchID(id)
             Select New PatientMaritalStatusView With {
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

    Public Function PatientMaritalStatusSearchStatus(Status As Integer) As List(Of PatientMaritalStatusView) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchStatus
        Dim datas As List(Of PatientMaritalStatusView) =
            (From data As DAL.PatientMaritalStatusView In patientMaritalStatusService.PatientMaritalStatusSearchStatus(Status)
             Select New PatientMaritalStatusView With {
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

    Public Function PatientMaritalStatusSearchLike(SearchValue As String) As List(Of PatientMaritalStatusView) Implements IPatientMaritalStatusService.PatientMaritalStatusSearchLike
        Dim datas As List(Of PatientMaritalStatusView) =
            (From data As DAL.PatientMaritalStatusView In patientMaritalStatusService.PatientMaritalStatusSearchLike(SearchValue)
             Select New PatientMaritalStatusView With {
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
