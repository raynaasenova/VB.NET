﻿Public Class Form1
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' redway the game board for a new game

        Dim g As Graphics = PictureBox1.CreateGraphics ' variable to hold instance of creategraphics
        Dim MyPen As New Pen(Color.Red) ' the pen is red to start
        Dim X As Integer ' X coordinate
        Dim Y As Integer ' Y coordinate

        MyPen.Width = 1  ' set pin to 1 pixel in width
        MyPen.Color = Color.White ' set pen to white to paint the entire game board

        ' draw a 1 pixel white dot at every location on the board
        For X = 0 To 200
            For Y = 0 To 200
                g.DrawEllipse(MyPen, New Rectangle(X, Y, 1, 1))
            Next
        Next

        MyPen.Width = 4 ' make the pen wider
        MyPen.Color = Color.Red ' make the pen red

        ' draw 4 concentric red circles for the target
        g.DrawEllipse(MyPen, New Rectangle(90, 90, 20, 20))
        g.DrawEllipse(MyPen, New Rectangle(80, 80, 40, 40))
        g.DrawEllipse(MyPen, New Rectangle(70, 70, 60, 60))
        g.DrawEllipse(MyPen, New Rectangle(60, 60, 80, 80))

        MyPen.Width = 1 ' make pen black

        ' draw a tiny black circle in the center of the target
        g.DrawEllipse(MyPen, New Rectangle(100, 100, 1, 1))

        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'play the game
        Dim g As Graphics = PictureBox1.CreateGraphics ' variable to hold instance of creategraphics
        Dim MyPen As New Pen(Color.Black) ' the pen is red to start
        Dim X As Integer ' X coordinate
        Dim Y As Integer ' Y coordinate
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Dim RanNum As Integer
        RanNum = 0
        Do Until X = 100 And Y = 100
            RanNum = RanNum + 1
            X = MyRandomGenerator.Next(0, 200)
            Y = MyRandomGenerator.Next(0, 200)
            g.DrawEllipse(MyPen, New Rectangle(X, Y, 1, 1))
        Loop
        TextBox1.Text = RanNum
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
