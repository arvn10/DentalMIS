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
        Return procedureTypeService.ProcedureTypeSearchID(id)
    End Function

    Public Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearchLike
        Return procedureTypeService.ProcedureTypeSearchLike(searchText)
    End Function

    Public Function ProcedureTypeSearchTooth(patientID As Long, toothNumber As Integer) As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearchTooth
        Return procedureTypeService.ProcedureTypeSearchTooth(patientID, toothNumber)
    End Function

    Public Function ProcedureTypeNotAllowedCreate(param As ProcedureNotAllowed) As Long Implements IProcedureTypeService.ProcedureTypeNotAllowedCreate
        Return procedureTypeService.ProcedureTypeNotAllowedCreate(param)
    End Function

    Public Function ProcedureTypeNotAllowedEdit(param As ProcedureNotAllowed) As Long Implements IProcedureTypeService.ProcedureTypeNotAllowedEdit
        Return procedureTypeService.ProcedureTypeNotAllowedEdit(param)
    End Function

    Public Function ProcedureTypeNotAllowedSelect(procedureID As Long) As List(Of ProcedureNotAllowed) Implements IProcedureTypeService.ProcedureTypeNotAllowedSelect
        Return procedureTypeService.ProcedureTypeNotAllowedSelect(procedureID)
    End Function

    Public Function ProcedureTypeNotAllowedSelectID(id As Long) As ProcedureNotAllowed Implements IProcedureTypeService.ProcedureTypeNotAllowedSelectID
        Return procedureTypeService.ProcedureTypeNotAllowedSelectID(id)
    End Function
End Class
