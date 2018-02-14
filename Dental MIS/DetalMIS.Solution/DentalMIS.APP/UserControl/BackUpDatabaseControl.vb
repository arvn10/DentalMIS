Public Class BackUpDatabaseControl
    Private Sub BackUpDatabaseControl_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub buttonBrowse_Click(sender As Object, e As EventArgs) Handles buttonBrowse.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            textSavePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click

    End Sub
End Class
