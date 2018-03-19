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

    Public Function ProcedureTypePairCreate(param As ProcedureTypePair) As Long Implements IProcedureTypeService.ProcedureTypePairCreate
        Return procedureTypeService.ProcedureTypePairCreate(param)
    End Function

    Public Function ProcedureTypePairEdit(param As ProcedureTypePair) As Long Implements IProcedureTypeService.ProcedureTypePairEdit
        Return procedureTypeService.ProcedureTypePairEdit(param)
    End Function

    Public Function ProcedureTypePairSelect(procedureID As Long) As List(Of ProcedureTypePair) Implements IProcedureTypeService.ProcedureTypePairSelect
        Return procedureTypeService.ProcedureTypePairSelect(procedureID)
    End Function

    Public Function ProcedureTypePairSelectID(id As Long) As ProcedureTypePair Implements IProcedureTypeService.ProcedureTypePairSelectID
        Return procedureTypeService.ProcedureTypePairSelectID(id)
    End Function

    Public Function ProcedureTypeSearch() As List(Of ProcedureType) Implements IProcedureTypeService.ProcedureTypeSearch
        Return procedureTypeService.ProcedureTypeSearch()
    End Function
End Class
