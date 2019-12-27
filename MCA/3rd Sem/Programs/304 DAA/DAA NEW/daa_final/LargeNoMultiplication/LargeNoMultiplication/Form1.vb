Public Class Form1

    Private Sub btnOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim i = 0, j As Long = 0
        Dim no1, temp, no2 As Long
        no1 = txtbx1.Text
        no2 = txtbx2.Text
        temp = no1
        While temp > 0
            i += 1
            temp \= 10
        End While
        While temp > 0
            j += 1
            temp \= 10
        End While
        If j > i Then
            i = j
        End If
        For j = 2 To 6
            If i <= 2 ^ j Then
                i = 2 ^ j
                Exit For
            End If
        Next
        Dim a(i - 1), b(i - 1) As Long
        Dim c(2 * UBound(a) + 2) As Long
        longToArr(no1, a, i)
        longToArr(no2, b, i)
        multiply(a, b, c, i)
        lbltxt.Text = CStr(arrToLong(c, 2 * i))
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtbx1.Text = ""
        txtbx2.Text = ""
        lbltxt.Text = ".........."
        txtbx1.Focus()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub multiply(ByRef x() As Long, ByRef y() As Long, ByRef z() As Long, ByVal n As Long)
        Dim a(n \ 2), b(n \ 2), c(n \ 2), d(n \ 2) As Long
        Dim productAC((2 * n) - 1), productBD((2 * n) - 1), productABDC((2 * n) - 1) As Long
        Dim IsNegative As Long  '0 = positive and  1=IsNegative
        Dim ab(n - 1), dc(n - 1) As Long
        Dim i, j As Long
        j = 0
        For i = 0 To n \ 2 - 1
            b(j) = x(i)
            j += 1
        Next
        j = 0
        For i = i To n - 1
            a(j) = x(i)
            j += 1
        Next
        j = 0
        For i = 0 To n \ 2 - 1
            d(j) = y(i)
            j += 1
        Next
        j = 0
        For i = i To n - 1
            c(j) = y(i)
            j += 1
        Next

        If n = 2 Then
            Dim p, q, r, s, pqrs As Long
            p = a(0) * c(0)
            s = b(0) * d(0)
            q = a(0) - b(0)
            r = d(0) - c(0)
            pqrs = p * 100 + (q * r + p + s) * 10 + s


            longToArr(pqrs, z, 2 * n)

        Else
            multiply(a, c, productAC, n \ 2)                    'AC
            multiply(b, d, productBD, n \ 2)                    'BD
            IsNegative = subtract(a, b, ab, n \ 2)              'A-B
            IsNegative *= subtract(d, c, dc, n \ 2)             'D-C

            copy(productAC, z)
            TenRaiseToPowr(z, n)                                'AC*10^n
            multiply(ab, dc, productABDC, n \ 2)                '(A-B)(D-C)
            'IsNegativeab *= IsNegativedc

            ReDim a(UBound(z))
            ReDim b(UBound(z))
            add(productAC, productBD, a, 2 * n)                 'BD+AC

            If IsNegative > 0 Then                              '(A-B)(D-C)+BD+AC
                add(a, productABDC, b, 2 * n)
            Else
                IsNegative = subtract(productABDC, a, b, 2 * n)
            End If

            TenRaiseToPowr(b, n \ 2)                            '[(A-B)(D-C)+BD+AC]*10^(n\2)

            add(z, b, z, 2 * n)
            add(z, productBD, z, 2 * n)
        End If


    End Sub
    Function subtract(ByRef x() As Long, ByRef y() As Long, ByRef xy() As Long, ByVal n As Long) As Long

        Dim flag As Long = 1    '1 = positive   -1= IsNegative
        Dim a, b, c As Long
        a = arrToLong(x, n)
        b = arrToLong(y, n)
        c = a - b
        If c < 0 Then
            flag = -1
            c *= -1
        End If
        longToArr(c, xy, n)
        'For i As long = n - 1 To 0 Step -1
        '    If c < 0 Then
        '        xy(i) = 0
        '    Else
        '        xy(i) = c Mod 10
        '        c = c \ 10
        '    End If
        'Next
        Return flag
    End Function
    Sub add(ByRef x() As Long, ByRef y() As Long, ByRef xy() As Long, ByVal n As Long)
        Dim a, b, c As Long
        a = arrToLong(x, n)
        b = arrToLong(y, n)
        c = a + b

        longToArr(c, xy, n)
    End Sub
    Function arrToLong(ByRef x() As Long, ByVal n As Long) As Long
        Dim y As Long = 0
        For i As Long = n - 1 To 0 Step -1
            y = y * 10 + x(i)
        Next
        Return y
    End Function

    Sub longToArr(ByVal x As Long, ByRef a() As Long, ByVal n As Long)
        For i As Long = 0 To n - 1
            If x <= 0 Then
                a(i) = 0
            Else
                a(i) = x Mod 10
                x = x \ 10
            End If
        Next
    End Sub

    Sub copy(ByRef x() As Long, ByRef y() As Long)
        For i As Long = UBound(x) To 0 Step -1
            If x(i) <> 0 Then
                y(i) = x(i)
            End If
        Next
    End Sub
    Sub TenRaiseToPowr(ByRef x() As Long, ByVal r As Long)
        Dim temp(UBound(x)) As Long
        For i As Long = 0 To UBound(x) \ 2
            temp(i + r) = x(i)
        Next
        ReDim x(UBound(x))
        copy(temp, x)
    End Sub

    
End Class
