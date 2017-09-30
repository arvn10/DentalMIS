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
                Dim procedureTypeControl As New ProcedureTypeControl
                procedureTypeControl.Dock = DockStyle.Fill
                PanelMain.Controls.Add(procedureTypeControl)
            Case "Patient Marital Status"
                ClearControls(PanelMain)
                Dim patientMaritalStatusControl As New PatientMaritalStatusControl
                patientMaritalStatusControl.Dock = DockStyle.Fill
                PanelMain.Controls.Add(patientMaritalStatusControl)
            Case "User"
                ClearControls(PanelMain)
                Dim userControl As New UserControl
                userControl.Dock = DockStyle.Fill
                PanelMain.Controls.Add(userControl)
        End Select
    End Sub

    Private Sub ConfigurationControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
