Public Class Form1

    Dim r, c As Integer
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim Arr(,) As Integer
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtCol.Text <> "" And txtRow.Text <> "" Then
            r = txtRow.Text
            c = txtCol.Text
            ReDim Arr(r, c)
            txtRow.Enabled = False
            txtCol.Enabled = False
            btnOK.Enabled = False
            btnNext.Enabled = True
            txtNo.Enabled = True
            txtNo.Focus()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim sumrd, sumld As Integer
       
        If i = r - 1 And j = c Then

            btnNext.Enabled = False
            txtNo.Enabled = False
            'txtArray.Text = Arr(0, 0)
            For i = 0 To r - 1
                For j = 0 To c - 1
                    'Display
                    txtArray.Text = txtArray.Text & " " & Arr(i, j)
                Next j
            Next
            sumrd = sumDiag(Arr, r, c)
            sumld = sumDiag2(Arr, r, c)
            sumr.Text = sumrd
            suml.Text = sumld
        End If
        Arr(i, j) = txtNo.Text
        j += 1
        Label_A.Text = " " & i & ", " & j
        If j = c Then
            i += 1
            j = 0
        End If
        txtNo.Focus()
        txtNo.Clear()
    End Sub

    Function sumDiag(ByVal Matrix(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer
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

    Function sumDiag2(ByVal Matrix(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer
        Dim sum As Integer = 0
        For i = 0 To r - 1
            For j = 0 To c - 1
                If i = j Then
                    sum += Matrix(i, j)
                End If
            Next
        Next
        Return sum
    End Function

End Class
