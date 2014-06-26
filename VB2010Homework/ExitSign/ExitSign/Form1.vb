Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        For i = 1 To 5
            MessageBox.Show("i inside= " & i)
            If i = 3 Then
                Exit For
            End If
        Next
        MessageBox.Show("i outside= " & i)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim LoopIndex As Integer
        For LoopIndex = 1 To 5
            If LoopIndex = 4 Then
                CheckBox1.Checked = True
            End If
            If CheckBox1.Checked = True Then
                MessageBox.Show("Exit on: " & LoopIndex)
                Exit For
            End If
        Next
    End Sub
End Class
