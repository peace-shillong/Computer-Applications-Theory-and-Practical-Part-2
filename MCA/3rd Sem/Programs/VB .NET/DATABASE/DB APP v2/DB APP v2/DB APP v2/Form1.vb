Public Class Form1

    Private Sub AddNewEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEntryToolStripMenuItem.Click
        Add_New_Entry.Show()
    End Sub

    Private Sub ViewAllEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllEntriesToolStripMenuItem.Click
        ViewAllVehicles.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.ConnectDB()
    End Sub
End Class
