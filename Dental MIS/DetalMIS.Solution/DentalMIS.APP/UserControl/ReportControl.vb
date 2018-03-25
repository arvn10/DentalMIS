Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ReportControl
    Private procedureSvc As IProcedureService
    Private scheduleSvc As IScheduleService
    Private patientSvc As IPatientService
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TreeViewConfig.SelectedNode.Text = String.Empty Then
            MessageBox.Show("Select Report Type", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim reportType As String
            Dim data As List(Of ProcedureReport)
            Dim schedules As List(Of MODEL.ScheduleReport)
            Dim patientList As List(Of MODEL.PatientReport)
            procedureSvc = New ProcedureService()
            Select Case TreeViewConfig.SelectedNode.Text
                Case "All"
                    data = procedureSvc.ProcedureSearchPaymentReport("", dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
                    reportType = "Procedure Report - All"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Paid"
                    data = procedureSvc.ProcedureSearchPaymentReport("Paid", dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
                    reportType = "Procedure Report - Paid Procedures"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Not Paid"
                    data = procedureSvc.ProcedureSearchPaymentReport("Not Paid", dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
                    reportType = "Procedure Report - Not Paid Procedures"
                    transactionReport1.SetDataSource(data)
                    transactionReport1.SetParameterValue("reportType", reportType)
                    CrystalReportViewer1.ReportSource = transactionReport1
                    CrystalReportViewer1.Refresh()
                Case "Schedule"
                    scheduleSvc = New ScheduleService
                    schedules = scheduleSvc.ScheduleReport(dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
                    scheduleReport1.SetDataSource(schedules)
                    CrystalReportViewer1.ReportSource = scheduleReport1
                    CrystalReportViewer1.Refresh()
                Case "Patient"
                    patientSvc = New PatientService
                    patientList = patientSvc.PatientSearchReport(dtPickerFrom.Value.ToString("yyyy-MM-dd"), dtPickerTo.Value.ToString("yyyy-MM-dd"))
                    patientReport1.SetDataSource(patientList)
                    CrystalReportViewer1.ReportSource = patientReport1
                    CrystalReportViewer1.Refresh()
            End Select
        End If



    End Sub

    Private Sub TreeViewConfig_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewConfig.AfterSelect
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Refresh()
        Dim reportType As String
        Dim data As List(Of ProcedureReport)
        Dim schedules As List(Of MODEL.ScheduleReport)
        Dim patientList As List(Of MODEL.PatientReport)
        procedureSvc = New ProcedureService()
        Select Case TreeViewConfig.SelectedNode.Text
            Case "All"
                data = procedureSvc.ProcedureSearchPaymentReport("", "", "")
                reportType = "Procedure Report - All"
                transactionReport1.SetDataSource(data)
                transactionReport1.SetParameterValue("reportType", reportType)
                CrystalReportViewer1.ReportSource = transactionReport1
                CrystalReportViewer1.Refresh()
            Case "Paid"
                data = procedureSvc.ProcedureSearchPaymentReport("Paid", "", "")
                reportType = "Procedure Report - Paid Procedures"
                transactionReport1.SetDataSource(data)
                transactionReport1.SetParameterValue("reportType", reportType)
                CrystalReportViewer1.ReportSource = transactionReport1
                CrystalReportViewer1.Refresh()
            Case "Not Paid"
                data = procedureSvc.ProcedureSearchPaymentReport("Not Paid", "", "")
                reportType = "Procedure Report - Not Paid Procedures"
                transactionReport1.SetDataSource(data)
                transactionReport1.SetParameterValue("reportType", reportType)
                CrystalReportViewer1.ReportSource = transactionReport1
                CrystalReportViewer1.Refresh()
            Case "Schedule"
                scheduleSvc = New ScheduleService
                schedules = scheduleSvc.ScheduleReport("", "")
                scheduleReport1.SetDataSource(schedules)
                CrystalReportViewer1.ReportSource = scheduleReport1
                CrystalReportViewer1.Refresh()
            Case "Patient"
                patientSvc = New PatientService
                patientList = patientSvc.PatientSearchReport("", "")
                patientReport1.SetDataSource(patientList)
                CrystalReportViewer1.ReportSource = patientReport1
                CrystalReportViewer1.Refresh()
        End Select
    End Sub
End Class
