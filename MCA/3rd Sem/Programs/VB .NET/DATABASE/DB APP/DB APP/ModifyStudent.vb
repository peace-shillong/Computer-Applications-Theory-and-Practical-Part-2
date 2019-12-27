Public Class ModifyStudent
    Dim dt As DataTable
    Dim rn As String

    Private Sub ModifyStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim str As String
        For Each dr In dt.Rows
            If rn.Equals(dr.Item("RollNo")) Then
                txtID.Text = dr.Item("StudentID")
                txtName.Text = dr.Item("StudentName")
                str = dr.Item("Gender")
                If str.Equals("MALE") Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If
                txtDOB.Text = dr.Item("DOB")
                txtDOJ.Text = dr.Item("DOJoining")
                Button1.Enabled = True
                txtDOB.ReadOnly = False
                txtID.ReadOnly = False
                txtName.ReadOnly = False
                txtDOJ.ReadOnly = False
                Exit For
            End If
        Next
    End Sub

    Private Sub CBRno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRno.SelectedIndexChanged
        DisplayBtn.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rn = CBRno.SelectedItem
        Dim dr As DataRow
        Dim ans As Integer
        ans = MsgBox("Do You want to update this record?", MsgBoxStyle.YesNo, "Update Record")
        If ans = vbYes Then
            For Each dr In dt.Rows
                Dim str As String = dr.Item("RollNo")
                If rn.Equals(str) Then
                    dr.Item("StudentName") = txtName.Text
                    If RadioButton1.Checked Then
                        dr.Item("Gender") = "MALE"
                    Else
                        dr.Item("Gender") = "FEMALE"
                    End If
                    dr.Item("DOB") = CDate(txtDOB.Text)
                    dr.Item("DOJoining") = CDate(txtDOJ.Text)

                    Module1.Update(dt)
                    MsgBox("Student Successfully Modified")
                    txtName.Clear()
                    txtDOB.Clear()
                    txtDOJ.Clear()
                    txtID.Clear()
                    CBRno.SelectedIndex = -1
                    Button1.Enabled = False
                    DisplayBtn.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtName.Clear()
        txtDOB.Clear()
        txtDOJ.Clear()
        txtID.Clear()
        CBRno.SelectedIndex = -1
    End Sub
End Class