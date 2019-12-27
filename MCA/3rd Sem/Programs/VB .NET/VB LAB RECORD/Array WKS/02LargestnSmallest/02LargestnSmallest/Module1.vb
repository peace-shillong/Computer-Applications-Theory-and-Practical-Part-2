Module Module1

    Sub Main()
        Dim n, Array(100) As Integer
        Dim lar, sml As Integer

        Console.WriteLine("Enter the size to the array")
        n = Console.ReadLine()

        Call Input(Array, n)

        lar = largest(Array, n)
        sml = smallest(Array, n)

        Call Display(Array, n, lar, sml)

        Console.Read()
    End Sub

    Sub Input(ByRef A() As Integer, ByVal n As Integer)

        Console.WriteLine("Enter the values to the array")
        For i = 0 To n - 1
            A(i) = Console.ReadLine()
        Next i
    End Sub

    Sub Display(ByVal A() As Integer, ByVal n As Integer, ByVal lar As Integer, ByVal sml As Integer)
        Console.WriteLine("The Array is :")
        For i = 0 To n - 1
            Console.WriteLine(" A(" & i & ") : " & A(i))
        Next
        Console.WriteLine("Largest Element is : " & lar)
        Console.WriteLine("Smallest Element is : " & sml)
    End Sub


    Function largest(ByVal A() As Integer, ByVal n As Integer) As Integer
        Dim lar, i As Integer
        lar = A(0)
        For i = 1 To n - 1
            If A(i) > lar Then
                lar = A(i)
            End If
        Next i
        Return lar
    End Function

    Function smallest(ByVal A() As Integer, ByVal n As Integer) As Integer
        Dim sml, i As Integer
        sml = A(0)
        For i = 1 To n - 1
            If A(i) < sml Then
                sml = A(i)
            End If
        Next i
        Return sml
    End Function

End Module
