Public Class Form1
    
    Private Function Multipliers(ByVal MultOne As Integer, ByVal MultTwo As Integer) As Integer
        Multipliers = MultOne * MultTwo
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Product As Integer
        Product = Multipliers(34, 57)
        MessageBox.Show(Product)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Product As Integer
        Product = Multipliers(Multipliers(2, 3), Multipliers(5, 7))
        MessageBox.Show(Product)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Тя връща дължината на символен низ като Integer стойност.
        Dim MyText, myLength As String

        MyText = "Добро утро!"
        myLength = MyText.Length
        MessageBox.Show(myLength)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim MyText, mySmalls As String
        MyText = "Добро утро!"
        mySmalls = MyText.ToLower
        MessageBox.Show(mySmalls)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim MyText, MyCaps As String
        MyText = "Добро утро!"
        MyCaps = MyText.ToUpper
        MessageBox.Show(MyCaps)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim MyText, myClean As String
        MyText = " Добро утро!"
        myClean = MyText.Trim
        MessageBox.Show(myClean)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Тя връща част от символен низ (подниз). 
        'Когато я извиквате, трябва да й подадете два целочислени аргумента. 
        'Първият то тях задава началната позиция, а вторият – дължината на подниза. 
        'Първият символ от низа е с индекс 0, а не с 1. Вторият символ е с индекс 1, а не с 2 и т.н.
        Dim MyText, mySub As String
        MyText = "Добро утро!"
        mySub = MyText.Substring(0, 4)
        MessageBox.Show(mySub)
    End Sub
End Class
