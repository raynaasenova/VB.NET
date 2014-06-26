Public Class Form1
    Dim P1, P2 As String
    Dim Result_P As Integer
    Dim Result_Z As Integer
    Dim MyRandomGenerator As System.Random
    Dim RanNum As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox1.Text = "Ези"
        End If

        If RadioButton2.Checked = True Then
            TextBox1.Text = "Тура"
        End If

        MyRandomGenerator = New System.Random
        'Generate random value between 0 and 2 -  not including 2=
        RanNum = MyRandomGenerator.Next(0, 2)

        If RanNum = 0 Then
            TextBox2.Text = "Ези"
        Else
            TextBox2.Text = "Тура"
        End If

        Result_P = TextBox3.Text
        Result_Z = TextBox4.Text

        If TextBox1.Text = TextBox2.Text Then
            TextBox3.Text = Result_P + 1
        Else
            TextBox4.Text = Result_Z + 1
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = 0
        TextBox4.Text = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'TextBox1.ResetText()
        'TextBox2.ResetText()
        'TextBox3.ResetText()
        'TextBox4.ResetText()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = 0
        TextBox4.Text = 0
    End Sub
End Class
