Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim GradeIn As String = "None Entered"  'one grade entered
        Dim Tochki As Integer = 0               ' sums grade points (A=4, B=3...)
        Dim BroiOcenki As Integer = 0               ' counts how many BroiOcenki entered
        Dim GPA As Single = 0                   ' grade point average
        ' loop until no grade is entered
        Do Until GradeIn = ""
            ' get one grade with an InputBox control
            GradeIn = InputBox("Въведи A, B, C, D, или F", "Въвеждане на символна оценка", "")
            ' if the grade is empty then exit from the loop
            If GradeIn = "" Then
                Exit Do
            End If
            ' add the grade to the list
            TextBox4.Text = TextBox4.Text & GradeIn & "   "
            ' check to see which grade
            ' assume they may be upper or lower case
            ' add the appropriate number of points to the total points
            ' add 1 to the count of BroiOcenki
            If GradeIn = "A" Or GradeIn = "a" Then
                Tochki = Tochki + 4
                BroiOcenki = BroiOcenki + 1
            End If
            If GradeIn = "B" Or GradeIn = "b" Then
                Tochki = Tochki + 3
                BroiOcenki = BroiOcenki + 1
            End If
            If GradeIn = "C" Or GradeIn = "c" Then
                Tochki = Tochki + 2
                BroiOcenki = BroiOcenki + 1
            End If
            If GradeIn = "D" Or GradeIn = "d" Then
                Tochki = Tochki + 1
                BroiOcenki = BroiOcenki + 1
            End If
            If GradeIn = "F" Or GradeIn = "f" Then
                BroiOcenki = BroiOcenki + 1
            End If
        Loop

        ' have any BroiOcenki been entered?
        ' if yes, calculate the numeric gradepoint
        If BroiOcenki = 0 Then
            MessageBox.Show("Въведете поне една оценка")
        Else
            TextBox1.Text = Tochki
            TextBox2.Text = BroiOcenki
            TextBox3.Text = Tochki / BroiOcenki
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
