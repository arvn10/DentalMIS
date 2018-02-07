Imports DentalMIS.BLL
Imports DentalMIS.DAL
Imports DentalMIS.MODEL
Public Class PaymentService
    Implements IPaymentService
    Private paymentRepository As PaymentRepository

    Public Sub New()
        paymentRepository = New PaymentRepository()
    End Sub

    Public Function PaymentCreate(param As Payment) As Long Implements IPaymentService.PaymentCreate
        Return paymentRepository.PaymentCreate(param)
    End Function

    Public Function PaymentEdit(param As Payment) As Long Implements IPaymentService.PaymentEdit
        Return paymentRepository.PaymentEdit(param)
    End Function

    Public Function PaymentSearchID(id As Long) As Payment Implements IPaymentService.PaymentSearchID
        Return paymentRepository.PaymentSearchID(id)
    End Function

    Public Function PaymentSearchProcedureID(procedureID As Long) As List(Of Payment) Implements IPaymentService.PaymentSearchProcedureID
        Return paymentRepository.PaymentSearchProcedureID(procedureID)
    End Function
End Class
