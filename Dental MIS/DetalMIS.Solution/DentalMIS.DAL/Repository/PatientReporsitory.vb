Imports DentalMIS.MODEL
Public Class PatientReporsitory
    Inherits Database

#Region "Declaration"

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function PatientCreate(param As Patient) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_patient_create`(
                                    '{param.Firstname}', 
                                    '{param.Lastname}', 
                                    '{param.MiddleName}', 
                                    '{param.AddressNumber}', 
                                    '{param.AddressStreetBuilding}', 
                                    '{param.AddressMunicipality}', 
                                    '{param.BirthDate.ToString("yyyy-MM-dd")}', 
                                    '{param.Age}', 
                                    '{param.Gender}', 
                                    '{param.Occupation}', 
                                    '{param.ContactNumber}', 
                                    '{param.CivilStatus}', 
                                    '{param.CreatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientEdit(param As Patient) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_patient_edit`(
                                    '{param.ID}',
                                    '{param.Firstname}', 
                                    '{param.Lastname}', 
                                    '{param.MiddleName}', 
                                    '{param.AddressNumber}', 
                                    '{param.AddressStreetBuilding}', 
                                    '{param.AddressMunicipality}', 
                                    '{param.BirthDate.ToString("yyyy-MM-dd")}', 
                                    '{param.Age}', 
                                    '{param.Gender}', 
                                    '{param.Occupation}', 
                                    '{param.ContactNumber}', 
                                    '{param.CivilStatus}', 
                                    '{param.UpdatedBy}');"
        Return Convert.ToInt32(ExecuteDataset(procedure).Rows(0)(0))
    End Function

    Public Function PatientSearchID(id As Long) As Patient
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_id`({0})", id)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As Patient

        data = (From dr As DataRow In dt.Rows
                Select New Patient With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientNumber = dr("patient_number").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .MiddleName = dr("middle_name").ToString(),
                    .FullName = dr("full_name").ToString(),
                    .AddressNumber = dr("address_house_number").ToString(),
                    .AddressStreetBuilding = dr("address_street_building").ToString(),
                    .AddressMunicipality = dr("address_municipality").ToString(),
                    .Address = dr("address").ToString(),
                    .BirthDate = Convert.ToDateTime(dr("birthday")).Date,
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Gender = dr("gender").ToString(),
                    .Occupation = dr("occupation").ToString(),
                    .ContactNumber = dr("contact_number").ToString(),
                    .CivilStatus = dr("civil_status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).FirstOrDefault()
        Return data
    End Function

    Public Function PatientSearchLike(searchText As String) As List(Of Patient)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_like`('{0}')", searchText)
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim datas As List(Of Patient)

        datas = (From dr As DataRow In dt.Rows
                 Select New Patient With {
                    .ID = Convert.ToInt32(dr("id")),
                    .PatientNumber = dr("patient_number").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .MiddleName = dr("middle_name").ToString(),
                    .FullName = dr("full_name").ToString(),
                    .AddressNumber = dr("address_house_number").ToString(),
                    .AddressStreetBuilding = dr("address_street_building").ToString(),
                    .AddressMunicipality = dr("address_municipality").ToString(),
                    .Address = dr("address").ToString(),
                    .BirthDate = Convert.ToDateTime(dr("birthday")).Date,
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Gender = dr("gender").ToString(),
                    .Occupation = dr("occupation").ToString(),
                    .ContactNumber = dr("contact_number").ToString(),
                    .CivilStatus = dr("civil_status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }).ToList()
        Return datas
    End Function

    Public Function PatientSearchReport([from] As Date, [to] As Date) As List(Of PatientReport)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_patient_search_report`('{0}', '{1}')", [from].Date.ToString("yyyy-MM-dd"), [to].Date.ToString("yyyy-MM-dd"))
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim datas As List(Of PatientReport)

        datas = (From dr As DataRow In dt.Rows
                 Select New PatientReport With {
                    .PatientNumber = dr("patient_number").ToString(),
                    .FullName = dr("full_name").ToString(),
                    .Address = dr("address").ToString(),
                    .Age = Convert.ToInt32(dr("age").ToString()),
                    .Gender = dr("gender").ToString(),
                    .ContactNumber = dr("contact_number").ToString()
                }).ToList()
        Return datas
    End Function
#End Region

#Region "Private Method"

#End Region

End Class
