Public Class Form1

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawLine(Pens.Chocolate, 100, 100, 200, 200)
    End Sub
End Class
