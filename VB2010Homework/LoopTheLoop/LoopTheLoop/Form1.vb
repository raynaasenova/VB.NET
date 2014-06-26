Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OuterLimit As Integer = 3
        Dim InnerLimit As Integer = 4
        Dim OuterCounter As Integer
        Dim InnerCounter As Integer
        Dim Total As Integer = 0

        For OuterCounter = 1 To OuterLimit
            For InnerCounter = 1 To InnerLimit
                Total = Total + 1
            Next
        Next
        MessageBox.Show("Total= " & Total)
    End Sub
End Class
