Imports DentalMIS.BLL
Public Class ProcedureTypeControl
    Private procedureTypeService As ProcedureTypeService
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        procedureTypeService = New ProcedureTypeService()
    End Sub

    Public Sub LoadData(searchText As String)
        Dim data As New List(Of ProcedureTypeView)
        data = procedureTypeService.ProcedureTypeSearchLike(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("procedureName").DataPropertyName = "Name"
        DataGrid.Columns("basePrice").DataPropertyName = "BasePrice"
        DataGrid.Columns("paymentType").DataPropertyName = "PaymentType"
        DataGrid.Columns("requireMedCert").DataPropertyName = "RequireMedCert"
        DataGrid.Columns("status").DataPropertyName = "Status"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub ProcedureTypeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Dim form As New ProcedureTypeAddEditForm
        form.activeUser = formMain.LabelMenu.Text
        form.HeaderLabel.Text = "Procedure Type - New"
        form.ShowDialog()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New ProcedureTypeAddEditForm
                form.activeUser = formMain.LabelMenu.Text
                form.procedureTypeID = DataGrid.CurrentRow.Cells(0).Value
                form.HeaderLabel.Text = "Procedure Type - Edit"
                form.ShowDialog()
                DataGrid.DataSource = Nothing
            Else
                MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        Try
            LoadData(TextSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        LoadData("")
    End Sub
End Class
