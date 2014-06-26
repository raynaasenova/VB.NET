Public Class Form1
    Dim N1, N2, N3, N4, N5, N6, N7, N8, N9, R10, R11, R12, R13, R14, R15, R16, R17 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        N3 = Val(TextBox3.Text)
        N4 = Val(TextBox4.Text)
        N5 = Val(TextBox5.Text)
        N6 = Val(TextBox6.Text)
        N7 = Val(TextBox7.Text)
        N8 = Val(TextBox8.Text)
        N9 = Val(TextBox9.Text)

        R17 = N1 + N2 + N3
        TextBox17.Text = R17
        R16 = N4 + N5 + N6
        TextBox16.Text = R16
        R15 = N7 + N8 + N9
        TextBox15.Text = R15
        R14 = N1 + N5 + N9
        TextBox14.Text = R14
        R13 = N3 + N6 + N9
        TextBox13.Text = R13
        R12 = N2 + N5 + N8
        TextBox12.Text = R12
        R11 = N1 + N4 + N7
        TextBox11.Text = R11
        R10 = N3 + N5 + N7
        TextBox10.Text = R10

        If N1 = N2 Or N1 = N3 Or N1 = N4 Or N1 = N5 Or N1 = N6 Or N1 = N7 Or N1 = N8 Or N1 = N9 _
            Or N2 = N3 Or N2 = N4 Or N2 = N5 Or N2 = N6 Or N2 = N7 Or N2 = N8 Or N2 = N9 _
            Or N3 = N4 Or N3 = N5 Or N3 = N6 Or N3 = N7 Or N3 = N8 Or N3 = N9 _
            Or N4 = N5 Or N4 = N6 Or N4 = N7 Or N4 = N8 Or N4 = N9 _
            Or N5 = N6 Or N5 = N7 Or N5 = N8 Or N5 = N9 _
            Or N6 = N7 Or N6 = N8 Or N6 = N9 _
            Or N7 = N8 Or N7 = N9 _
            Or N8 = N9 Then

            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""

        End If
        If 0 >= N1 Or 0 >= N2 Or 0 >= N3 Or 0 >= N4 Or 0 >= N5 Or 0 >= N6 Or 0 >= N7 Or 0 >= N8 Or 0 >= N9 _
            Or N1 > 9 Or N2 > 9 Or N3 > 9 Or N4 > 9 Or N5 > 9 Or N5 > 9 Or N6 > 9 Or N7 > 9 Or N8 > 9 Or N9 > 9 Then
            MessageBox.Show("Моля, попълнете всички полета с неповтарящи се числа от 1 до 9!")

            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""

        End If

        If N1 + N2 + N3 <> 15 Or N4 + N5 + N6 <> 15 Or N7 + N8 + N9 <> 15 Or N1 + N4 + N7 <> 15 Or N2 + N5 + N8 <> 15 Or N3 + N6 + N9 <> 15 Or N1 + N5 + N9 <> 15 Or N3 + N5 + N7 <> 15 Or N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 <> 45 Then
            Label2.Text = "Това не е решението! Опитайте отново!"

        End If

        If N1 + N2 + N3 = 15 And N4 + N5 + N6 = 15 And N7 + N8 + N9 = 15 And N1 + N4 + N7 = 15 And N2 + N5 + N8 = 15 And N3 + N6 + N9 = 15 And N1 + N5 + N9 = 15 And N3 + N5 + N7 = 15 And N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 = 45 Then
            Label2.Text = "Браво! Вие сте истински магьосник!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
