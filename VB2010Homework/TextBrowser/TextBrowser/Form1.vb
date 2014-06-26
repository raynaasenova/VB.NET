Imports System.IO

Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim AllText As String = ""
        Dim LineOfText As String = ""
        OpenFileDialog1.Filter = "Text files (*.TXT)|*.TXT"
        OpenFileDialog1.ShowDialog() 'изобразяване на диалоговия прозорец Open
        If OpenFileDialog1.FileName <> "" Then
            Try 'отваряне на файл и прихващане на грешки с хендлър (handler - секундант)
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1) 'resd lines from file
                    LineOfText = LineInput(1)
                    'добавяне на всеки ред към променливата ALLText
                    AllText = AllText & LineOfText & vbCrLf
                Loop
                lblNote.Text = OpenFileDialog1.FileName 'актуализиране на етикета
                txtNote.Text = AllText 'изобразяване на файла
                txtNote.Enabled = True 'разрешаване на текстов курсор
                CloseToolStripMenuItem.Enabled = True 'разрешаване на команда Close
                'ExitToolStripMenuItem.Enabled = True
                OpenToolStripMenuItem.Enabled = False 'деактивиране на командата Open
            Catch ex As Exception
                MsgBox("Error opening file.")
            Finally
                FileClose(1) 'затваряне на файла
                'ExitToolStripMenuItem.Enabled = True
            End Try
        End If

        '    Dim iFileSelect As FileDialog
        '    iFileSelect = Application.FileDialog(msoFileDialogFilePicker)

        '    Dim vrtSelectedItem As Object

        '    If iFileSelect.Show = -1 Then
        '        For Each vrtSelectedItem In iFileSelect.SelectedItems

        '            MsgBox("The path is: " & vrtSelectedItem)
        '        Next vrtSelectedItem
        '    End If

        '    iFileSelect = Nothing

        'End Sub

    End Sub
    Private Function txtNote() As Object
        Throw New NotImplementedException
    End Function

    Private Function msoFileDialogFilePicker() As Object
        Throw New NotImplementedException
    End Function

    Private Function CloseToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

End Class
