Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Imports DentalMIS.DAL
Public Class ToothService
    Implements IToothService

    Private toothRepository As ToothRepository
    Public Sub New()
        toothRepository = New ToothRepository()
    End Sub
    Public Function ToothSearch() As List(Of Tooth) Implements IToothService.ToothSearch
        Return toothRepository.ToothSearch()
    End Function
End Class
