Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PatientAddEditForm
    Private patientSvc As IPatientService
    Public patientID As Integer = 0
    Public activeUser As String
    Public patientControl As PatientControl
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            patientSvc = New PatientService()
            Dim data As New Patient()
            Dim valid As Boolean = True

            For Each control As Control In Me.Controls
                If (control.GetType() Is GetType(TextBox)) Then
                    Dim textBox As TextBox = CType(control, TextBox)
                    If textBox.Text = String.Empty And textBox.Name <> "textOccupation" And textBox.Name <> "textMI" Then
                        valid = False
                    End If
                ElseIf (control.GetType() Is GetType(ComboBox)) Then
                    Dim comboBox As ComboBox = CType(control, ComboBox)
                    If comboBox.Text = String.Empty Or comboBox.Text.Contains("Select") Then
                        valid = False
                    End If
                End If
            Next

            If valid Then
                data.Firstname = textFirstname.Text
                data.Lastname = textLastname.Text
                data.MiddleName = textMI.Text
                data.Suffix = comboSuffix.Text
                data.AddressNumber = textHouseNumber.Text
                data.AddressStreetBuilding = textStreet.Text
                data.AddressMunicipality = textCity.Text
                data.BirthDate = dateBirthdate.Value.Date
                data.Age = textAge.Text
                data.Gender = comboGender.Text
                data.Occupation = textOccupation.Text
                data.CivilStatus = comboCivilStatus.Text
                data.ContactNumber = textContactNumber.Text
                If HeaderLabel.Text.Contains("Edit") Then
                    Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = DialogResult.Yes Then
                        data.ID = patientID
                        data.UpdatedBy = activeUser
                        Dim ret As Long = patientSvc.PatientEdit(data)
                        If ret > 0 Then
                            MessageBox.Show("Patient Profile Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            patientControl.LoadData("")
                            Me.Dispose()
                        End If
                    End If
                Else
                    data.CreatedBy = activeUser
                    Dim ret As Long = patientSvc.PatientCreate(data)
                    If ret > 0 Then
                        MessageBox.Show("Patient Profile Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        patientControl.LoadData("")
                        Me.Dispose()
                    Else
                        MessageBox.Show("Patient Profile Already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Fill up all the required fields", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboGender.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboMaritalStatus_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub textFirstname_Leave(sender As Object, e As EventArgs) Handles textFirstname.Leave
        textFirstname.Text = StrConv(textFirstname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textLastname_Leave(sender As Object, e As EventArgs) Handles textLastname.Leave
        textLastname.Text = StrConv(textLastname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textMI_Leave(sender As Object, e As EventArgs) Handles textMI.Leave
        textMI.Text = StrConv(textMI.Text, VbStrConv.ProperCase)
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

    Private Sub buttonSave_Load(sender As Object, e As EventArgs) Handles buttonSave.Load

    End Sub

    Private Sub PatientAddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If HeaderLabel.Text.Contains("Edit") Then
            Try
                patientSvc = New PatientService()
                Dim data As New Patient()
                data = patientSvc.PatientSearchID(patientID)
                textFirstname.Text = data.Firstname
                textMI.Text = data.MiddleName
                textLastname.Text = data.Lastname
                comboSuffix.Text = data.Suffix
                textHouseNumber.Text = data.AddressNumber
                textStreet.Text = data.AddressStreetBuilding
                textCity.Text = data.AddressMunicipality
                dateBirthdate.Value = data.BirthDate
                textAge.Text = data.Age
                comboGender.Text = data.Gender
                textOccupation.Text = data.Occupation
                comboCivilStatus.Text = data.CivilStatus
                textContactNumber.Text = data.ContactNumber
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dateBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dateBirthdate.ValueChanged
        Dim dt1 As Date = dateBirthdate.Value.Date
        Dim dt2 As Date = DateTime.Now.Date
        Dim dt3 As TimeSpan = (dt2 - dt1)
        Dim diff As Double = dt3.Days

        textAge.Text = Str(Int(diff / 365.25))
    End Sub

    Private Sub textContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textContactNumber.KeyPress
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

    Private Sub textStreet_Leave(sender As Object, e As EventArgs) Handles textStreet.Leave
        textStreet.Text = StrConv(textStreet.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textCity_Leave(sender As Object, e As EventArgs) Handles textCity.Leave
        textCity.Text = StrConv(textCity.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub comboSuffix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSuffix.KeyPress
        e.Handled = True
    End Sub

    Private Sub textFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textFirstname.KeyPress
        Dim AllowedKeys As String = "abcdefghijklmnopqrstuvwxyz-"
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

    Private Sub textLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLastname.KeyPress
        Dim AllowedKeys As String = "abcdefghijklmnopqrstuvwxyz-"
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

    Private Sub textMI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMI.KeyPress
        Dim AllowedKeys As String = "abcdefghijklmnopqrstuvwxyz-"
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