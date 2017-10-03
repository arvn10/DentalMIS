Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class UserTypeService
    Implements IUserTypeService
    Private userTypeRepository As UserTypeRepository
    Public Sub New()
        userTypeRepository = New UserTypeRepository()
    End Sub

    Public Function UserTypeCreate(param As UserTypeModel) As Long Implements IUserTypeService.UserTypeCreate
        Return userTypeRepository.UserTypeCreate(New UserType With {
                                                    .Name = param.Name,
                                                    .CreatedBy = param.CreatedBy
                                                })
    End Function

    Public Function UserTypeUpdate(param As UserTypeModel) As Long Implements IUserTypeService.UserTypeUpdate
        Return userTypeRepository.UserTypeUpdate(New UserType With {
                                                    .ID = param.ID,
                                                    .Name = param.Name,
                                                    .UpdatedBy = param.UpdatedBy
                                                })
    End Function

    Public Function UserTypeGet() As List(Of UserTypeModel) Implements IUserTypeService.UserTypeGet
        Return (From data As UserType In userTypeRepository.UserTypeGet
                Select New UserTypeModel With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                }).ToList()
    End Function
End Class
