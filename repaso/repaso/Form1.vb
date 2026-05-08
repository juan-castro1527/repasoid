Public Class Form1
    Dim cont As Integer = 0
    Dim bool As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cont < 1 Then
            Label1.Text = "Arriba Tampico"
            Label1.ForeColor = Color.DarkGreen
            Label1.BackColor = Color.Transparent
            cont += 1
        ElseIf cont = 1 Then
            Label1.Text = "Arriba el IEST"
            Label1.ForeColor = Color.DarkOrange
            Label1.BackColor = Color.Black
            cont -= 1
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "Arriba madero"
        Label1.ForeColor = Color.ForestGreen
        Label1.BackColor = Color.Transparent
        cont = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bool = True Then
            bool = False
            Label1.Visible = False
            Button1.Visible = False
        ElseIf bool = False Then
            bool = True
            Label1.Visible = True
            Button1.Visible = True
        End If
    End Sub
End Class
