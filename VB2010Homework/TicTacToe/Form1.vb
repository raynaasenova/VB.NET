Public Class Form1

    Dim XWins As Object
    Dim OWins As Object
    Dim Ties As Object
    Dim Turn As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' when the form is loaded, initialize a new game
        Call NewGame()
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
    End Sub

    Private Sub NewGame()

        ' reset game board
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""

        'reset board background color as red was used
        ' to mark the winning path
        Label1.BackColor = System.Drawing.Color.Aqua
        Label2.BackColor = System.Drawing.Color.Aqua
        Label3.BackColor = System.Drawing.Color.Aqua
        Label4.BackColor = System.Drawing.Color.Aqua
        Label5.BackColor = System.Drawing.Color.Aqua
        Label6.BackColor = System.Drawing.Color.Aqua
        Label7.BackColor = System.Drawing.Color.Aqua
        Label8.BackColor = System.Drawing.Color.Aqua
        Label9.BackColor = System.Drawing.Color.Aqua

    End Sub

    Private Sub WinnerFound(ByVal LabelText As String)

        'a winner was found - who was it?
        If LabelText = "X" Then
            Label10.Text = "X Wins"
            XWins = XWins + 1
            TextBox1.Text = XWins
        Else
            Label10.Text = "O Wins"
            OWins = OWins + 1
            TextBox2.Text = OWins
        End If

    End Sub

    Private Sub tieFound()

        ' record a tie
        Label10.Text = "Tie"
        Ties = Ties + 1
        TextBox3.Text = Ties

    End Sub

    Private Sub CheckForWinner()

        ' check for all 8 ways a player can win

        If Label1.Text = Label2.Text And Label2.Text = Label3.Text And Label1.Text <> "" Then
            Label1.BackColor = System.Drawing.Color.Red
            Label2.BackColor = System.Drawing.Color.Red
            Label3.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label1.Text)
        ElseIf Label4.Text = Label5.Text And Label5.Text = Label6.Text And Label4.Text <> "" Then
            Label4.BackColor = System.Drawing.Color.Red
            Label5.BackColor = System.Drawing.Color.Red
            Label6.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label4.Text)
        ElseIf Label7.Text = Label8.Text And Label8.Text = Label9.Text And Label7.Text <> "" Then
            Label7.BackColor = System.Drawing.Color.Red
            Label8.BackColor = System.Drawing.Color.Red
            Label9.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label7.Text)
        ElseIf Label1.Text = Label4.Text And Label4.Text = Label7.Text And Label1.Text <> "" Then
            Label1.BackColor = System.Drawing.Color.Red
            Label4.BackColor = System.Drawing.Color.Red
            Label7.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label1.Text)
        ElseIf Label2.Text = Label5.Text And Label5.Text = Label8.Text And Label2.Text <> "" Then
            Label2.BackColor = System.Drawing.Color.Red
            Label5.BackColor = System.Drawing.Color.Red
            Label8.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label2.Text)
        ElseIf Label3.Text = Label6.Text And Label6.Text = Label9.Text And Label3.Text <> "" Then
            Label3.BackColor = System.Drawing.Color.Red
            Label6.BackColor = System.Drawing.Color.Red
            Label9.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label3.Text)
        ElseIf Label1.Text = Label5.Text And Label5.Text = Label9.Text And Label1.Text <> "" Then
            Label1.BackColor = System.Drawing.Color.Red
            Label5.BackColor = System.Drawing.Color.Red
            Label9.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label1.Text)
        ElseIf Label3.Text = Label5.Text And Label5.Text = Label7.Text And Label3.Text <> "" Then
            Label3.BackColor = System.Drawing.Color.Red
            Label5.BackColor = System.Drawing.Color.Red
            Label7.BackColor = System.Drawing.Color.Red
            Call WinnerFound(Label3.Text)
        ElseIf Label1.Text <> "" And _
               Label2.Text <> "" And _
               Label3.Text <> "" And _
               Label4.Text <> "" And _
               Label5.Text <> "" And _
               Label6.Text <> "" And _
               Label7.Text <> "" And _
               Label8.Text <> "" And _
               Label9.Text <> "" Then
            ' if there is no winner but all 9 boxes are
            ' full then it is a tie
            Call tieFound()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label1.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label1.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label2.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label2.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label3.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label3.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label4.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label4.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label5.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label5.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label6.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label6.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label7.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label7.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label8.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label8.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        ' If the label has something in it 
        ' or if the win label is full because the game ended, 
        ' then do nothing
        If Label9.Text <> "" Or Label10.Text <> "" Then
            Exit Sub
        End If

        Label9.Text = Turn

        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

        Call CheckForWinner()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' start a new game if the player chooses
        Call NewGame()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        End

    End Sub
End Class
