Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Verdana"
        'TextBox1.Text = "8"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FontName As String
        Dim FontStyle As System.Drawing.FontStyle = Drawing.FontStyle.Regular
        Dim FontSize As Integer = Val(TextBox1.Text)
        If CheckBox1.Checked = True Then
            FontStyle = System.Drawing.FontStyle.Bold
            If CheckBox2.Checked = True Then
                FontStyle = System.Drawing.FontStyle.Italic
                If CheckBox3.Checked = True Then
                    FontStyle = System.Drawing.FontStyle.Underline
                    If CheckBox4.Checked = True Then
                        FontStyle = System.Drawing.FontStyle.Strikeout
                    End If
                End If
            End If
        End If
        Select Case ComboBox1.SelectedIndex
            Case 0
                FontName = "Verdana"
            Case 1
                FontName = "Courier New"
            Case 2
                FontName = "Ariel"
            Case 3
                FontName = "Symbol"
        End Select
        Dim MyFont As New Drawing.Font(FontName, FontSize, FontStyle)
        Label3.Font = MyFont
    End Sub

    'If ComboBox1.SelectedIndex = "Verdana" Then
    '    FontName = "Verdana"
    '    If ComboBox1.SelectedIndex = "Courier New" Then
    '        FontName = "Courier New"
    '        If ComboBox1.SelectedIndex = "Ariel" Then
    '            FontName = "Ariel"
    '            If ComboBox1.SelectedIndex = "Symbol" Then
    '                FontName = "Symbol"
    '            End If
    '        End If
    '    End If
    'End If
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
