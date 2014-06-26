Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' alternate the visable property of the label containing 
        ' the question mark so it will blink on the form
        If Label5.Visible = True Then
            Label5.Visible = False
        Else
            Label5.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' at form load, set the time to 2/3 
        ' of one second then start it
        Timer1.Interval = 667
        Timer1.Start()
    End Sub
End Class
