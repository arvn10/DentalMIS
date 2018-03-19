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
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_create`('{0}', {1}, '{2}', {3}, '{4}', {5}, '{6}');",
                                                    param.Name,
                                                    param.BasePrice,
                                                    param.PaymentType,
                                                    param.RequireMedCert,
                                                    param.RequireTooth,
                                                    param.Status,
                                                    param.CreatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureTypeEdit(param As ProcedureType) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_edit`({0}, '{1}', {2}, '{3}', {4}, '{5}', {6}, '{7}');",
                                                param.ID,
                                                param.Name,
                                                param.BasePrice,
                                                param.PaymentType,
                                                param.RequireMedCert,
                                                param.RequireTooth,
                                                param.Status,
                                                param.UpdatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureTypeSearchID(id As Long) As ProcedureType
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_id`({0})",
                                                id)
        Dim data As New ProcedureType
        Dim dt As DataTable = ExecuteDataset(procedure)
        data = (From dr As DataRow In dt.Rows
                Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .RequireMedCert = dr("require_med_cert"),
                    .RequireTooth = dr("require_tooth").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).FirstOrDefault()
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
                    .RequireTooth = dr("require_tooth").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function ProcedureTypeSearch() As List(Of ProcedureType)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search`();")
        Dim datas As List(Of ProcedureType)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .RequireMedCert = dr("require_med_cert"),
                    .RequireTooth = dr("require_tooth").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function ProcedureTypeSearchTooth(patientID As Long, toothNumber As Integer) As List(Of ProcedureType)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_type_search_tooth`({0},{1})",
                                                patientID,
                                                toothNumber)
        Dim datas As List(Of ProcedureType)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New ProcedureType With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .BasePrice = Convert.ToDouble(dr("base_price")),
                    .PaymentType = dr("payment_type").ToString(),
                    .RequireMedCert = dr("require_med_cert"),
                    .RequireTooth = dr("require_tooth").ToString(),
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
                    .RequireMedCert = dr("require_med_cert"),
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
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function ProcedureTypePairCreate(param As ProcedureTypePair) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_type_pair_create`(
                                    {param.ProcedureID}, 
                                    {param.ProcedureIDPair}, 
                                    '{param.VisibilityType}',
                                    {param.Status}, 
                                    '{param.CreatedBy}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Return dt.Rows(0)(0)
    End Function

    Public Function ProcedureTypePairEdit(param As ProcedureTypePair) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_type_pair_edit`(
                                    {param.ID},
                                    {param.ProcedureID},
                                    {param.ProcedureIDPair}, 
                                    '{param.VisibilityType}',
                                    {param.Status}, 
                                    '{param.UpdatedBy}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Return dt.Rows(0)(0)
    End Function

    Public Function ProcedureTypePairSelect(procedureID As Long) As List(Of ProcedureTypePair)
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_type_pair_select`({procedureID});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureTypePair)
        data = (From dr As DataRow In dt.Rows
                Select New ProcedureTypePair With {
                    .ID = Convert.ToInt64(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_type_id")),
                    .ProcedureIDPair = Convert.ToInt64(dr("procedure_type_id_pair")),
                    .ProcedureName = Convert.ToString(dr("name")),
                    .VisibilityType = Convert.ToString(dr("visibility_type")),
                    .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }
               ).ToList()
        Return data
    End Function

    Public Function ProcedureTypePairSelectID(id As Long) As ProcedureTypePair
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_type_pair_select_id`({id});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New ProcedureTypePair
        data = (From dr As DataRow In dt.Rows
                Select New ProcedureTypePair With {
                    .ID = Convert.ToInt64(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_type_id")),
                    .ProcedureIDPair = Convert.ToInt64(dr("procedure_type_id_pair")),
                    .ProcedureName = Convert.ToString(dr("name")),
                    .VisibilityType = Convert.ToString(dr("visibility_type")),
                    .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }
               ).FirstOrDefault()
        Return data
    End Function
#End Region

#Region "Private Method"

#End Region

End Class
