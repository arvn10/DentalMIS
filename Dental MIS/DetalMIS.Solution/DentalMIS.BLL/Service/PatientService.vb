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
        Dim datas As Patient =
            (From data As Patient In patientService.PatientSearchID(id)
             Select New Patient With {
                    .ID = data.ID,
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
                    .UpdatedDate = data.UpdatedDate
                 }
                ).FirstOrDefault()
        Return datas
    End Function

    Public Function PatientSearchAge(age As Long) As List(Of Patient) Implements IPatientService.PatientSearchAge
        Dim datas As List(Of Patient) =
            (From data As Patient In patientService.PatientSearchAge(age)
             Select New Patient With {
                    .ID = data.ID,
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
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function PatientSearchLike(searchText As String) As List(Of Patient) Implements IPatientService.PatientSearchLike
        Dim datas As List(Of Patient) =
            (From data As Patient In patientService.PatientSearchLike(searchText)
             Select New Patient With {
                    .ID = data.ID,
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
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function
End Class
