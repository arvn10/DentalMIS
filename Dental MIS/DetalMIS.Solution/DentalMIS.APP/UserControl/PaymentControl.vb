Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PaymentControl
    Public activeUser As String
    Private procedureSvc As ProcedureService


    Public Sub LoadData(searchText As String)
        procedureSvc = New ProcedureService()
        Dim data As List(Of Procedure)
        Dim bs As New BindingSource
        data = procedureSvc.ProcedureSearchPaymentLike(searchText)
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("fullname").DataPropertyName = "Fullname"
        DataGrid.Columns("tooth").DataPropertyName = "Tooth"
        DataGrid.Columns("procedure").DataPropertyName = "ProcedureName"
        DataGrid.Columns("amountToPay").DataPropertyName = "AmountToPay"
        DataGrid.Columns("amountPaid").DataPropertyName = "AmountPaid"
        DataGrid.Columns("balance").DataPropertyName = "Balance"
        DataGrid.Columns("paymentStatus").DataPropertyName = "PaymentStatus"
        DataGrid.Columns("procedureDate").DataPropertyName = "ProcedureDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "ProcedureUpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "ProcedureUpdatedDate"

        DataGrid.Columns("amountToPay").DefaultCellStyle.Format = "C"
        DataGrid.Columns("amountToPay").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGrid.Columns("amountPaid").DefaultCellStyle.Format = "C"
        DataGrid.Columns("amountPaid").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGrid.Columns("balance").DefaultCellStyle.Format = "C"
        DataGrid.Columns("balance").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub PaymentControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData("")
    End Sub

    Private Sub textSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        LoadData(textSearch.Text)
    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        LoadData("")
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New PaymentForm
                form.procedureID = Convert.ToInt64(DataGrid.CurrentRow.Cells(0).Value)
                form.activeUser = MainForm.LabelMenu.Text
                form.HeaderLabel.Text = "Payment - " + DataGrid.CurrentRow.Cells(1).Value.ToString()
                form.ShowDialog()
            Else
                MessageBox.Show("No item(s) to view", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
