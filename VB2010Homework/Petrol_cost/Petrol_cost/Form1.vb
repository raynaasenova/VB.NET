Public Class Form1
    'Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    Dim MTG As Single    ' miles to go
    '    Dim MPG As Single    ' miles per gallon
    '    Dim CPG As Single    ' cost per gallon
    '    Dim TC As Single     ' total cost

    '    ' retrieve values from form

    '    MTG = TextBox1.Text
    '    MPG = TextBox2.Text
    '    CPG = TextBox3.Text

    '    ' calculate total cost

    '    TC = (MTG / MPG) * CPG

    '    ' format total cost for display

    '    TextBox4.Text = TC
    '    TextBox4.Text = FormatCurrency(TextBox4.Text)

    'End Sub

    Dim KiewMili As Single 'Raztoyanie do sl. destinacia
    Dim GallonRazhod As Single 'Razhod na gorivo na galon
    Dim CostGallon As Single 'Cena na galon
    Dim FullCost As Single 'Obshta stoinost na izrazhodvanoto gorivo

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        KiewMili = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        GallonRazhod = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        CostGallon = TextBox3.Text
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        FullCost = (KiewMili / GallonRazhod) * CostGallon
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = FullCost
        TextBox4.Text = FormatCurrency(TextBox4.Text)
    End Sub
End Class
