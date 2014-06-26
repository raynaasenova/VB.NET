Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim MyAge As Integer
        'MyAge = 3
        ''MyAge = 2 - Second variant
        'If MyAge = 3 Then
        '    TextBox1.Text = "I am 3."
        'End If
        If CheckBox1.Checked = True Then
            TextBox1.Text = "I am checked"
        End If


    End Sub
End Class
