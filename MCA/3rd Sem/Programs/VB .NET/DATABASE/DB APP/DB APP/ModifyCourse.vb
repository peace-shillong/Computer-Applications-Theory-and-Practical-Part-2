Public Class ModifyCourse
    Dim dt As DataTable
    Dim rn As Integer
    Private Sub ModifyCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        dt = ds.Tables("Courses")
        Dim dr As DataRow
        Dim roll As Integer
        For Each dr In dt.Rows
            roll = dr.Item("CourseID")
            ComboBox1.Items.Add(roll)
        Next
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        rn = ComboBox1.SelectedItem
        Dim dr As DataRow
        Dim ans As Integer
        ans = MsgBox("Do You want to update this record?", MsgBoxStyle.YesNo, "Update Record")
        If ans = vbYes Then
            For Each dr In dt.Rows
                Dim cid As Integer = dr.Item("CourseID")
                If cid = rn Then
                    'dr.Item("CourseID") = TextBox1.Text
                    dr.Item("CourseName") = TextBox1.Text
                    dr.Item("Duration") = TextBox2.Text
                    dr.Item("Fees") = TextBox3.Text
                    Module1.UpdateC(dt, daC)
                    MsgBox("Record Successfully Modified")
                    ComboBox1.SelectedItem = -1
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()

                End If
            Next
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedItem = -1
    End Sub
End Class