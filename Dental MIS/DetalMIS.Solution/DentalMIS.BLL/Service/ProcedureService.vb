Imports DentalMIS.BLL
Imports DentalMIS.DAL
Public Class ProcedureService
    Implements IProcedureService
    Private procedureService As ProcedureRepository
    Public Sub New()
        procedureService = New ProcedureRepository
    End Sub

    Public Function ProcedureCreate(param As ProcedureCreate) As Long Implements IProcedureService.ProcedureCreate
        Return procedureService.ProcedureCreate(New DAL.ProcedureCreate With {
                                                    .PatientID = param.PatientID,
                                                    .ProcedureTypeID = param.ProcedureTypeID,
                                                    .DoctorID = param.DoctorID,
                                                    .Notes = param.Notes,
                                                    .Prescription = param.Prescription,
                                                    .ProcedureDate = param.ProcedureDate,
                                                    .Status = param.Status,
                                                    .CreatedBy = param.CreatedBy
                                                })
    End Function

    Public Function ProcedureEdit(param As ProcedureEdit) As Long Implements IProcedureService.ProcedureEdit
        Return procedureService.ProcedureEdit(New DAL.ProcedureEdit With {
                                                    .ID = param.ID,
                                                    .PatientID = param.PatientID,
                                                    .ProcedureTypeID = param.ProcedureTypeID,
                                                    .DoctorID = param.DoctorID,
                                                    .Notes = param.Notes,
                                                    .Prescription = param.Prescription,
                                                    .ProcedureDate = param.ProcedureDate,
                                                    .Status = param.Status,
                                                    .UpdatedBy = param.UpdatedBy
                                                })
    End Function

    Public Function ProcedureSearchID(id As Long) As List(Of ProcedureView) Implements IProcedureService.ProcedureSearchID
        Dim data As List(Of ProcedureView) = (From procedure As DAL.ProcedureView In procedureService.ProcedureSearchID(id)
                                              Select New ProcedureView With {
                                                  .ID = procedure.ID,
                                                  .PatientID = procedure.PatientID,
                                                  .ProcedureTypeID = procedure.ProcedureTypeID,
                                                  .DoctorID = procedure.DoctorID,
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

    Public Function ProcedureSearchLike(searchText As Long) As List(Of ProcedureView) Implements IProcedureService.ProcedureSearchLike
        Dim data As List(Of ProcedureView) = (From procedure As DAL.ProcedureView In procedureService.ProcedureSearchLike(searchText)
                                              Select New ProcedureView With {
                                                  .ID = procedure.ID,
                                                  .PatientID = procedure.PatientID,
                                                  .ProcedureTypeID = procedure.ProcedureTypeID,
                                                  .DoctorID = procedure.DoctorID,
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
