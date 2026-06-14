Public Class frmUpdateRate

    Private Sub btnSaveRate_Click(sender As Object, e As EventArgs) Handles btnSaveRate.Click
        Dim newRate As Decimal

        If Not Decimal.TryParse(txtNewRate.Text, newRate) Then
            lblUpdateMessage.Text = "Invalid rate entered"
            lblUpdateMessage.ForeColor = Color.Red
            Exit Sub
        End If

        If newRate <= 0 Then
            lblUpdateMessage.Text = "Rate must be greater than 0"
            lblUpdateMessage.ForeColor = Color.Red
            Exit Sub
        End If

        lblCurrentRate.Text = newRate.ToString()

        If Me.Owner IsNot Nothing AndAlso TypeOf Me.Owner Is Form1 Then
            Dim mainForm As Form1 = CType(Me.Owner, Form1)
            mainForm.txtRate.Text = newRate.ToString()
        End If

        lblUpdateMessage.Text = "Rate updated successfully"
        lblUpdateMessage.ForeColor = Color.Green
    End Sub

End Class
