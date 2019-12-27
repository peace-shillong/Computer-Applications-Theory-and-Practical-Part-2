Public Class LongShort

    Private sentence As String
    Public Sub New()
        sentence = "default string"
    End Sub

    Public Property getvalue()
        Get
            Return sentence
        End Get
        Set(ByVal value)
            sentence = value
        End Set
    End Property

    Public Function getlongestword() As String
        Dim i, len As Integer
        Dim word, rword As String
        len = 0
        sentence = sentence.Trim & " "

        word = ""
        rword = ""
        For i = 0 To sentence.Length - 1
            word = ""
            While sentence(i) <> " "
                word = word & sentence(i)
                i = i + 1

            End While
            If word.Length > len Then
                len = word.Length
                rword = word
            End If
        Next
        Return rword
    End Function

    Public Function getshortestword() As String
        Dim i, len As Integer
        Dim word, rword As String
        len = 0
        word = ""
        rword = ""
        sentence = sentence.Trim & " "
        For i = 0 To sentence.Length - 1
            word = ""
            While sentence(i) <> " "
                word = word & sentence(i)
                i = i + 1
            End While
            If word.Length < len Or len = 0 Then
                len = word.Length
                rword = word
            End If

        Next
        Return rword
    End Function

End Class
