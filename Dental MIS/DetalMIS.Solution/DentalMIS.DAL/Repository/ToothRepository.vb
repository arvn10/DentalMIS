Imports DentalMIS.MODEL
Public Class ToothRepository
    Inherits Database

    Public Function ToothSearch() As List(Of Tooth)

        Dim dt As DataTable = ExecuteDataset("SELECT * FROM dental_mis.tooth")
        Dim data As List(Of Tooth)
        data = (From dr As DataRow In dt.Rows
                Select New Tooth With {
                    .ToothNumber = Convert.ToInt64(dr("id")),
                    .Tooth = dr("id").ToString() + " - " + dr("description").ToString()
                }).ToList()

        Return data
    End Function
End Class
