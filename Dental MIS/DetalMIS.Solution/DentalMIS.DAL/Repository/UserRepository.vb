Imports DentalMIS.DAL.Database
Imports DentalMIS.DAL.UserCreate
Imports DentalMIS.DAL.UserEdit
Imports DentalMIS.DAL.UserView
Public Class UserRepository
    Inherits Database

#Region "Declartion"
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function UserCreate(param As UserCreate) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_create`({0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}')",
                                  param.UserTypeID,
                                  param.Username,
                                  param.Password,
                                  param.Firstname,
                                  param.Lastname,
                                  param.Status,
                                  param.CreatedBy)

        Dim id As Long = ExecuteDataset(procedure).Rows(0)(0)

        Return id
    End Function

    Public Function UserEdit(param As UserEdit) As Long
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_create`({0}, {1}, '{2}', '{3}', '{4}', '{5}', {5}, '{6}')",
                                  param.ID,
                                  param.UserTypeID,
                                  param.Username,
                                  param.Password,
                                  param.Firstname,
                                  param.Lastname,
                                  param.Status,
                                  param.UpdatedBy)

        Dim id As Long = ExecuteDataset(procedure).Rows(0)(0)

        Return id
    End Function

    Public Function UserSearchID(ID As Long) As List(Of UserView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_search_id`({0})", ID)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of UserView)

        datas = (From dr As DataRow In dt.Rows
                 Select New UserView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function UserSearchStatus(Status As Long) As List(Of UserView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_search_status`({0})", Status)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of UserView)

        datas = (From dr As DataRow In dt.Rows
                 Select New UserView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function UserSearchLike(SearchText As Long) As List(Of UserView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_search_Like`({0})", SearchText)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of UserView)

        datas = (From dr As DataRow In dt.Rows
                 Select New UserView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function UserLogin(Username As String, Password As String) As List(Of UserView)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_login`('{0}', '{1}')", Username, Password)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of UserView)

        datas = (From dr As DataRow In dt.Rows
                 Select New UserView With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = dr("status").ToString(),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("created_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function
#End Region

#Region "Private Method"

#End Region

End Class
