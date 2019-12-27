Public Class AddCourse
    Dim dt As DataTable = ds.Tables("Courses")

    Private Sub AddCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        txtID.Text = GenerateKey()
        txtID.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow

        dr = dt.NewRow

        dr.Item("CourseID") = txtID.Text
        dr.Item("CourseName") = txtNm.Text
        dr.Item("Duration") = txtD.Text
        dr.Item("Fees") = txtF.Text

        dt.Rows.Add(dr)

        Module1.UpdateC(dt, daC)
        MsgBox("Course Added Successfully")
        txtD.Clear()
        txtF.Clear()
        txtID.Clear()
        txtNm.Clear()
        txtID.Text = GenerateKey()
    End Sub

    Function GenerateKey() As Integer
        Dim dr() As DataRow
        dr = dt.Select("CourseID=MAX(CourseID)")
        Dim MaxKey As Integer
        MaxKey = dr(0).Item("CourseID")
        MaxKey += 1
        Return MaxKey
    End Function

End Class