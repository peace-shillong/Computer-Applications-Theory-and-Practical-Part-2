Public Class DeleteCourse
    Dim dt As DataTable
    Dim rn As Integer
    Private Sub DeleteCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        dt = ds.Tables("Courses")
        Dim dr As DataRow
        Dim roll As Integer
        For Each dr In dt.Rows
            roll = dr.Item("CourseID")
            ComboBox1.Items.Add(roll)
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dr As DataRow
        Dim ans As Integer
        ans = MsgBox("Do You want to delete this record?", MsgBoxStyle.YesNo, "Delete Record")
        If ans = vbYes Then
            For Each dr In dt.Rows
                If rn = dr.Item("CourseID") Then
                    dr.Delete()
                    Module1.UpdateC(dt, daC)
                    MsgBox("Successfully Deleted Record")
                    ComboBox1.Items.Remove(rn)
                    Exit For
                End If
            Next
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rn = ComboBox1.SelectedItem
        Dim dr As DataRow
        For Each dr In dt.Rows
            If rn.Equals(dr.Item("CourseID")) Then
                TextBox1.Text = dr.Item("CourseName")
                TextBox2.Text = dr.Item("Duration")
                TextBox3.Text = dr.Item("Fees")
                Exit For
            End If
        Next
    End Sub
End Class