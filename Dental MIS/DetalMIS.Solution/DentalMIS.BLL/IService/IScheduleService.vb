Imports DentalMIS.MODEL
Public Interface IScheduleService
    Function ScheduleCreate(param As Schedule) As Long
    Function ScheduleEdit(param As Schedule) As Long
    Function ScheduleSelect(scheduleDate As Date) As List(Of Schedule)
    Function ScheduleReport([from] As String, [to] As String) As List(Of ScheduleReport)
End Interface
