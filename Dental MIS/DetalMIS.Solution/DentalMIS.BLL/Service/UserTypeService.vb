Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class UserTypeService
    Implements IUserTypeService
    Private userTypeRepository As UserTypeRepository
    Public Sub New()
        userTypeRepository = New UserTypeRepository()
    End Sub

    Public Function UserTypeCreate(param As UserType) As Long Implements IUserTypeService.UserTypeCreate
        Return userTypeRepository.UserTypeCreate(param)
    End Function

    Public Function UserTypeUpdate(param As UserType) As Long Implements IUserTypeService.UserTypeUpdate
        Return userTypeRepository.UserTypeUpdate(param)
    End Function

    Public Function UserTypeGet() As List(Of UserType) Implements IUserTypeService.UserTypeGet
        Return (From data As UserType In userTypeRepository.UserTypeGet
                Select New UserType With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                }).ToList()
    End Function
End Class
