Module Module1

    Sub Main()
        Dim n As Integer, i As Integer, Flag As Boolean
        Console.WriteLine("Program to Find Whether the number is Prime or Not")
        Console.Write("Enter any Number : ")
        n = Console.ReadLine
        Flag = True
        If n <> 2 Then
            For i = 2 To n / 2
                If n Mod i = 0 Then
                    Flag = False
                End If
                If Flag = False Then
                    Exit For
                End If
                'Console.WriteLine("i " & i)

            Next
        End If
        If Flag = False Then
            Console.WriteLine("It is not a Prime Number")
        Else
            Console.WriteLine("It is a  Prime Number")
        End If
        Console.ReadLine()

    End Sub

End Module
