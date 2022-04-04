Public Class Form3
    Dim num1 As Double
    Dim num2 As Double
    Dim result As Double
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        lblresult.Text = num1 + num2
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        lblresult.Text = num2 - num1
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        lblresult.Text = num1 * num2
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        lblresult.Text = num1 / num2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Close()
        Form1.Close()
    End Sub

End Class