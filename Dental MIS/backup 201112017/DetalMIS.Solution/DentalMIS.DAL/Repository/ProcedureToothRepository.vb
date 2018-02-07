Public Class ProcedureToothRepository
    Inherits Database
    Public Function ProcedureToothCreate(param As ProcedureToothCreate) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_tooth_create`({0}, {1}, '{2}')",
                                                param.ProcedureID,
                                                param.ToothNumber,
                                                param.CreatedBy)
        Return Convert.ToInt64(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureToothEdit(param As ProcedureToothEdit) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_tooth_edit`({0}, {1}, {2}, '{3}')",
                                                param.ID,
                                                param.ProcedureID,
                                                param.ToothNumber,
                                                param.UpdatedBy)
        Return Convert.ToInt64(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureToothSearchID(id As Long) As List(Of ProcedureToothView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_tooth_search_id`({0});",
                                                id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureToothView)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureToothView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .ToothNumber = Convert.ToInt32(dr("tooth_number")),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureToothSearchProcedureID(procedureID As Long) As List(Of ProcedureToothView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_tooth_procedure_id`({0});",
                                                procedureID)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureToothView)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureToothView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .ToothNumber = Convert.ToInt32(dr("tooth_number")),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function
End Class
