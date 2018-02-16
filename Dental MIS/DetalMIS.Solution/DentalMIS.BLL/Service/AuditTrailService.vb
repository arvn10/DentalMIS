Imports DentalMIS.MODEL
Imports DentalMIS.DAL
Public Class AuditTrailService
    Implements IAuditTrailService
    Private auditTrailRepository As AuditTrailRepository

    Public Sub New()
        auditTrailRepository = New AuditTrailRepository()
    End Sub

    Public Sub AuditTrailCreate(param As AuditTrail) Implements IAuditTrailService.AuditTrailCreate
        auditTrailRepository.AuditTrailCreate(param)
    End Sub

    Public Function AuditTrailSelect(from As String, [to] As String) As List(Of AuditTrail) Implements IAuditTrailService.AuditTrailSelect
        Return auditTrailRepository.AuditTrailSelect([from], [to])
    End Function
End Class
