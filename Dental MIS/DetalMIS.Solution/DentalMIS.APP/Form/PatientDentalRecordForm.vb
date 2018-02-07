Imports System.ComponentModel
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PatientDentalRecordForm

    Public patientID As Integer
    Public activeUser As String
    Private procedureSvc As ProcedureService

    Public Sub LoadData([from] As String, [to] As String)
        procedureSvc = New ProcedureService()
        Dim data As List(Of Procedure)
        Dim bs As New BindingSource
        data = procedureSvc.ProcedureSearchPatientID(patientID, [from], [to])
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("procedureName").DataPropertyName = "ProcedureName"
        DataGrid.Columns("tooth").DataPropertyName = "Tooth"
        DataGrid.Columns("paymentStatus").DataPropertyName = "PaymentStatus"
        DataGrid.Columns("createdBy").DataPropertyName = "ProcedureCreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "ProcedureCreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "ProcedureUpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "ProcedureUpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        Try
            Dim form As New ProcedureAddEditForm
            form.activeUser = activeUser
            form.patientID = patientID
            form.patientDentalRecordForm = Me
            form.HeaderLabel.Text = "Procedure - New"
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PatientDentalRecordForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData("", "")
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        LoadData(dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        LoadData("", "")
    End Sub
End Class