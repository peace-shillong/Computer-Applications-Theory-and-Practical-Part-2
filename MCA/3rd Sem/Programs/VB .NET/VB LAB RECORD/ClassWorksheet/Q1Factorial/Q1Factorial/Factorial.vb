Public Class Factorial
    Dim number As Integer

    Public Sub New()
        number = 1
    End Sub

    Public Property data() As Integer

        Get
            Return number
        End Get
        Set(ByVal value As Integer)
            number = value
        End Set
    End Property

    Public Function Findfactorial() As Integer
        Dim fact As Integer = 1
        For i = 1 To number
            fact = fact * i
        Next i
        Console.WriteLine("fact " & fact)
        Return fact
    End Function
End Class




