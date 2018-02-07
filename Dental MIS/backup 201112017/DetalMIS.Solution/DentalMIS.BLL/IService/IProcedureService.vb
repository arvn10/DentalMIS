Public Interface IProcedureService
    Function ProcedureCreate(param As Procedure) As Long
    Function ProcedureEdit(param As Procedure) As Long
    Function ProcedureSearchID(id As Long) As List(Of Procedure)
    Function ProcedureSearchLike(searchText As Long) As List(Of Procedure)
End Interface
