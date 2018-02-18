Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureTypeNotAllowedAddEditForm
    Private procedureTypeSvc As IProcedureTypeService
    Public procedureTypeNotAllowedID As Long
    Public procedureTypeID As Long
    Public activeUser As String
    Public procedureTypeAddEditForm As ProcedureTypeAddEditForm
    Dim procedureTypeNotAllowed As ProcedureNotAllowed
    Private Sub ProcedureTypeNotAllowedAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        procedureTypeSvc = New ProcedureTypeService
        Dim procedureTypeList As List(Of ProcedureType)
        procedureTypeList = procedureTypeSvc.ProcedureTypeSearchLike("")
        comboProcedureType.DisplayMember = "Name"
        comboProcedureType.ValueMember = "ID"
        comboProcedureType.DataSource = procedureTypeList
        comboProcedureType.Text = ""
        If HeaderLabel.Text.Contains("Edit") Then
            procedureTypeNotAllowed = New ProcedureNotAllowed
            procedureTypeNotAllowed = procedureTypeSvc.ProcedureTypeNotAllowedSelectID(procedureTypeNotAllowedID)
            comboProcedureType.Text = procedureTypeNotAllowed.ProcedureName
            comboStatus.Text = procedureTypeNotAllowed.Status
            procedureTypeID = procedureTypeNotAllowed.ProcedureID
        End If
    End Sub

    Private Sub comboProcedureType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboProcedureType.KeyPress
        e.Handled = True
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If comboProcedureType.Text = String.Empty Or comboStatus.Text = String.Empty Then
            MessageBox.Show("Select Procedure Type", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            procedureTypeSvc = New ProcedureTypeService
            procedureTypeNotAllowed = New ProcedureNotAllowed
            procedureTypeNotAllowed.ProcedureNotAllowedID = comboProcedureType.SelectedValue
            procedureTypeNotAllowed.ProcedureID = procedureTypeID
            procedureTypeNotAllowed.Status = IIf(comboStatus.Text = "Active", True, False)
            If HeaderLabel.Text.Contains("New") Then
                procedureTypeNotAllowed.CreatedBy = activeUser
                If procedureTypeSvc.ProcedureTypeNotAllowedCreate(procedureTypeNotAllowed) > 0 Then
                    MessageBox.Show("Procedure Type Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    procedureTypeAddEditForm.LoadData()
                    Me.Dispose()
                Else
                    MessageBox.Show("Procedure Type Exist!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

                procedureTypeNotAllowed.ID = procedureTypeNotAllowedID
                procedureTypeNotAllowed.UpdatedBy = activeUser
                Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    If procedureTypeSvc.ProcedureTypeNotAllowedEdit(procedureTypeNotAllowed) > 0 Then
                        MessageBox.Show("Procedure Type Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procedureTypeAddEditForm.LoadData()
                        Me.Dispose()
                    End If
                End If
            End If
            End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class