Public Interface IDoctorService
    Function DoctorCreate(param As DoctorCreate)
    Function DoctorEdit(param As DoctorEdit)
    Function DoctorSearchID(id As Long) As List(Of DoctorView)
End Interface
