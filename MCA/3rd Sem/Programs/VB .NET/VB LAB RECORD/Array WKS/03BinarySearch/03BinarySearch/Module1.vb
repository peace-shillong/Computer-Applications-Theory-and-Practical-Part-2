Module Module1

    Sub Main()
        Dim n, val, Array(100) As Integer
        Dim result As Boolean

        Console.WriteLine("Enter the size to the array")
        n = Console.ReadLine()

        Call Input(Array, n)
        Call Display(Array, n)
        Console.WriteLine("Enter the Element you want to search : ")
        val = Console.ReadLine()
        result = BinarySearch(Array, n, val)
        If result Then
            Console.WriteLine("Found")
        Else
            Console.WriteLine("Not Found")
        End If
        Console.Read()
    End Sub

    Sub Input(ByRef A() As Integer, ByVal n As Integer)

        Console.WriteLine("Enter the values to the array")
        For i = 0 To n - 1
            A(i) = Console.ReadLine()
        Next i
    End Sub

    Sub Display(ByVal A() As Integer, ByVal n As Integer)
        Console.WriteLine("The Array is :")
        For i = 0 To n - 1
            Console.WriteLine(" A(" & i & ") : " & A(i))
        Next

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
End Module
