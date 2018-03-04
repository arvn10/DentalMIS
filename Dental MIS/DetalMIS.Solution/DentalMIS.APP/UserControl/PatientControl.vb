Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PatientControl
    Private patientSvc As PatientService

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        patientSvc = New PatientService()
    End Sub

    Public Sub LoadData(searchText As String)
        Dim data As List(Of Patient)
        data = patientSvc.PatientSearchLike(searchText)
        Dim bs As New BindingSource
        bs.DataSource = data
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = bs
        DataGrid.Columns("ID").DataPropertyName = "ID"
        DataGrid.Columns("Firstname").DataPropertyName = "Firstname"
        DataGrid.Columns("Lastname").DataPropertyName = "Lastname"
        DataGrid.Columns("Address").DataPropertyName = "Address"
        DataGrid.Columns("Age").DataPropertyName = "Age"
        DataGrid.Columns("Gender").DataPropertyName = "Gender"
        DataGrid.Columns("createdBy").DataPropertyName = "CreatedBy"
        DataGrid.Columns("createdDate").DataPropertyName = "CreatedDate"
        DataGrid.Columns("updatedBy").DataPropertyName = "UpdatedBy"
        DataGrid.Columns("updatedDate").DataPropertyName = "UpdatedDate"

        DataGrid.AutoResizeColumns()
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


    Private Sub buttonNew_Click(sender As Object, e As EventArgs)
        Try
            PatientAddEditForm.patientControl = Me
            PatientAddEditForm.activeUser = MainForm.user.ID
            PatientAddEditForm.HeaderLabel.Text = "Patient - New"
            PatientAddEditForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub textSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        If textSearch.Text = String.Empty Then
            DataGrid.DataSource = Nothing
        Else
            LoadData(textSearch.Text)
        End If
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs)
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New PatientAddEditForm
                form.patientControl = Me
                form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
                form.activeUser = MainForm.user.ID
                form.HeaderLabel.Text = "Patient - Edit"
                form.ShowDialog()
            Else
                MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PatientControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData("")
    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs)
        LoadData("")
    End Sub

    Private Sub buttonView_Click(sender As Object, e As EventArgs)
        Try
            If DataGrid.Rows.Count > 0 Then
                Dim form As New PatientDentalRecordForm
                form.patientControl = Me
                form.activeUser = MainForm.user.ID
                form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
                form.HeaderLabel.Text = Convert.ToString(DataGrid.CurrentRow.Cells(1).Value) + " " + Convert.ToString(DataGrid.CurrentRow.Cells(2).Value) + "'s Dental Record"
                form.ShowDialog()
            Else
                MessageBox.Show("No Patient Dental Record to View", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowAll.Click
        LoadData("")
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
        On Error Resume Next
        PatientAddEditForm.patientControl = Me
        PatientAddEditForm.activeUser = MainForm.user.ID
        PatientAddEditForm.HeaderLabel.Text = "Patient - New"
        PatientAddEditForm.ShowDialog()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        On Error Resume Next
        If (DataGrid.Rows.Count > 0) Then
            Dim form As New PatientAddEditForm
            form.patientControl = Me
            form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
            form.activeUser = MainForm.user.ID
            form.HeaderLabel.Text = "Patient - Edit"
            form.ShowDialog()
        Else
            MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ToolStripButtonViewDR_Click(sender As Object, e As EventArgs) Handles ToolStripButtonViewDR.Click
        On Error Resume Next
        If DataGrid.Rows.Count > 0 Then
            Dim form As New PatientDentalRecordForm
            form.patientControl = Me
            form.activeUser = MainForm.user.ID
            form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
            form.HeaderLabel.Text = Convert.ToString(DataGrid.CurrentRow.Cells(1).Value) + " " + Convert.ToString(DataGrid.CurrentRow.Cells(2).Value) + "'s Dental Record"
            form.ShowDialog()
        Else
            MessageBox.Show("No Patient Dental Record to View", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
