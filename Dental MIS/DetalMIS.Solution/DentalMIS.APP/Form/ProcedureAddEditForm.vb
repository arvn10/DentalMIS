Imports System.ComponentModel
Imports System.Globalization
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureAddEditForm
    Public activeUser As String
    Public patientID As Long
    Public procedureID As Long
    Public patientDentalRecordForm As PatientDentalRecordForm
    Public tooths As New List(Of ProcedureTooth)
    Public remarks As New List(Of ProcedureRemark)
    Private procedureTypeSvc As IProcedureTypeService
    Private paymentSvc As IPaymentService
    Private procedureSvc As IProcedureService
    Private toothSvc As IToothService
    Dim firstRun As Boolean = True
    Dim activeTextCharge As Boolean = False
    Dim paymentDetail As PaymentDetail
    Dim procedureType As ProcedureType
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        procedureTypeSvc = New ProcedureTypeService
        procedureSvc = New ProcedureService()
        toothSvc = New ToothService()
    End Sub

    Public Sub LoadTooth(toothData As List(Of ProcedureTooth))
        Dim bs As New BindingSource
        bs.DataSource = toothData
        DataGridTooth.AutoGenerateColumns = False
        DataGridTooth.DataSource = bs
        DataGridTooth.Columns("procedureToothID").DataPropertyName = "ID"
        DataGridTooth.Columns("toothID").DataPropertyName = "ToothID"
        DataGridTooth.Columns("tooth").DataPropertyName = "Tooth"
        DataGridTooth.AutoResizeColumns()
        DataGridTooth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub LoadRemark(remarkData As List(Of ProcedureRemark))
        Dim bs As New BindingSource
        bs.DataSource = remarkData
        DataGridViewRemark.AutoGenerateColumns = False
        DataGridViewRemark.DataSource = bs
        DataGridViewRemark.Columns("procedureRemarkID").DataPropertyName = "ID"
        DataGridViewRemark.Columns("remark").DataPropertyName = "Remark"
        DataGridViewRemark.Columns("dateAdded").DataPropertyName = "DateAdded"
        DataGridViewRemark.AutoResizeColumns()
        DataGridViewRemark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        patientDentalRecordForm.LoadData("", "", "")
        Me.Dispose()
    End Sub

    Private Sub ProcedureAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim procedureTypeList As List(Of ProcedureType)
        procedureTypeList = procedureTypeSvc.ProcedureTypeSearch()
        comboProcedureType.DisplayMember = "Name"
        comboProcedureType.ValueMember = "ID"
        comboProcedureType.DataSource = procedureTypeList
        comboProcedureType.Text = ""
        firstRun = False

        If HeaderLabel.Text.Contains("Edit") Then
            TabPagePayment.Enabled = True
            Dim data As Procedure
            procedureSvc = New ProcedureService()
            data = procedureSvc.ProcedureSearchID(procedureID)
            patientID = data.PatientID
            comboProcedureType.Text = data.ProcedureName
            dtPickerTransDate.Value = data.ProcedureDate
            textCharge.Text = data.AmountToPay.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            tooths = procedureSvc.ProcedureToothSelectProcedureID(procedureID)
            remarks = procedureSvc.ProcedureRemarkSelectProcedureID(procedureID)
            LoadRemark(remarks)
            LoadTooth(tooths)
            paymentDetail = New PaymentDetail
            paymentDetail.TopLevel = False
            paymentDetail.Height = Panel1.Height
            paymentDetail.Width = Panel1.Width
            paymentDetail.procedureID = procedureID
            paymentDetail.activeUser = activeUser
            paymentDetail.paymentControl = Nothing
            Panel1.Controls.Add(paymentDetail)
            paymentDetail.Show()
        Else
            TabControl.TabPages.Remove(TabPagePayment)
        End If
    End Sub


    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            procedureSvc = New ProcedureService
            Dim procedure As New Procedure
            Dim valid As Boolean = True
            Dim tempProcedureID As Long
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
            If Not IsNothing(procedureType) Then
                If procedureType.RequireTooth = "Yes" Then
                    If DataGridTooth.Rows.Count <= 0 Then
                        valid = False
                    End If
                End If
            End If



            If valid Then
                procedure.PatientID = patientID
                procedure.ProcedureTypeID = Convert.ToInt64(comboProcedureType.SelectedValue)
                procedure.AmountToPay = Double.Parse(textCharge.Text.Replace("₱", ""))
                procedure.ProcedureDate = dtPickerTransDate.Value.Date.ToString("yyyy-MM-dd")

                If HeaderLabel.Text.Contains("New") Then
                    procedure.ProcedureCreatedBy = activeUser
                    tempProcedureID = procedureSvc.ProcedureCreate(procedure)
                    If tempProcedureID > 0 Then
                        For Each dr As ProcedureRemark In remarks
                            dr.ProcedureID = tempProcedureID
                            If dr.ID.Contains("N-") Then
                                dr.CreatedBy = activeUser
                                procedureSvc.ProcedureRemarkCreate(dr)
                            Else
                                dr.UpdatedBy = activeUser
                                procedureSvc.ProcedureRemarkEdit(dr)
                            End If
                        Next
                        For Each dr As ProcedureTooth In tooths
                            dr.ProcedureID = tempProcedureID
                            If dr.ID.Contains("N-") Then
                                dr.CreatedBy = activeUser
                                procedureSvc.ProcedureToothCreate(dr)
                            Else
                                dr.UpdatedBy = activeUser
                                procedureSvc.ProcedureToothEdit(dr)
                            End If
                        Next
                        MessageBox.Show("Procedure Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        patientDentalRecordForm.LoadData("", "", "")
                        Me.Dispose()
                    End If
                Else
                    Dim msg = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If msg = DialogResult.Yes Then
                        procedure.ID = procedureID
                        procedure.ProcedureUpdatedBy = activeUser
                        tempProcedureID = procedureSvc.ProcedureEdit(procedure)
                        If tempProcedureID > 0 Then
                            For Each dr As ProcedureRemark In remarks
                                dr.ProcedureID = tempProcedureID
                                If dr.ID.Contains("N") Then
                                    dr.CreatedBy = activeUser
                                    procedureSvc.ProcedureRemarkCreate(dr)
                                Else
                                    dr.UpdatedBy = activeUser
                                    procedureSvc.ProcedureRemarkEdit(dr)
                                End If
                            Next
                            For Each dr As ProcedureTooth In tooths
                                dr.ProcedureID = tempProcedureID
                                If dr.ID.Contains("N-") Then
                                    dr.CreatedBy = activeUser
                                    procedureSvc.ProcedureToothCreate(dr)
                                Else
                                    dr.UpdatedBy = activeUser
                                    procedureSvc.ProcedureToothEdit(dr)
                                End If
                            Next
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

    Private Sub comboTooth_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub textCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCharge.KeyPress

        If Not String.IsNullOrWhiteSpace(comboProcedureType.Text) Then
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
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub buttonPrintDC_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboProcedureType_TextChanged(sender As Object, e As EventArgs) Handles comboProcedureType.TextChanged
        If Not firstRun Then
            procedureType = procedureTypeSvc.ProcedureTypeSearchID(comboProcedureType.SelectedValue)
            textPrice.Text = procedureType.BasePrice.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        End If
    End Sub

    Private Sub textCharge_Leave(sender As Object, e As EventArgs) Handles textCharge.Leave
        If textCharge.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textCharge.Text.Replace("₱", ""))
            textCharge.Text = amount.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))

            If HeaderLabel.Text.Contains("Edit") Then
                paymentDetail.textCharge.Text = textCharge.Text
                If paymentDetail.textTotalAmountPaid.Text <> String.Empty Then
                    paymentDetail.textBalance.Text = (Double.Parse(textCharge.Text.Replace("₱", "")) - Double.Parse(paymentDetail.textTotalAmountPaid.Text.Replace("₱", ""))).ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
                Else
                    Dim val As Double = 0
                    paymentDetail.textBalance.Text = val.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
                End If
            End If
        End If
    End Sub

    Private Sub textCharge_Enter(sender As Object, e As EventArgs) Handles textCharge.Enter
        If textCharge.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textCharge.Text.Replace("₱", ""))
            textCharge.Text = amount.ToString()
        End If
    End Sub

    Private Sub textCharge_TextChanged(sender As Object, e As EventArgs) Handles textCharge.TextChanged
        'If Not String.IsNullOrEmpty(textCharge.Text) Then
        '    If Double.Parse(textCharge.Text.Replace("₱", "")) > Double.Parse(textPrice.Text.Replace("₱", "")) Then
        '        MessageBox.Show("Charge cannot be greater than Price", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        textCharge.Clear()
        '    End If
        'End If
    End Sub

    Private Sub ToolStripButtonToothNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonToothNew.Click
        Try
            Dim form As New ProcedureToothAddEditForm
            form.procedureAddEditForm = Me
            form.HeaderLabel.Text = "Procedure Tooth - New"
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonToothEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonToothEdit.Click
        Try
            If DataGridTooth.Rows.Count > 0 Then
                Dim form As New ProcedureToothAddEditForm
                form.procedureAddEditForm = Me
                form.HeaderLabel.Text = "Procedure Tooth - Edit"
                form.toothID = DataGridTooth.CurrentRow.Cells(0).Value
                form.comboTooth.Text = DataGridTooth.CurrentRow.Cells(2).Value
                form.ShowDialog()
            Else
                MessageBox.Show("No Item(s) to edit.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonRemarkNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRemarkNew.Click
        Try
            Dim form As New ProcedureRemarkAddEditForm
            form.procedureAddEditForm = Me
            form.HeaderLabel.Text = "Procedure Remark - New"
            form.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButtonRemarkEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRemarkEdit.Click
        Try
            If DataGridViewRemark.Rows.Count > 0 Then
                Dim form As New ProcedureRemarkAddEditForm
                form.procedureAddEditForm = Me
                form.HeaderLabel.Text = "Procedure Remark - Edit"
                form.remarkID = DataGridViewRemark.CurrentRow.Cells(0).Value
                form.textRemark.Text = DataGridViewRemark.CurrentRow.Cells(1).Value
                form.dtPickerTransDate.Value = DataGridViewRemark.CurrentRow.Cells(2).Value
                form.ShowDialog()
            Else
                MessageBox.Show("No Item(s) to edit.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class