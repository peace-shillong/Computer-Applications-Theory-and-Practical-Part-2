Module Module1

    Sub Main()
        Dim n As Integer, i As Short, fact As Long
        Console.WriteLine("Factorial Program")
        Console.Write("Enter A Number: ")
        n = Console.ReadLine()
        fact = 1
        If n >= 20 Then
            Console.WriteLine("Number too Large")
        Else
            For i = 1 To n
                fact = fact * i
            Next
            Console.WriteLine("Factorial of : " & n & " is " & fact)
        End If
        Console.Read()
    End Sub

End Module
