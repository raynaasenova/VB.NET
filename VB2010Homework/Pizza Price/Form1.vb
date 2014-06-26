Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' by calling the prize calculation subprogram when the form
        ' is initially loaded, and initial base price is calculated

        Call CalculatePrice()

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged

        ' calculate a new price if any item changes

        Call CalculatePrice()

    End Sub

    Private Sub CalculatePrice()

        ' initialize price
        Dim PizzaPrice As Single = 0

        ' basic charge
        PizzaPrice = 5.0

        ' ingredients are either $1.00 each
        ' or $0.50 each
        If CheckBox1.Checked = True Then
            PizzaPrice = PizzaPrice + 1
        End If
        If CheckBox2.Checked = True Then
            PizzaPrice = PizzaPrice + 1
        End If
        If CheckBox3.Checked = True Then
            PizzaPrice = PizzaPrice + 1
        End If
        If CheckBox4.Checked = True Then
            PizzaPrice = PizzaPrice + 1
        End If
        If CheckBox5.Checked = True Then
            PizzaPrice = PizzaPrice + 0.5
        End If
        If CheckBox6.Checked = True Then
            PizzaPrice = PizzaPrice + 0.5
        End If
        If CheckBox7.Checked = True Then
            PizzaPrice = PizzaPrice + 0.5
        End If
        If CheckBox8.Checked = True Then
            PizzaPrice = PizzaPrice + 0.5
        End If

        ' allow for larger pizza
        If RadioButton2.Checked = True Then
            PizzaPrice = PizzaPrice * 1.25
        End If

        ' largest pizza
        If RadioButton3.Checked = True Then
            PizzaPrice = PizzaPrice * 1.5
        End If

        ' show formated result on form 
        Label2.Text = FormatCurrency(PizzaPrice)

    End Sub

End Class
