Imports DentalMIS.MODEL
Public Class ScheduleRepository
    Inherits Database

    Public Function ScheduleCreate(param As Schedule) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_create`('{param.Title}', '{param.Description}', '{param.StartTime}', '{param.EndTime}', '{param.CreatedBy}');"
    End Function

    Public Function ScheduleEdit(param As Schedule) As Long

    End Function

    Public Function ScheduleSelect(scheduleDate As String) As List(Of Schedule)

    End Function

End Class
