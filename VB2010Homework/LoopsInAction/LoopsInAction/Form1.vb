Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LoopIndex As Integer = 0
        Dim WhileController As Integer = 167
        Do While (WhileController >= 0)
            LoopIndex = LoopIndex + 1
            WhileController = WhileController - (23 * LoopIndex)
        Loop
        MessageBox.Show(WhileController)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim LoopIndex As Integer = 0
        RadioButton1.Checked = True
        Do While (RadioButton3.Checked = False)
            LoopIndex = LoopIndex + 1
            If LoopIndex = 1 Then
                RadioButton1.Checked = True
            ElseIf LoopIndex = 2 Then
                RadioButton2.Checked = True
            ElseIf LoopIndex = 3 Then
                RadioButton3.Checked = True
            End If
        Loop
        MessageBox.Show(LoopIndex)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim MatchText As String = ""
        Dim LoopIndex As Integer = 0
        Do Until (MatchText = TextBox1.Text)
            LoopIndex = LoopIndex + 1
            If LoopIndex = 2 Then
                MatchText = "Text"
            ElseIf MatchText = "The Purple Pit" Then
            End If
            If LoopIndex = 3 Then
                MatchText = "Box1"
            End If
            If LoopIndex = 4 Then
                MatchText = "TextBox1"
            End If
        Loop
        MessageBox.Show("Number " & LoopIndex & " is a match.")
    End Sub
End Class
