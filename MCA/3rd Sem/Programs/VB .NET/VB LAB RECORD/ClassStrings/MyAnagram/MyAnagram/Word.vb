Public Class Word
    Dim myWord As String
    Public Sub New()
        myWord = "default"
    End Sub

    Public Sub New(ByVal n As String)
        myWord = n
    End Sub

    Public Property data() As String
        Get
            Return myWord
        End Get
        Set(ByVal value As String)
            myWord = value
        End Set
    End Property

    Shared Function isAnagram(ByRef word1 As Word, ByRef word2 As Word) As Boolean
        word1.myWord = word1.myWord.ToLower()
        word2.myWord = word2.myWord.ToLower()
        'Console.WriteLine("String is " & myWord)
        'Form1.Mytest.Text = myWord
        If word1.myWord.Length <> word2.myWord.Length Then
            Return False
        ElseIf word1.myWord.Length = word2.myWord.Length Then
            word1.myWord = word1.sortWord(word1.myWord)
            word2.myWord = word2.sortWord(word2.myWord)
            Form1.test.Text = word1.myWord
            Form1.test.Text = Form1.test.Text & word2.myWord
            Dim i, j As Integer
            i = 0 : j = 0
            While i < word1.myWord.Length
                If word1.myWord(i) = word2.myWord(i) Then
                    j += 1
                End If
                i += 1
            End While
            If j = word1.myWord.Length Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Function sortWord(ByRef str As String) As String
        Dim len As Integer
        Dim newWord As String
        len = str.Length
        newWord = "a"
        'Console.WriteLine("Length is " & len)
        Dim char1() As Char
        char1 = str.ToCharArray()
        System.Array.Sort(char1)
        Return char1
    End Function

End Class

