Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class PaymentDetail
    Public procedureID As Long
    Public activeUser As String
    Public paymentControl As PaymentControl
    Private paymentSvc As IPaymentService
    Private procedureSvc As IProcedureService
    Dim procedure As Procedure
    Public Sub LoadData()

        paymentSvc = New PaymentService()
        procedureSvc = New ProcedureService()

        procedure = procedureSvc.ProcedureSearchID(procedureID)
        textProcedure.Text = procedure.ProcedureName
        textPaymentType.Text = procedure.PaymentType
        textCharge.Text = procedure.AmountToPay.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        textTotalAmountPaid.Text = procedure.AmountPaid.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        textBalance.Text = procedure.Balance.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))

        If procedure.Balance = 0 Then
            buttonNew.Enabled = False
            buttonEdit.Enabled = False
        End If

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

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        On Error Resume Next
        Dim form As New PaymentAddEdit
        form.paymentForm = Me
        form.activeUser = activeUser
        form.procedureID = procedureID
        form.HeaderLabel.Text = "Payment - New"
        form.ShowDialog()
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        On Error Resume Next
        Dim form As New PaymentAddEdit
        If DataGrid.Rows.Count > 0 Then
            form.paymentForm = Me
            form.paymentID = Convert.ToInt64(DataGrid.CurrentRow.Cells(0).Value)
            form.activeUser = activeUser
            form.procedureID = procedureID
            form.HeaderLabel.Text = "Payment - Edit"
            form.ShowDialog()
        Else
            MessageBox.Show("No Item(s) to edit.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PaymentDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(paymentControl) Then
            paymentControl.LoadData("")
        End If
    End Sub
End Class