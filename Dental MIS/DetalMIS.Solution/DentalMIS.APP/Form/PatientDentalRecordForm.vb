Imports System.ComponentModel
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PatientDentalRecordForm

    Public patientID As Integer
    Public activeUser As String
    Public patientControl As PatientControl
    Private procedureSvc As IProcedureService

    Public Sub LoadData(toothNumber As String, [from] As String, [to] As String)
        procedureSvc = New ProcedureService()
        Dim data As List(Of Procedure)
        Dim bs As New BindingSource
        data = procedureSvc.ProcedureSearchPatientID(patientID, toothNumber, [from], [to])
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
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
    End Sub


    Private Sub LoadToothButtonControls()
        For Each control In GroupBoxTooth.Controls
            If (control.GetType() Is GetType(Bunifu.Framework.UI.BunifuImageButton)) Then
                Dim button As Bunifu.Framework.UI.BunifuImageButton = CType(control, Bunifu.Framework.UI.BunifuImageButton)
                AddHandler button.Click, AddressOf buttonTooths_Click
            End If
        Next
    End Sub

    Private Sub buttonTooths_Click(sender As Object, e As EventArgs)
        Dim button As Bunifu.Framework.UI.BunifuImageButton = sender
        LoadData(button.Tag, "", "")
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        On Error Resume Next
        Dim form As New ProcedureAddEditForm
        form.activeUser = activeUser
        form.patientID = patientID
        form.patientDentalRecordForm = Me
        form.HeaderLabel.Text = "Procedure - New"
        form.ShowDialog()
    End Sub

    Private Sub PatientDentalRecordForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.user.UserType = "Secretary" Then
            buttonNew.Visible = False
            buttonEdit.Visible = False
        End If
        LoadData("", "", "")
        LoadToothButtonControls()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        LoadData("", dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        On Error Resume Next
        If (DataGrid.Rows.Count > 0) Then
            Dim form As New ProcedureAddEditForm
            form.procedureID = Convert.ToInt64(DataGrid.CurrentRow.Cells(0).Value)
            form.patientID = patientID
            form.activeUser = activeUser
            form.patientDentalRecordForm = Me
            form.HeaderLabel.Text = "Procedure - Edit"
            form.ShowDialog()
        Else
            MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PatientDentalRecordForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        patientControl.LoadData("")
    End Sub

    Private Sub ToolStripMenuItemShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemShowAll.Click
        LoadData("", "", "")
    End Sub

    Private Sub ToolStripMenuItemPrint_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemPrint.Click

        On Error Resume Next
        If (DataGrid.Rows.Count > 0) Then
            Dim form As New PrintDentalCertificateForm
            form.procedureID = Convert.ToInt64(DataGrid.CurrentRow.Cells(0).Value)
            form.ShowDialog()
        Else
            MessageBox.Show("No item(s) to Print", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class