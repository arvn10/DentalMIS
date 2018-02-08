Imports System.ComponentModel
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureAddEditForm
    Public activeUser As String
    Public patientID As Long
    Public procedureID As long
    Public patientDentalRecordForm As PatientDentalRecordForm
    Private procedureTypeSvc As ProcedureTypeService
    Private paymentSvc As PaymentService
    Private procedureSvc As ProcedureService
    Private toothSvc As ToothService
    Dim firstRun As Boolean = True


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        procedureTypeSvc = New ProcedureTypeService
        toothSvc = New ToothService
    End Sub

    Public Sub LoadData()
        paymentSvc = New PaymentService()
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

    Private Sub ProcedureAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim procedureTypeList As List(Of ProcedureType)
        procedureTypeList = procedureTypeSvc.ProcedureTypeSearchLike("")
        comboProcedureType.DisplayMember = "Name"
        comboProcedureType.ValueMember = "ID"
        comboProcedureType.DataSource = procedureTypeList
        comboProcedureType.Text = "-Select Item-"
        Dim toothList As List(Of Tooth)
        toothList = toothSvc.ToothSearch()
        comboTooth.DisplayMember = "Tooth"
        comboTooth.ValueMember = "ToothNumber"
        comboTooth.DataSource = toothList
        comboTooth.Text = "-Select Tooth-"
        firstRun = False

        If HeaderLabel.Text.Contains("Edit") Then
            TabPagePayment.Visible = True
            Dim data As Procedure
            procedureSvc = New ProcedureService()
            data = procedureSvc.ProcedureSearchID(procedureID)
            comboProcedureType.Text = data.ProcedureName
            comboTooth.Text = data.Tooth
            dtPickerTransDate.Value = data.ProcedureDate
            textPrescription.Text = data.Notes
            textCharge.Text = data.AmountToPay
            textAmountPaid.Text = data.AmountPaid
            textPaymentBalance.Text = data.Balance
            LoadData()
        Else
            TabPagePayment.Visible = False
        End If
    End Sub

    Private Sub comboProcedureType_TextChanged(sender As Object, e As EventArgs) Handles comboProcedureType.TextChanged
        If Not firstRun Then
            Dim procedureType As New ProcedureType
            procedureType = procedureTypeSvc.ProcedureTypeSearchID(comboProcedureType.SelectedValue)
            textPrice.Text = procedureType.BasePrice
        End If
    End Sub

    Private Sub comboProcedureType_Click(sender As Object, e As EventArgs) Handles comboProcedureType.Click

    End Sub

    Private Sub comboProcedureType_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboProcedureType.SelectedValueChanged

    End Sub

    Private Sub ProcedureAddEditForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            procedureSvc = New ProcedureService
            Dim procedureID As Long
            Dim procedure As New Procedure
            If HeaderLabel.Text.Contains("New") Then
                Dim valid As Boolean = True
                For Each control As Control In Me.Controls
                    If (control.GetType() Is GetType(TextBox)) Then
                        Dim textBox As TextBox = CType(control, TextBox)
                        If textBox.Text = String.Empty And textBox.Tag = "*" Then
                            valid = False
                        End If
                    ElseIf (control.GetType() Is GetType(ComboBox)) Then
                        Dim comboBox As ComboBox = CType(control, ComboBox)
                        If (comboBox.Text = String.Empty Or comboBox.Text.Contains("Select")) And comboBox.Tag = "*" Then
                            valid = False
                        End If
                    End If
                Next

                If valid Then
                    procedure.PatientID = patientID
                    procedure.ProcedureTypeID = Convert.ToInt64(comboProcedureType.SelectedValue)
                    procedure.ToothNumber = Convert.ToInt64(comboTooth.SelectedValue)
                    procedure.AmountToPay = Convert.ToInt64(textCharge.Text)
                    procedure.ProcedureDate = dtPickerTransDate.Value.Date.ToString("yyyy-MM-dd")
                    procedure.Notes = textPrescription.Text
                    procedure.ProcedureCreatedBy = activeUser
                    procedureID = procedureSvc.ProcedureCreate(procedure)
                    If procedureID > 0 Then
                        MessageBox.Show("Procedure Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        patientDentalRecordForm.LoadData("", "", "")
                        Me.Dispose()
                    End If
                Else
                    MessageBox.Show("Fill all the required fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub comboTooth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboTooth.KeyPress
        e.Handled = True
    End Sub

    Private Sub textCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCharge.KeyPress
        Dim AllowedKeys As String = "0123456789."
        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                ' Call method here...

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Left)
                e.Handled = False

            Case Convert.ToChar(Keys.Right)
                e.Handled = False

            Case Convert.ToChar(Keys.Up)
                e.Handled = False

            Case Convert.ToChar(Keys.Down)
                e.Handled = False

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))

            Case Else ' Other key is pressed
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)
        End Select
    End Sub

    Private Sub textCharge_TextChanged(sender As Object, e As EventArgs) Handles textCharge.TextChanged
        textPaymentCharge.Text = textCharge.Text
    End Sub

    Private Sub ProcedureAddEditForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class