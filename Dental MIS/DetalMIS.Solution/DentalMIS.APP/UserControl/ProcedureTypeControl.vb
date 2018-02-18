Imports System.Security.Permissions
Imports System.Threading
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureTypeControl
    Private procedureTypeService As ProcedureTypeService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        procedureTypeService = New ProcedureTypeService()
    End Sub

    Public Sub LoadData(searchText As String)
        Dim data As New List(Of ProcedureType)
        data = procedureTypeService.ProcedureTypeSearchLike(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("procedureName").DataPropertyName = "Name"
        DataGrid.Columns("basePrice").DataPropertyName = "BasePrice"
        DataGrid.Columns("paymentType").DataPropertyName = "PaymentType"
        DataGrid.Columns("requireMedCert").DataPropertyName = "RequireMedCert"
        DataGrid.Columns("status").DataPropertyName = "Status"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.Columns("basePrice").DefaultCellStyle.Format = "C"
        DataGrid.Columns("basePrice").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ProcedureTypeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs)
        Try
            ProcedureTypeAddEditForm.procedureTypeControl = Me
            ProcedureTypeAddEditForm.activeUser = MainForm.LabelMenu.Text
            ProcedureTypeAddEditForm.HeaderLabel.Text = "Procedure Type - New"
            ProcedureTypeAddEditForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        Try
            If TextSearch.Text <> String.Empty Then
                LoadData(TextSearch.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs)
        LoadData("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ProcedureTypeAddEditForm.activeUser = MainForm.LabelMenu.Text
        ProcedureTypeAddEditForm.HeaderLabel.Text = "Procedure Type - New"
        ProcedureTypeAddEditForm.ShowDialog()
    End Sub

    Private Sub ToolStripButtonShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowAll.Click
        LoadData("")
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
        On Error Resume Next
        ProcedureTypeAddEditForm.procedureTypeControl = Me
        ProcedureTypeAddEditForm.activeUser = MainForm.LabelMenu.Text
        ProcedureTypeAddEditForm.HeaderLabel.Text = "Procedure Type - New"
        ProcedureTypeAddEditForm.ShowDialog()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        On Error Resume Next
        If (DataGrid.Rows.Count > 0) Then
            ProcedureTypeAddEditForm.procedureTypeControl = Me
            ProcedureTypeAddEditForm.activeUser = MainForm.LabelMenu.Text
            ProcedureTypeAddEditForm.procedureTypeID = DataGrid.CurrentRow.Cells(0).Value
            ProcedureTypeAddEditForm.HeaderLabel.Text = "Procedure Type - Edit"
            ProcedureTypeAddEditForm.ShowDialog()
        Else
            MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
