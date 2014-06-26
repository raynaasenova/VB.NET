Public Class Form1
    Dim Answer_1, Answer_2, Answer_3, Answer_4, Answer_5, Answer_6, Answer_tot As Integer

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Answer_1 = Val(TextBox1.Text)
        If Answer_1 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Answer_2 = Val(TextBox2.Text)
        If Answer_2 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Answer_3 = Val(TextBox3.Text)
        If Answer_3 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Answer_4 = Val(TextBox4.Text)
        If Answer_4 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Answer_5 = Val(TextBox5.Text)
        If Answer_5 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Answer_6 = Val(TextBox6.Text)
        If Answer_6 > 10 Then
            MessageBox.Show("Оцени се от 0 до 10!")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Answer_tot = Answer_1 + Answer_2 + Answer_3 + Answer_4 + Answer_5 + Answer_6
        TextBox7.Text = Answer_tot

        If Answer_tot >= 40 Then
            TextBox8.Text = "Браво, бе! Ти си отличен кандидат за курса по програмиране!"
        End If
        If 20 < Answer_tot And Answer_tot <= 39 Then
            TextBox8.Text = "Ъ-ъ-ъ, възможността за успех в курса по програмиране е несигурна, но не пречи да опиташ!"
        End If
        If Answer_tot < 20 Or Answer_tot = 20 Then
            TextBox8.Text = "А, мислил ли си да опиташ с курс по готварство!?"
        End If
        If Answer_tot > 60 Then
            TextBox8.Text = "Ле-ле! С такъв резултат можеш да станеш политик!"
        End If
    End Sub
End Class
