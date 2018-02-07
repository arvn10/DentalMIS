Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class PatientService
    Implements IPatientService
    Private patientService As DAL.PatientReporsitory

    Public Sub New()
        patientService = New PatientReporsitory
    End Sub

    Public Function PatientCreate(param As PatientCreate) As Long Implements IPatientService.PatientCreate
        Return patientService.PatientCreate(
            New DAL.PatientCreate With {
                .PatientMaritalStatusID = param.PatientMaritalStatusID,
                .Firstname = param.Firstname,
                .Lastname = param.Lastname,
                .MiddleInitial = param.MiddleInitial,
                .Age = param.Age,
                .Address = param.Address,
                .Gender = param.Gender,
                .Occupation = param.Occupation,
                .CreatedBy = param.CreatedBy
        })
    End Function

    Public Function PatientEdit(param As PatientEdit) As Long Implements IPatientService.PatientEdit
        Return patientService.PatientEdit(
            New DAL.PatientEdit With {
                .ID = param.ID,
                .PatientMaritalStatusID = param.PatientMaritalStatusID,
                .Firstname = param.Firstname,
                .Lastname = param.Lastname,
                .MiddleInitial = param.MiddleInitial,
                .Age = param.Age,
                .Address = param.Address,
                .Gender = param.Gender,
                .Occupation = param.Occupation,
                .UpdatedBy = param.UpdatedBy
        })
    End Function

    Public Function PatientSearchID(id As Long) As List(Of PatientView) Implements IPatientService.PatientSearchID
        Dim datas As List(Of PatientView) =
            (From data As DAL.PatientView In patientService.PatientSearchID(id)
             Select New PatientView With {
                    .ID = data.ID,
                    .PatientMaritalStatusID = data.PatientMaritalStatusID,
                    .Firstname = data.Firstname,
                    .Lastname = data.Lastname,
                    .MiddleInitial = data.MiddleInitial,
                    .Address = data.Address,
                    .Age = data.Age,
                    .Occupation = data.Occupation,
                    .Gender = data.Gender,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate,
                    .MaritalStatus = data.MaritalStatus
                 }
                ).ToList()
        Return datas
    End Function

    Public Function PatientSearchAge(age As Long) As List(Of PatientView) Implements IPatientService.PatientSearchAge
        Dim datas As List(Of PatientView) =
            (From data As DAL.PatientView In patientService.PatientSearchAge(age)
             Select New PatientView With {
                    .ID = data.ID,
                    .PatientMaritalStatusID = data.PatientMaritalStatusID,
                    .Firstname = data.Firstname,
                    .Lastname = data.Lastname,
                    .MiddleInitial = data.MiddleInitial,
                    .Address = data.Address,
                    .Age = data.Age,
                    .Occupation = data.Occupation,
                    .Gender = data.Gender,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate,
                    .MaritalStatus = data.MaritalStatus
                 }
                ).ToList()
        Return datas
    End Function

    Public Function PatientSearchLike(searchText As String) As List(Of PatientView) Implements IPatientService.PatientSearchLike
        Dim datas As List(Of PatientView) =
            (From data As DAL.PatientView In patientService.PatientSearchLike(searchText)
             Select New PatientView With {
                    .ID = data.ID,
                    .PatientMaritalStatusID = data.PatientMaritalStatusID,
                    .Firstname = data.Firstname,
                    .Lastname = data.Lastname,
                    .MiddleInitial = data.MiddleInitial,
                    .Address = data.Address,
                    .Age = data.Age,
                    .Occupation = data.Occupation,
                    .Gender = data.Gender,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate,
                    .MaritalStatus = data.MaritalStatus
                 }
                ).ToList()
        Return datas
    End Function
End Class
