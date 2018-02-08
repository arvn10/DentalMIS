Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class PaymentForm
    Public procedureID As Long
    Public activeUser As String

    Public Sub LoadData()
        Dim paymentSvc As New PaymentService
        Dim procedureSvc As New ProcedureService

        Dim procedure As Procedure
        procedure = procedureSvc.ProcedureSearchID(procedureID)
        textProcedure.Text = procedure.ProcedureName
        textTooth.Text = procedure.Tooth
        textCharge.Text = procedure.AmountToPay
        textTotalAmountPaid.Text = procedure.AmountPaid
        textBalance.Text = procedure.Balance

        Dim data As List(Of Payment)
        Dim bs As New BindingSource
        data = paymentSvc.PaymentSearchProcedureID(procedureID)
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("amountPaid").DataPropertyName = "AmountPaid"
        DataGrid.Columns("paymentDate").DataPropertyName = "TransactionDate"

        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.Columns("amountPaid").DefaultCellStyle.Format = "C"
        DataGrid.Columns("amountPaid").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
End Class