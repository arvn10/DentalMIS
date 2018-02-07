Imports DentalMIS.MODEL
Public Class ProcedureTypeRepository
    Inherits Database

#Region "Declaration"

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function ProcedureTypeCreate(param As ProcedureType) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_create`('{0}', {1}, '{2}', {3}, {4}, '{5}');", param.Name, param.BasePrice, param.PaymentType, param.RequireMedCert, param.Status, param.CreatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureTypeEdit(param As ProcedureType) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_edit`({0}, '{1}', {2}, '{3}', {4}, {5}, '{6}');", param.ID, param.Name, param.BasePrice, param.PaymentType, param.RequireMedCert, param.Status, param.UpdatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureTypeSearchID(id As Long) As ProcedureType
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_id`({0})",
                                                id)
        Dim data As New ProcedureType
        Dim dt As DataTable = ExecuteDataset(procedure)
        data.ID = Convert.ToInt32(dt.Rows(0)("id"))
        data.Name = dt.Rows(0)("name").ToString()
        data.BasePrice = Convert.ToDouble(dt.Rows(0)("base_price"))
        data.PaymentType = dt.Rows(0)("payment_type").ToString()
        data.RequireMedCert = dt.Rows(0)("require_med_cert")
        data.Status = dt.Rows(0)("status").ToString()
        data.CreatedBy = dt.Rows(0)("created_by").ToString()
        data.CreatedDate = If(IsDBNull(dt.Rows(0)("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dt.Rows(0)("created_date")))
        data.UpdatedBy = dt.Rows(0)("updated_by").ToString()
        data.UpdatedDate = If(IsDBNull(dt.Rows(0)("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dt.Rows(0)("updated_date")))

        Return data
    End Function

    Public Function ProcedureTypeSearchLike(searchText As String) As List(Of ProcedureType)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_like`('{0}')",
                                                searchText)
        Dim datas As List(Of ProcedureType)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .RequireMedCert = dr("require_med_cert"),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function ProcedureTypeSearchRequireMedCert(requireMedCert As Integer) As List(Of ProcedureType)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_require_med_cert`({0})",
                                                requireMedCert)
        Dim datas As List(Of ProcedureType)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .requireMedCert = dr("require_med_cert"),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function ProcedureTypeSearchStatus(status As Integer) As List(Of ProcedureType)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_status`({0})",
                                                status)
        Dim datas As List(Of ProcedureType)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .RequireMedCert = dr("require_med_cert"),
                    .status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function
#End Region

#Region "Private Method"

#End Region

End Class
