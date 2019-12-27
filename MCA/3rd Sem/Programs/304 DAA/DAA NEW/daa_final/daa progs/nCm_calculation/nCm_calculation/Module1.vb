Module Module1
    Dim m, n As Integer
    Sub Main()

        Dim arr(,) As Double
        Console.WriteLine("Calculating the value of  'n C m'")
        Console.WriteLine()
        Console.WriteLine("Enter the value of n : ")
        n = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Enter the value of m : ")
        m = Console.ReadLine()
        ReDim arr(n, m)
        calculate(arr)
        Console.WriteLine()
        Console.WriteLine(n & " C " & m & " = ")
        Console.Write(arr(n, m))
        Console.ReadKey()
    End Sub

    Sub calculate(ByVal arr(,) As Double)

        Dim i, j As Long
        For i = 0 To m
            For j = 1 To n
                If (i = 0 Or i = j) Then
                    arr(j, i) = 1
                ElseIf (i = 1) Then
                    arr(j, i) = j
                ElseIf (i > 0 And i < j) Then
                    arr(j, i) = arr(j - 1, i) + arr(j - 1, i - 1)
                End If
            Next
        Next
    End Sub

End Module
