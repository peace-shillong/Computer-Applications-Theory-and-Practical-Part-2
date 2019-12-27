Public Class Form1
    Dim obj As New findingwords.words
    Private Sub btnfindword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfindword.Click
        Dim array() As String
        Dim i, digits, vowels, spc As Integer
        digits = 0
        vowels = 0
        spc = 0
        If txtsentence.Text <> "" Then
            obj.sentencevalue = CStr(txtsentence.Text)
            lstwords.Items.Clear()
            array = obj.getword()
            For i = 0 To UBound(array) - 1
                lstwords.Items.Add(array(i))
            Next
            digits = obj.getdigits()
            vowels = obj.getvowels()
            spc = obj.getchars()
            lstwords.Items.Add("Number of Words is " & UBound(array))
            lstwords.Items.Add("Number of Digits is " & digits)
            lstwords.Items.Add("Number of Vowels is " & vowels)
            lstwords.Items.Add("Number of Special Characters is " & spc)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtsentence.Clear()
        lstwords.Items.Clear()
    End Sub
End Class
