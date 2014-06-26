Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Gens As Integer = 0      ' counts generations of rabbits
        Dim Rabbits As Double = 0    ' number of rabbits
        Dim SqFt As Int64 = 0        ' square feet of rabbit territory
        Dim RabbitsPerFoot As Single ' rabbits per square foot
        Dim k As Integer = 0         ' loop counter
        Dim EndLoop As Integer       ' how many times to loop

        ' the rabbit territory is defined as 1 square mile
        ' calculated how many square feet in 1 square mile
        SqFt = 5280 * 5280
        EndLoop = Val(TextBox1.Text)

        ' put titles in the text box
        TextBox2.Text = "Gen." & vbTab & "Rabbits" & vbTab & "Per Square Foot" & vbNewLine & vbNewLine

        ' start with two rabbits
        Rabbits = 2
        For k = 1 To EndLoop
            ' add a new generation of rabbits to those
            ' already on hand
            Rabbits = Rabbits + (Rabbits * 2)
            RabbitsPerFoot = Rabbits / SqFt
            TextBox2.Text = TextBox2.Text & k & vbTab & Format(Rabbits, "###,###,###,###,###,###,##0") & vbTab & Format(RabbitsPerFoot, "###,##0.0000") & vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
