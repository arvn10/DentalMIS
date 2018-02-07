Imports DentalMIS.MODEL

Public Interface IPaymentService
    Function PaymentCreate(param As Payment) As Long
    Function PaymentEdit(param As Payment) As Long
    Function PaymentSearchID(id As Long) As Payment
    Function PaymentSearchProcedureID(procedureID As Long) As List(Of Payment)
End Interface
