Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myColor As System.Drawing.Color
        If RadioButton1.Checked = True And CheckBox1.Checked Then
            myColor = System.Drawing.Color.Red
        End If
        If RadioButton2.Checked = True And CheckBox1.Checked Then
            myColor = System.Drawing.Color.Yellow
        End If

        If RadioButton3.Checked = True And CheckBox1.Checked Then
            myColor = System.Drawing.Color.Green
        End If
        Form.ActiveForm.BackColor = myColor
    End Sub
End Class
