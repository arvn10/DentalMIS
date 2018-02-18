Imports System.ComponentModel
Imports System.Globalization
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureAddEditForm
    Public activeUser As String
    Public patientID As Long
    Public procedureID As Long
    Public patientDentalRecordForm As PatientDentalRecordForm
    Private procedureTypeSvc As IProcedureTypeService
    Private paymentSvc As IPaymentService
    Private procedureSvc As IProcedureService
    Private toothSvc As IToothService
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


        Dim toothList As List(Of Tooth)
        toothList = toothSvc.ToothSearch()
        comboTooth.DisplayMember = "Tooth"
        comboTooth.ValueMember = "ToothNumber"
        comboTooth.DataSource = toothList
        comboTooth.Text = ""
        firstRun = False

        If HeaderLabel.Text.Contains("Edit") Then
            TabPagePayment.Enabled = True
            Dim data As Procedure
            procedureSvc = New ProcedureService()
            data = procedureSvc.ProcedureSearchID(procedureID)
            patientID = data.PatientID
            comboTooth.Text = data.Tooth
            comboProcedureType.Text = data.ProcedureName
            dtPickerTransDate.Value = data.ProcedureDate
            textPrescription.Text = data.Notes
            textCharge.Text = data.AmountToPay.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textPaymentCharge.Text = textCharge.Text
            textAmountPaid.Text = data.AmountPaid.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textPaymentBalance.Text = data.Balance.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            LoadData()
        Else
            TabPagePayment.Enabled = False
        End If
    End Sub


    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            procedureSvc = New ProcedureService
            Dim procedure As New Procedure
            Dim valid As Boolean = True
            For Each control As Control In Me.TabPageProcedure.Controls
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
                procedure.AmountToPay = Double.Parse(textCharge.Text, NumberStyles.Currency)
                procedure.ProcedureDate = dtPickerTransDate.Value.Date.ToString("yyyy-MM-dd")
                procedure.Notes = textPrescription.Text

                If HeaderLabel.Text.Contains("New") Then
                    procedure.ProcedureCreatedBy = activeUser
                    procedureID = procedureSvc.ProcedureCreate(procedure)

                    If procedureID > 0 Then
                        MessageBox.Show("Procedure Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        patientDentalRecordForm.LoadData("", "", "")
                        Me.Dispose()
                    End If
                Else
                    Dim msg = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If msg = DialogResult.Yes Then
                        procedure.ID = procedureID
                        procedure.ProcedureUpdatedBy = activeUser
                        procedureID = 0
                        procedureID = procedureSvc.ProcedureEdit(procedure)

                        If procedureID > 0 Then
                            MessageBox.Show("Procedure Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            patientDentalRecordForm.LoadData("", "", "")
                            Me.Dispose()
                        End If
                    End If
                End If


            Else
                MessageBox.Show("Fill all the required fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub buttonPrintDC_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboProcedureType_TextChanged(sender As Object, e As EventArgs) Handles comboProcedureType.TextChanged
        If Not firstRun Then
            Dim procedureType As New ProcedureType
            procedureType = procedureTypeSvc.ProcedureTypeSearchID(comboProcedureType.SelectedValue)
            textPrice.Text = procedureType.BasePrice.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        End If
    End Sub

    Private Sub textCharge_Leave(sender As Object, e As EventArgs) Handles textCharge.Leave
        If textCharge.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textCharge.Text, NumberStyles.Currency)
            textCharge.Text = amount.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textPaymentCharge.Text = textCharge.Text
            If textAmountPaid.Text <> String.Empty Then
                textPaymentBalance.Text = (Double.Parse(textPaymentCharge.Text, NumberStyles.Currency) - Double.Parse(textAmountPaid.Text, NumberStyles.Currency)).ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            Else
                Dim val As Double = 0
                textPaymentBalance.Text = val.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            End If

        End If
    End Sub

    Private Sub textCharge_Enter(sender As Object, e As EventArgs) Handles textCharge.Enter
        If textCharge.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textCharge.Text, NumberStyles.Currency)
            textCharge.Text = amount.ToString()
        End If
    End Sub

    Private Sub comboTooth_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboTooth_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboTooth.SelectedValueChanged
        Dim procedureTypeList As List(Of ProcedureType)
        If HeaderLabel.Text.Contains("New") Then
            procedureTypeList = procedureTypeSvc.ProcedureTypeSearchTooth(patientID, comboTooth.SelectedValue)
            comboProcedureType.DisplayMember = "Name"
            comboProcedureType.ValueMember = "ID"
            comboProcedureType.DataSource = procedureTypeList
            comboProcedureType.Text = ""
        Else
            procedureTypeList = procedureTypeSvc.ProcedureTypeSearchLike("")
            comboProcedureType.DisplayMember = "Name"
            comboProcedureType.ValueMember = "ID"
            comboProcedureType.DataSource = procedureTypeList
            comboProcedureType.Text = ""
        End If
        textPrice.Clear()
        textCharge.Clear()
    End Sub
End Class