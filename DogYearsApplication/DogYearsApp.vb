Public Class DogYearsApp

    Private Sub picDog_Click(sender As Object, e As EventArgs) Handles picDog.Click

    End Sub

    Private Sub txtEnterDogsAge_TextChanged(sender As Object, e As EventArgs) Handles txtEnterDogsAge.TextChanged
        txtEnterDogsAge.Focus()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strEnterDogsAge As String = txtEnterDogsAge.Text
        Dim intEnterDogsAge As Integer = Convert.ToInt32(strEnterDogsAge)
        Dim decDogsAgeCalculation As Decimal
        decDogsAgeCalculation = intEnterDogsAge * 7
        lblDogsAgeCalculation.Text = decDogsAgeCalculation.ToString("N0")
        lblDisplaysAgeFromText.Text = intEnterDogsAge.ToString(intEnterDogsAge)
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        txtEnterDogsAge.Text = ""
        lblDogsAgeCalculation.Text = ""
        lblDisplaysAgeFromText.Text = ""
        txtEnterDogsAge.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub lblYourDogsAgeIs_Click(sender As Object, e As EventArgs) Handles lblYourDogsAgeIs.Click

    End Sub
End Class
