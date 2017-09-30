Imports DentalMIS.BLL

Public Class DoctorService
    Implements IDoctorService
    Private doctorRepository As DAL.DoctorRepository
    Public Sub New()
        doctorRepository = New DAL.DoctorRepository
    End Sub
    Public Function DoctorCreate(param As DoctorCreate) As Object Implements IDoctorService.DoctorCreate
        Return doctorRepository.DoctorCreate(New DAL.DoctorCreate With {
                                                .Firstname = param.Firstname,
                                                .Lastname = param.Lastname,
                                                .MiddleInitial = param.MiddleInitial,
                                                .Status = param.Status,
                                                .CreatedBy = param.CreatedBy
                                            })
    End Function

    Public Function DoctorEdit(param As DoctorEdit) As Object Implements IDoctorService.DoctorEdit
        Return doctorRepository.DoctorEdit(New DAL.DoctorEdit With {
                                                .Firstname = param.Firstname,
                                                .Lastname = param.Lastname,
                                                .MiddleInitial = param.MiddleInitial,
                                                .Status = param.Status,
                                                .UpdatedBy = param.UpdatedBy
                                            })
    End Function

    Public Function DoctorSearchID(id As Long) As List(Of DoctorView) Implements IDoctorService.DoctorSearchID
        Dim data As List(Of DoctorView) = (From doctor In doctorRepository.DoctorSearchID(id)
                                           Select New DoctorView With {
                                               .ID = doctor.ID,
                                               .Firstname = doctor.Firstname,
                                               .Lastname = doctor.Lastname,
                                               .MiddleInitial = doctor.MiddleInitial,
                                               .Status = doctor.Status,
                                               .CreatedBy = doctor.CreatedBy,
                                               .CreatedDate = doctor.CreatedDate,
                                               .UpdatedBy = doctor.UpdatedBy,
                                               .UpdatedDate = doctor.UpdatedDate
                                            })
        Return data
    End Function
End Class
