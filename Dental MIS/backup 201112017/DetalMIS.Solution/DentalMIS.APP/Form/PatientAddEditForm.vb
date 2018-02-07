Imports DentalMIS.BLL
Public Class PatientAddEditForm
    Private patientSvc As PatientService
    Private maritalStatusSvc As PatientMaritalStatusService
    Public patientID As Integer = 0
    Public activeUser As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        patientSvc = New PatientService()
        maritalStatusSvc = New PatientMaritalStatusService()

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            If HeaderLabel.Text.Contains("Edit") Then
                Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    Dim data As New PatientEdit()
                    data.ID = patientID
                    data.Firstname = textFirstname.Text
                    data.Lastname = textLastname.Text
                    data.MiddleInitial = textMI.Text
                    data.Address = textAddres.Text
                    data.Age = Convert.ToInt32(textAge.Text)
                    data.Gender = comboGender.Text
                    data.PatientMaritalStatusID = comboMaritalStatus.SelectedValue
                    data.Occupation = textOccupation.Text
                    data.UpdatedBy = activeUser
                    Dim ret As Long = patientSvc.PatientEdit(data)
                    If ret > 0 Then
                        MessageBox.Show("Patient Profile Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Patient Profile Already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                Dim valid As Boolean = True

                For Each control As Control In Me.Controls
                    If (control.GetType() Is GetType(TextBox)) Then
                        Dim textBox As TextBox = CType(control, TextBox)
                        If textBox.Text = String.Empty And textBox.Name <> "textOccupation" And textBox.Name <> "textMI" Then
                            valid = False
                        End If
                    ElseIf (control.GetType() Is GetType(ComboBox)) Then
                        Dim comboBox As ComboBox = CType(control, ComboBox)
                        If comboBox.Text = String.Empty Then
                            valid = False
                        End If
                    End If
                Next

                If valid Then
                    Dim data As New PatientCreate()
                    data.Firstname = textFirstname.Text
                    data.Lastname = textLastname.Text
                    data.MiddleInitial = textMI.Text
                    data.Address = textAddres.Text
                    data.Age = Convert.ToInt32(textAge.Text)
                    data.Gender = comboGender.Text
                    data.PatientMaritalStatusID = comboMaritalStatus.SelectedValue
                    data.Occupation = textOccupation.Text
                    data.CreatedBy = activeUser
                    Dim ret As Long = patientSvc.PatientCreate(data)
                    If ret > 0 Then
                        MessageBox.Show("Patient Profile Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Patient Profile Already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Fill up all the required fields", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboGender.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboMaritalStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboMaritalStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub PatientAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        comboMaritalStatus.DisplayMember = "Name"
        comboMaritalStatus.ValueMember = "ID"
        comboMaritalStatus.DataSource = maritalStatusSvc.PatientMaritalStatusSearchLike("")
        comboMaritalStatus.Text = "-Select Item-"
        Try
            If HeaderLabel.Text.Contains("Edit") Then
                Dim data As New PatientView
                data = patientSvc.PatientSearchID(patientID)(0)
                textFirstname.Text = data.Firstname
                textLastname.Text = data.Lastname
                textMI.Text = data.MiddleInitial
                textAddres.Text = data.Address
                textAge.Text = data.Age
                comboGender.Text = data.Gender
                comboMaritalStatus.Text = data.MaritalStatus
                textOccupation.Text = data.Occupation
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub textFirstname_Leave(sender As Object, e As EventArgs) Handles textFirstname.Leave
        textFirstname.Text = StrConv(textFirstname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textLastname_Leave(sender As Object, e As EventArgs) Handles textLastname.Leave
        textLastname.Text = StrConv(textLastname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textMI_Leave(sender As Object, e As EventArgs) Handles textMI.Leave
        textMI.Text = StrConv(textMI.Text, VbStrConv.Uppercase)
    End Sub

    Private Sub textAddres_Leave(sender As Object, e As EventArgs) Handles textAddres.Leave
        textAddres.Text = StrConv(textAddres.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textOccupation_Leave(sender As Object, e As EventArgs) Handles textOccupation.Leave
        textOccupation.Text = StrConv(textOccupation.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textAge.KeyPress
        Dim AllowedKeys As String = "0123456789"
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)

            Case Convert.ToChar(Keys.Back)
                e.Handled = False

            Case Convert.ToChar(Keys.Space)
                e.Handled = False

            Case Convert.ToChar(Keys.Space)
                e.Handled = False

            Case Convert.ToChar(Keys.Left)
                e.Handled = False

            Case Convert.ToChar(Keys.Right)
                e.Handled = False

            Case Convert.ToChar(Keys.Up)
                e.Handled = False

            Case Convert.ToChar(Keys.Down)
                e.Handled = False

            Case Convert.ToChar(Keys.Capital Or Keys.RButton)
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))

            Case Else
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)
        End Select
    End Sub
End Class