Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Opit As Integer = 0       ' how many in a row have been found
        Dim Ezi As Integer = 0        ' attempts 
        Dim RanNum As Integer = 0       ' hold random number
        Dim MyRandomGenerator As System.Random  ' hold an instance of the random number generator
        MyRandomGenerator = New System.Random   ' create an instance of the random number generator
        Ezi = 0
        Opit = 0
        TextBox2.Text = ""
        ' loop until the number in a row equals the number desired
        'Докато опитите не станат, колкото желаем, подхвълряй ези-тура и покажи резултата
        Do Until Opit = Val(TextBox1.Text)
            ' Generate random integer between 0 and 2
            ' not including 2.
            RanNum = MyRandomGenerator.Next(0, 2)
            ' increment attempts
            Ezi = Ezi + 1
            ' a random number of 1 is assumed to be heads
            ' so it adds to the number in a row
            If RanNum = 1 Then
                Opit = Opit + 1
            Else    ' else start over
                Opit = 0
            End If
            ' to prevent a run-away program, stop after
            ' a half-million attempts
            If Ezi > 500000 Then
                MessageBox.Show("possible loop - 500,000 random numbers processed - program is ending")
                Exit Sub
            End If
        Loop
        ' report how many tries it took
        TextBox2.Text = Ezi
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
