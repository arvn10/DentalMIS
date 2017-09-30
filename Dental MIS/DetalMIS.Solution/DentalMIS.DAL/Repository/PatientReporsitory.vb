﻿Public Class PatientReporsitory
    Inherits Database

#Region "Declaration"

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function PatientCreate(param As PatientCreate) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_create`({0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}')",
                                                    param.PatientMaritalStatusID,
                                                    param.Firstname,
                                                    param.Lastname,
                                                    param.MiddleInitial,
                                                    param.Address,
                                                    param.Age,
                                                    param.Occupation,
                                                    param.CreatedBy
                                               )
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientEdit(param As PatientEdit) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_edit` ({0}, {1}, '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}')",
                                                    param.ID,
                                                    param.PatientMaritalStatusID,
                                                    param.Firstname,
                                                    param.Lastname,
                                                    param.MiddleInitial,
                                                    param.Address,
                                                    param.Age,
                                                    param.Occupation,
                                                    param.UpdatedBy
                                               )
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientSearchID(id As Long) As List(Of PatientView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_id`({0})", id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim datas As List(Of PatientView)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientMaritalStatusID = Convert.ToInt32(dr("patient_marital_status_id")),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .MiddleInitial = dr("middle_initial").ToString(),
                    .Address = dr("address").ToString(),
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Occupation = dr("occupation").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = dr("created_date").ToString(),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = dr("updated_date").ToString()
                }).ToList()
        Return datas
    End Function

    Public Function PatientSearchAge(age As Long) As List(Of PatientView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_age`({0})", age)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim datas As List(Of PatientView)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientMaritalStatusID = Convert.ToInt32(dr("patient_marital_status_id")),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .MiddleInitial = dr("middle_initial").ToString(),
                    .Address = dr("address").ToString(),
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Occupation = dr("occupation").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = dr("created_date").ToString(),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = dr("updated_date").ToString()
                }).ToList()
        Return datas
    End Function

    Public Function PatientSearchLike(searchText As String) As List(Of PatientView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_like`({0})", searchText)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim datas As List(Of PatientView)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientMaritalStatusID = Convert.ToInt32(dr("patient_marital_status_id")),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .MiddleInitial = dr("middle_initial").ToString(),
                    .Address = dr("address").ToString(),
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Occupation = dr("occupation").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = dr("created_date").ToString(),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = dr("updated_date").ToString()
                }).ToList()
        Return datas
    End Function
#End Region

#Region "Private Method"

#End Region

End Class
