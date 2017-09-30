Public Interface IProcedureTypeService
    Function ProcedureTypeCreate(param As ProcedureTypeCreate) As Long
    Function ProcedureTypeEdit(param As ProcedureTypeEdit) As Long
    Function ProcedureTypeSearchID(id As Long) As List(Of ProcedureTypeView)
    Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureTypeView)
    Function ProcedureTypeSearchRequireMedCert(requireMedCert As Integer) As List(Of ProcedureTypeView)
    Function ProcedureTypeSearchStatus(status As Integer) As List(Of ProcedureTypeView)
End Interface
