Imports DentalMIS.DAL.Database
Imports DentalMIS.DAL.PatientMaritalStatusCreate
Imports DentalMIS.DAL.PatientMaritalStatusEdit
Imports DentalMIS.DAL.PatientMaritalStatusView
Public Class PatientMaritalStatusRepository
    Inherits Database

#Region "Declaration"
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function PatientMaritalStatusCreate(param As PatientMaritalStatusCreate) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_marital_status_create`('{0}', '{1}', '{2}')",
                                                param.Name,
                                                param.Status,
                                                param.CreatedBy)

        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientMaritalStatusEdit(param As PatientMaritalStatusEdit) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_marital_status_edit`({0}, '{1}', '{2}', '{3}')",
                                                param.ID,
                                                param.Name,
                                                param.Status,
                                                param.UpdatedBy)

        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientMaritalStatusSearchID(id As Long) As List(Of PatientMaritalStatusView)

        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_marital_status_search_id`({0})",
                                                id)
        Dim datas As List(Of PatientMaritalStatusView)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientMaritalStatusView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function PatientMaritalStatusSearchStatus(Status As Integer) As List(Of PatientMaritalStatusView)

        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_marital_status_search_status`({0})",
                                                Status)
        Dim datas As List(Of PatientMaritalStatusView)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientMaritalStatusView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()

        Return datas

    End Function

    Public Function PatientMaritalStatusSearchLike(SearchValue As String) As List(Of PatientMaritalStatusView)

        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_marital_status_search_like`('{0}')",
                                                SearchValue)
        Dim datas As List(Of PatientMaritalStatusView)
        Dim dt As DataTable = ExecuteDataset(procedure)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientMaritalStatusView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .Name = dr("name").ToString(),
                    .Status = dr("status"),
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
