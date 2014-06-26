Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim txt As String
        Dim openFileDialog1 As New OpenFileDialog()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim stream As New System.IO.FileStream(OpenFileDialog1.FileName, System.IO.FileMode.Open)
            Dim reader As New System.IO.StreamReader(stream)
            txt = reader.ReadToEnd()
            reader.Dispose() : stream.Dispose()
            TextBox1.Text = txt
        End If
    End Sub
End Class
