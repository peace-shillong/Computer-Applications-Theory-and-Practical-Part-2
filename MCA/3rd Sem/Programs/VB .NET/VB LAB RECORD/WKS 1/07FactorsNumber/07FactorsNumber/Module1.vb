Module Module1

    Sub Main()
        Dim i, fac, n As Integer
        Console.WriteLine("Program to Find FACTORS OF A NUMBER")
        Console.Write("Enter a number: ")
        n = Console.ReadLine()
        Console.WriteLine("Factors of " & n & ":")
        For i = 1 To n
            If n Mod i = 0 Then
                Console.WriteLine(" " & i)
            End If
        Next
        Console.ReadKey()

    End Sub

End Module
