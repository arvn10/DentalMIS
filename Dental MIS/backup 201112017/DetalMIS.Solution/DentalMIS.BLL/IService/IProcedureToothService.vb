Public Interface IProcedureToothService
    Function ProcedureToothCreate(param As ProcedureToothCreate) As Long
    Function ProcedureToothEdit(param As ProcedureToothEdit) As Long
    Function ProcedureToothSearchID(id As Long) As List(Of ProcedureToothView)
    Function ProcedureToothSearchProcedureID(procedureID As Long) As List(Of ProcedureToothView)
End Interface
