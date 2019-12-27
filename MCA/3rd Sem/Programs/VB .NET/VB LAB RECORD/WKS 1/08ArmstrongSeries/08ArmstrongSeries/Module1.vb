Module Module1

    Sub Main()
        Dim n As Integer, res As Integer, r As Integer
        Dim tn As Integer
        Console.WriteLine("Program to Generate Armstrong Numbers")
        Console.Write("Enter a Limit: ")
        n = Console.ReadLine()
        For i = 1 To n
            res = 0
            tn = i
            While tn > 0
                r = tn Mod 10
                res = res + r ^ 3
                tn = tn \ 10
                'Console.WriteLine(" r n " & n)
            End While
            ' Console.WriteLine("Reverse no: " & rev)
            If res = i Then
                Console.WriteLine(" " & i)
            End If

        Next i
        Console.Read()
    End Sub

End Module
