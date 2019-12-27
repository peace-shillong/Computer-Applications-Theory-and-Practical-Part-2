Module Module1

    Sub Main()
        Dim n As Integer, sum As Decimal, f As Decimal, s As Decimal, nxt As Decimal
        Console.WriteLine("Program to Find the sum of Fibonacci series")
        Console.Write("Enter the limit: ")
        n = Console.ReadLine()
        f = 0
        s = 1
        sum = 0
        nxt = 0
        Dim i As Integer = 1
        Console.WriteLine("Series is ")
        While i <= n
            sum += f
            nxt = f + s
            f = s
            s = nxt
            i += 1
            'Console.WriteLine(" i " & i & " sum nxt f s " & sum & " " & nxt & " " & f & " " & s)
            'Console.Read()
            Console.Write(" " & f)
        End While
        Console.WriteLine(vbNewLine & "Sum of the Series is " & sum)
        Console.Read()

    End Sub

End Module
