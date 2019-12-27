Module Module1

    Sub Main()
        Dim n As Integer, rev As Integer, r As Integer
        Dim tn As Integer
        Console.WriteLine("Program to Check if a Number is an Armstrong Number")
        Console.Write("Enter a Number : ")
        n = Console.ReadLine()
        rev = 0
        tn = n
        While n > 0
            r = n Mod 10
            rev = rev + r ^ 3
            n = n \ 10
            'Console.WriteLine(" r n " & n)
        End While
        ' Console.WriteLine("Reverse no: " & rev)

        If rev = tn Then
            Console.WriteLine(" The Number is an Armstrong Number ")
        Else
            Console.WriteLine("The Number  is not an Armstrong Number")


        End If
        Console.Read()

    End Sub

End Module
