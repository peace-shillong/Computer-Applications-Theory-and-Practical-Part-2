Public Class AddNewEntry

    Private Sub AddNewEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SlNo.Clear()
        NoPlate.Clear()
        VType.Clear()
        CWeight.Clear()
        GWeight.Clear()
        TWeight.Clear()
        NWeight.Clear()
        VStatus.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dr As DataRow
        Dim dt As DataTable
        dt = ds.Tables("Vehicle")

        dr = dt.NewRow()


        If SlNo.Text <> "" And NoPlate.Text <> "" And VType.Text <> "" And CWeight.Text <> "" And GWeight.Text <> "" And TWeight.Text <> "" And NWeight.Text <> "" And VStatus.Text <> "" Then
            dr.Item("Date") = Date1.Value
            'Label10.Text = Date1.Value
            dr.Item("SlipNumber") = CInt(SlNo.Text)
            dr.Item("VehicleNumberPlate") = NoPlate.Text
            If RadioButton1.Checked Then
                dr.Item("NumberOfTyres") = "6" 'RadioButton1.Text
            Else
                dr.Item("NumberOfTyres") = "10" 'RadioButton2.Text
            End If
            dr.Item("VehicleType") = VType.Text
            dr.Item("CapturedWeight") = CWeight.Text
            dr.Item("GrossWeight") = GWeight.Text
            dr.Item("TareWeight") = TWeight.Text
            dr.Item("NetWeight") = NWeight.Text
            dr.Item("VehicleStatus") = VStatus.Text
            dt.Rows.Add(dr)

            Module1.Update(dt)
            MsgBox("Vehicle Weight Successfully Added")
            'Clear and do New Entry
        Else
            MsgBox("Please Fill The Empty Fields!", MsgBoxStyle.Information)
            'End If
            '  End If
            ''
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrintPreview.Show()
    End Sub
End Class