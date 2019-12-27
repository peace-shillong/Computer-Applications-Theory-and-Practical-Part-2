Public Class Armstrong
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

    Public Function Check() As Boolean
        Dim rev, tn, r As Integer
        rev = 0
        tn = number
        While tn > 0
            r = tn Mod 10
            rev = rev + r ^ 3
            tn = tn \ 10
            'Console.WriteLine(" r n " & n)
        End While
        ' Console.WriteLine("Reverse no: " & rev)

        If rev = number Then
            ' Console.WriteLine(" The Number is an Armstrong Number ")
            Return True
        Else
            'Console.WriteLine("The Number  is not an Armstrong Number")
            Return False

        End If
    End Function
End Class
