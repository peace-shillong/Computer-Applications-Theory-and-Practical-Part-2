Module Module1

    Sub Main()
        Dim n, Array(100) As Integer
        Dim sum As Integer, avg As Decimal
        Console.WriteLine("Enter the size to the array")
        n = Console.ReadLine()
        Console.WriteLine("Enter the values to the array")
        For i = 0 To n - 1
            Array(i) = Console.ReadLine()
            sum = sum + Array(i)
        Next i
        Console.WriteLine("The Array is :")
        For i = 0 To n - 1
            Console.WriteLine(" A(" & i & ") : " & Array(i))
        Next
        avg = sum / n
        Console.WriteLine("Sum is " & sum)
        Console.WriteLine("Average is " & avg)
        Console.Read()
    End Sub

End Module
