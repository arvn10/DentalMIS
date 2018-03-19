Imports DentalMIS.MODEL
Imports DentalMIS.BLL
Public Class ProcedureToothAddEditForm
    Private toothSvc As IToothService
    Public procedureAddEditForm As ProcedureAddEditForm
    Public toothID As String
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub comboTooth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboTooth.KeyPress
        e.Handled = True
    End Sub

    Private Sub ProcedureToothAddEditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        toothSvc = New ToothService()
        Dim toothList As List(Of Tooth)
        toothList = toothSvc.ToothSearch()
        comboTooth.DisplayMember = "Tooth"
        comboTooth.ValueMember = "ToothNumber"
        comboTooth.DataSource = toothList
        If HeaderLabel.Text.Contains("New") Then
            comboTooth.Text = ""
        End If

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            Dim tooth As New ProcedureTooth
            If String.IsNullOrEmpty(comboTooth.Text) Or String.IsNullOrWhiteSpace(comboTooth.Text) Then
                MessageBox.Show("Fillup all required field(s)", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If HeaderLabel.Text.Contains("New") Then
                    If procedureAddEditForm.tooths.Where(Function(s) s.Tooth = "All Tooths").Count > 0 Then
                        MessageBox.Show("Tooth already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        comboTooth.Text = String.Empty
                    ElseIf procedureAddEditForm.tooths.Where(Function(s) s.Tooth = "All Upper Tooths" And (comboTooth.Text.Contains("UR") Or comboTooth.Text.Contains("UL"))).Count > 0 Then
                        MessageBox.Show("Tooth already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        comboTooth.Text = String.Empty
                    ElseIf procedureAddEditForm.tooths.Where(Function(s) s.Tooth = "All Lower Tooths" And (comboTooth.Text.Contains("LR") Or comboTooth.Text.Contains("LR"))).Count > 0 Then
                        MessageBox.Show("Tooth already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        comboTooth.Text = String.Empty
                    ElseIf procedureAddEditForm.tooths.Where(Function(s) s.Tooth = comboTooth.Text).Count > 0 Then
                        MessageBox.Show("Tooth already Exist", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        comboTooth.Text = String.Empty
                    Else
                        tooth.ID = "N-" & procedureAddEditForm.tooths.Count + 1
                        tooth.Tooth = comboTooth.Text
                        tooth.ToothID = comboTooth.SelectedValue
                        procedureAddEditForm.tooths.Add(tooth)
                        procedureAddEditForm.LoadTooth(procedureAddEditForm.tooths)
                        MessageBox.Show("Tooth Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                Else
                    Dim confirmation = MessageBox.Show("Save Changes?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirmation = DialogResult.Yes Then
                        For Each data As ProcedureTooth In procedureAddEditForm.tooths.ToList()
                            If data.ToothID = comboTooth.SelectedValue Then
                                data.Tooth = comboTooth.Text
                                data.ToothID = comboTooth.SelectedValue
                            End If
                        Next
                        MessageBox.Show("Tooth Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procedureAddEditForm.LoadTooth(procedureAddEditForm.tooths)
                        Me.Dispose()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try
    End Sub
End Class