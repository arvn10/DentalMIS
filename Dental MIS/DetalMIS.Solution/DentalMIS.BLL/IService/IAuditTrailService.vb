Imports DentalMIS.MODEL
Public Interface IAuditTrailService
    Sub AuditTrailCreate(param As AuditTrail)
    Function AuditTrailSelect([from] As String, [to] As String) As List(Of AuditTrail)
End Interface
