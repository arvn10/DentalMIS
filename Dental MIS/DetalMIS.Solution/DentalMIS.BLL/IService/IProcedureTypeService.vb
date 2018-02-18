Imports DentalMIS.MODEL
Public Interface IProcedureTypeService
    Function ProcedureTypeCreate(param As ProcedureType) As Long
    Function ProcedureTypeEdit(param As ProcedureType) As Long
    Function ProcedureTypeSearchID(id As Long) As ProcedureType
    Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType)
    Function ProcedureTypeSearchTooth(patientID As Long, toothNumber As Integer) As List(Of ProcedureType)

    Function ProcedureTypeNotAllowedCreate(param As ProcedureNotAllowed) As Long
    Function ProcedureTypeNotAllowedEdit(param As ProcedureNotAllowed) As Long
    Function ProcedureTypeNotAllowedSelect(procedureID As Long) As List(Of ProcedureNotAllowed)
    Function ProcedureTypeNotAllowedSelectID(id As Long) As ProcedureNotAllowed
End Interface
