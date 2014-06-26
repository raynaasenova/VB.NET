Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyValue As Integer
        MyValue = 1
        If CheckBox1.Checked = True Then
            MyValue = 2
        Else
            MyValue = 3
        End If
    End Sub
End Class
