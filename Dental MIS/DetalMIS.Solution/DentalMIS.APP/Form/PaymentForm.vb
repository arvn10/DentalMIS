Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class PaymentForm
    Public procedureID As Long
    Public activeUser As String
    Public paymentControl As PaymentControl
    Private paymentSvc As IPaymentService
    Private procedureSvc As IProcedureService
    Public Sub LoadData()

        paymentSvc = New PaymentService()
        procedureSvc = New ProcedureService()

        Dim procedure As Procedure
        procedure = procedureSvc.ProcedureSearchID(procedureID)
        textProcedure.Text = procedure.ProcedureName
        textTooth.Text = procedure.Tooth
        textCharge.Text = procedure.AmountToPay.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        textTotalAmountPaid.Text = procedure.AmountPaid.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        textBalance.Text = procedure.Balance.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))

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
        paymentControl.LoadData("")
        Me.Dispose()
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        Try
            Dim form As New PaymentAddEdit
            form.paymentForm = Me
            form.activeUser = activeUser
            form.procedureID = procedureID
            form.HeaderLabel.Text = "Payment - New"
            form.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
End Class