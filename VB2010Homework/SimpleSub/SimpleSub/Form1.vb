Public Class Form1

    Private Sub MyMessage()
        MessageBox.Show("Here's a message from Sub MyMessage.")
        YourMessage()
    End Sub

    Private Sub YourMessage()
        MessageBox.Show("Here's a message from Sub YourMessage.")
    End Sub

    Private Sub GeneralMessage(ByVal InMessage As String)
        MessageBox.Show(InMessage)
    End Sub
    Private Sub Adders(ByVal AddOne As Integer, ByVal AddTwo As Integer)
        Dim Total As Integer
        Total = AddOne + AddTwo
        MessageBox.Show(Total)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyMessage()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GeneralMessage("Whatever message.")
        GeneralMessage("Some other message.")
        GeneralMessage("A different message.")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Adders(34, 57)
    End Sub
End Class
