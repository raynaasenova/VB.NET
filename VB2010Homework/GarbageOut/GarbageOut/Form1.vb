Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MomMessage As String
        Dim i As Integer = 0
        MomMessage = "Please, Take Out The Garbage"
        For i = 1 To 5
            MessageBox.Show(MomMessage)
            MomMessage = MomMessage & vbNewLine & MomMessage
        Next
    End Sub
End Class
