Imports DentalMIS.MODEL
Public Interface IProcedureTypeService
    Function ProcedureTypeCreate(param As ProcedureType) As Long
    Function ProcedureTypeEdit(param As ProcedureType) As Long
    Function ProcedureTypeSearchID(id As Long) As ProcedureType
    Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType)
    Function ProcedureTypeSearchRequireMedCert(requireMedCert As Integer) As List(Of ProcedureType)
    Function ProcedureTypeSearchStatus(status As Integer) As List(Of ProcedureType)
End Interface
