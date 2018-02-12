Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class AuditTrailControl
    Private auditTrailSvc As IAuditTrailService

    Public Sub LoadData([from] As String, [to] As String)
        auditTrailSvc = New AuditTrailService()
        Dim data As List(Of AuditTrail)
        Dim bs As New BindingSource
        data = auditTrailSvc.AuditTrailSelect([from], [to])
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("action").DataPropertyName = "Action"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub AuditTrailControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        LoadData(DateTimePickerFrom.Value.ToString("yyy-MM-dd"), DateTimePickerTo.Value.ToString("yyy-MM-dd"))
    End Sub
End Class
