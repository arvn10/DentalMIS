Imports System.Windows.Forms.Calendar
Imports DentalMIS.BLL
Imports DentalMIS.MODEL

Public Class DashboardControl

    Public calendarItems As New List(Of CalendarItem)()
    Private scheduleSvc As IScheduleService
    Public schedules As New List(Of Schedule)
    Private procedureSvc As IProcedureService

    Public Sub LoadData(searchText As String)
        procedureSvc = New ProcedureService()
        Dim data As List(Of Procedure)
        Dim bs As New BindingSource
        data = procedureSvc.ProcedureSearchPaymentLike(searchText)
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("fullname").DataPropertyName = "Fullname"
        DataGrid.Columns("tooth").DataPropertyName = "Tooth"
        DataGrid.Columns("procedure").DataPropertyName = "ProcedureName"
        DataGrid.Columns("amountToPay").DataPropertyName = "AmountToPay"
        DataGrid.Columns("amountPaid").DataPropertyName = "AmountPaid"
        DataGrid.Columns("balance").DataPropertyName = "Balance"
        DataGrid.Columns("procedureDate").DataPropertyName = "ProcedureDate"

        DataGrid.Columns("amountToPay").DefaultCellStyle.Format = "C"
        DataGrid.Columns("amountToPay").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGrid.Columns("amountPaid").DefaultCellStyle.Format = "C"
        DataGrid.Columns("amountPaid").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGrid.Columns("balance").DefaultCellStyle.Format = "C"
        DataGrid.Columns("balance").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub GetSchedules()
        calendarItems.Clear()

        scheduleSvc = New ScheduleService()
        schedules = scheduleSvc.ScheduleSelect(DateTime.Now.ToString("yyyy-MM-dd"))

        For Each schedule As Schedule In schedules
            If Not schedule.IsDeleted Then
                Dim calendar As New CalendarItem(calendarSchedule, schedule.StartTime, schedule.EndTime, schedule.Title)
                calendar.ApplyColor(Color.FromArgb(schedule.BackgroundColor))
                calendar.ForeColor = Color.Black
                calendar.Tag = $"{schedule.Index},{schedule.ID},{schedule.Description},{schedule.CreatedBy},{schedule.UpdatedBy}"
                calendarItems.Add(calendar)
            End If
        Next

        LoadSchedule()
    End Sub

    Public Sub LoadSchedule()
        calendarSchedule.Items.Clear()

        For Each calendar As CalendarItem In calendarItems
            If calendarSchedule.ViewIntersects(calendar) Then
                calendarSchedule.Items.Add(calendar)
            End If
        Next

    End Sub

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        calendarSchedule.ViewStart = Date.Now()
        calendarSchedule.ViewEnd = Date.Now()

        GetSchedules()
        LoadData("")
    End Sub

    Private Sub calendarSchedule_LoadItems(sender As Object, e As CalendarLoadEventArgs) Handles calendarSchedule.LoadItems
        LoadSchedule()
    End Sub

    Private Sub calendarSchedule_ItemCreated(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreated
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemCreating(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemCreating
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemTextEdited(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemTextEdited
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemTextEditing(sender As Object, e As CalendarItemCancelEventArgs) Handles calendarSchedule.ItemTextEditing
        e.Cancel = True
    End Sub

    Private Sub calendarSchedule_ItemMouseHover(sender As Object, e As CalendarItemEventArgs) Handles calendarSchedule.ItemMouseHover
        If e.Item.Text <> String.Empty Then
            Dim toolTipText As String
            Dim scheduleDetails As String() = IIf(e.Item.Tag <> String.Empty, e.Item.Tag.ToString().Split(", "), "")
            If scheduleDetails.Length > 0 Then
                toolTipText = "Title : " + e.Item.Text + vbNewLine +
                              "Description : " + scheduleDetails(2) + vbNewLine +
                              "Start Time : " + e.Item.StartDate.ToString("yyyy-MM-dd hh:mm:ss tt") + vbNewLine +
                              "End Time : " + e.Item.EndDate.ToString("yyyy-MM-dd hh:mm:ss tt")

                ToolTip1.Show(toolTipText, Me, Point.Add(Me.PointToClient(MousePosition), New Size(20, 20)))
                Timer1.Start()
            End If
        Else
            ToolTip1.Hide(Me)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Me.ToolTip1.Hide(Me)
    End Sub
End Class
