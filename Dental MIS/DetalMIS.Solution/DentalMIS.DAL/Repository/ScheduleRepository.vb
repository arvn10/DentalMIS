Imports DentalMIS.MODEL
Public Class ScheduleRepository
    Inherits Database

    Public Function ScheduleCreate(param As Schedule) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_create`('{param.Title}', 
                                                                            '{param.Description}', 
                                                                            '{param.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                                                            '{param.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                                                            '{param.BackgroundColor}', 
                                                                            '{param.CreatedBy}');"
        Return ExecuteDataset(procedure).Rows(0)(0)
    End Function

    Public Function ScheduleEdit(param As Schedule) As Long
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_edit`({param.ID},
                                                                          '{param.Title}', 
                                                                          '{param.Description}', 
                                                                          '{param.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                                                          '{param.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                                                          '{param.BackgroundColor}', 
                                                                          {param.IsDeleted},
                                                                          '{param.UpdatedBy}');"
        Return ExecuteDataset(procedure).Rows(0)(0)
    End Function

    Public Function ScheduleSelect(scheduleDate As Date) As List(Of Schedule)
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_select`('{scheduleDate.ToString("yyyy-MM-dd")}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of Schedule)
        data = (From dr As DataRow In dt.Rows
                Select New Schedule With {
                    .Index = Convert.ToInt32(dr("index")),
                    .ID = Convert.ToInt64(dr("id")),
                    .Title = Convert.ToString(dr("title")),
                    .Description = Convert.ToString(dr("description")),
                    .BackgroundColor = Convert.ToString(dr("background_color")),
                    .StartTime = Convert.ToDateTime(dr("start_time")),
                    .EndTime = Convert.ToDateTime(dr("end_time")),
                    .IsDeleted = Convert.ToBoolean(dr("is_deleted")),
                    .ActionType = "No Action",
                    .CreatedBy = dr("created_by").ToString(),
                    .CreatedDate = If(IsDBNull(dr("created_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("created_date"))),
                    .UpdatedBy = dr("updated_by").ToString(),
                    .UpdatedDate = If(IsDBNull(dr("updated_date")), CType(Nothing, DateTime?), Convert.ToDateTime(dr("updated_date")))
                }
               ).ToList()
        Return data
    End Function

    Public Function ScheduleReport([from] As String, [to] As String) As List(Of ScheduleReport)
        Dim procedure As String = $"CALL `dental_mis`.`usp_schedule_select_report`('{[from]}', '{[to]}');"
        Dim dt As DataTable = ExecuteDataset(procedure)
        Dim data As List(Of ScheduleReport)
        data = (From dr As DataRow In dt.Rows
                Select New ScheduleReport With {
                    .Title = Convert.ToString(dr("title")),
                    .Description = Convert.ToString(dr("description")),
                    .StartTime = Convert.ToDateTime(dr("start_time")),
                    .EndTime = Convert.ToDateTime(dr("end_time"))
                }
               ).ToList()
        Return data
    End Function

End Class
