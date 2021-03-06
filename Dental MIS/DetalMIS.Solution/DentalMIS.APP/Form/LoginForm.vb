﻿Imports System.ComponentModel
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class LoginForm
    Private userService As IUserService
    Private auditTrailService As IAuditTrailService
    Dim attempts As Integer = 0
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Login()
        userService = New UserService()
        If textUsername.Text = String.Empty Or textPassword.Text = String.Empty Then
            MessageBox.Show("Enter Username and the Password.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            attempts += 1
            If attempts > 2 Then
                Try
                    attempts = 0
                    Dim form As New LoginFailedForm
                    form.textUsername.Text = textUsername.Text
                    form.ShowDialog()
                Catch ex As Exception

                End Try
            End If
        Else
            Try
                Me.Height = 250
                LabelConnecting.Text = "Logging in..."
                Dim userList As New List(Of User)
                userList = userService.UserLogin(textUsername.Text, textPassword.Text)
                If userList.Count > 0 Then
                    Dim user As User = userList(0)
                    Dim dashboardControl As New DashboardControl
                    Dim form As New MainForm
                    MainForm.Refresh()
                    MainForm.userID = user.ID
                    MainForm.user = user

                    If user.UserType = "Doctor" Then
                        MainForm.ButtonConfiguration.Visible = True
                        MainForm.ButtonReport.Visible = True
                    Else
                        MainForm.ButtonConfiguration.Visible = False
                        MainForm.ButtonReport.Visible = False
                    End If

                    MainForm.LabelMenu.Text = user.Firstname & " " & user.Lastname
                    MainForm.ClearControls()
                    MainForm.PanelSideMenu.Visible = True
                    MainForm.PanelMain.Visible = True
                    dashboardControl.Dock = DockStyle.Fill
                    MainForm.PanelMain.Controls.Add(dashboardControl)

                    textUsername.Clear()
                    textPassword.Clear()
                    textUsername.Select()
                Else
                    MessageBox.Show("Username or Password is incorrect.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    attempts += 1
                    If attempts > 2 Then
                        Try
                            attempts = 0
                            Dim form As New LoginFailedForm
                            form.textUsername.Text = textUsername.Text
                            form.ShowDialog()
                        Catch ex As Exception

                        End Try
                    End If
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
            Me.Height = 250
            LabelConnecting.Visible = False
        ElseIf e.Cancelled Then
            buttonLogin.Enabled = False
            ButtonSettingDisconnected.Visible = True
            ButtonSettingConnected.Visible = False
            Me.Height = 250
            LabelConnecting.Visible = False
        End If
    End Sub

    Private Sub forgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotPassword.LinkClicked
        Dim form As New ForgotPasswordForm
        form.ShowDialog()
    End Sub
End Class