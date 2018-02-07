Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class ProcedureTypeService
    Implements IProcedureTypeService

    Private procedureTypeService As ProcedureTypeRepository

    Public Sub New()
        procedureTypeService = New ProcedureTypeRepository
    End Sub

    Public Function ProcedureTypeCreate(param As ProcedureType) As Long Implements IProcedureTypeService.ProcedureTypeCreate
        Return procedureTypeService.ProcedureTypeCreate(param)
    End Function

    Public Function ProcedureTypeEdit(param As ProcedureType) As Long Implements IProcedureTypeService.ProcedureTypeEdit
        Return procedureTypeService.ProcedureTypeEdit(param)
    End Function

    Public Function ProcedureTypeSearchID(id As Long) As ProcedureType Implements IProcedureTypeService.ProcedureTypeSearchID
        Dim data As New ProcedureType
        Dim repoData As New ProcedureType
        repoData = procedureTypeService.ProcedureTypeSearchID(id)
        data.ID = repoData.ID
        data.Name = repoData.Name
        data.BasePrice = repoData.BasePrice
        data.PaymentType = repoData.PaymentType
        data.RequireMedCert = repoData.RequireMedCert
        data.Status = repoData.Status
        data.CreatedBy = repoData.CreatedBy
        data.CreatedDate = repoData.CreatedDate
        data.UpdatedBy = repoData.UpdatedBy
        data.UpdatedDate = repoData.UpdatedDate
        Return data
    End Function

    Public Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearchLike
        Dim datas As List(Of ProcedureType) =
            (From data As ProcedureType In procedureTypeService.ProcedureTypeSearchLike(searchText)
             Select New ProcedureType With {
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

    Public Function ProcedureTypeSearchRequireMedCert(requireMedCert As Integer) As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearchRequireMedCert
        Dim datas As List(Of ProcedureType) =
            (From data As ProcedureType In procedureTypeService.ProcedureTypeSearchRequireMedCert(requireMedCert)
             Select New ProcedureType With {
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

    Public Function ProcedureTypeSearchStatus(status As Integer) As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearchStatus
        Dim datas As List(Of ProcedureType) =
            (From data As ProcedureType In procedureTypeService.ProcedureTypeSearchStatus(status)
             Select New ProcedureType With {
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
