Public Interface IPatientMaritalStatusService
    Function PatientMaritalStatusCreate(param As PatientMaritalStatusCreate) As Long
    Function PatientMaritalStatusEdit(param As PatientMaritalStatusEdit) As Long
    Function PatientMaritalStatusSearchID(id As Long) As List(Of PatientMaritalStatusView)
    Function PatientMaritalStatusSearchStatus(Status As Integer) As List(Of PatientMaritalStatusView)
    Function PatientMaritalStatusSearchLike(SearchValue As String) As List(Of PatientMaritalStatusView)
End Interface
