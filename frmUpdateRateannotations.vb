Public Class frmUpdateRate
    'runs when the user clicks to apply changes to the rate.
    Private Sub btnSaveRate_Click(sender As Object, e As EventArgs) Handles btnSaveRate.Click
        'the local variable that stores the updated exchange rate
        Dim newRate As Decimal
        'validation that ensures the input is numerical.
        If Not Decimal.TryParse(txtNewRate.Text, newRate) Then
            lblUpdateMessage.Text = "Invalid rate entered"
            lblUpdateMessage.ForeColor = Color.Red
            Exit Sub
        End If
        'validation that ensures the input is a positive number and greater than 0.
        If newRate <= 0 Then
            lblUpdateMessage.Text = "Rate must be greater than 0"
            lblUpdateMessage.ForeColor = Color.Red
            Exit Sub
        End If
        'updates the "current rate" label on this form to display the updated one.
        lblCurrentRate.Text = newRate.ToString()
        'sends the updated exchange rate data to display on the main form (Form1)
        If Me.Owner IsNot Nothing AndAlso TypeOf Me.Owner Is Form1 Then
            Dim mainForm As Form1 = CType(Me.Owner, Form1)
            mainForm.txtRate.Text = newRate.ToString()
        End If
        'success message shown when the exchange rate is updated.
        lblUpdateMessage.Text = "Rate updated successfully"
        lblUpdateMessage.ForeColor = Color.Green
    End Sub

End Class
