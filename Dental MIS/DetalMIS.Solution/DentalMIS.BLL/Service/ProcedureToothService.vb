Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class ProcedureToothService
    Implements IProcedureToothService
    Private procedureToothRepository As ProcedureToothRepository
    Public Sub New()
        procedureToothRepository = New ProcedureToothRepository
    End Sub
    Public Function ProcedureToothCreate(param As ProcedureToothCreate) As Long Implements IProcedureToothService.ProcedureToothCreate
        Return procedureToothRepository.ProcedureToothCreate(New DAL.ProcedureToothCreate With {
                                                             .ProcedureID = param.ProcedureID,
                                                             .ToothNumber = param.ToothNumber,
                                                             .CreatedBy = param.CreatedBy})
    End Function

    Public Function ProcedureToothEdit(param As ProcedureToothEdit) As Long Implements IProcedureToothService.ProcedureToothEdit
        Return procedureToothRepository.ProcedureToothEdit(New DAL.ProcedureToothEdit With {
                                                             .ID = param.ID,
                                                             .ProcedureID = param.ProcedureID,
                                                             .ToothNumber = param.ToothNumber,
                                                             .UpdatedBy = param.UpdatedBy})
    End Function

    Public Function ProcedureToothSearchID(id As Long) As List(Of ProcedureToothView) Implements IProcedureToothService.ProcedureToothSearchID
        Dim data As List(Of ProcedureToothView) = (From procedureTooth In procedureToothRepository.ProcedureToothSearchID(id)
                                                   Select New ProcedureToothView With {
                                                       .ID = procedureTooth.ID,
                                                       .ProcedureID = procedureTooth.ProcedureID,
                                                       .ToothNumber = procedureTooth.ToothNumber,
                                                       .CreatedBy = procedureTooth.CreatedBy,
                                                       .CreatedDate = procedureTooth.CreatedDate,
                                                       .UpdatedBy = procedureTooth.UpdatedBy,
                                                       .UpdatedDate = procedureTooth.UpdatedDate
                                                    })
        Return data
    End Function

    Public Function ProcedureToothSearchProcedureID(procedureID As Long) As List(Of ProcedureToothView) Implements IProcedureToothService.ProcedureToothSearchProcedureID
        Dim data As List(Of ProcedureToothView) = (From procedureTooth In procedureToothRepository.ProcedureToothSearchProcedureID(procedureID)
                                                   Select New ProcedureToothView With {
                                                       .ID = procedureTooth.ID,
                                                       .ProcedureID = procedureTooth.ProcedureID,
                                                       .ToothNumber = procedureTooth.ToothNumber,
                                                       .CreatedBy = procedureTooth.CreatedBy,
                                                       .CreatedDate = procedureTooth.CreatedDate,
                                                       .UpdatedBy = procedureTooth.UpdatedBy,
                                                       .UpdatedDate = procedureTooth.UpdatedDate
                                                    })
        Return data
    End Function
End Class
