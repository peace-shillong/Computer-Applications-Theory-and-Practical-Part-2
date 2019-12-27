Public Class FindStudent
    Dim dt As DataTable
    Private Sub FindStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        dt = ds.Tables.Item("Enrollment")
        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "StudentID"
        ComboBox1.DisplayMember = "StudentID"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr() As DataRow
        Dim dtfound As DataTable
        Dim id As Integer = ComboBox1.SelectedValue
        dr = dt.Select("StudentID = " & id)
        dtfound = dr.CopyToDataTable
        DataGridView1.DataSource = dtfound
    End Sub
End Class