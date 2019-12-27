Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.ConnectDB()
    End Sub

    Private Sub NewEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEntryToolStripMenuItem.Click
        AddNewEntry.Show()
    End Sub

    Private Sub ViewAllEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllEntriesToolStripMenuItem.Click
        ViewAllEntries.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("Are You sure you want to exit", MsgBoxStyle.YesNo)
        'If Then
        'Me.Close()
        'End If
    End Sub
End Class
