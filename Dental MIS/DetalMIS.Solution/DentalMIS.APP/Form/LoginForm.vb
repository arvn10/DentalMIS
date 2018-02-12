Imports System.ComponentModel
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class LoginForm
    Private userService As IUserService
    Private auditTrailService As IAuditTrailService
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        userService = New UserService()
    End Sub

    Private Sub Login()
        If textUsername.Text = String.Empty Or textPassword.Text = String.Empty Then
            MessageBox.Show("Enter Username and the Password.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.Height = 231
                LabelConnecting.Text = "Logging in..."
                Dim userList As New List(Of User)
                userList = userService.UserLogin(textUsername.Text, textPassword.Text)
                If userList.Count > 0 Then
                    Dim user As User = userList(0)
                    Dim dashboardControl As New DashboardControl
                    MainForm.userID = user.ID
                    MainForm.user = user

                    If user.UserType = "Doctor" Or user.UserType = "Administrator" Then
                        MainForm.ButtonConfiguration.Enabled = True
                        MainForm.ButtonReport.Enabled = True
                    End If

                    MainForm.LabelMenu.Text = user.Firstname & " " & user.Lastname
                    MainForm.PanelSideMenu.Visible = True
                    MainForm.PanelMain.Visible = True
                    dashboardControl.Dock = DockStyle.Fill
                    MainForm.PanelMain.Controls.Add(dashboardControl)

                    textUsername.Clear()
                    textPassword.Clear()
                    textUsername.Select()
                Else
                    MessageBox.Show("Username or Password is incorrect.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textUsername.Clear()
                    textPassword.Clear()
                    textUsername.Select()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundCheckDBCon.RunWorkerAsync()
        textUsername.Select()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
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

    Private Sub ButtonSettingDisconnected_Click(sender As Object, e As EventArgs) Handles ButtonSettingDisconnected.Click
        Try
            DatabaseConfigForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonSettingConnected_Click(sender As Object, e As EventArgs) Handles ButtonSettingConnected.Click
        Try
            DatabaseConfigForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Try
            Login()
        Catch ex As Exception

        End Try
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

    Private Sub BackgroundCheckDBCon_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCheckDBCon.RunWorkerCompleted
        If e.Result Then
            buttonLogin.Enabled = True
            ButtonSettingConnected.Visible = True
            ButtonSettingDisconnected.Visible = False
            Me.Height = 231
            LabelConnecting.Visible = False
        ElseIf e.Cancelled Then
            buttonLogin.Enabled = False
            ButtonSettingDisconnected.Visible = True
            ButtonSettingConnected.Visible = False
            Me.Height = 231
            LabelConnecting.Visible = False
        End If
    End Sub
End Class