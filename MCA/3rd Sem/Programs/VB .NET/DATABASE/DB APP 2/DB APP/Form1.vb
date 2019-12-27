Public Class Form1


    Private Sub ViewRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        ViewAllStudents.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.ConnectDB()
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        AddEntry.Show()
    End Sub

    Private Sub RemoveRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveRecordToolStripMenuItem.Click
        DeleteStudent.Show()
    End Sub
End Class
