Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class UserAddEditForm
    Private userService As IUserService
    Public userID As Long
    Public activeUser As String
    Public userControl As UserControl
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userService = New UserService()

    End Sub
    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            Dim param As New User()
            If HeaderLabel.Text.Contains("New") Then
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
                    param.Username = textUsername.Text
                    param.Password = textPassword.Text
                    param.Firstname = textFirstname.Text
                    param.Lastname = textLastname.Text
                    param.UserTypeID = comboUserType.SelectedValue
                    param.Status = If(comboStatus.Text = "Active", 1, 0)
                    param.CreatedBy = activeUser
                    Dim ret As Long = userService.UserCreate(param)
                    If ret > 0 Then
                        MessageBox.Show("User Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        userControl.LoadData("")
                        Me.Dispose()
                    Else
                        MessageBox.Show("User Exist!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Else
                Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    param.ID = userID
                    param.Username = textUsername.Text
                    param.Password = textPassword.Text
                    param.Firstname = textFirstname.Text
                    param.Lastname = textLastname.Text
                    param.UserTypeID = comboUserType.SelectedValue
                    param.Status = If(comboStatus.Text = "Active", 1, 0)
                    param.UpdatedBy = activeUser
                    Dim ret As Long = userService.UserEdit(param)
                    If ret > 0 Then
                        MessageBox.Show("User Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        userControl.LoadData("")
                        Me.Dispose()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UserAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            For Each control As Control In Me.Controls
                If (control.GetType() Is GetType(TextBox)) Then
                    Dim textBox As TextBox = CType(control, TextBox)
                    textBox.Text = String.Empty

                ElseIf (control.GetType() Is GetType(ComboBox)) Then
                    Dim comboBox As ComboBox = CType(control, ComboBox)
                    comboBox.Text = String.Empty
                End If
            Next

            Dim userTypeService As New UserTypeService
            comboUserType.DisplayMember = "Name"
            comboUserType.ValueMember = "ID"
            comboUserType.DataSource = userTypeService.UserTypeGet
            comboUserType.Text = ""
            If HeaderLabel.Text.Contains("Edit") Then
                Dim data As New User
                data = userService.UserSearchID(userID).ToList()(0)
                textUsername.Text = data.Username
                textPassword.Text = data.Password
                textFirstname.Text = data.Firstname
                textLastname.Text = data.Lastname
                comboUserType.Text = data.UserType
                comboStatus.Text = data.Status
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub comboUserType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboUserType.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub textFirstname_Leave(sender As Object, e As EventArgs) Handles textFirstname.Leave
        textFirstname.Text = StrConv(textFirstname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub textLastname_Leave(sender As Object, e As EventArgs) Handles textLastname.Leave
        textLastname.Text = StrConv(textLastname.Text, VbStrConv.ProperCase)
    End Sub
End Class