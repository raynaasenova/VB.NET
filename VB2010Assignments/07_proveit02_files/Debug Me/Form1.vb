Public Class Form1
    Dim AnswerOne As String = "This line of code has net yet run."
    Dim AnswerTwo As String = "This line of code has net yet run."
    Dim Int1 As Integer = 1
    Dim Int2 As Integer = 2
    Dim Int3 As Integer = 3
    Dim Work1 As String = "the quick brown fox jumped over the lazy dog"
    Dim Work2 As String = ""
    Dim Work3 As String = ""
    Dim Work4 As String = ""

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' You are expected to use the debugging techniques 
        ' you learned in Unit 8 to identify the FINAL values 
        ' contained in the variables called AnswerOne and AnswerTwo
        ' The code is intentionally obscure so that you will 
        ' use the debugging tools instead of trying to answer 
        ' the questions by following the code

        AnswerOne = Mid(Work1, 2, 2) & Mid(Work1, Int3 * 11 + 4, 1) & Mid(Work1, Int3 ^ 3 + Int2 * 5, 1) & Mid(Work1, Int2 * 6 + Int1, Int1)
        TextBox1.Text = Trim(TextBox1.Text)
        Work3 = ""
        For Int3 As Integer = TextBox1.Text.Length To Int1 Step -1
            Work3 = Work3 & Mid(TextBox1.Text, Int3, 1)
        Next
        Work3 = Work3 & Work2 & Work1
        Work4 = Mid(Work3, Int2 - Int1, TextBox1.Text.Length)
        AnswerTwo = Work4

        ' write down the value you entered in the text box.
        ' write down the value of AnswerOne 
        ' write down the value of AnswerTwo 

    End Sub
End Class
