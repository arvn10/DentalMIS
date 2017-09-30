Imports System.ComponentModel
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports DentalMIS.BLL
Public Class LoginForm
    Private userService As BLL.UserService
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Login()
        If textUsername.Text = String.Empty Or textPassword.Text = String.Empty Then
            MessageBox.Show("Enter Username and the Password.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                LabelConnecting.Text = "Logging in..."
                Dim userList As New List(Of UserView)
                userList = userService.UserLogin(textUsername.Text, textPassword.Text)
                If userList.Count > 0 Then
                    Dim user As UserView = userList(0)
                    formMain.LabelMenu.Text = user.Firstname & " " & user.Lastname
                    formMain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Username or Password is incorrect.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundCheckDBCon.RunWorkerAsync()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim confirmation = MessageBox.Show("Exit System?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = DialogResult.Yes Then
            Environment.Exit(0)
        End If
    End Sub

    Private Sub BackgroundCheckDBCon_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundCheckDBCon.DoWork
        Try
            Dim con As New MySqlConnection(ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString)
            con.Open()
            If con.State = ConnectionState.Open Then
                e.Result = True
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try

    End Sub

    Private Sub BackgroundCheckDBCon_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCheckDBCon.RunWorkerCompleted
        LabelConnecting.Visible = False
        If e.Cancelled Then
            ButtonSettingDisconnected.Enabled = True
            MessageBox.Show("An error occured while trying to connect on database. Kindly check your database configuration by clicking the disconnected wifi icon.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ButtonSettingDisconnected.Visible = True
            ButtonSettingConnected.Visible = False
            buttonLogin.Enabled = False
            textUsername.Enabled = False
            textPassword.Enabled = False
        ElseIf e.Result Then
            ButtonSettingDisconnected.Visible = False
            ButtonSettingConnected.Visible = True
            buttonLogin.Enabled = True
            textUsername.Enabled = True
            textPassword.Enabled = True
            Me.Width = 352
            userService = New UserService()
        End If
    End Sub

    Private Sub ButtonSettingDisconnected_Click(sender As Object, e As EventArgs) Handles ButtonSettingDisconnected.Click
        If Me.Width = 602 Then
            Me.Width = 352
        Else
            Dim constring As String = ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString
            Dim constringParts() As String = constring.Split(";")
            For Each part As String In constringParts
                Dim field() As String = part.Split("=")
                If field(0) = "Server" Then
                    textServer.Text = field(1)
                ElseIf field(0) = "Database" Then
                    textDatabase.Text = field(1)
                ElseIf field(0) = "Uid" Then
                    textDbUsername.Text = field(1)
                ElseIf field(0) = "Pwd" Then
                    textDbPassword.Text = field(1)
                End If
            Next
            Me.Width = 602
        End If

    End Sub

    Private Sub ButtonSettingConnected_Click(sender As Object, e As EventArgs) Handles ButtonSettingConnected.Click
        If Me.Width = 602 Then
            Me.Width = 352
        Else
            Dim constring As String = ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString
            Dim constringParts() As String = constring.Split(";")
            For Each part As String In constringParts
                Dim field() As String = part.Split("=")
                If field(0) = "Server" Then
                    textServer.Text = field(1)
                ElseIf field(0) = "Database" Then
                    textDatabase.Text = field(1)
                ElseIf field(0) = "Uid" Then
                    textDbUsername.Text = field(1)
                ElseIf field(0) = "Pwd" Then
                    textDbPassword.Text = field(1)
                End If
            Next
            Me.Width = 602
        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim valid As Boolean = True
            For Each ctrl As Control In PanelDatabase.Controls
                If (ctrl.GetType() Is GetType(TextBox)) Then
                    Dim textBox As TextBox = CType(ctrl, TextBox)
                    If textBox.Text = String.Empty And textBox.Name <> "textDbPassword" Then
                        valid = False
                    End If
                ElseIf (ctrl.GetType() Is GetType(ComboBox)) Then
                    Dim comboBox As ComboBox = CType(ctrl, ComboBox)
                    If comboBox.Text = String.Empty Then
                        valid = False
                    End If
                End If
            Next

            If valid Then
                Dim connectionString As String = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", textServer.Text, textDatabase.Text, textDbUsername.Text, textDbPassword.Text)

                Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                config.ConnectionStrings.ConnectionStrings("DentalMIS.Connection").ConnectionString = connectionString
                config.Save()
                ConfigurationManager.RefreshSection("connectionStrings")
                MessageBox.Show("Configuration Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BackgroundCheckDBCon.RunWorkerAsync()
            Else
                MessageBox.Show("Fillup and the required fields", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Login()
    End Sub

    Private Sub textPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Login()
        End If
    End Sub

    Private Sub textUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textUsername.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Login()
        End If
    End Sub
End Class