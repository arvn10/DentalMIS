Imports DentalMIS.MODEL
Public Interface IProcedureTypeService
    Function ProcedureTypeCreate(param As ProcedureType) As Long
    Function ProcedureTypeEdit(param As ProcedureType) As Long
    Function ProcedureTypeSearchID(id As Long) As ProcedureType
    Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType)
    Function ProcedureTypeSearchTooth(patientID As Long, toothNumber As Integer) As List(Of ProcedureType)

    Function ProcedureTypePairCreate(param As ProcedureTypePair) As Long
    Function ProcedureTypePairEdit(param As ProcedureTypePair) As Long
    Function ProcedureTypePairSelect(procedureID As Long) As List(Of ProcedureTypePair)
    Function ProcedureTypePairSelectID(id As Long) As ProcedureTypePair
    Function ProcedureTypeSearch() As List(Of ProcedureType)
End Interface
