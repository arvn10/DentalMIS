Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ReportControl
    Private procedureSvc As IProcedureService
    Private scheduleSvc As IScheduleService
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TreeViewConfig.SelectedNode.Text = String.Empty Then
            MessageBox.Show("Select Report Type", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim reportType As String
            Dim data As List(Of ProcedureReport)
            Dim schedules As List(Of MODEL.ScheduleReport)
            procedureSvc = New ProcedureService()
            Select Case TreeViewConfig.SelectedNode.Text
                Case "All"
                    data = procedureSvc.ProcedureSearchPaymentReport("", dtPickerFrom.Value, dtPickerTo.Value)
                    reportType = "Procedure Report - All"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Paid"
                    data = procedureSvc.ProcedureSearchPaymentReport("Paid", dtPickerFrom.Value, dtPickerTo.Value)
                    reportType = "Procedure Report - Paid Procedures"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Not Paid"
                    data = procedureSvc.ProcedureSearchPaymentReport("Not Paid", dtPickerFrom.Value, dtPickerTo.Value)
                    reportType = "Procedure Report - Not Paid Procedures"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Schedule"
                    scheduleSvc = New ScheduleService
                    schedules = scheduleSvc.ScheduleReport(dtPickerFrom.Value, dtPickerTo.Value)
                    scheduleReport1.SetDataSource(schedules)
                    CrystalReportViewer1.ReportSource = scheduleReport1
                    CrystalReportViewer1.Refresh()
                    reportType = "Schedule Report"
            End Select
        End If



    End Sub

    Private Sub TreeViewConfig_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewConfig.AfterSelect
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Refresh()
    End Sub
End Class
