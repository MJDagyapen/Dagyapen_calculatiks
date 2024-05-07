Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Single
        a = Val(Txtfirstnum.Text)
        b = Val(Txtsecondnum.Text)
        lblresult.Text = add(a, b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Single
        a = Val(Txtfirstnum.Text)
        b = Val(Txtsecondnum.Text)
        lblresult.Text = subtract(a, b)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Single
        a = Val(Txtfirstnum.Text)
        b = Val(Txtsecondnum.Text)
        lblresult.Text = divide(a, b)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As Single
        a = Val(Txtfirstnum.Text)
        b = Val(Txtsecondnum.Text)
        lblresult.Text = multiply(a, b)
    End Sub

    Public Function add(x As Single, y As Single)
        Dim sum As Single
        sum = x + y
        Return sum
    End Function
    Public Function subtract(x As Single, y As Single)
        Dim difference As Single
        difference = x - y
        MessageBox.Show(x)
        MessageBox.Show(y)
        Return difference
    End Function
    Public Function divide(x As Single, y As Single)
        Dim quotient As Single
        quotient = x / y
        Return quotient
    End Function
    Public Function multiply(x As Single, y As Single)
        Dim product As Single
        product = x * y
        Return product

    End Function

End Class
