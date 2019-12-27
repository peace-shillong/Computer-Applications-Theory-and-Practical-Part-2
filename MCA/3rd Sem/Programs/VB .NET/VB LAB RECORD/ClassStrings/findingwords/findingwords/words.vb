Imports System.Text.RegularExpressions
Public Class words
    Private sentence As String
    Dim length As Integer
    Public Sub New()
        sentence = "default string"
    End Sub
    Public Property sentencevalue() As String
        Get
            Return sentence
        End Get
        Set(ByVal value As String)
            sentence = value
        End Set
    End Property
    Public Function getword() As String()
        Dim i, j As Integer
        Dim word As String
        Dim arr() As String
        j = 0
        ReDim arr(j)
        sentence = sentence.Trim() & " "

        For i = 0 To sentence.Length - 1
            word = ""
            'count Words
            While sentence(i) <> " "
                ' word = word & sentence(i)
                word = word & sentence(i)
                i = i + 1
                length = i
            End While
            arr(j) = word
            j = j + 1

            ReDim Preserve arr(j)
        Next
        Return arr
    End Function

    Public Function getdigits() As Integer
        Dim i, noOfDigits As Integer
        Dim word As String
        noOfDigits = 0
        word = sentence
        For i = 0 To length
            If sentence(i) = "1" Or sentence(i) = "2" Or sentence(i) = "3" Or sentence(i) = "4" Or sentence(i) = "5" Or sentence(i) = "6" Or sentence(i) = "7" Or sentence(i) = "8" Or sentence(i) = "9" Or sentence(i) = "0" Then
                noOfDigits = noOfDigits + 1
            End If
        Next i
        Return noOfDigits
    End Function

    Public Function getvowels() As Integer
        Dim i, noOfvowels As Integer
        Dim word As String
        noOfvowels = 0
        word = sentence
        Console.WriteLine("length I s" & length)
        For i = 0 To length
            If sentence(i) = "A" Or sentence(i) = "a" Or sentence(i) = "E" Or sentence(i) = "e" Or sentence(i) = "i" Or sentence(i) = "I" Or sentence(i) = "O" Or sentence(i) = "o" Or sentence(i) = "U" Or sentence(i) = "u" Then
                noOfvowels = noOfvowels + 1
            End If
        Next i
        Console.WriteLine("no " & noOfvowels)
        Return noOfvowels
    End Function

    Public Function getchars() As Integer
        Dim noOfsc As Integer
        Dim word As String
        noOfsc = 0

        word = sentence
        For i = 0 To length
            If Regex.IsMatch(word(i), "[^a-zA-Z0-9 ]") Then
                noOfsc = noOfsc + 1
            End If
        Next i

        'Console.WriteLine("no " & noOfvowels)
        Return noOfsc
    End Function

End Class
