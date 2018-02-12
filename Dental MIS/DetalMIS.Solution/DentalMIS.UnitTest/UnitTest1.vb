Imports System.Text
Imports System.Data
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Private userService As BLL.UserService
    <TestMethod()> Public Sub TestMethod1()
        Console.WriteLine("test")
    End Sub

    <TestMethod()> Public Sub UserCreate()
        Dim svc As New PaymentService
        Dim payment As New Payment
        payment.ProcedureID = 1
        payment.AmountPaid = 100
        payment.TransactionDate = DateTime.Now().ToString("yyyy-MM-dd")
        payment.CreatedBy = "test"
        svc.PaymentCreate(payment)
    End Sub
End Class