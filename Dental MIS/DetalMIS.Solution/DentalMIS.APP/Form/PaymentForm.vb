Public Class PaymentForm
    Public procedureID As Long
    Public activeUser As String
    Public paymentControl As PaymentControl

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim paymentDetail = New PaymentDetail
        paymentDetail.TopLevel = False
        paymentDetail.Height = Panel1.Height
        paymentDetail.Width = Panel1.Width
        paymentDetail.procedureID = procedureID
        paymentDetail.activeUser = activeUser
        paymentDetail.paymentControl = paymentControl
        Panel1.Controls.Add(paymentDetail)
        paymentDetail.Show()
    End Sub
End Class