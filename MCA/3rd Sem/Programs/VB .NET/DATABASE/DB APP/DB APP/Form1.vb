Public Class Form1
    Private Sub ViewRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        ViewAllStudents.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.ConnectDB()
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        AddStudent.Show()
    End Sub

    Private Sub RemoveRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveRecordToolStripMenuItem.Click
        DeleteStudent.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        ModifyStudent.Show()
    End Sub

    Private Sub ViewRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRecordsToolStripMenuItem1.Click
        ViewCourses.Show()
    End Sub

    Private Sub AddNewCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCourseToolStripMenuItem.Click
        AddCourse.Show()
    End Sub

    Private Sub RemoveRecordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveRecordToolStripMenuItem1.Click
        DeleteCourse.Show()
    End Sub

    Private Sub ModifyExistingRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyExistingRecordToolStripMenuItem.Click
        ModifyCourse.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem1.Click
        Enrollment.Show()
    End Sub

    Private Sub SearchAStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAStudentToolStripMenuItem.Click
        FindStudent.Show()
    End Sub

    Private Sub SearchByCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchByCourseToolStripMenuItem.Click
        FindCourse.Show()
    End Sub

    Private Sub EnrollStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollStudentsToolStripMenuItem.Click
        NewEnroll.Show()
    End Sub
End Class
