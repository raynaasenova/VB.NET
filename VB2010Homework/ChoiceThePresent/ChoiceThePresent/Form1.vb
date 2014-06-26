Public Class Form1
    'Ако желаете в текстовото поле да се появяват два елемента, 
    'в което съм сигурен, поставете специална Visual Basic 
    'константа между тях, като например:
    'TextBox1.Text = “A” & vbNewLine & “B”. 
    'Където A и B са визуализираните от текстовото поле елементи.

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If ComboBox1.SelectedItem = "Шапка" Then
        '    TextBox1.Text = "Шал" & vbNewLine & "Ръкавици"
        'End If
        'If ComboBox1.SelectedItem = "Ботуши" Then
        '    TextBox1.Text = "Обувалка" & vbNewLine & "Боя за обувки"
        'End If
        'If ComboBox1.SelectedItem = "Книга" Then
        '    TextBox1.Text = "Разделител за страници" & vbNewLine & "Подаръчна чантичка"
        'End If
        'If ComboBox1.SelectedItem = "Пощенска картичка" Then
        '    TextBox1.Text = "Пощенска марка" & vbNewLine & "Пощенски плик"
        'End If
        'If ComboBox1.SelectedItem = "Ваза" Then
        '    TextBox1.Text = "Цветя" & vbNewLine & "Панделка"
        'End If

        'С следващия вариант се избягва нуждата от точно изписване - пример -
        'правописна грешка в колекцията
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "Шал" & vbNewLine & "Ръкавици"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "Обувалка" & vbNewLine & "Боя за обувки"
        End If
        If ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "Разделител за страници" & vbNewLine & "Подаръчна чантичка"
        End If
        If ComboBox1.SelectedIndex = 3 Then
            TextBox1.Text = "Пощенска марка" & vbNewLine & "Пощенски плик"
        End If
        If ComboBox1.SelectedIndex = 4 Then
            TextBox1.Text = "Цветя" & vbNewLine & "Панделка"
        End If
    End Sub
End Class
