Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LoopCounter As Integer
        Dim TotalCount As Integer = 0
        For LoopCounter = 1 To 1000
            TotalCount = TotalCount + LoopCounter
        Next
        MessageBox.Show(TotalCount)
    End Sub
End Class
