Imports System.Reflection.Metadata

Public Class Form1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim A As Double
        Const Pi As Double = 22 / 7

        Dim r As Double


        r = Val(TextBox1.Text)

        A = Pi * (r ^ 2)


        TextBox2.Text = A
    End Sub
End Class
