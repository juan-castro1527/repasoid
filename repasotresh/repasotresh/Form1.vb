Public Class Form1
    Dim cont As String = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cont += 1
        Label2.Text = cont
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cont = 0
        Label2.Text = cont
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cont += 2
        Label2.Text = cont
    End Sub
End Class
