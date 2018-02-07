Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PatientControl
    Public ReadOnly Property ButtonRefreshIns() As Bunifu.Framework.UI.BunifuFlatButton
        ' Rename the property name to what you like, e.g.
        ' Public ReadOnly Property TextBox1Ref() As TextBox
        Get
            Return Me.buttonRefresh
        End Get
    End Property

    Private patientSvc As PatientService

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        patientSvc = New PatientService()
    End Sub

    Private Sub LoadData(searchText As String)
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


    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        Try
            DataGrid.DataSource = Nothing
            PatientAddEditForm.activeUser = MainForm.LabelMenu.Text
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

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        Try
            If (DataGrid.Rows.Count > 0) Then
                Dim form As New PatientAddEditForm
                form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
                form.activeUser = MainForm.LabelMenu.Text
                form.HeaderLabel.Text = "Patient - Edit"
                form.ShowDialog()
                DataGrid.DataSource = Nothing
            Else
                MessageBox.Show("No item(s) to edit", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PatientControl_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        LoadData("")
    End Sub

    Private Sub buttonView_Click(sender As Object, e As EventArgs) Handles buttonView.Click
        Try
            If DataGrid.Rows.Count > 0 Then
                Dim form As New PatientDentalRecordForm
                form.activeUser = MainForm.LabelMenu.Text
                form.patientID = Convert.ToInt32(DataGrid.CurrentRow.Cells(0).Value)
                form.HeaderLabel.Text = Convert.ToString(DataGrid.CurrentRow.Cells(1).Value) + " " + Convert.ToString(DataGrid.CurrentRow.Cells(2).Value) + "'s Dental Record"
                form.ShowDialog()
                DataGrid.DataSource = Nothing
            Else
                MessageBox.Show("No Patient Dental Record to View", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class
