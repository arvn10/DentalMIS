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

            For Each control As Control In Me.Controls
                If (control.GetType() Is GetType(TextBox)) Then
                    Dim textBox As TextBox = CType(control, TextBox)
                    If textBox.Text = String.Empty Then
                        valid = False
                    End If
                ElseIf (control.GetType() Is GetType(ComboBox)) Then
                    Dim comboBox As ComboBox = CType(control, ComboBox)
                    If comboBox.Text = String.Empty Then
                        valid = False
                    End If
                End If
            Next

            If Not valid Then
                MessageBox.Show("Fill up all fields.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else


                param.Name = textName.Text
                param.BasePrice = Convert.ToDouble(textBasePrice.Text)
                param.PaymentType = comboPaymentType.Text
                param.RequireMedCert = If(comboMedCert.Text = "Yes", 1, 0)
                param.Status = If(comboStatus.Text = "Active", 1, 0)


                If HeaderLabel.Text.Contains("New") Then
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
                Dim data As New ProcedureType
                data = procedureTypeService.ProcedureTypeSearchID(procedureTypeID)
                textName.Text = data.Name
                textBasePrice.Text = data.BasePrice
                comboPaymentType.Text = data.PaymentType
                comboMedCert.Text = data.RequireMedCert
                comboStatus.Text = data.Status
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class