Public Class ProcedureRepository
    Inherits Database

    Public Function ProcedureCreate(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_create`({0}, {1}, {2}, '{3}', '{4}', '{5}', '{6}', '{7}')",
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.Notes,
                                                param.Prescription,
                                                param.ProcedureDate,
                                                param.Status,
                                                param.CreatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureEdit(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_create`({0}, {1}, {2}, {3}, '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                param.ID,
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.Notes,
                                                param.Prescription,
                                                param.ProcedureDate,
                                                param.Status,
                                                param.UpdatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureSearchID(id As Long) As List(Of Procedure)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_search_id`({0});",
                                                id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of Procedure)

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .ProcedureName = dr("procedure_name"),
                    .Notes = dr("notes").ToString(),
                    .Prescription = dr("prescription").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("date")),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureSearchLike(searchText As Long) As List(Of Procedure)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_search_id`('{0}');",
                                                searchText)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of Procedure)

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .ProcedureName = dr("procedure_name"),
                    .Notes = dr("notes").ToString(),
                    .Prescription = dr("prescription").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("date")),
                    .Status = IIf(Convert.ToInt32(dr("status")) = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function
End Class
