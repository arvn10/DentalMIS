Imports DentalMIS.MODEL
Public Class SecretQuestionRepository
    Inherits Database

    Public Function SecretQuestionCreate(param As SecretQuestion) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_secret_question_create`('{param.Question}','{param.CreatedBy}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Return dt.Rows(0)(0)
    End Function

    Public Function SecretQuestionEdit(param As SecretQuestion) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_secret_question_edit`({param.ID}, '{param.Question}', '{param.CreatedBy}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Return dt.Rows(0)(0)
    End Function

    Public Function SecretQuestionSelect(searchText As String) As List(Of SecretQuestion)
        Dim procedure As String = $"CALL `dental_mis`.`usp_secret_question_select`('{searchText}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of SecretQuestion) = (From dr As DataRow In dt.Rows
                                               Select New SecretQuestion With {
                                                   .ID = Convert.ToInt64(dr("id")),
                                                   .Question = Convert.ToString(dr("question")),
                                                   .CreatedBy = dr("created_by").ToString(),
                                                   .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                                                   .UpdatedBy = dr("updated_by").ToString(),
                                                   .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                                               }
                                              ).ToList()
        Return data
    End Function

    Public Function SecretQuestionSelectID(id As Long) As SecretQuestion
        Dim procedure As String = $"CALL `dental_mis`.`usp_secret_question_select_id`({id});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New SecretQuestion
        data = (From dr As DataRow In dt.Rows
                Select New SecretQuestion With {
                    .ID = Convert.ToInt64(dr("id")),
                    .Question = Convert.ToString(dr("question")),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }
               ).FirstOrDefault()
        Return data
    End Function
End Class
