Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim WhileValue As Integer
        WhileValue = 0
        Do While (WhileValue < 2)
            MessageBox.Show(WhileValue)
            WhileValue = WhileValue + 1
        Loop
    End Sub
End Class
