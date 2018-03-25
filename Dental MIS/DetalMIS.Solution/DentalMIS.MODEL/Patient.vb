Public Class Patient
    Public Property ID As Long
    Public Property PatientNumber As String
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property MiddleName As String
    Public Property Suffix As String
    Public Property FullName As String
    Public Property AddressNumber As String
    Public Property AddressStreetBuilding As String
    Public Property AddressMunicipality As String
    Public Property Address As String
    Public Property BirthDate As Date
    Public Property Age As Integer
    Public Property Gender As String
    Public Property Occupation As String
    Public Property ContactNumber As String
    Public Property CivilStatus As String
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class

Public Class PatientReport
    Public Property PatientNumber As String
    Public Property FullName As String
    Public Property Address As String
    Public Property Gender As String
    Public Property Age As Integer
    Public Property ContactNumber As String
End Class

