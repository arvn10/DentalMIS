Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PrintDentalCertificateForm
    Public procedureID As Long
    Private procedureSvc As IProcedureService
    Private Sub PrintDentalCertificateForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        procedureSvc = New ProcedureService()
        Dim procedure As New Procedure
        procedure = procedureSvc.ProcedureSearchID(procedureID)
        dentalCertificate1.SetParameterValue("name", procedure.FullName)
        dentalCertificate1.SetParameterValue("age", procedure.Age)
        dentalCertificate1.SetParameterValue("gender", procedure.Gender)
        dentalCertificate1.SetParameterValue("address", procedure.Address)
        dentalCertificate1.SetParameterValue("procedure", procedure.Tooth + " " + procedure.ProcedureName)
        dentalCertificate1.SetParameterValue("remarks", procedure.Notes)
        dentalCertificate1.SetParameterValue("doctor", procedure.ProcedureCreatedBy)
        CrystalReportViewer1.ReportSource = dentalCertificate1
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class