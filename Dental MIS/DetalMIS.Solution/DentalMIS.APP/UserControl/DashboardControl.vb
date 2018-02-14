Public Class DashboardControl
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        calendarSchedule.ViewStart = Date.Now()
        calendarSchedule.ViewEnd = Date.Now()
    End Sub

    Private Sub calendarSchedule_ItemCreating(sender As Object, e As Calendar.CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreating
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemCreated(sender As Object, e As Calendar.CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreated
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemTextEditing(sender As Object, e As Calendar.CalendarItemCancelEventArgs) Handles calendarSchedule.ItemTextEditing
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemTextEdited(sender As Object, e As Calendar.CalendarItemCancelEventArgs) Handles calendarSchedule.ItemTextEdited
        e.Cancel = True
    End Sub
End Class
