Module Module1

    Sub Main()
        Dim n As Integer, rev As Integer, r As Integer
        Dim tn As Integer
        Console.WriteLine("Program to Reverse a number")
        Console.Write("Enter a Number : ")
        n = Console.ReadLine()
        rev = 0
        tn = n
        While tn > 0
            r = tn Mod 10
            rev = rev * 10 + r
            tn /= 10
        End While
        Console.WriteLine("Reverse no: " & rev)

        If rev = n Then
            Console.WriteLine(" The Reverse is equal to the Original Number")
        Else
            Console.WriteLine("The Reverse is not equal to the Original number")


        End If
        Console.Read()

    End Sub

End Module
