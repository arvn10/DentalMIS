Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Imports DentalMIS.DAL
Public Class ScheduleService
    Implements IScheduleService
    Private scheduleRepository As ScheduleRepository
    Public Sub New()
        scheduleRepository = New ScheduleRepository
    End Sub

    Public Function ScheduleCreate(param As Schedule) As Long Implements IScheduleService.ScheduleCreate
        Return scheduleRepository.ScheduleCreate(param)
    End Function

    Public Function ScheduleEdit(param As Schedule) As Long Implements IScheduleService.ScheduleEdit
        Return scheduleRepository.ScheduleEdit(param)
    End Function

    Public Function ScheduleSelect(scheduleDate As Date) As List(Of Schedule) Implements IScheduleService.ScheduleSelect
        Return scheduleRepository.ScheduleSelect(scheduleDate)
    End Function

    Public Function ScheduleReport(from As Date, [to] As Date) As List(Of ScheduleReport) Implements IScheduleService.ScheduleReport
        Return scheduleRepository.ScheduleReport(from, [to])
    End Function
End Class
