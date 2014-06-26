Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FirstNum, SecondNum As Double 'Голям тип с общо предназначение Text1, Text2
        FirstNum = Val(TextBox1.Text)
        SecondNum = Val(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = FirstNum + SecondNum
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = FirstNum - SecondNum
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = FirstNum * SecondNum
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = FirstNum / SecondNum
        End If
        If RadioButton5.Checked = True Then
            TextBox3.Text = FirstNum \ SecondNum
        End If
        If RadioButton6.Checked = True Then
            TextBox3.Text = FirstNum Mod SecondNum
        End If
        If RadioButton7.Checked = True Then
            TextBox3.Text = FirstNum ^ SecondNum
        End If
        If RadioButton8.Checked = True Then
            TextBox3.Text = FirstNum & SecondNum
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim FirstStr, SecondStr As String
        FirstStr = TextBox1.Text
        SecondStr = TextBox2.Text
        If RadioButton9.Checked = True Then
            TextBox3.Text = FirstStr & SecondStr
        End If
    End Sub
End Class
