Imports DentalMIS.BLL
Public Class PatientDentalRecordForm
    Public patientID As Integer
    Public activeUser As String



    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class