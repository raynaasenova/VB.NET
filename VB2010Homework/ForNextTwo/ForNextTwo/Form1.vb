Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LoopCounter As Integer
        For LoopCounter = 1 To 2
            MessageBox.Show(LoopCounter)
        Next
    End Sub
End Class
