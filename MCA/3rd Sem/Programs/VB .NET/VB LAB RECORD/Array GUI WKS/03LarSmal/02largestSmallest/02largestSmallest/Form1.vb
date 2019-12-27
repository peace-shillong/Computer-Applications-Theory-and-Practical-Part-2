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
        Dim sml, lar As Decimal
        sml = 0
        Label_A.Text = "Enter Array(" & i + 1 & ")"
        Arr(i) = txtNo.Text

        i += 1
        txtNo.Clear()
        If i = n Then
            btnNext.Enabled = False
            txtNo.Enabled = False
            sml = Arr(0)
            lar = Arr(0)
            txtArray.Text = Arr(0)
            For j = 1 To n - 1
                'Finding elements
                If Arr(j) < sml Then
                    sml = Arr(j)
                End If
                If Arr(j) > lar Then
                    lar = Arr(j)
                End If
                'Display
                txtArray.Text = txtArray.Text & " " & Arr(j)
            Next j
        End If

        txtSml.Text = sml
        txtLar.Text = lar
        txtSml.Enabled = True
        txtLar.Enabled = True
        txtNo.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtArray.Clear()
        txtSize.Clear()
        txtNo.Clear()
        txtSize.Enabled = True
        btnOK.Enabled = True
        i = 0
    End Sub
End Class
