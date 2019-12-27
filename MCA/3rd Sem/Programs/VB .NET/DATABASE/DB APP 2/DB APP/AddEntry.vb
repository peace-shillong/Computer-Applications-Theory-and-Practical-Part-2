Public Class AddEntry

    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1


    End Sub

    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        Dim dr As DataRow
        Dim dt As DataTable
        dt = ds.Tables("Vehicle")

        dr = dt.NewRow()
        dr.Item("VehicleID") = CInt(txtid.Text)
        dr.Item("VehicleName") = txtname.Text
        dr.Item("NumberPlate") = txtno.Text
        If RadioButton1.Checked Then
            dr.Item("Weight") = "6 tyres"
        Else
            dr.Item("Weight") = "10 tyres"
        End If
        dr.Item("DOEntry") = DoE.Value
        'dr.Item("DOJoining") = CDate(txtweight.Text)
        dt.Rows.Add(dr)

        Module1.Update(dt)
        MsgBox("Student Successfully Added")
        txtno.Clear()
        txtweight.Clear()
        txtid.Clear()
        txtname.Clear()
        txtname.Clear()
        'RadioButton1.Checked = False

    End Sub
End Class