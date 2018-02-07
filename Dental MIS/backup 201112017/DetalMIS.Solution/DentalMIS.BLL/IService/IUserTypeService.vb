Public Interface IUserTypeService
    Function UserTypeCreate(param As UserTypeModel) As Long
    Function UserTypeUpdate(param As UserTypeModel) As Long
    Function UserTypeGet() As List(Of UserTypeModel)
End Interface
