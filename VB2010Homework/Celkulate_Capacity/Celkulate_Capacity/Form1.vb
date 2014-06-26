Public Class Form1
    'I can't believe that I get it!
    Dim a As Single
    Dim r As Single
    Dim V_kub As Single
    Dim V_sfera As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = TextBox1.Text
        V_kub = a ^ 3
        TextBox3.Text = V_kub
        r = TextBox2.Text
        V_sfera = (4 / 3) * Math.PI * (r ^ 3)
        TextBox4.Text = V_sfera
    End Sub
End Class
