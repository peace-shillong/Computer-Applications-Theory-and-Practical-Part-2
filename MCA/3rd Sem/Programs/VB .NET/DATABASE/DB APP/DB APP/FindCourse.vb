Public Class FindCourse
    Dim dt As DataTable
    Private Sub FindCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Form1
        dt = ds.Tables.Item("Enrollment")
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "CourseID"
        ComboBox1.DisplayMember = "CourseID"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr() As DataRow
        Dim dtfound As DataTable
        Dim id As Integer = ComboBox1.SelectedValue
        dr = dt.Select("CourseID = " & id)
        dtfound = dr.CopyToDataTable
        DataGridView1.DataSource = dtfound
    End Sub
End Class