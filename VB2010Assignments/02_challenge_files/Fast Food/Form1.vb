Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\four.gif")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\one.gif")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\two.gif")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\three.gif")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\four.gif")
    End Sub
End Class
