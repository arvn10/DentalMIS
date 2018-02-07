Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class ProcedureTypeService
    Implements IProcedureTypeService

    Private procedureTypeService As DAL.ProcedureTypeRepository

    Public Sub New()
        procedureTypeService = New DAL.ProcedureTypeRepository
    End Sub

    Public Function ProcedureTypeCreate(param As ProcedureTypeCreate) As Long Implements IProcedureTypeService.ProcedureTypeCreate
        Return procedureTypeService.ProcedureTypeCreate(
            New DAL.ProcedureTypeCreate With {
                .Name = param.Name,
                .BasePrice = param.BasePrice,
                .PaymentType = param.PaymentType,
                .RequireMedCert = param.RequireMedCert,
                .Status = param.Status,
                .CreatedBy = param.CreatedBy
            }
        )
    End Function

    Public Function ProcedureTypeEdit(param As ProcedureTypeEdit) As Long Implements IProcedureTypeService.ProcedureTypeEdit
        Return procedureTypeService.ProcedureTypeEdit(
            New DAL.ProcedureTypeEdit With {
                .ID = param.ID,
                .Name = param.Name,
                .BasePrice = param.BasePrice,
                .PaymentType = param.PaymentType,
                .RequireMedCert = param.RequireMedCert,
                .Status = param.Status,
                .UpdatedBy = param.UpdatedBy
            }
        )
    End Function

    Public Function ProcedureTypeSearchID(id As Long) As List(Of ProcedureTypeView) Implements IProcedureTypeService.ProcedureTypeSearchID
        Dim datas As List(Of ProcedureTypeView) =
            (From data As DAL.ProcedureTypeView In procedureTypeService.ProcedureTypeSearchID(id)
             Select New ProcedureTypeView With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .BasePrice = data.BasePrice,
                    .PaymentType = data.PaymentType,
                    .RequireMedCert = data.RequireMedCert,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureTypeView) Implements IProcedureTypeService.ProcedureTypeSearchLike
        Dim datas As List(Of ProcedureTypeView) =
            (From data As DAL.ProcedureTypeView In procedureTypeService.ProcedureTypeSearchLike(searchText)
             Select New ProcedureTypeView With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .BasePrice = data.BasePrice,
                    .PaymentType = data.PaymentType,
                    .RequireMedCert = data.RequireMedCert,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function ProcedureTypeSearchRequireMedCert(requireMedCert As Integer) As List(Of ProcedureTypeView) Implements IProcedureTypeService.ProcedureTypeSearchRequireMedCert
        Dim datas As List(Of ProcedureTypeView) =
            (From data As DAL.ProcedureTypeView In procedureTypeService.ProcedureTypeSearchRequireMedCert(requireMedCert)
             Select New ProcedureTypeView With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .BasePrice = data.BasePrice,
                    .PaymentType = data.PaymentType,
                    .RequireMedCert = data.RequireMedCert,
                    .Status = data.Status,
                    .CreatedBy = data.CreatedBy,
                    .CreatedDate = data.CreatedDate,
                    .UpdatedBy = data.UpdatedBy,
                    .UpdatedDate = data.UpdatedDate
                 }
                ).ToList()
        Return datas
    End Function

    Public Function ProcedureTypeSearchStatus(status As Integer) As List(Of ProcedureTypeView) Implements IProcedureTypeService.ProcedureTypeSearchStatus
        Dim datas As List(Of ProcedureTypeView) =
            (From data As DAL.ProcedureTypeView In procedureTypeService.ProcedureTypeSearchStatus(status)
             Select New ProcedureTypeView With {
                    .ID = data.ID,
                    .Name = data.Name,
                    .BasePrice = data.BasePrice,
                    .PaymentType = data.PaymentType,
                    .RequireMedCert = data.RequireMedCert,
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
