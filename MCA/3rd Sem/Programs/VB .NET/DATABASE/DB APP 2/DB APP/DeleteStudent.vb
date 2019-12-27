Public Class DeleteStudent
    Dim dt As DataTable
    Dim rn As String
    Private Sub DeleteStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        dt = ds.Tables("Student")
        Dim dr As DataRow
        Dim roll As String
        For Each dr In dt.Rows
            roll = dr.Item("RollNo")
            CBRno.Items.Add(roll)
        Next
    End Sub

    Private Sub DisplayBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayBtn.Click
        rn = CBRno.SelectedItem
        Dim dr As DataRow
        For Each dr In dt.Rows
            If rn.Equals(dr.Item("RollNo")) Then
                TextBox1.Text = dr.Item("StudentName")
                TextBox2.Text = dr.Item("Gender")
                TextBox3.Text = dr.Item("DOB")
                TextBox4.Text = dr.Item("DOJoining")
                Exit For
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow
        Dim ans As Integer
        ans = MsgBox("Do You want to delete this record?", MsgBoxStyle.YesNo, "Delete Record")
        If ans = vbYes Then
            For Each dr In dt.Rows
                If rn.Equals(dr.Item("RollNo")) Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    dr.Delete()
                    Module1.Update(dt)
                    MsgBox("Successfully Deleted Record")
                    CBRno.Items.Remove(rn)
                    Exit For
                End If
            Next
        End If
    End Sub
End Class