Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class ProcedureTypePairAddEditForm
    Private procedureTypeSvc As IProcedureTypeService
    Public procedureTypePairID As Long
    Public procedureTypeID As Long
    Public activeUser As String
    Public procedureTypeAddEditForm As ProcedureTypeAddEditForm
    Dim procedureTypePair As ProcedureTypePair
    Private Sub procedureTypePairAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        procedureTypeSvc = New ProcedureTypeService
        Dim procedureTypeList As List(Of ProcedureType)
        procedureTypeList = procedureTypeSvc.ProcedureTypeSearchLike("")
        comboProcedureType.DisplayMember = "Name"
        comboProcedureType.ValueMember = "ID"
        comboProcedureType.DataSource = procedureTypeList
        comboProcedureType.Text = ""
        If HeaderLabel.Text.Contains("Edit") Then
            comboStatus.Visible = True
            Label1.Visible = True
            procedureTypePair = New ProcedureTypePair
            procedureTypePair = procedureTypeSvc.ProcedureTypePairSelectID(procedureTypePairID)
            comboProcedureType.Text = procedureTypePair.ProcedureName
            comboVisibilityType.Text = procedureTypePair.VisibilityType
            comboStatus.Text = procedureTypePair.Status
            procedureTypeID = procedureTypePair.ProcedureID
        End If
    End Sub

    Private Sub comboProcedureType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboProcedureType.KeyPress
        e.Handled = True
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If String.IsNullOrEmpty(comboProcedureType.Text) Then
            MessageBox.Show("Select Procedure Type", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            procedureTypeSvc = New ProcedureTypeService
            procedureTypePair = New ProcedureTypePair
            procedureTypePair.ProcedureIDPair = comboProcedureType.SelectedValue
            procedureTypePair.ProcedureID = procedureTypeID
            procedureTypePair.VisibilityType = comboVisibilityType.Text
            If HeaderLabel.Text.Contains("New") Then
                procedureTypePair.Status = True
                procedureTypePair.CreatedBy = activeUser
                If procedureTypeSvc.ProcedureTypePairCreate(procedureTypePair) > 0 Then
                    MessageBox.Show("Procedure Type Saved!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    procedureTypeAddEditForm.LoadData()
                    Me.Dispose()
                Else
                    MessageBox.Show("Procedure Type Exist!", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                procedureTypePair.Status = If(comboStatus.Text = "Active", True, False)
                procedureTypePair.ID = procedureTypePairID
                procedureTypePair.UpdatedBy = activeUser
                Dim confirm = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    If procedureTypeSvc.ProcedureTypePairEdit(procedureTypePair) > 0 Then
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

    Private Sub comboVisibilityType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboVisibilityType.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStatus.KeyPress
        e.Handled = True
    End Sub
End Class