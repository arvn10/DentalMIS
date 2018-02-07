Public Interface IPatientService
    Function PatientCreate(param As PatientCreate) As Long
    Function PatientEdit(param As PatientEdit) As Long
    Function PatientSearchID(id As Long) As List(Of PatientView)
    Function PatientSearchAge(age As Long) As List(Of PatientView)
    Function PatientSearchLike(searchText As String) As List(Of PatientView)
End Interface
