﻿Imports System.Globalization
Imports DentalMIS.BLL
Imports DentalMIS.MODEL
Public Class PaymentAddEdit
    Public paymentForm As PaymentForm
    Public activeUser As String
    Public paymentID As Long
    Public procedureID As Long
    Private paymentSvc As IPaymentService
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        paymentForm.LoadData()
        Me.Dispose()
    End Sub

    Private Sub textAmount_Leave(sender As Object, e As EventArgs) Handles textAmount.Leave
        If textAmount.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textAmount.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textAmount.Text = amount.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        End If
    End Sub

    Private Sub textAmount_Enter(sender As Object, e As EventArgs) Handles textAmount.Enter
        If textAmount.Text <> String.Empty Then
            Dim amount As Double = Double.Parse(textAmount.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
            textAmount.Text = amount.ToString()
        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            paymentSvc = New PaymentService()
            Dim payment As New Payment()
            If textAmount.Text <> String.Empty Then
                If HeaderLabel.Text.Contains("New") Then
                    payment.ProcedureID = procedureID
                    payment.AmountPaid = Double.Parse(textAmount.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
                    payment.TransactionDate = dtPickerPaymentDate.Value.ToString("yyyy-MM-dd")
                    payment.CreatedBy = activeUser
                    If paymentSvc.PaymentCreate(payment) > 0 Then
                        MessageBox.Show("Payment Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        paymentForm.LoadData()
                        Me.Dispose()
                    End If
                Else
                    payment.ID = paymentID
                    payment.ProcedureID = procedureID
                    payment.AmountPaid = Double.Parse(textAmount.Text, NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("en-PH"))
                    payment.TransactionDate = dtPickerPaymentDate.Value.ToString("yyyy-MM-dd")
                    payment.UpdatedBy = activeUser
                    If paymentSvc.PaymentEdit(payment) > 0 Then
                        MessageBox.Show("Payment Saved", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        paymentForm.LoadData()
                        Me.Dispose()
                    End If
                End If
            Else
                MessageBox.Show("Fill up required field(s)", "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Olaes Dental Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textAmount.KeyPress
        Dim AllowedKeys As String = "0123456789."
        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                ' Call method here...

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Left)
                e.Handled = False

            Case Convert.ToChar(Keys.Right)
                e.Handled = False

            Case Convert.ToChar(Keys.Up)
                e.Handled = False

            Case Convert.ToChar(Keys.Down)
                e.Handled = False

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))

            Case Else ' Other key is pressed
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)
        End Select
    End Sub

    Private Sub PaymentAddEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If HeaderLabel.Text.Contains("Edit") Then
            Dim payment As New Payment()
            paymentSvc = New PaymentService
            payment = paymentSvc.PaymentSearchID(paymentID)
            textAmount.Text = payment.AmountPaid.ToString("c", Globalization.CultureInfo.GetCultureInfo("en-PH"))
        End If
    End Sub
End Class