Public Interface IProcedureService
    Function ProcedureCreate(param As ProcedureCreate) As Long
    Function ProcedureEdit(param As ProcedureEdit) As Long
    Function ProcedureSearchID(id As Long) As List(Of ProcedureView)
    Function ProcedureSearchLike(searchText As Long) As List(Of ProcedureView)
End Interface
