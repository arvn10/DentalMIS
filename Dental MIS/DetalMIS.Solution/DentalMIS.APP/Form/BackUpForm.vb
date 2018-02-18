Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class BackUpForm
    Dim con As MySqlConnection
    Dim command As MySqlCommand
    Dim backup As MySqlBackup

    Dim currentTable As String

    Dim totalRowsInCurrentTable As Integer = 0
    Dim totalRowsInAllTables As Integer = 0
    Dim currentRowIndexInCurrentTable As Integer = 0
    Dim currentRowIndexInAllTable As Integer = 0
    Dim totalTables As Integer = 0
    Dim currentTableIndex As Integer = 0
    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click

        CircleProgressBar.Value = 0
        currentTable = String.Empty
        totalTables = 0
        currentTableIndex = 0
        con = New MySqlConnection(Configuration.ConfigurationManager.ConnectionStrings("DentalMIS.Connection").ConnectionString())
        command = New MySqlCommand()
        command.Connection = con
        con.Open()

        backup.ExportInfo.IntervalForProgressReport = 50
        backup.ExportInfo.GetTotalRowsBeforeExport = True
        backup.ExportInfo.AddCreateDatabase = True
        backup.ExportInfo.ExportFunctions = True
        backup.ExportInfo.ExportProcedures = True
        backup.ExportInfo.ExportViews = True
        backup.ExportInfo.ExportEvents = True
        backup.Command = command
        bwExport.RunWorkerAsync()
    End Sub

    Private Sub BackUpForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        backup = New MySqlBackup()
    End Sub

    Sub exportProgessChanged(sender As Object, e As ExportProgressArgs)
        currentRowIndexInAllTable = e.CurrentRowIndexInAllTables
        currentRowIndexInCurrentTable = e.CurrentRowIndexInCurrentTable
        currentTableIndex = e.CurrentTableIndex
        currentTable = e.CurrentTableName.ToString()
        totalRowsInAllTables = e.TotalRowsInAllTables
        totalRowsInCurrentTable = e.TotalRowsInCurrentTable
        totalTables = e.TotalTables
    End Sub

    Private Sub bwExport_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwExport.RunWorkerCompleted
        If IsNothing(backup.LastError) Then
            CircleProgressBar.Value = CircleProgressBar.MaxValue
            Me.Refresh()
            MessageBox.Show("Backup Complete", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Backup Completed with error(s)" + vbNewLine + backup.LastError.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bwExport_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwExport.DoWork
        Try
            backup.ExportToFile(textSavePath.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircleProgressBar.MaxValue = totalTables
        If currentTableIndex < CircleProgressBar.MaxValue Then
            CircleProgressBar.Value = currentTableIndex
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub buttonBrowse_Click(sender As Object, e As EventArgs) Handles buttonBrowse.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            textSavePath.Text = FolderBrowserDialog1.SelectedPath + "\DentalMIS Backup " + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".sql"
        End If
    End Sub
End Class