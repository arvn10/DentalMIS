Imports DentalMIS.MODEL
Public Class ScheduleRepository
    Inherits Database

    Public Function ScheduleCreate(param As Schedule) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_create`('{param.Title}', 
                                                                            '{param.Description}', 
                                                                            '{param.StartTime}', 
                                                                            '{param.EndTime}', 
                                                                            '{param.BackgroundColor}', 
                                                                            '{param.CreatedBy}');"
        Return ExecuteDataset(procedure).Rows(0)(0)
    End Function

    Public Function ScheduleEdit(param As Schedule) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_edit`('{param.Title}', 
                                                                          '{param.Description}', 
                                                                          '{param.StartTime}', 
                                                                          '{param.EndTime}', 
                                                                          '{param.BackgroundColor}', 
                                                                          '{param.CreatedBy}');"
        Return ExecuteDataset(procedure).Rows(0)(0)
    End Function

    Public Function ScheduleSelect(scheduleDate As Date) As List(Of Schedule)
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_select`('{scheduleDate.ToString("yyyy-MM-dd")}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of Schedule)
        data = (From dr As DataRow In dt.Rows
                Select New Schedule With {
                    .ID = Convert.ToInt64(dr("id")),
                    .Title = Convert.ToString(dr("title")),
                    .Description = Convert.ToString(dr("description")),
                    .BackgroundColor = Convert.ToString(dr("background_color")),
                    .StartTime = Convert.ToDateTime(dr("start_time")),
                    .EndTime = Convert.ToDateTime(dr("end_time")),
                    .ActionType = "No Action",
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }
               ).ToList()
        Return data
    End Function

End Class
