Public Class DoctorRepository
    Inherits Database
    Public Function DoctorCreate(param As DoctorCreate) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_doctor_create`({0}, {1}, {2}, {3}, {4})",
                                                param.Firstname,
                                                param.Lastname,
                                                param.MiddleInitial,
                                                param.Status,
                                                param.CreatedBy)

        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function DoctorEdit(param As DoctorEdit) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_doctor_edit`({0}, {1}, {2}, {3}, {4}, {5})",
                                                param.ID,
                                                param.Firstname,
                                                param.Lastname,
                                                param.MiddleInitial,
                                                param.Status,
                                                param.UpdatedBy)

        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function DoctorSearchID(id As Long) As List(Of DoctorView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_doctor_search_id`({0});",
                                                id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of DoctorView)

        data = (From dr As DataRow In dt.Rows
                Select New DoctorView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Firstname = dr("firstname").ToString(),
                    .MiddleInitial = dr("middle_initial").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function DoctorSearchID(searchText As String) As List(Of DoctorView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_doctor_search_like`('{0}');",
                                                searchText)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of DoctorView)

        data = (From dr As DataRow In dt.Rows
                Select New DoctorView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Firstname = dr("firstname").ToString(),
                    .MiddleInitial = dr("middle_initial").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function
End Class
