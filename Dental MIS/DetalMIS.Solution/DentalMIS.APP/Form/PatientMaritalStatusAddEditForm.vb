Imports DentalMIS.BLL
Public Class PatientMaritalStatusAddEditForm
    Private patientMaritalStatusService As PatientMaritalStatusService
    Public patientMaritalStatusID As Integer = 0
    Public activeUser As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        patientMaritalStatusService = New PatientMaritalStatusService
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            If HeaderLabel.Text.Contains("Edit") Then
                Dim confirm = MessageBox.Show("Save Changes?", "OLAES DENTAL CLINIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    Dim data As New PatientMaritalStatusEdit()

                    data.ID = patientMaritalStatusID
                    data.Name = textName.Text
                    data.Status = If(comboStatus.Text = "Active", 1, 0)
                    data.UpdatedBy = activeUser
                    Dim ret As Long = patientMaritalStatusService.PatientMaritalStatusEdit(data)
                    If ret > 0 Then
                        MessageBox.Show("Patient Marital Status Saved!", "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                End If
            Else
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
                    MessageBox.Show("Fill up all fields.", "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim data As New PatientMaritalStatusCreate
                    data.Name = textName.Text
                    data.Status = If(comboStatus.Text = "Active", 1, 0)
                    data.CreatedBy = activeUser
                    Dim ret As Long = patientMaritalStatusService.PatientMaritalStatusCreate(data)
                    If ret > 0 Then
                        MessageBox.Show("Patient Marital Status Saved!", "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Patient Marital Status Exist!", "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PatientMaritalStatusAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If HeaderLabel.Text.Contains("Edit") Then
                Dim data As New PatientMaritalStatusView
                data = patientMaritalStatusService.PatientMaritalStatusSearchID(patientMaritalStatusID)(0)
                textName.Text = data.Name
                comboStatus.Text = data.Status
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "OLAES DENTAL CLINIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub comboStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStatus.KeyPress
        e.Handled = True
    End Sub
End Class