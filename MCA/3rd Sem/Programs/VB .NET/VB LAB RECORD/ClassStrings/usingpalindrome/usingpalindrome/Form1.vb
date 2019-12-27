Public Class Form1
    Dim obj As New palindromelib.palindrome
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        obj.wordvalue = CStr(txtinput.Text)
        If obj.ispalinddrome() = True Then
            txtoutput.Text = "A Palindrome"
        Else
            txtoutput.Text = "Not a Palindrome"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtinput.Clear()
        txtoutput.Clear()
    End Sub
    
End Class
