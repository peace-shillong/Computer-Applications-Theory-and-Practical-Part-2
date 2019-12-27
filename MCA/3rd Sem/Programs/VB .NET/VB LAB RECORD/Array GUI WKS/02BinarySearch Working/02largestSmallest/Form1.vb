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
        Dim sml As Decimal
        sml = 0
        Label_A.Text = "Enter Array(" & i + 1 & ")"
        Arr(i) = txtNo.Text
        i += 1
        txtSrch.Enabled = False
        btnFind.Enabled = False
        txtNo.Focus()
        If i = n Then
            txtNo.Enabled = False
            btnNext.Enabled = False
            txtSrch.Enabled = True
            txtSrch.Focus()
            btnFind.Enabled = True
        End If
        txtNo.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtArray.Clear()
        txtSize.Clear()
        txtNo.Clear()
        txtFound.Clear()
        txtSrch.Clear()
        txtSize.Enabled = True
        btnOK.Enabled = True
        i = 0
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim element As Integer
        Dim result As Boolean
        element = txtSrch.Text
        result = BinarySearch(Arr, n, element)
        txtArray.Text = Arr(0)
        For j = 1 To n - 1
            'Display
            txtArray.Text = txtArray.Text & " " & Arr(j)
        Next j
        txtFound.Enabled = True
        If result Then
            txtFound.Text = "Found"
        Else
            txtFound.Text = "Not Found"
            'txtFound.Text = result
        End If
    End Sub

    Function BinarySearch(ByVal A() As Integer, ByVal n As Integer, ByVal val As Integer) As Boolean

        Dim up, mid, low As Integer, flag As Boolean
        low = 0
        up = n
        'While (low <> up)
        '    mid = (up + low) \ 2
        '    If A(mid) = val Then
        '        Return True
        '    ElseIf (A(mid) > val) Then
        '        up = mid - 1
        '    ElseIf A(mid) < val Then
        '        low = mid + 1
        '    End If
        '    If low = up Then
        '        Exit While
        '    End If
        'End While
        'Return False
        flag = False
        Do While low <= up
            mid = (low + up) / 2
            If val = A(mid) Then
                flag = True
                Exit Do
            ElseIf val < A(mid) Then
                up = (mid - 1)
            Else
                low = (mid + 1)
            End If
        Loop

        Return flag
    End Function


End Class
