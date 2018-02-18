Imports DentalMIS.MODEL
Public Class UserRepository
    Inherits Database

#Region "Declartion"
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Method"
    Public Function UserCreate(param As User) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_user_create`(
                                        {param.UserTypeID}, 
                                        {param.SecretQuestionID}, 
                                        '{param.Username}', 
                                        '{param.Password}', 
                                        '{param.SecretQuestionAnswer}', 
                                        '{param.Firstname}', 
                                        '{param.Lastname}', 
                                        {param.Status},
                                        '{param.CreatedBy}')"

        Dim id As Long = Convert.ToInt64(ExecuteDataset(procedure).Rows(0)(0))

        Return id
    End Function

    Public Function UserEdit(param As User) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_user_edit`(
                                        {param.ID},
                                        {param.UserTypeID}, 
                                        {param.SecretQuestionID}, 
                                        '{param.Username}', 
                                        '{param.Password}', 
                                        '{param.SecretQuestionAnswer}', 
                                        '{param.Firstname}', 
                                        '{param.Lastname}', 
                                        {param.Status},
                                        '{param.UpdatedBy}')"

        Dim id As Long = Convert.ToInt64(ExecuteDataset(procedure).Rows(0)(0))

        Return id
    End Function

    Public Function UserSearchID(ID As Long) As List(Of User)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_search_id`({0})", ID)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of User)

        datas = (From dr As DataRow In dt.Rows
                 Select New User With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .SecretQuestionID = Convert.ToInt32(dr("secret_question_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .SecretQuestion = dr("secret_question").ToString(),
                    .SecretQuestionAnswer = dr("secret_question_answer").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function UserSearchLike(SearchText As String) As List(Of User)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_search_Like`('{0}')", SearchText)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of User)

        datas = (From dr As DataRow In dt.Rows
                 Select New User With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .SecretQuestionID = Convert.ToInt32(dr("secret_question_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .SecretQuestion = dr("secret_question").ToString(),
                    .SecretQuestionAnswer = dr("secret_question_answer").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function UserLogin(Username As String, Password As String) As List(Of User)
        Dim procedure As String = String.Format("CALL `dental_mis`.`usp_user_login`('{0}', '{1}')", Username, Password)
        Dim dt As DataTable = ExecuteDataset(procedure)

        Dim datas As New List(Of User)

        datas = (From dr As DataRow In dt.Rows
                 Select New User With {
                    .ID = Convert.ToInt32(dr("id")),
                    .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                    .SecretQuestionID = Convert.ToInt32(dr("secret_question_id")),
                    .UserType = dr("user_type").ToString(),
                    .Username = dr("username").ToString(),
                    .Password = dr("password").ToString(),
                    .SecretQuestion = dr("secret_question").ToString(),
                    .SecretQuestionAnswer = dr("secret_question_answer").ToString(),
                    .Firstname = dr("firstname").ToString(),
                    .Lastname = dr("lastname").ToString(),
                    .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                 }).ToList()
        Return datas
    End Function

    Public Function ForgotPassword(username As String, secretQuestionID As Long, secretQuestionAnswer As String) As User
        Dim procedure As String = $"CALL `dental_mis`.`usp_user_forgot_password`('{username}',{secretQuestionID},'{secretQuestionAnswer}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As User = (From dr As DataRow In dt.Rows
                            Select New User With {
                                .ID = Convert.ToInt32(dr("id")),
                                .UserTypeID = Convert.ToInt32(dr("user_type_id")),
                                .SecretQuestionID = Convert.ToInt32(dr("secret_question_id")),
                                .UserType = dr("user_type").ToString(),
                                .Username = dr("username").ToString(),
                                .Password = dr("password").ToString(),
                                .SecretQuestion = dr("secret_question").ToString(),
                                .SecretQuestionAnswer = dr("secret_question_answer").ToString(),
                                .Firstname = dr("firstname").ToString(),
                                .Lastname = dr("lastname").ToString(),
                                .Status = IIf(dr("status") = 1, "Active", "Not Active"),
                                .CreatedBy = dr("created_by").ToString(),
                                .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                                .UpdatedBy = dr("updated_by").ToString(),
                                .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                            }).FirstOrDefault()
        Return data
    End Function
#End Region

#Region "Private Method"

#End Region

End Class
