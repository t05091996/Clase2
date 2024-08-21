Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, Result As Integer
        Dim op As String
        a = CInt(T1.Text)
        b = CInt(T2.Text)
        op = c1.Text
        If op = "+" Then
            Result = a + b
        End If
        If op = "-" Then
            Result = a - b
        End If
        If op = "*" Then
            Result = a * b
        End If
        If op = "/" Then
            Result = a / b
        End If
        MsgBox("El resultado es:" & Result)

    End Sub
End Class
