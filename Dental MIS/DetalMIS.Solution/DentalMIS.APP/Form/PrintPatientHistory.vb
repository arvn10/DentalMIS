Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class PrintPatientHistory
    Public patientID As Long
    Private procedureSvc As IProcedureService
    Private patientService As IPatientService
    Private Sub PrintPatientHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        procedureSvc = New ProcedureService
        patientService = New PatientService
        Dim patient As New Patient()
        patient = patientService.PatientSearchID(patientID)
        Dim procedures As List(Of ProcedureHistoryReport) = procedureSvc.ProcedureSearchProcedureReport(patientID, "", "", "")
        patientProcedureReport1.SetDataSource(procedures)
        patientProcedureReport1.SetParameterValue("Fullname", patient.FullName)
        patientProcedureReport1.SetParameterValue("Address", patient.Address)
        patientProcedureReport1.SetParameterValue("Gender", patient.Gender)
        patientProcedureReport1.SetParameterValue("Age", patient.Age)
        CrystalReportViewer1.ReportSource = patientProcedureReport1
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class