Module Module1

    Sub Main()
        Dim n, Sq, last As Integer
        Console.WriteLine("Program to Check For an Automorphic Number")
        Console.WriteLine("Enter a Number : ")
        n = Console.ReadLine()

        If n > 9 Or n < 1 Then
            Console.WriteLine("Invalid input")
        Else
            Sq = n * n
            last = Sq Mod 10
            If last = n Then
                Console.WriteLine("It is Automorphic")
            Else
                Console.WriteLine("It is Not an automorphic number")
            End If
        End If

        Console.Read()
    End Sub

End Module
