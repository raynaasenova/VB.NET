Public Class Form1
    Dim Pok As Integer = 0
    Dim Rabb As Double = 2
    Dim Ter As Int64 = 0
    Dim Rabb_M As Single
    Dim i As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TextBox2.Text = "Gen." & vbTab & "Rabbits" & vbTab & "Per Square Foot" & vbNewLine & vbNewLine
        Pok = Val(TextBox1.Text)
        TextBox2.Text = "Пок." & vbTab & "Зайци" & vbTab & "На кв. м." & vbNewLine & vbNewLine
        Ter = 1000 * 1000
        Rabb = 2
        For i = 1 To Pok
            'Rabbits = Rabbits + (Rabbits * 2)
            'RabbitsPerFoot = Rabbits / SqFt
            'TextBox2.Text = TextBox2.Text & k & vbTab & Format(Rabbits, "###,###,###,###,###,###,##0") & vbTab & Format(RabbitsPerFoot, "###,##0.0000") & vbNewLine
            Rabb = Rabb + (Rabb * 2)
            Rabb_M = Rabb / Ter
            TextBox2.Text = TextBox2.Text & i & vbTab & Format(Rabb, "###,###,###,###,###,###,##0") & vbTab & Format(Rabb_M, "###,##0.0000") & vbNewLine
        Next
    End Sub
End Class
