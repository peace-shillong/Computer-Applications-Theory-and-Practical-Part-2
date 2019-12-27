Module Module1

    Sub Main()
        Dim n As Integer, i, tn, j As Integer, Flag As Boolean
        Console.WriteLine("Program to Generate Prime Number")
        Console.Write("Enter Limit : ")
        n = Console.ReadLine
        Flag = True
        For j = 2 To n
            tn = j
            'If tn <> 2 Then
            For i = 2 To j \ 2
                If tn Mod i = 0 Then
                    Flag = False
                    Exit For
                End If
                'Console.WriteLine("i " & i)
            Next i
            ' End If
            'Console.WriteLine("" & j)
            If Flag = False Then
                Console.Write("")
                Flag = True
            Else
                Console.WriteLine(" " & tn)
            End If

        Next j
        Console.ReadKey()
    End Sub

End Module
