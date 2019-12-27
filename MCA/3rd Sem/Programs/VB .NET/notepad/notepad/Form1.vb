Public Class Form1
    Public count As Integer
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If RichTextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "New Document")
            If ask = MsgBoxResult.No Then
                RichTextBox1.Clear()
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
            'If textbox's text is still the same, notepad will open a new page:
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If RichTextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "Open Document")
            If ask = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
        Else
            'If textbox's text is still the same, notepad will show the OpenFileDialog
            OpenFileDialog1.ShowDialog()
            Try
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Dim dlg As SaveFileDialog = New SaveFileDialog
        ''dlg.Title = "Save"
        'dlg.DefaultExt = ".txt"
        'dlg.FileName = "*"
        'dlg.AddExtension = True
        'dlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
        'dlg.ShowDialog()

        '' the application will check if the file  already exists, if exists, it will ask the user if they want to replace it
        'If My.Computer.FileSystem.FileExists(dlg.FileName) Then
        '    Dim ask As MsgBoxResult
        '    ask = MsgBox("File already exists, would you like to replace it?", MsgBoxStyle.YesNo, "File Exists")
        '    'if the user decides not to replace the existing file
        '    If ask = MsgBoxResult.No Then
        '        dlg.ShowDialog()
        '        'if the user decides to replace the existing file
        '    ElseIf ask = MsgBoxResult.Yes Then
        '        My.Computer.FileSystem.WriteAllText(dlg.FileName, RichTextBox1.Text, True)
        '    End If
        '    'if the file doesn't exist
        'Else
        '    Try
        '        RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        '        'My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
        '    Catch ex As Exception
        '    End Try
        'End If

        Dim saveMe As New SaveFileDialog
        saveMe.Title = "Save"
        saveMe.DefaultExt = ".txt"
        saveMe.FileName = "*"
        saveMe.AddExtension = True
        saveMe.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
        If saveMe.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(saveMe.FileName,RichTextBoxStreamType.PlainText)
        Else
            MsgBox("File Not save")
        End If

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        If RichTextBox1.CanUndo Then
            RichTextBox1.Undo()
        Else
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then

            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
        End If
        RichTextBox1.SelectedText = ""
        
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then

            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
    
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then

            If My.Computer.Clipboard.ContainsText Then
                RichTextBox1.Paste()
            End If


        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter text to be found")
        b = InStr(RichTextBox1.Text, a)
        If b Then
            RichTextBox1.Focus()
            RichTextBox1.SelectionStart = b - 1
            RichTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("Text not found.")
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub
    Private Sub FontColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColourToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub BackColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColourToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

   Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()



    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close the applications?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            'Dim dlg As SaveFileDialog = New SaveFileDialog
            ' dlg.Title = "Save As"
            'dlg.Filter = "TextDocuments(*.txt)"
            'If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            'End If

            Dim saveMe As New SaveFileDialog
            saveMe.Title = "SaveAs"
            saveMe.DefaultExt = ".txt"
            saveMe.FileName = "*"
            saveMe.AddExtension = True
            saveMe.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
            If saveMe.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(saveMe.FileName, RichTextBoxStreamType.PlainText)
            Else
                MsgBox("File Not save")
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()

    End Sub


   

    Private Sub RichTextBox1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.SelectionChanged
        If RichTextBox1.SelectedText <> "" Then
            CopyToolStripMenuItem.Enabled = True
            CutToolStripMenuItem.Enabled = True
            SelectAllToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        ElseIf RichTextBox1.SelectedText = "" Then
            CopyToolStripMenuItem.Enabled = False
            CutToolStripMenuItem.Enabled = False
            '           SelectAllToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub


    
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim response As MsgBoxResult
        If RichTextBox1.Text <> "" Then
            MsgBox("Save your File", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then
                Dim saveMe As New SaveFileDialog
                saveMe.Title = "Save"
                saveMe.DefaultExt = ".txt"
                saveMe.FileName = "*"
                saveMe.AddExtension = True
                saveMe.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
                If saveMe.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    RichTextBox1.SaveFile(saveMe.FileName, RichTextBoxStreamType.PlainText)
                Else
                    MsgBox("File Not save")
                End If
            End If
        End If
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
