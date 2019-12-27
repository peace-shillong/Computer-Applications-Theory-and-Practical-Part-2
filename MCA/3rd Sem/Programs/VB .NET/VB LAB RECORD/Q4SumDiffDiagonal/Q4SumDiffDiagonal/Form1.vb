Public Class Form1
    Dim Matrix(,) As Integer
    Dim r, c, k As Integer

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        If txtC.Text <> "" And txtR.Text <> "" Then
            r = txtR.Text
            c = txtC.Text
            txtC.Enabled = False
            txtR.Enabled = False
            btnOK1.Enabled = False
            txtIn.Enabled = True
            ReDim Matrix(r - 1, c - 1)
            k = 0
        End If
    End Sub


    Private Sub btnOK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK2.Click
        For i = 0 To r - 1
            For j = 0 To c - 1
                txtOut.Text = txtOut.Text & " " & Matrix(i, j)
            Next
            txtOut.Text = txtOut.Text & vbCrLf
        Next
        txtOut.Enabled = True
        btnOK2.Enabled = False
        txtSumDia.Enabled = True
        txtSumDia.Text = SumDiag()
    End Sub

    Private Sub txtIn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIn.TextChanged

        If txtIn.Lines.Length = c + 1 Then
            For j = 0 To c - 1
                Matrix(k, j) = CInt(txtIn.Lines(j))
            Next
            If k < r - 1 Then
                k += 1
                txtIn.Clear()
            Else
                txtIn.Clear()
                txtIn.Enabled = False
                btnOK2.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtOut.Enabled = False
        txtOut.Clear()
        txtR.Enabled = True
        txtC.Enabled = True
        btnOK1.Enabled = True
        txtSumDia.Clear()
        txtSumDia.Enabled = False
    End Sub

    Public Function SumDiag() As Integer
        Dim sum As Integer = 0
        For i = 0 To r - 1
            For j = 0 To c - 1
                If i + j = c - 1 Then
                    sum += Matrix(i, j)
                End If
            Next
        Next
        Return sum
    End Function
End Class
