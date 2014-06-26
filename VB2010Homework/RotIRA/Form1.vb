Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' define and initialize all variables
        Dim k As Integer = 0            ' loop counter variable
        Dim LoopStart As Integer = 0
        Dim LoopStop As Integer = 0
        Dim TotalDeposits As Single = 0 ' total of all deposits w/o interest 
        Dim AnnualDeposit As Single = 0 ' amount deposited in one year
        Dim InterestRate As Single = 0  ' entered without a decimal
        Dim IRAAccount As Single = 0    ' total money including deposits and interest
        Dim Profit As Single = 0        ' total minus deposits

        ' create titles in text box
        TextBox5.Text = "Възраст" & "    " & "Депозит" & "    " & "    " & "Баланс" & "    " & "    " & "Печалба" & vbNewLine & vbNewLine

        ' set variables to input values
        LoopStart = Val(TextBox1.Text)
        LoopStop = Val(TextBox2.Text)
        AnnualDeposit = Val(TextBox3.Text)
        ' convert interest rate to decimal form
        InterestRate = Val(TextBox4.Text) / 100

        ' loop from the age when saving starts to the 
        ' age when saving stops
        For k = LoopStart To LoopStop
            ' add the annual deposit to total deposits
            TotalDeposits = TotalDeposits + AnnualDeposit
            ' add the annual deposit to the account
            IRAAccount = IRAAccount + AnnualDeposit
            ' add interest on the entire account
            IRAAccount = IRAAccount * (1 + InterestRate)
            'calculate profit as total minus deposits
            Profit = IRAAccount - TotalDeposits
            TextBox5.Text = TextBox5.Text & k & "    " & FormatCurrency(TotalDeposits) & "    " & "    " & FormatCurrency(IRAAccount) & "    " & "    " & FormatCurrency(Profit) & vbNewLine
        Next
    End Sub
End Class
