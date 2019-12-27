Public Class Form1
    Dim word1, word2 As New Word
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button4.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            word1.data = TextBox1.Text
            word2.data = TextBox2.Text
            If Word.isAnagram(word1, word2) = True Then
                result.Text = "The Words form an anagram"
            Else
                result.Text = "The Words do not form an anagram"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button3.Click
        TextBox2.Clear()
        TextBox1.Clear()
        result.Text = ""
    End Sub

End Class
