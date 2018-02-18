Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class SecretQuestionControl

    Private secretQuestioSvc As ISecretQuestionService

    Public Sub LoadData(searchText As String)
        secretQuestioSvc = New SecretQuestionService
        Dim data As New List(Of SecretQuestion)
        data = secretQuestioSvc.SecretQuestionSelect(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("question").DataPropertyName = "Question"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ToolStripButtonShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowAll.Click
        LoadData("")
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
        On Error Resume Next
        Dim form As New SecretQuestionAddEdit()
        form.activeUser = MainForm.LabelMenu.Text
        form.secretQuestionControl = Me
        form.HeaderLabel.Text = "Secret Question - New"
        form.ShowDialog()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        On Error Resume Next
        Dim form As New SecretQuestionAddEdit()
        form.activeUser = MainForm.LabelMenu.Text
        form.secretQuestionControl = Me
        form.secretQuestionID = DataGrid.CurrentRow.Cells(0).Value
        form.HeaderLabel.Text = "Secret Question - Edit"
        form.ShowDialog()
    End Sub
End Class
