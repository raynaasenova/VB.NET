Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' define a pen for writing
        Dim MyPen As New Pen(Color.Black)
        ' define where to write 
        Dim g As Graphics = PictureBox1.CreateGraphics
        ' erase any previous picture then refresh the picture box
        PictureBox1.ForeColor = System.Drawing.Color.Gray
        PictureBox1.Refresh()
        ' set size of pen
        MyPen.Width = 8
        ' draw 7 rainbow colors - first choose a color then 
        ' draw an arc using that color
        ' the supplied template has all colors set to black
        ' the student should make exactly these choices for button1
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 10, 200, 140, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 18, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 26, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 34, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 42, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 50, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 58, 200, 150, 180, 180)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' define a pen for writing
        Dim MyPen As New Pen(Color.Black)
        ' define a place to draw (the picture box)
        Dim g As Graphics = PictureBox1.CreateGraphics
        ' erase any previous picture then refresh the picture box
        PictureBox1.ForeColor = System.Drawing.Color.Gray
        PictureBox1.Refresh()
        ' set size of pen
        MyPen.Width = 8
        ' draw 7 rainbow colors - first choose a color then 
        ' draw an arc using that color
        ' the supplied template has all colors set to black
        ' the student may choose any for button2
        ' the student may change the drawarc numbers to make 
        ' a design instead of a rainbow
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 10, 200, 140, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 18, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 26, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 34, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 42, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 50, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Black
        g.DrawArc(MyPen, 30, 58, 200, 150, 180, 180)

    End Sub
End Class
