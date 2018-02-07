Imports DentalMIS.MODEL
Public Class UserTypeRepository
    Inherits Database

    Public Function UserTypeCreate(param As UserType) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_type_create`('{1}', '{2}')",
                          param.Name,
                          param.CreatedBy)

        Dim id As Long = ExecuteDataset(procedure).Rows(0)(0)

        Return id
    End Function

    Public Function UserTypeUpdate(param As UserType) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_type_edit`({0}, '{1}', '{2}')",
                          param.ID,
                          param.Name,
                          param.UpdatedBy)

        Dim id As Long = ExecuteDataset(procedure).Rows(0)(0)

        Return id
    End Function

    Public Function UserTypeGet() As List(Of UserType)
        Dim procedure As String = "SELECT id, name, created_by, created_date, updated_by, updated_date FROM `dental_mis`.`user_type`"

        Dim dt As DataTable = ExecuteDataset(procedure)

        If dt.Rows.Count > 0 Then
            Return (From dr As DataRow In dt.Rows
                    Select New UserType With {
                        .ID = Convert.ToInt64(dr("id")),
                        .Name = Convert.ToString(dr("name")),
                        .CreatedBy = dr("created_by").ToString(),
                        .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                        .UpdatedBy = dr("updated_by").ToString(),
                        .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                   }).ToList()
        Else
            Return New List(Of UserType)
        End If
    End Function
End Class
