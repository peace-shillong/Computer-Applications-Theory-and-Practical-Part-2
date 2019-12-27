Public Class ViewCourses

    Private Sub ViewCourses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1

        Dim dt As DataTable
        dt = ds.Tables("Courses")

        DataGridView1.DataSource = dt
    End Sub
End Class