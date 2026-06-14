Public Class Form1
    'The code runs when you click GBP to EUR button
    Private Sub btnGbpToEur_Click(sender As Object, e As EventArgs) Handles btnGbpToEur.Click
        'These are local variables which store the users input temporarily within this part of the code
        '"amount" refers to the money input, "rate" refers to the exchange rate.
        Dim amount As Decimal
        Dim rate As Decimal

        'The validation here makes sure that all inputs are numerical
        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse Not Decimal.TryParse(txtRate.Text, rate) Then
            lblError.Text = "Please enter valid numbers"
            lblResult.Text = ""
            Exit Sub
        End If

        'The validation here checks the input to make sure that all inputs are more than 0 as well as positive.
        If amount <= 0 Or rate <= 0 Then
            lblError.Text = "Amount and rate must be greater than 0"
            lblResult.Text = ""
            Exit Sub
        End If
        'Multiplies the amount and rate together to calculate the converted amount.
        Dim result As Decimal = amount * rate
        'Displays the calculated result
        lblResult.Text = result.ToString("C2")
        lblError.Text = ""
    End Sub

    'the code runs when you click EUR to GBP button
    Private Sub btnEurToGbp_Click(sender As Object, e As EventArgs) Handles btnEurToGbp.Click
        'these are local variables which store the users input temporarily within this part of the code
        '"amount" refers to the money input, "rate" refers to the exchange rate.
        Dim amount As Decimal
        Dim rate As Decimal

        'the validation here makes sure that all inputs are numerical
        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse Not Decimal.TryParse(txtRate.Text, rate) Then
            lblError.Text = "Please enter valid numbers"
            lblResult.Text = ""
            Exit Sub
        End If

        'the validation here checks the input to make sure that all inputs are more than 0 as well as positive.
        If amount <= 0 Or rate <= 0 Then
            lblError.Text = "Amount and rate must be greater than 0"
            lblResult.Text = ""
            Exit Sub
        End If
        'divides the amount and rate together to calculate the converted amount.
        Dim result As Decimal = amount / rate
        'displays the calculated result.
        lblResult.Text = result.ToString("C2")
        lblError.Text = ""
    End Sub
    'opens the update conversion rates screen
    Private Sub btnUpdateRate_Click(sender As Object, e As EventArgs) Handles btnUpdateRate.Click
        'makes a new instance of the update rate form, so that
        'every time the button to open it is clicked, a new window appears.
        Dim updateForm As New frmUpdateRate
        'tells the update form what the current exchange rate on form1 is.
        updateForm.lblCurrentRate.Text = txtRate.Text
        'lets the update form send the data (new updated conversion rate)
        'back to form1.
        updateForm.Owner = Me
        'displays the update form.
        updateForm.Show()
    End Sub

End Class
