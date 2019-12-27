Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x(), y(), z() As Long
        Dim s As Long
        s = 4
        ReDim Preserve x(s - 1)
        ReDim Preserve y(s - 1)

        generate(x, y, s)
        z = multiply(x, y, s)

        Dim i As Long
        For i = x.GetUpperBound(0) To 0 Step -1
            Label1.Text &= x(i)
        Next
        For i = y.GetUpperBound(0) To 0 Step -1
            Label2.Text &= y(i)
        Next

        For i = z.GetUpperBound(0) To 0 Step -1
            Label3.Text &= z(i)
        Next
    End Sub

    Private Sub generate(ByVal x() As Long, ByVal y() As Long, ByVal s As Long)
        Dim r As New Random
        Dim i As Long
        x(s - 1) = r.Next(1, 9)
        y(s - 1) = r.Next(1, 9)
        For i = s - 2 To 0 Step -1
            x(i) = r.Next(0, 9)
            y(i) = r.Next(0, 9)
        Next
    End Sub

    Private Function multiply(ByVal x() As Long, ByVal y() As Long, ByVal s As Long) As Long()
        If s = 1 Then
            Return mult(x(0), y(0))
        Else
            Dim a(s / 2 - 1), b(s / 2 - 1), c(s / 2 - 1), d(s / 2 - 1) As Long
            Dim p(), q(), r(), t(), l(), m() As Long
            a = firstHalf(x)
            b = secondhalf(x)
            c = firsthalf(y)
            d = secondhalf(y)

            p = multiply(a, c, s / 2)
            q = multiply(a, d, s / 2)
            r = multiply(b, c, s / 2)
            t = multiply(b, d, s / 2)

            l = Add(shift(p, s), shift(q, s / 2))
            m = Add(l, shift(r, s / 2))
            Return (add(m, t))
        End If
    End Function

    Private Function mult(ByVal a As Integer, ByVal b As Integer) As Long()
        Dim z() As Long
        Dim p As Integer = a * b
        If p > 9 Then
            ReDim Preserve z(1)
            z(1) = p \ 10
            z(0) = p Mod 10
        Else
            ReDim Preserve z(0)
            z(0) = p
        End If
        Return z
    End Function

    Private Function add(ByVal a() As Long, ByVal b() As Long) As Long()
        Dim up1, up2, big, small, i As Long
        Dim sum, carry As Integer
        up1 = a.GetUpperBound(0)
        up2 = b.GetUpperBound(0)

        If up1 > up2 Then
            big = up1
            small = up2
        Else
            big = up2
            small = up1
        End If

        Dim c(big) As Long
        For i = 0 To small
            sum = a(i) + b(i) + carry
            If sum > 9 Then
                carry = 1
                c(i) = sum Mod 10
            Else
                carry = 0
                c(i) = sum
            End If
        Next

        Do While i <= big
            If big = up1 Then
                sum = a(i) + carry
            Else
                sum = b(i) + carry
            End If

            If sum > 9 Then
                carry = 1
                c(i) = sum Mod 1
            Else
                carry = 0
                c(i) = sum
            End If
            i += 1
        Loop
        If carry = 1 Then
            ReDim Preserve c(c.GetUpperBound(0) + 1)
            c(c.GetUpperBound(0)) = 1
        End If

        Return c
    End Function

    Private Function shift(ByVal a() As Long, ByVal s As Long) As Long()
        Dim oldUpBound As Long = a.GetUpperBound(0)
        Dim i, k As Long

        For k = 1 To s
            ReDim Preserve a(oldUpBound + 1)
            For i = oldUpBound To 0 Step -1
                a(i + 1) = a(i)
            Next
            oldUpBound += 1
        Next

        For k = 0 To s - 1
            a(k) = 0
        Next

        Return a
    End Function

    Private Function firstHalf(ByVal x() As Long) As Long()
        Dim a(x.Length / 2 - 1), i, j As Long
        j = x.GetUpperBound(0)
        For i = a.GetUpperBound(0) To 0 Step -1
            a(i) = x(j)
            j -= 1
        Next
        Return a
    End Function

    Private Function secondHalf(ByVal x() As Long) As Long()
        Dim a(x.Length / 2 - 1), i As Long
        For i = a.GetUpperBound(0) To 0 Step -1
            a(i) = x(i)
        Next

        Return a
    End Function

    Private Sub RandomNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
