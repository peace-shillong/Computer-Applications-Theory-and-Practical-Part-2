Public Class Number
    Private magnitude As Integer
    Public Sub New()
        magnitude = 1
    End Sub
    Public Sub New(ByVal n As Integer)
        magnitude = n
    End Sub
    Public Property data() As Integer
        Get
            Return magnitude
        End Get
        Set(ByVal value As Integer)
            magnitude = value
        End Set
    End Property

    Function sumDigits() As Integer
        Dim sum, tn, r As Integer
        sum = 0
        tn = magnitude
        While tn > 0
            r = tn Mod 10
            sum = sum + r
            tn /= 10
        End While
        Return sum
    End Function

    Function noOfDigits() As Integer
        Dim count, tn As Integer
        count = 0
        tn = magnitude
        While tn > 0
            count = count + 1
            tn /= 10
        End While
        Return count
    End Function

    Function reverse() As Integer
        Dim rev, tn, r As Integer
        rev = 0
        tn = magnitude
        While tn > 0
            r = tn Mod 10
            rev = rev * 10 + r
            tn /= 10
        End While
        Return rev
    End Function

End Class
