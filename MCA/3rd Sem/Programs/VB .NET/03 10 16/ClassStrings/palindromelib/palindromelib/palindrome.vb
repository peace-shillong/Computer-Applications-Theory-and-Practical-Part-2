Public Class palindrome
    Private word As String
    Public Sub New()
        word = "default string"
    End Sub
    Public Property wordvalue() As String
        Get
            Return word
        End Get
        Set(ByVal value As String)
            word = value
        End Set
    End Property
    Public Function ispalinddrome() As Boolean
        Dim i As Integer
        Dim reverse As String
        reverse = ""
        reverse = StrReverse(word)
        'For i = word.Length - 1 To 0 Step -1
        'reverse = reverse & word(i)
        'Next
        If (String.Compare(word, reverse) = 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
