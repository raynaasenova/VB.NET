Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim UntilValue As Integer
        UntilValue = 0
        Do Until (UntilValue > 1)
            MessageBox.Show(UntilValue)
            UntilValue = UntilValue + 1
        Loop
    End Sub
End Class
