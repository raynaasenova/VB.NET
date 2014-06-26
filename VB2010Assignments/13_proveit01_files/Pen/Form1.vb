Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim g As Graphics
        g = Me.CreateGraphics
        g.Clear(Drawing.Color.White)
        Dim Color As System.Drawing.Color
        Select Case ComboBox1.SelectedIndex
            Case 0
                Color = Drawing.Color.Blue
            Case 1
                Color = Drawing.Color.Red
            Case 2
                Color = Drawing.Color.Green
            Case 3
                Color = Drawing.Color.Cyan
            Case 4
                Color = Drawing.Color.Magenta
            Case 5
                Color = Drawing.Color.Yellow
            Case 6
                Color = Drawing.Color.Purple
            Case 7
                Color = Drawing.Color.Brown
            Case Else
                Color = Drawing.Color.Black
        End Select

        Dim pen As New Drawing.Pen(Color, Val(TextBox1.Text))
        If ComboBox2.SelectedIndex = -1 Then
            pen.DashStyle = 0
        Else
            pen.DashStyle = ComboBox2.SelectedIndex
        End If
        g.DrawLine(pen, 50, 180, 250, 180)
    End Sub
End Class
