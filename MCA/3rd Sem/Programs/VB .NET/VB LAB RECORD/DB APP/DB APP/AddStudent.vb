Public Class AddStudent
    Dim dt As DataTable = ds.Tables("Student")

    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        txtid.Text = GenerateKey()
        txtid.ReadOnly = True
    End Sub

    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        Dim dr As DataRow

        dr = dt.NewRow()
        'Load Automatically 
        'Generate ID in
        dr.Item("StudentID") = txtid.Text
        dr.Item("StudentName") = txtname.Text
        dr.Item("RollNo") = txtrl.Text
        If RadioButton1.Checked Then
            dr.Item("Gender") = "MALE"
        Else
            dr.Item("Gender") = "FEMALE"
        End If
        dr.Item("DOB") = CDate(txtdob.Text)
        dr.Item("DOJoining") = CDate(txtdoj.Text)
        dt.Rows.Add(dr)

        Module1.Update(dt)
        MsgBox("Student Successfully Added")
        txtdob.Clear()
        txtdoj.Clear()
        'txtid.Clear()
        txtname.Clear()
        txtrl.Clear()
        txtid.Text = GenerateKey()
        'RadioButton1.Checked = False

    End Sub

    Function GenerateKey() As Integer
        Dim dr() As DataRow
        dr = dt.Select("StudentID=MAX(StudentID)")
        Dim MaxKey As Integer
        MaxKey = dr(0).Item("StudentID")
        MaxKey += 1
        Return MaxKey
    End Function


End Class