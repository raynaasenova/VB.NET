Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim myString As String

        Dim myInteger As Integer

        Dim mySingle As Single

        Dim myBoolean As Boolean

        Dim MyColor As System.Drawing.Color

        MyColor = System.Drawing.Color.Blue

        TextBox1.Text = "John Smith"

        'TextBox1.Text = TextBox1.ForeColor

        myInteger = "127"

        myBoolean = True

        MessageBox.Show("The Splat program is working.")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
