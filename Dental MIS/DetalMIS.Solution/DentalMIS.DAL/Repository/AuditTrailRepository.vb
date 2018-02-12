Imports DentalMIS.MODEL
Public Class AuditTrailRepository
    Inherits Database

    Public Sub AuditTrailCreate(param As AuditTrail)
        Dim procedure As String = $"CALL `dental_mis`.`usp_audit_trail_create`('{param.Action}', '{param.CreatedBy}')"
        ExecuteDataset(procedure)
    End Sub

    Public Function AuditTrailSelect([from] As String, [to] As String) As List(Of AuditTrail)
        Dim procedure As String = $"CALL `dental_mis`.`usp_audit_trail_select`('{[from]} 00:00:00', '{[to]} 23:59:59')"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of AuditTrail)
        data = (From dr As DataRow In dt.Rows
                Select New AuditTrail With {
                    .Action = Convert.ToString(dr("action")),
                    .CreatedBy = Convert.ToString(dr("created_by")),
                    .CreatedDate = Convert.ToDateTime(dr("created_date"))
                }).ToList()

        Return data
    End Function

End Class
