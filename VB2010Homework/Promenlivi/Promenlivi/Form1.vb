Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyName As String
        MyName = "Peter, Paul and Mary"
        MyName = "Bill"
        MyName = "Bob"
        MyName = "Коте"
        TextBox1.Text = MyName
        

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyName1 As String
        MyName1 = "Рая Асенова"
        Dim YourName As String
        YourName = MyName1
        MessageBox.Show(MyName1)
    End Sub
End Class
