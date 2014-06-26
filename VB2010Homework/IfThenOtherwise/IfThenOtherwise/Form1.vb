Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Form.ActiveForm.BackColor = System.Drawing.Color.Red
        End If

        If CheckBox1.Checked = False Then
            Form.ActiveForm.BackColor = System.Drawing.Color.Blue
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Form.ActiveForm.BackColor = System.Drawing.Color.Red
            MessageBox.Show("I'm red.")
            TextBox1.Text = "I'm red."
        Else
            Form.ActiveForm.BackColor = System.Drawing.Color.Blue
            MessageBox.Show("I'm blue.")
            TextBox1.Text = "I'm blue."
        End If
    End Sub
End Class
