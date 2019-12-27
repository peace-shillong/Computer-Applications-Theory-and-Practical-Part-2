Public Class Add_New_Entry

    Private Sub Add_New_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow
        Dim dt As DataTable
        dt = ds.Tables("Vehicle")

        dr = dt.NewRow()
        dr.Item("VehicleID") = CInt(TextBox1.Text)
        dr.Item("DOEntry") = DoE.Value
        dr.Item("VehicleName") = TextBox2.Text
        dr.Item("NumberPlate") = TextBox3.Text
        If RadioButton1.Checked Then
            dr.Item("NumberofTyres") = "6 tyres"
        Else
            dr.Item("NumberofTyres") = "10 tyres"
        End If
        'dr.Item("DOJoining") = CDate(txtweight.Text)
        dr.Item("Weight") = TextBox4.Text
        dt.Rows.Add(dr)

        Module1.Update(dt)
        MsgBox("Entry Successfully Added")

    End Sub
End Class