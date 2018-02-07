Imports MySql.Data.MySqlClient

Public Class Database
    Private con As MySqlConnection
    Public Sub New()
        Dim constring As String = Configuration.ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString
        con = New MySqlConnection(constring)
        If con.State = ConnectionState.Open Then
            con.Dispose()
            con.Close()
        End If
        con.Open()
    End Sub

    Public Function ExecuteDataset(procedure As String) As DataTable
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(procedure, con)
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

    Public Function ExecuteNonQuery(procedure As String) As Integer
        Dim cmd As New MySqlCommand(procedure, con)
        Return cmd.ExecuteNonQuery()
    End Function

    Public Function ExecuteScalar(procedure As String) As Integer
        Dim cmd As New MySqlCommand(procedure, con)
        Return cmd.ExecuteScalar()
    End Function

End Class
