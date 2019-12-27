Public Class Form1
    Dim n As Integer, Arr(100) As Integer, i As Integer = 0
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        n = txtSize.Text
        btnOK.Enabled = False
        txtSize.Enabled = False
        btnNext.Enabled = True
        txtNo.Enabled = True
        txtNo.Focus()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim sum, avg As Decimal
        sum = 0
        Label_A.Text = "Enter Array(" & i + 1 & ")"
        Arr(i) = txtNo.Text

        i += 1
        txtNo.Clear()
        If i = n Then
            btnNext.Enabled = False
            txtNo.Enabled = False
            For j = 0 To n - 1
                txtArray.Text = txtArray.Text & " " & Arr(j)
                sum = sum + Arr(j)
            Next j
        End If
        avg = sum / n

        txtSum.Text = sum
        txtAvg.Text = avg
        txtSum.Enabled = True
        txtAvg.Enabled = True
        txtNo.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtArray.Clear()
        txtSize.Clear()
        txtNo.Clear()
        txtSum.Clear()
        txtAvg.Clear()
        txtSize.Enabled = True
        btnOK.Enabled = True
        i = 0
    End Sub
End Class

