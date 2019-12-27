Module Module1

    Sub Main()
        Dim r As Integer, c, Matrix(100, 100) As Integer
        Dim sumrd, sumld As Integer

        Console.WriteLine("Enter the row of the Matrix")
        r = Console.ReadLine()
        Console.WriteLine("Enter the column of the Matrix")
        c = Console.ReadLine()
        ReDim Matrix(r, c)

        Input(Matrix, r, c)
        Display(Matrix, r, c)
        sumrd = sumDiag(Matrix, r, c)
        sumld = sumDiag2(Matrix, r, c)

        Console.WriteLine("Sum of The Left Diagonal is " & sumld)
        Console.WriteLine("Sum of The Right and Left Diagonals is " & sumrd)
        Console.Read()
    End Sub

    Sub Input(ByRef A(,) As Integer, ByVal r As Integer, ByVal c As Integer)

        Console.WriteLine("Enter the values to the array")
        For i = 0 To r - 1
            For j = 0 To c - 1
                A(i, j) = Console.ReadLine()
            Next j
        Next i
    End Sub

    Sub Display(ByVal A(,) As Integer, ByVal r As Integer, ByVal c As Integer)
        Console.WriteLine("The Matrix is :")
        For i = 0 To r - 1
            For j = 0 To c - 1
                Console.Write(A(i, j) & vbTab)
            Next j
            Console.WriteLine()
        Next

    End Sub

    Function sumDiag(ByVal Matrix(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer
        Dim sum As Integer = 0
        For i = 0 To r - 1
            For j = 0 To c - 1
                If i + j = c - 1 Then
                    sum += Matrix(i, j)
                End If
            Next
        Next
        Return sum
    End Function

    Function sumDiag2(ByVal Matrix(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer
        Dim sum As Integer = 0
        For i = 0 To r - 1
            For j = 0 To c - 1
                If i = j Then
                    sum += Matrix(i, j)
                End If
            Next
        Next
        Return sum
    End Function
End Module
