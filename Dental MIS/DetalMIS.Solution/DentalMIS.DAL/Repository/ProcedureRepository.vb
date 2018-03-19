Imports DentalMIS.MODEL
Public Class ProcedureRepository
    Inherits Database

    Public Function ProcedureCreate(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_create`({0}, {1}, {2}, '{3}', '{4}')",
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.AmountToPay,
                                                param.ProcedureDate,
                                                param.ProcedureCreatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureEdit(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_edit`({0}, {1}, {2}, {3}, '{4}', '{5}')",
                                                param.ID,
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.AmountToPay,
                                                param.ProcedureDate,
                                                param.ProcedureUpdatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureSearchID(id As Long) As Procedure
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_search_id`({0});",
                                                id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New Procedure

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .FullName = dr("full_name").ToString(),
                    .Age = Convert.ToInt32(dr("age")),
                    .Address = Convert.ToString(dr("address")),
                    .Gender = Convert.ToString(dr("gender")),
                    .Tooth = Convert.ToString(dr("tooth")),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
                    .PaymentType = Convert.ToString(dr("payment_type")),
                    .AmountToPay = Convert.ToDouble(dr("amount_to_pay")),
                    .AmountPaid = Convert.ToDouble(dr("amount_paid")),
                    .Balance = Convert.ToDouble(dr("balance")),
                    .PaymentStatus = dr("payment_status").ToString(),
                    .ProcedureCreatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureCreatedDate = If(IsDBNull(dr("procedure_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_created_date"))),
                    .ProcedureUpdatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureUpdatedDate = If(IsDBNull(dr("procedure_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_updated_date"))),
                    .PaymentCreatedBy = dr("payment_created_by").ToString(),
                    .PaymentCreatedDate = If(IsDBNull(dr("payment_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_created_date"))),
                    .PaymentUpdatedBy = dr("payment_created_by").ToString(),
                    .PaymentUpdatedDate = If(IsDBNull(dr("payment_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_updated_date")))
                 }).FirstOrDefault()
        Return data
    End Function

    Public Function ProcedureSearchPatientID(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of Procedure)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_search_patient_id`({0}, '{1}', '{2}', '{3}');",
                                                patientID,
                                                toothNumber,
                                                [from],
                                                [to])
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of Procedure)

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                     .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .FullName = dr("full_name").ToString(),
                    .Age = Convert.ToInt32(dr("age")),
                    .Address = Convert.ToString(dr("address")),
                    .Gender = Convert.ToString(dr("gender")),
                    .Tooth = Convert.ToString(dr("tooth")),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
                    .PaymentType = Convert.ToString(dr("payment_type")),
                    .AmountToPay = Convert.ToDouble(dr("amount_to_pay")),
                    .AmountPaid = Convert.ToDouble(dr("amount_paid")),
                    .Balance = Convert.ToDouble(dr("balance")),
                    .PaymentStatus = dr("payment_status").ToString(),
                    .ProcedureCreatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureCreatedDate = If(IsDBNull(dr("procedure_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_created_date"))),
                    .ProcedureUpdatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureUpdatedDate = If(IsDBNull(dr("procedure_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_updated_date"))),
                    .PaymentCreatedBy = dr("payment_created_by").ToString(),
                    .PaymentCreatedDate = If(IsDBNull(dr("payment_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_created_date"))),
                    .PaymentUpdatedBy = dr("payment_created_by").ToString(),
                    .PaymentUpdatedDate = If(IsDBNull(dr("payment_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureSearchPaymentStatus(paymentStatus As String) As List(Of Procedure)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_payment_search_status`('{0}');",
                                                paymentStatus)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of Procedure)

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                     .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .FullName = dr("full_name").ToString(),
                    .Age = Convert.ToInt32(dr("age")),
                    .Address = Convert.ToString(dr("address")),
                    .Gender = Convert.ToString(dr("gender")),
                    .Tooth = Convert.ToString(dr("tooth")),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
                    .PaymentType = Convert.ToString(dr("payment_type")),
                    .AmountToPay = Convert.ToDouble(dr("amount_to_pay")),
                    .AmountPaid = Convert.ToDouble(dr("amount_paid")),
                    .Balance = Convert.ToDouble(dr("balance")),
                    .PaymentStatus = dr("payment_status").ToString(),
                    .ProcedureCreatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureCreatedDate = If(IsDBNull(dr("procedure_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_created_date"))),
                    .ProcedureUpdatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureUpdatedDate = If(IsDBNull(dr("procedure_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_updated_date"))),
                    .PaymentCreatedBy = dr("payment_created_by").ToString(),
                    .PaymentCreatedDate = If(IsDBNull(dr("payment_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_created_date"))),
                    .PaymentUpdatedBy = dr("payment_created_by").ToString(),
                    .PaymentUpdatedDate = If(IsDBNull(dr("payment_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureSearchPaymentLike(searchText As String) As List(Of Procedure)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_payment_search_like`('{0}');",
                                                searchText)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of Procedure)

        data = (From dr As DataRow In dt.Rows
                Select New Procedure With {
                     .ID = Convert.ToInt32(dr("id")),
                    .PatientID = Convert.ToInt32(dr("patient_id")),
                    .ProcedureTypeID = Convert.ToInt32(dr("procedure_type_id")),
                    .FullName = dr("full_name").ToString(),
                    .Age = Convert.ToInt32(dr("age")),
                    .Address = Convert.ToString(dr("address")),
                    .Gender = Convert.ToString(dr("gender")),
                    .Tooth = Convert.ToString(dr("tooth")),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
                    .PaymentType = Convert.ToString(dr("payment_type")),
                    .AmountToPay = Convert.ToDouble(dr("amount_to_pay")),
                    .AmountPaid = Convert.ToDouble(dr("amount_paid")),
                    .Balance = Convert.ToDouble(dr("balance")),
                    .PaymentStatus = dr("payment_status").ToString(),
                    .ProcedureCreatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureCreatedDate = If(IsDBNull(dr("procedure_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_created_date"))),
                    .ProcedureUpdatedBy = dr("procedure_created_by").ToString(),
                    .ProcedureUpdatedDate = If(IsDBNull(dr("procedure_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("procedure_updated_date"))),
                    .PaymentCreatedBy = dr("payment_created_by").ToString(),
                    .PaymentCreatedDate = If(IsDBNull(dr("payment_created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_created_date"))),
                    .PaymentUpdatedBy = dr("payment_created_by").ToString(),
                    .PaymentUpdatedDate = If(IsDBNull(dr("payment_updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("payment_updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureSearchPaymentReport(paymentStatus As String, [from] As Date, [to] As Date) As List(Of ProcedureReport)
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_payment_search_report`('{paymentStatus}', '{[from].ToString("yyyy-MM-dd")}', '{[to].ToString("yyyy-MM-dd")}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureReport)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureReport With {
                    .FullName = dr("full_name").ToString(),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
                    .AmountToPay = Convert.ToDouble(dr("amount_to_pay")),
                    .AmountPaid = Convert.ToDouble(dr("amount_paid")),
                    .Balance = Convert.ToDouble(dr("balance")),
                    .PaymentStatus = Convert.ToString(dr("payment_status"))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureSearchProcedureReport(patientID As Long, toothNumber As String, [from] As String, [to] As String) As List(Of ProcedureHistoryReport)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_search_patient_id`({0}, '{1}', '{2}', '{3}');",
                                                patientID,
                                                toothNumber,
                                                [from],
                                                [to])
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureHistoryReport)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureHistoryReport With {
                    .Tooth = IIf(String.IsNullOrEmpty(Convert.ToString(dr("tooth"))), "", Convert.ToString(dr("tooth"))),
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")).Date
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureToothCreate(param As ProcedureTooth) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_tooth_create`({param.ProcedureID}, {param.ToothID}, '{param.CreatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureToothEdit(param As ProcedureTooth) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_tooth_edit`({param.ID}, {param.ToothID}, '{param.UpdatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureToothSelectProcedureID(procedureID As Long) As List(Of ProcedureTooth)
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_tooth_select_procedure_id`({procedureID});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureTooth)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureTooth With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .ToothID = Convert.ToInt64(dr("tooth_id")),
                    .Tooth = Convert.ToString(dr("tooth"))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureToothSelectID(id As Long) As ProcedureTooth
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_tooth_select_id`({id});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New ProcedureTooth

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureTooth With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .ToothID = Convert.ToInt64(dr("tooth_id")),
                    .Tooth = Convert.ToString(dr("tooth"))
                 }).FirstOrDefault()
        Return data
    End Function

    Public Function ProcedureRemarkCreate(param As ProcedureRemark) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_remark_create`(
                                    {param.ProcedureID}, 
                                    '{param.Remark}', 
                                    '{param.DateAdded.ToString("yyyy-MM-dd")}', 
                                    '{param.CreatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureRemarkEdit(param As ProcedureRemark) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_remark_edit`(
                                    {param.ID},
                                    '{param.Remark}', 
                                    '{param.DateAdded.ToString("yyyy-MM-dd")}', 
                                    '{param.UpdatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureRemarkSelectProcedureID(procedureID As Long) As List(Of ProcedureRemark)
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_remark_select_procedure_id`({procedureID});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New List(Of ProcedureRemark)

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureRemark With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .Remark = Convert.ToString(dr("value")),
                    .DateAdded = Convert.ToDateTime(dr("date_added")).Date,
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return data
    End Function

    Public Function ProcedureRemarkSelectID(id As Long) As ProcedureRemark
        Dim procedure As String = $"CALL `dental_mis`.`usp_procedure_remark_select_id`({id});"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As New ProcedureRemark

        data = (From dr As DataRow In dt.Rows
                Select New ProcedureRemark With {
                    .ID = Convert.ToInt32(dr("id")),
                    .ProcedureID = Convert.ToInt64(dr("procedure_id")),
                    .Remark = Convert.ToString(dr("value")),
                    .DateAdded = Convert.ToDateTime(dr("date_added")).Date,
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).FirstOrDefault()
        Return data
    End Function
End Class
