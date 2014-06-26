Public Class Form1

    Dim RedFish As Single
    Dim BlueFish As Single
    Dim YellowFish As Single
    Dim GreenFish As Single
    Dim TotalFish As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' place each fish count from the text box 
        ' into a variable that is designed to hold numbers
        RedFish = TextBox1.Text
        BlueFish = TextBox2.Text
        YellowFish = TextBox3.Text
        GreenFish = TextBox4.Text

        ' find the total number of fish
        TotalFish = RedFish + BlueFish + YellowFish + GreenFish

        ' put the fish total into the form text box
        TextBox5.Text = TotalFish

        ' calculate the percentage of red fish by dividing the number of reds 
        ' by the total fish then multiply by 100
        RedFish = RedFish / TotalFish * 100

        ' format the percentage to look nice then put it in the appropriate text box
        TextBox6.Text = Format(RedFish, "##0.0")

        ' calculate the percentage of blue fish by dividing the number of blues 
        ' by the total fish then multiply by 100        
        BlueFish = BlueFish / TotalFish * 100

        ' format the percentage to look nice then put it in the appropriate text box
        TextBox7.Text = Format(BlueFish, "##0.0")

        ' calculate the percentage of yellow fish by dividing the number of yellows 
        ' by the total fish then multiply by 100   
        YellowFish = YellowFish / TotalFish * 100

        ' format the percentage to look nice then put it in the appropriate text box
        TextBox8.Text = Format(YellowFish, "##0.0")

        ' calculate the percentage of green fish by dividing the number of greens 
        ' by the total fish then multiply by 100   
        GreenFish = GreenFish / TotalFish * 100

        ' format the percentage to look nice then put it in the appropriate text box
        TextBox9.Text = Format(GreenFish, "##0.0")
    End Sub
End Class
