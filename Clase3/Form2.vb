Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles C1.Click
        Dim rutaArchivo As String = "D:\APUNTES .txt"
        Try
            If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                Dim contenido As String = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                txtcarga.Text = contenido
                lblestado.Text = "Archivo"
            Else
                lblestado.Text = "El archivo no fue encontrado."
            End If
        Catch ex As Exception
            lblestado.Text = "Error al cargar el archivo: " & ex.Message

        End Try
    End Sub
End Class