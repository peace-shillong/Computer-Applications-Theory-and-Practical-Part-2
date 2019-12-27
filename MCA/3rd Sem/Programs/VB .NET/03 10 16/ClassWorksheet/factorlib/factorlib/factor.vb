Public Class Factors
    Private n, Counter As Integer
    Private Array() As Integer
    Public Sub New()
        n = 1
        ReDim Array(0)
        Array(0) = 1
    End Sub

    Public Property data() As Integer
        Get
            Return n
        End Get
        Set(ByVal value As Integer)
            n = value
            Dim j As Integer = 0
            For i As Integer = 1 To n
                If n Mod i = 0 Then
                    ReDim Preserve Array(j)
                    Array(j) = i
                    Counter = j
                    j = j + 1
                End If
            Next
        End Set
    End Property
    Public ReadOnly Property count() As Integer
        Get
            Return Counter
        End Get
    End Property
    ReadOnly Property getarray() As Integer()
        Get
            Return Array
        End Get
    End Property

    Function Abundant() As Boolean
        Dim i, sum As Integer
        i = 0
        sum = 0
        While i < Counter
            sum += Array(i)
            i += 1
        End While
        If sum > n Then
            Return True
        Else
            Return False
        End If
    End Function

    Function PerfectNo() As Boolean
        Dim i, sum As Integer
        i = 0
        sum = 0
        While i < Counter
            sum += Array(i)
            i += 1
        End While
        If sum = n Then
            Return True
        Else
            Return False
        End If
    End Function

    Function isPrime() As Boolean
        Dim i As Integer, Flag As Boolean
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
            'Console.WriteLine("It is not a Prime Number")
            Return False
        Else
            'Console.WriteLine("It is a  Prime Number")
            Return True
        End If
    End Function

End Class
