Imports System.IO
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("D:\Proba\easy.log", TextBox1.Text & vbCrLf, True)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            TextBox2.Text = My.Computer.FileSystem.ReadAllText("D:\Proba\easy.log")
        Catch ex As Exception
            TextBox2.Text = "Неуспешно четене от D:\Proba\easy.log"
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        If My.Computer.FileSystem.FileExists("D:\Proba\easy.log") Then
            My.Computer.FileSystem.DeleteFile("D:\Proba\easy.log")
        End If
    End Sub
End Class
