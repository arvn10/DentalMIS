﻿Imports DentalMIS.MODEL
Public Interface IPatientService
    Function PatientCreate(param As Patient) As Long
    Function PatientEdit(param As Patient) As Long
    Function PatientSearchID(id As Long) As Patient
    Function PatientSearchLike(searchText As String) As List(Of Patient)
    Function PatientSearchReport([from] As String, [to] As String) As List(Of PatientReport)
End Interface
