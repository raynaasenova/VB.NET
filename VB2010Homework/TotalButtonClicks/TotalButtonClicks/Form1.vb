Public Class Form1
    Dim TotalButtonClicks As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TotalButtonClicks = TotalButtonClicks + 1
        MessageBox.Show(TotalButtonClicks)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TotalButtonClicks = TotalButtonClicks + 1
        MessageBox.Show(TotalButtonClicks)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TotalButtonClicks = TotalButtonClicks + 1
        MessageBox.Show(TotalButtonClicks)
    End Sub
End Class
