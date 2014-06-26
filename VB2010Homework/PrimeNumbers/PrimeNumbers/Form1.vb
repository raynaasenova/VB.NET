Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PNum As Integer 'просто число
        Dim DNum As Integer 'числото на което се дели простото 
        Dim Remainder As Single 'остатък от деленето
        Dim PFlag As String = "Y" 'флаг за просто число

        For PNum = 2 To 5000
            'Флаг за следене, дали числото, което се проверява е просто или не
            'Предполагаме, че е просто число, до доказване на противното
            PFlag = "Y"
            'дали се дели или не само на себе си с остатък нула?
            For DNum = 2 To PNum - 1
                Remainder = PNum Mod DNum
                'Ако остатакът от деленето на числото само на себе си е нула, значи е просто
                'Дали съществува остатък при делене на съответното число с променливата
                'която управлява цикъла - DNum
                If Remainder = 0 Then
                    PFlag = "N"
                End If
            Next
            If PFlag = "Y" Then
                TextBox1.Text = TextBox1.Text & PNum & "  "
            End If
        Next
    End Sub

End Class
