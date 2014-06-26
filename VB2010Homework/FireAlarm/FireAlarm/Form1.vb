Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Form.ActiveForm.BackColor = System.Drawing.Color.Red
        End If
        If CheckBox1.Checked = True Then
            TextBox1.Text = "Red Alert"
        End If
        If CheckBox1.Checked = True Then
            MessageBox.Show("Danger! Danger!")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Form.ActiveForm.BackColor = System.Drawing.Color.Red
            TextBox1.Text = "Red Alert"
            MessageBox.Show("Danger! Danger!")
        End If
    End Sub
End Class
