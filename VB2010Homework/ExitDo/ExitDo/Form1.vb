Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim UntilValue As Integer
        UntilValue = 0
        Do Until (UntilValue > 10)
            MessageBox.Show(UntilValue)
            UntilValue = UntilValue + 1
            If UntilValue = 5 Then
                Exit Do
            End If
        Loop
        MessageBox.Show("Exit Value= " & UntilValue)
    End Sub
End Class
