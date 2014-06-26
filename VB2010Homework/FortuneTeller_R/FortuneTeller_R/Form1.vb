Public Class Form1
    Dim MyText, MyVupros, MyOtgovor As String
    Dim MyLength, MyText2 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Proverka dali e polunenen vupros
        If TextBox1.Text = "" Then
            MessageBox.Show("Моля, въведете въпрос")
        Else
            Duljina()
            'Prisvoiavam si teksta ot TextBox1
            MyText2 = TextBox1.Text
            TextBox2.Text = MyOtgovor
        End If
    End Sub
    'MyText = "TextBox1"
    'myLength = MyText.Length 'returns 9, the length of "TextBox1"
    'Dim str As String
    '    str = "This is a Test"
    '    MsgBox(str.Length())
    Private Function Duljina() As String
        MyText2 = TextBox1.Text
        MyLength = MyText2.Substring(0, 5)
        Duljina = MyText2
    End Function


    'Private Function MySub() As String
    '    MyVupros = TextBox1.Text
    '    'MySub = MyVupros.Substring()
    '    MySub = MyVupros.Length(0, 5)
    '    MyOtgovor = MyVupros
    'End Function
End Class
