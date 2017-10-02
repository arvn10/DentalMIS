Imports DentalMIS.BLL
Public Class UserControl
    Private userService As UserService
    Private Sub LoadData(searchText As String)
        Dim data As New List(Of UserView)
        data = userService.UserSearchLike(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("username").DataPropertyName = "Username"
        DataGrid.Columns("password").DataPropertyName = "Password"
        DataGrid.Columns("firstname").DataPropertyName = "Firstname"
        DataGrid.Columns("lastname").DataPropertyName = "Lastname"
        DataGrid.Columns("userType").DataPropertyName = "UserType"
        DataGrid.Columns("status").DataPropertyName = "Status"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        Try
            LoadData(TextSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Dim form As New UserAddEditForm
        form.activeUser = formMain.LabelMenu.Text
        form.HeaderLabel.Text = "User - New"
        form.ShowDialog()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New UserAddEditForm
                form.activeUser = formMain.LabelMenu.Text
                form.userID = DataGrid.CurrentRow.Cells(0).Value
                form.HeaderLabel.Text = "User - Edit"
                form.ShowDialog()
                DataGrid.DataSource = Nothing
            Else
                MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
