Public Class Form1

    Private Sub btnGbpToEur_Click(sender As Object, e As EventArgs) Handles btnGbpToEur.Click
        Dim amount As Decimal
        Dim rate As Decimal

        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse Not Decimal.TryParse(txtRate.Text, rate) Then
            lblError.Text = "Please enter valid numbers"
            lblResult.Text = ""
            Exit Sub
        End If

        If amount <= 0 Or rate <= 0 Then
            lblError.Text = "Amount and rate must be greater than 0"
            lblResult.Text = ""
            Exit Sub
        End If

        Dim result As Decimal = amount * rate
        lblResult.Text = result.ToString("C2")
        lblError.Text = ""
    End Sub

    Private Sub btnEurToGbp_Click(sender As Object, e As EventArgs) Handles btnEurToGbp.Click
        Dim amount As Decimal
        Dim rate As Decimal

        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse Not Decimal.TryParse(txtRate.Text, rate) Then
            lblError.Text = "Please enter valid numbers"
            lblResult.Text = ""
            Exit Sub
        End If

        If amount <= 0 Or rate <= 0 Then
            lblError.Text = "Amount and rate must be greater than 0"
            lblResult.Text = ""
            Exit Sub
        End If

        Dim result As Decimal = amount / rate
        lblResult.Text = result.ToString("C2")
        lblError.Text = ""
    End Sub

    Private Sub btnUpdateRate_Click(sender As Object, e As EventArgs) Handles btnUpdateRate.Click
        Dim updateForm As New frmUpdateRate
        updateForm.lblCurrentRate.Text = txtRate.Text
        updateForm.Owner = Me
        updateForm.Show()
    End Sub

End Class
