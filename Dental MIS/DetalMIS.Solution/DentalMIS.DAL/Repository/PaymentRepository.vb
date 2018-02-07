Imports DentalMIS.MODEL
Public Class PaymentRepository
    Inherits Database
#Region "Declaration"

#End Region

#Region "Constructor"

#End Region

#Region "Method"
    Public Function PaymentCreate(param As Payment) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_payment_create`({0}, {1}, '{3}', '{4}')",
                                                    param.ProcedureID,
                                                    param.AmountPaid,
                                                    param.TransactionDate,
                                                    param.CreatedBy
                                               )
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PaymentEdit(param As Payment) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_payment_edit`({0}, {2}, '{3}', '{4}', '{5}')",
                                                    param.ID,
                                                    param.ProcedureID,
                                                    param.AmountPaid,
                                                    param.TransactionDate,
                                                    param.CreatedBy
                                               )

        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PaymentSearchID(id As Long) As Payment
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_payment_search_id` ({0})", id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim payment As New Payment

        If dt.Rows.Count > 0 Then
            payment.ID = Convert.ToInt32(dt.Rows(0)("id"))
            payment.ProcedureID = Convert.ToInt32(dt.Rows(0)("procedure_id"))
            payment.TransactionDate = dt.Rows(0)("date").ToString()
            payment.Status = Convert.ToString(dt.Rows(0)("status"))
            payment.CreatedBy = Convert.ToString(dt.Rows(0)("created_by"))
            payment.CreatedDate = If(IsDBNull(dt.Rows(0)("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dt.Rows(0)("created_date")))
            payment.UpdatedBy = Convert.ToString(dt.Rows(0)("updated_by"))
            payment.UpdatedDate = If(IsDBNull(dt.Rows(0)("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dt.Rows(0)("updated_date")))
        End If

        Return payment
    End Function

    Public Function PaymentSearchProcedureID(procedureID As Long) As List(Of Payment)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_payment_search_procedure_id` ({0})", procedureID)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of Payment)
        data = (From dr As DataRow In dt.Rows
                Select New Payment With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt32(dr("procedure_id")),
                    .TransactionDate = dt.Rows(0)("date").ToString(),
                    .Status = Convert.ToString(dr("status")),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()
        Return data
    End Function
#End Region

#Region "Private Method"

#End Region
End Class
