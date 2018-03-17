Imports System.Globalization
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureTypeAddEditForm
    Private procedureTypeService As IProcedureTypeService
    Public procedureTypeControl As ProcedureTypeControl
    Public procedureTypeID As Integer = 0
    Public activeUser As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        procedureTypeService = New ProcedureTypeService()
    End Sub

    Public Sub LoadData()
        Dim data As New List(Of ProcedureNotAllowed)
        data = procedureTypeService.ProcedureTypeNotAllowedSelect(procedureTypeID)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("procedureName").DataPropertyName = "ProcedureName"
        DataGrid.Columns("status").DataPropertyName = "Status"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub comboPaymentType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboPaymentType.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboMedCert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboMedCert.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub textBasePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBasePrice.KeyPress
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

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            Dim param As New ProcedureType()
            Dim valid As Boolean = True

            For Each control As Control In TabPageDetails.Controls
                If (control.GetType() Is GetType(TextBox)) Then
                    Dim textBox As TextBox = CType(control, TextBox)
                    If textBox.Text = String.Empty Then
                        valid = False
                    End If
                ElseIf (control.GetType() Is GetType(ComboBox)) Then
                    Dim comboBox As ComboBox = CType(control, ComboBox)
                    If comboBox.Text = String.Empty Then
                        If comboBox.Name = "comboStatus" Then
                            If HeaderLabel.Text.Contains("Edit") Then
                                valid = False
                            End If
                        Else
                            valid = False
                        End If
                    End If
                End If
            Next

            If Not valid Then
                MessageBox.Show("Fill up all fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else


                param.Name = textName.Text
                param.BasePrice = Double.Parse(textBasePrice.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
                param.PaymentType = comboPaymentType.Text
                param.RequireMedCert = If(comboMedCert.Text = "Yes", 1, 0)

                If HeaderLabel.Text.Contains("New") Then
                    param.Status = 1
                    param.CreatedBy = activeUser
                    Dim ret As Long = procedureTypeService.ProcedureTypeCreate(param)
                    If ret > 0 Then
                        MessageBox.Show("Procedure Type Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procedureTypeControl.LoadData("")
                        Me.Dispose()
                    Else
                        MessageBox.Show("Procedure Type Exist!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = DialogResult.Yes Then
                        param.ID = procedureTypeID
                        param.Status = If(comboStatus.Text = "Active", 1, 0)
                        param.UpdatedBy = activeUser
                        Dim ret As Long = procedureTypeService.ProcedureTypeEdit(param)
                        If ret > 0 Then
                            MessageBox.Show("Procedure Type Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            procedureTypeControl.LoadData("")
                            Me.Dispose()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProcedureTypeAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If HeaderLabel.Text.Contains("Edit") Then
                comboStatus.Visible = True
                Label5.Visible = True
                Dim data As New ProcedureType
                TabPageNotAllowed.Enabled = True
                LoadData()
                data = procedureTypeService.ProcedureTypeSearchID(procedureTypeID)
                textName.Text = data.Name
                textBasePrice.Text = data.BasePrice.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
                comboPaymentType.Text = data.PaymentType
                comboMedCert.Text = data.RequireMedCert
                comboStatus.Text = data.Status
            Else
                TabPageNotAllowed.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButtonShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowAll.Click
        LoadData()
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
        On Error Resume Next
        Dim form As New ProcedureTypeNotAllowedAddEditForm
        form.procedureTypeAddEditForm = Me
        form.activeUser = activeUser
        form.procedureTypeID = procedureTypeID
        form.HeaderLabel.Text = "Procedure Type Not Allowed - New"
        form.ShowDialog()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        On Error Resume Next
        Dim form As New ProcedureTypeNotAllowedAddEditForm
        form.procedureTypeAddEditForm = Me
        form.procedureTypeNotAllowedID = DataGrid.CurrentRow.Cells(0).Value
        form.activeUser = activeUser
        form.HeaderLabel.Text = "Procedure Type Not Allowed - Edit"
        form.ShowDialog()
    End Sub

    Private Sub textBasePrice_Enter(sender As Object, e As EventArgs) Handles textBasePrice.Enter
        If textBasePrice.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textBasePrice.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textBasePrice.Text = amount.ToString()
        End If
    End Sub

    Private Sub textBasePrice_Leave(sender As Object, e As EventArgs) Handles textBasePrice.Leave
        If textBasePrice.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textBasePrice.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textBasePrice.Text = amount.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        End If
    End Sub
End Class