Imports DentalMIS.MODEL
Public Interface IUserTypeService
    Function UserTypeCreate(param As UserType) As Long
    Function UserTypeUpdate(param As UserType) As Long
    Function UserTypeGet() As List(Of UserType)
End Interface
