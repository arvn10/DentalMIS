Public Class ConfigurationControl
    Public Sub ClearControls(panel As Panel)
        For Each control As Control In panel.Controls
            PanelMain.Controls.Remove(control)
        Next
    End Sub

    Private Sub TreeViewConfig_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewConfig.AfterSelect
        Select Case e.Node.Text
            Case "Procedure Type"
                ClearControls(PanelMain)
                Dim control As New ProcedureTypeControl
                control.Dock = DockStyle.Fill
                PanelMain.Controls.Add(control)
            Case "Audit Trail"
                ClearControls(PanelMain)
                Dim control As New AuditTrailControl
                control.Dock = DockStyle.Fill
                PanelMain.Controls.Add(control)
            Case "User"
                ClearControls(PanelMain)
                Dim control As New UserControl
                control.Dock = DockStyle.Fill
                PanelMain.Controls.Add(control)
            Case "Secret Question"
                ClearControls(PanelMain)
                Dim control As New SecretQuestionControl
                control.Dock = DockStyle.Fill
                PanelMain.Controls.Add(control)
            Case "Backup"
                ClearControls(PanelMain)
                Dim control As New BackUpDatabaseControl
                control.Dock = DockStyle.Fill
                PanelMain.Controls.Add(control)
                BackUpForm.ShowDialog()
        End Select
    End Sub

    Private Sub ConfigurationControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
