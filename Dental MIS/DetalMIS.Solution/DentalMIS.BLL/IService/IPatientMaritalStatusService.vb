Imports DentalMIS.MODEL
Public Interface IPatientMaritalStatusService
    Function PatientMaritalStatusCreate(param As PatientMaritalStatus) As Long
    Function PatientMaritalStatusEdit(param As PatientMaritalStatus) As Long
    Function PatientMaritalStatusSearchID(id As Long) As List(Of PatientMaritalStatus)
    Function PatientMaritalStatusSearchStatus(Status As Integer) As List(Of PatientMaritalStatus)
    Function PatientMaritalStatusSearchLike(SearchValue As String) As List(Of PatientMaritalStatus)
End Interface
