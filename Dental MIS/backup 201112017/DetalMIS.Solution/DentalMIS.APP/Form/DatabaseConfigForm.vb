Imports System.ComponentModel
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class DatabaseConfigForm
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
                Dim connectionString As String = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", textServer.Text, comboDatabase.Text, textUsername.Text, textPassword.Text)

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
        If e.Result = True Then
            LoginForm.ButtonSettingDisconnected.Visible = False
            LoginForm.ButtonSettingConnected.Visible = True
            Me.Dispose()
        ElseIf e.Cancelled Then
            LoginForm.ButtonSettingConnected.Visible = False
            LoginForm.ButtonSettingDisconnected.Visible = True
            Me.Dispose()
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub comboDatabase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboDatabase.KeyPress
        e.Handled = True
    End Sub

    Private Sub textPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPassword.KeyPress
        Try
            Dim constring As String = String.Format("Server={0};Database=sys;Uid={1};Pwd={2};", textServer.Text, textUsername.Text, textPassword.Text)
            Dim con As New MySqlConnection(constring)
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            If textServer.Text <> String.Empty And textPassword.Text <> String.Empty And textUsername.Text <> String.Empty Then
                con.Open()
                da = New MySqlDataAdapter("SHOW DATABASES", con)
                da.Fill(ds)
                comboDatabase.DisplayMember = "Database"
                comboDatabase.ValueMember = "Database"
                comboDatabase.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textUsername_Leave(sender As Object, e As EventArgs) Handles textUsername.Leave
        Try
            Dim constring As String = String.Format("Server={0};Database=sys;Uid={1};Pwd={2};", textServer.Text, textUsername.Text, textPassword.Text)
            Dim con As New MySqlConnection(constring)
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            If textServer.Text <> String.Empty And textPassword.Text <> String.Empty And textUsername.Text <> String.Empty Then
                con.Open()
                da = New MySqlDataAdapter("SHOW DATABASES", con)
                da.Fill(ds)
                comboDatabase.DisplayMember = "Database"
                comboDatabase.ValueMember = "Database"
                comboDatabase.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textServer_Leave(sender As Object, e As EventArgs) Handles textServer.Leave
        Try
            Dim constring As String = String.Format("Server={0};Database=sys;Uid={1};Pwd={2};", textServer.Text, textUsername.Text, textPassword.Text)
            Dim con As New MySqlConnection(constring)
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            If textServer.Text <> String.Empty And textPassword.Text <> String.Empty And textUsername.Text <> String.Empty Then
                con.Open()
                da = New MySqlDataAdapter("SHOW DATABASES", con)
                da.Fill(ds)
                comboDatabase.DisplayMember = "Database"
                comboDatabase.ValueMember = "Database"
                comboDatabase.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DatabaseConfigForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim constring As String = ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString
            Dim databaseName As String = String.Empty
            Dim conStringParts() As String = constring.Split(";")
            For Each part As String In conStringParts
                Dim field() As String = part.Split("=")
                If field(0) = "Server" Then
                    textServer.Text = field(1)
                ElseIf field(0) = "Database" Then
                    databaseName = field(1)
                ElseIf field(0) = "Uid" Then
                    textUsername.Text = field(1)
                ElseIf field(0) = "Pwd" Then
                    textPassword.Text = field(1)
                End If
            Next

            Dim con As New MySqlConnection(String.Format("Server={0};Database=sys;Uid={1};Pwd={2};", textServer.Text, textUsername.Text, textPassword.Text))
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            If textServer.Text <> String.Empty And textPassword.Text <> String.Empty And textUsername.Text <> String.Empty Then
                con.Open()
                da = New MySqlDataAdapter("SHOW DATABASES", con)
                da.Fill(ds)
                comboDatabase.DisplayMember = "Database"
                comboDatabase.ValueMember = "Database"
                comboDatabase.DataSource = ds.Tables(0)
                If databaseName <> String.Empty Then
                    comboDatabase.Text = databaseName
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buttonTest_Click(sender As Object, e As EventArgs) Handles buttonTest.Click
        Try
            Dim con As New MySqlConnection(ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString)
            con.Open()
            If con.State = ConnectionState.Open Then
                MessageBox.Show("Success connecting to database.", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Dispose()
    End Sub
End Class