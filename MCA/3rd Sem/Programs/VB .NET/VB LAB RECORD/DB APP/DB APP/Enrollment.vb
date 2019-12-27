Public Class Enrollment

    Private Sub Enrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Dim dt As DataTable
        dt = ds.Tables("Enrollment")
        DataGridView1.DataSource = dt
    End Sub
End Class