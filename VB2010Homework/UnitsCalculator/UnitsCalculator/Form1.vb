Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' call appropriate function to convert US to Canadian
        TextBox4.Text = MilesToKilometers(Val(TextBox1.Text))
        TextBox5.Text = GallonsToLiters(Val(TextBox2.Text))
        TextBox6.Text = DollarsToCanadianDollars(Val(TextBox3.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' call appropriate function to convert Canadian to US
        TextBox1.Text = KilometersToMiles(Val(TextBox4.Text))
        TextBox2.Text = LitersToGallons(Val(TextBox5.Text))
        TextBox3.Text = CanadianDollarsToDollars(Val(TextBox6.Text))
    End Sub

    Private Function MilesToKilometers(ByVal Miles As Single)

        ' convert miles into kilos then return the resultng number
        Dim Kilos As Single
        Kilos = Miles / 0.621
        Return Kilos

    End Function

    Private Function GallonsToLiters(ByVal Gallons As Single)

        ' convert gallons into liters then return the resultng number
        Dim Liters As Single
        Liters = Gallons * 3.79
        Return Liters

    End Function

    Private Function DollarsToCanadianDollars(ByVal Dollars As Single)

        ' convert US dollars into Canadian dollars then return the resultng number
        Dim CanadianDollars As Single
        CanadianDollars = Dollars * 1.27
        Return CanadianDollars

    End Function

    Private Function KilometersToMiles(ByVal Kilometers As Single)

        ' convert kilometers into miles then return the resultng number
        Dim Miles As Single
        Miles = Kilometers * 0.621
        Return Miles

    End Function

    Private Function LitersToGallons(ByVal Liters As Single)

        ' convert liters into gallons then return the resultng number
        Dim Gallons As Single
        Gallons = Liters / 3.79
        Return Gallons

    End Function

    Private Function CanadianDollarsToDollars(ByVal CanadianDollars As Single)

        ' convert Canadian dolloars into US dollars then return the resultng number
        Dim Dollars As Single
        Dollars = CanadianDollars / 1.27
        Return Dollars

    End Function
End Class
