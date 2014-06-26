Public Class Form1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyText As String
        Dim TempText As String = ""
        MyText = TextBox1.Text
        TempText = TempText & MyText
        TempText = TempText & vbNewLine & MyText.ToLower
        TempText = TempText & vbNewLine & MyText.ToUpper
        TempText = TempText & vbNewLine & MyText.Trim
        TempText = TempText & vbNewLine & MyText.Substring(0, 4)
        TempText = TempText & vbNewLine & MyText.Substring(0, 2)
        TempText = TempText & vbNewLine & MyText.Length
        TextBox2.Text = TempText

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MyRandomGenerator As System.Random
        Dim MyRandomInteger As Integer
        MyRandomGenerator = New System.Random
        MyRandomInteger = MyRandomGenerator.Next(1, 7)
        MessageBox.Show(MyRandomInteger)
    End Sub
End Class
