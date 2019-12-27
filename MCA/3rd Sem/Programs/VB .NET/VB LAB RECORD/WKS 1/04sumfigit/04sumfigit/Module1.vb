Module Module1

    Sub Main()
        Dim n As Integer, rev As Integer, r As Integer
        Dim tn As Integer
        Console.WriteLine("Program to Find the sum of the digits of a number")
        Console.Write("Enter a Number : ")
        n = Console.ReadLine()
        rev = 0
        tn = n
        While tn > 0
            r = tn Mod 10
            rev = rev + r
            tn /= 10
        End While
        Console.WriteLine("Sum of the digits is: " & rev)

      
        Console.Read()

    End Sub

End Module
