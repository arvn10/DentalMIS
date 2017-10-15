Imports DentalMIS.BLL
Public Class PatientMaritalStatusControl
    Private patientMaritalStatusService As BLL.PatientMaritalStatusService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        patientMaritalStatusService = New PatientMaritalStatusService
    End Sub
    Public Sub LoadData(searchText As String)
        Dim data As New List(Of PatientMaritalStatusView)
        data = patientMaritalStatusService.PatientMaritalStatusSearchLike(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("cname").DataPropertyName = "Name"
        DataGrid.Columns("status").DataPropertyName = "Status"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        LoadData(TextSearch.Text)
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        DataGrid.DataSource = Nothing
        Dim form As New PatientMaritalStatusAddEditForm
        form.activeUser = MainForm.LabelMenu.Text
        form.HeaderLabel.Text = "Patient Marital Status - New"
        form.ShowDialog()
    End Sub

    Private Sub PatientMaritalStatusControl_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        LoadData("")
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New PatientMaritalStatusAddEditForm
                form.activeUser = MainForm.LabelMenu.Text
                form.patientMaritalStatusID = DataGrid.CurrentRow.Cells(0).Value
                form.HeaderLabel.Text = "Patient Marital Status - Edit"
                form.ShowDialog()
                DataGrid.DataSource = Nothing
            Else
                MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
