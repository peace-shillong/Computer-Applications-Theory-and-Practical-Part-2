Public Class NewEnroll
    Dim dt As DataTable
    Private Sub NewEnroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        dt = ds.Tables.Item("Enrollment")
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "StudentID"
        ComboBox1.DisplayMember = "StudentID"

        ComboBox2.DataSource = dt
        ComboBox2.ValueMember = "CourseName"
        ComboBox2.DisplayMember = "CourseName"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class