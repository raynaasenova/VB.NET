Public Class Form1
    Dim Klif, Durk, Djin, Niki As Integer
    Dim Sr As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        

        Klif = Val(TextBox1.Text)
        If Klif > Sr Then
            Label6.Text = "Отлично"
        Else
            Label6.Text = "Тренирай още"
        End If
        Durk = Val(TextBox2.Text)
        If Durk > Sr Then
            Label7.Text = "Отлично"
        Else
            Label7.Text = "Тренирай още"
        End If
        Djin = Val(TextBox3.Text)
        If Djin > Sr Then
            Label8.Text = "Отлично"
        Else
            Label8.Text = "Тренирай още"
        End If
        Niki = Val(TextBox4.Text)
        If Niki > Sr Then
            Label9.Text = "Отлично"
        Else
            Label9.Text = "Тренирай още"
        End If
        Sr = (Klif + Durk + Djin + Niki) / 4
        TextBox5.Text = Sr
    End Sub
End Class
