Module Module1

    Sub Main()
        Dim r As Integer, c, Matrix(,), Matrix2(,) As Integer
        Dim sum(,), diff(,) As Integer

        Console.WriteLine("Enter the row of the Matrix")
        r = Console.ReadLine()
        Console.WriteLine("Enter the column of the Matrix")
        c = Console.ReadLine()
        ReDim Matrix(r, c)
        ReDim Matrix2(r, c)
        ReDim sum(r, c)
        ReDim diff(r, c)

        Console.WriteLine("Enter Into First Matrix/Array")
        Input(Matrix, r, c)
        Display(Matrix, r, c)

        Console.WriteLine("Enter Into Second Matrix/Array")
        Input(Matrix2, r, c)
        Display(Matrix2, r, c)

        Console.WriteLine("The Sum of the Matrices is :")
        sum = sumMat(Matrix, Matrix2, r, c)
        Display(sum, r, c)

        Console.WriteLine("The Difference of the Matrices is :")
        diff = diffMat(Matrix, Matrix2, r, c)
        Display(diff, r, c)

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

    Function sumMat(ByRef Matrix(,) As Integer, ByRef Matrix2(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer(,)
        Dim sum(r, c) As Integer
        For i = 0 To r - 1
            For j = 0 To c - 1
                sum(i, j) = Matrix(i, j) + Matrix2(i, j)
            Next
        Next
        Return sum
    End Function

    Function diffMat(ByRef Matrix(,) As Integer, ByRef Matrix2(,) As Integer, ByVal r As Integer, ByVal c As Integer) As Integer(,)
        Dim sum(r, c) As Integer
        For i = 0 To r - 1
            For j = 0 To c - 1
                sum(i, j) = Matrix(i, j) - Matrix2(i, j)
            Next
        Next
        Return sum
    End Function

End Module
