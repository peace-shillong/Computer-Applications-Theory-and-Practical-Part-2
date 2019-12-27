Public Class Form1
    Dim n, m As Integer, i As Integer = 0, j As Integer = 0
    Dim Arr(,) As Integer


    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        m = txtCol.Text
        btnOK1.Enabled = False
        txtCol.Enabled = False
        n = txtRow.Text

        txtRow.Enabled = False
        ReDim Arr(n, m)
        btnNext.Enabled = True
        txtNo.Enabled = True
        txtNo.Focus()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If i >= n - 1 And j >= m - 1 Then
            Arr(i, j) = txtNo.Text
            If j = m - 1 And i = n - 1 Then
                btnNext.Enabled = False
                txtNo.Enabled = False
            End If
            'print
            For ii = 0 To n - 1
                For jj = 0 To m - 1
                    txtArray.Text = txtArray.Text & " " & Arr(ii, jj)
                Next jj
                txtArray.Text = txtArray.Text & vbNewLine
            Next ii

            'txtArray.Text= 
        End If
        If j >= m Then
            i += 1
            j = 0
        End If
        Label_A.Text = "Enter Array (" & i & "," & j & "): "
        Arr(i, j) = txtNo.Text
        txtNo.Clear()
        txtNo.Focus()
        j += 1
        ' txtNo.Focus()
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtArray.Clear()
        txtCol.Clear()
        txtNo.Clear()
        txtRow.Clear()

        txtCol.Enabled = True
        txtRow.Enabled = True

        btnOK1.Enabled = True
        i = 0
        j = 0
        Label_A.Text = "Enter Array (0,0): "
    End Sub
End Class
