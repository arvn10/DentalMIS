Imports DentalMIS.MODEL
Public Class ProcedureRepository
    Inherits Database

    Public Function ProcedureCreate(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_create`({0}, {1}, {2}, {3}, '{4}', '{5}', '{6}')",
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.ToothNumber,
                                                param.AmountToPay,
                                                param.Notes,
                                                param.ProcedureDate,
                                                param.ProcedureCreatedBy)
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function ProcedureEdit(param As Procedure) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_procedure_create`({0}, {1}, {2}, {3}, {4}, '{5}', '{6}', '{7}')",
                                                param.ID,
                                                param.PatientID,
                                                param.ProcedureTypeID,
                                                param.ToothNumber,
                                                param.AmountToPay,
                                                param.Notes,
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
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ToothNumber = Convert.ToInt64(dr("tooth_number")),
                    .Tooth = dr("tooth").ToString(),
                    .Notes = dr("notes").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
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
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ToothNumber = Convert.ToInt64(dr("tooth_number")),
                    .Tooth = dr("tooth").ToString(),
                    .Notes = dr("notes").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
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
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ToothNumber = Convert.ToInt64(dr("tooth_number")),
                    .Tooth = dr("tooth").ToString(),
                    .Notes = dr("notes").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
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
                    .ProcedureName = dr("procedure_name").ToString(),
                    .ToothNumber = Convert.ToInt64(dr("tooth_number")),
                    .Tooth = dr("tooth").ToString(),
                    .Notes = dr("notes").ToString(),
                    .ProcedureDate = Convert.ToDateTime(dr("procedure_date")),
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

End Class
