﻿Public Class Schedule
    Public Property Index As Integer
    Public Property ID As Long
    Public Property Title As String
    Public Property Description As String
    Public Property StartTime As DateTime
    Public Property EndTime As DateTime
    Public Property IsDeleted As Boolean
    Public Property BackgroundColor As String
    Public Property ActionType As String
    Public Property CreatedBy As String
    Public Property CreatedDate As DateTime?
    Public Property UpdatedBy As String
    Public Property UpdatedDate As DateTime?
End Class

Public Class ScheduleReport
    Public Property Title As String
    Public Property Description As String
    Public Property StartTime As DateTime
    Public Property EndTime As DateTime
End Class
