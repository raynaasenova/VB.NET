Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim XName As String
        'Dim YName As String
        'XName = "X is my name"
        'YName = "Y is my name"
        'TextBox1.Text = XName
        'TextBox2.Text = YName

        Dim XName As String
        Dim YName As String
        Dim ZName As String
        ZName = TextBox3.Text
        XName = ZName
        YName = XName
        TextBox1.Text = XName
        TextBox2.Text = YName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MyColor As System.Drawing.Color
        MyColor = System.Drawing.Color.Blue
        Form1.ActiveForm.BackColor = MyColor
    End Sub
End Class
