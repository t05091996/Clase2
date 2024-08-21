Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim T1, T2, T3 As String
        T1 = txt1.Text
        T2 = txt2.Text
        T3 = txt3.Text

        MsgBox("Su nombre es: " & T1 & T2 & T3)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form2.Show()





    End Sub
End Class
