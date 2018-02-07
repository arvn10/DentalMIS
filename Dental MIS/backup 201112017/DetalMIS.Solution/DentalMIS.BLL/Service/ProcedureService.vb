Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class ProcedureService
    Implements IProcedureService
    Private procedureService As ProcedureRepository
    Public Sub New()
        procedureService = New ProcedureRepository
    End Sub

    Public Function ProcedureCreate(param As Procedure) As Long Implements IProcedureService.ProcedureCreate
        Return procedureService.ProcedureCreate(New DAL.Procedure With {
                                                    .PatientID = param.PatientID,
                                                    .ProcedureTypeID = param.ProcedureTypeID,
                                                    .Notes = param.Notes,
                                                    .Prescription = param.Prescription,
                                                    .ProcedureDate = param.ProcedureDate,
                                                    .Status = param.Status,
                                                    .CreatedBy = param.CreatedBy
                                                })
    End Function

    Public Function ProcedureEdit(param As Procedure) As Long Implements IProcedureService.ProcedureEdit
        Return procedureService.ProcedureEdit(New DAL.Procedure With {
                                                    .ID = param.ID,
                                                    .PatientID = param.PatientID,
                                                    .ProcedureTypeID = param.ProcedureTypeID,
                                                    .Notes = param.Notes,
                                                    .Prescription = param.Prescription,
                                                    .ProcedureDate = param.ProcedureDate,
                                                    .Status = param.Status,
                                                    .UpdatedBy = param.UpdatedBy
                                                })
    End Function

    Public Function ProcedureSearchID(id As Long) As List(Of Procedure) Implements IProcedureService.ProcedureSearchID
        Dim data As List(Of Procedure) = (From procedure As DAL.Procedure In procedureService.ProcedureSearchID(id)
                                          Select New Procedure With {
                                                  .ID = procedure.ID,
                                                  .PatientID = procedure.PatientID,
                                                  .ProcedureTypeID = procedure.ProcedureTypeID,
                                                  .Notes = procedure.Notes,
                                                  .Prescription = procedure.Prescription,
                                                  .ProcedureDate = procedure.ProcedureDate,
                                                  .Status = procedure.Status,
                                                  .CreatedBy = procedure.CreatedBy,
                                                  .CreatedDate = procedure.CreatedDate,
                                                  .UpdatedBy = procedure.UpdatedBy,
                                                  .UpdatedDate = procedure.UpdatedDate
                                              }
                                             )
        Return data
    End Function

    Public Function ProcedureSearchLike(searchText As Long) As List(Of Procedure) Implements IProcedureService.ProcedureSearchLike
        Dim data As List(Of Procedure) = (From procedure As DAL.Procedure In procedureService.ProcedureSearchLike(searchText)
                                          Select New Procedure With {
                                                  .ID = procedure.ID,
                                                  .PatientID = procedure.PatientID,
                                                  .ProcedureTypeID = procedure.ProcedureTypeID,
                                                  .Notes = procedure.Notes,
                                                  .Prescription = procedure.Prescription,
                                                  .ProcedureDate = procedure.ProcedureDate,
                                                  .Status = procedure.Status,
                                                  .CreatedBy = procedure.CreatedBy,
                                                  .CreatedDate = procedure.CreatedDate,
                                                  .UpdatedBy = procedure.UpdatedBy,
                                                  .UpdatedDate = procedure.UpdatedDate
                                              }
                                             )
        Return data
    End Function
End Class
